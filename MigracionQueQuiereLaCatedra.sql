CREATE PROCEDURE WEST_WORLD.Migracion
AS 
BEGIN

	

	
	/*MIGRACION CLIENTE*/
	INSERT INTO WEST_WORLD.Cliente (nombre, apellido, mail, direccion, codigoPostal, DNI, telefono, fecha_nac, habilitado)
	SELECT DISTINCT [Cliente-Nombre], [Cliente-Apellido], Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, [Cliente-Dni], NULL, [Cliente-Fecha_Nac], 1
	FROM gd_esquema.Maestra

	

	-- Migrar rubro
	INSERT INTO WEST_WORLD.Rubro
	SELECT DISTINCT Rubro_Descripcion
	FROM gd_esquema.Maestra

	-- Migrar Empresa
	INSERT INTO WEST_WORLD.Empresa
	SELECT DISTINCT Empresa_Cuit, Empresa_Nombre, Empresa_Direccion, Empresa_Rubro, 1 AS 'Habilitado', DAY(MAX(Rendicion_Fecha)) as 'Dia de Rendicion'
	FROM gd_esquema.Maestra
	GROUP BY Empresa_Cuit, Empresa_Nombre, Empresa_Direccion, Empresa_Rubro

	--Migrar Sucursal
	INSERT INTO WEST_WORLD.Sucursal
	SELECT DISTINCT Sucursal_Nombre, Sucursal_Dirección, Sucursal_Codigo_Postal, 1, NULL
	FROM gd_esquema.Maestra
	WHERE Sucursal_Codigo_Postal IS NOT NULL

	--Migrar FormaPago
	INSERT INTO WEST_WORLD.FormaPago
	SELECT DISTINCT FormaPagoDescripcion
	FROM gd_esquema.Maestra
	WHERE FormaPagoDescripcion IS NOT NULL

	--Migrar Pagos
	INSERT INTO WEST_WORLD.Pago
	SELECT DISTINCT Pago_nro, Pago_Fecha, wc.idCliente, ws.idSucursal, Total, fp.idFormaPago
	FROM gd_esquema.Maestra
	JOIN WEST_WORLD.Cliente wc ON (wc.DNI = [Cliente-Dni])
	JOIN WEST_WORLD.Sucursal ws ON (ws.codigoPostal = Sucursal_Codigo_Postal)
	JOIN WEST_WORLD.FormaPago fp ON (fp.descripcion = FormaPagoDescripcion)
	WHERE Pago_nro IS NOT NULL
	ORDER BY Pago_nro



	--Migrar Rendiciones
	SET IDENTITY_INSERT WEST_WORLD.RENDICION ON
		INSERT INTO WEST_WORLD.Rendicion (numeroRendicion, FechaRendicion, cantidadFacturas, importeNeto, empresa, porcentajeComision, importeTotal)
	SELECT DISTINCT Rendicion_Nro, Rendicion_Fecha, count(DISTINCT Nro_Factura) as cantidadFact, Factura_Total - ItemRendicion_Importe, we.idEmpresa, 
					cast(ROUND(Factura_Total/ItemRendicion_Importe,0) as numeric(5,2)), Factura_Total
	FROM gd_esquema.Maestra join WEST_WORLD.Empresa we on (Empresa_Cuit = we.cuit)
	WHERE Rendicion_Nro IS NOT NULL
	GROUP BY Rendicion_Nro, Rendicion_Fecha,we.idEmpresa, Factura_Total, ItemRendicion_Importe
	ORDER BY Rendicion_Nro

	SET IDENTITY_INSERT WEST_WORLD.RENDICION OFF

	
	/*MIGRACION FACTURAS*/
	
	INSERT INTO WEST_WORLD.Factura (numeroFactura, cliente, empresa, fechaAlta, FechaVencimiento, total, pago, rendicion)
	SELECT DISTINCT Nro_Factura, w.idCliente, e.idEmpresa, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total, Pago_nro, Rendicion_Nro
	FROM (SELECT DISTINCT Nro_Factura, Factura_Fecha, Factura_Total, Factura_Fecha_Vencimiento, [Cliente-Dni], Empresa_Cuit, Pago_nro, Rendicion_Nro
		FROM gd_esquema.Maestra
		) as TablaTemp
	JOIN WEST_WORLD.Cliente w ON (w.DNI = TablaTemp.[Cliente-Dni])
	JOIN WEST_WORLD.Empresa e ON (e.cuit = TablaTemp.Empresa_Cuit)
	WHERE TablaTemp.Pago_nro IS NULL AND Rendicion_Nro IS NULL
	ORDER BY Nro_Factura ASC

	MERGE INTO WEST_WORLD.Factura TNN
	USING ( SELECT DISTINCT g.Nro_Factura, P.numeroPago
			FROM gd_esquema.Maestra g
			JOIN WEST_WORLD.Pago P on P.numeroPago = g.Pago_nro
			WHERE Pago_nro IS NOT NULL
	 ) TRN
	ON TNN.numeroFactura = TRN.Nro_Factura
	WHEN MATCHED THEN
   UPDATE 
      SET TNN.pago = TRN.numeroPago;

MERGE INTO WEST_WORLD.Factura TNN
	USING ( SELECT DISTINCT g.Nro_Factura, R.numeroRendicion
			FROM gd_esquema.Maestra g
			JOIN WEST_WORLD.Rendicion R on R.numeroRendicion = g.Rendicion_nro
			WHERE G.Rendicion_nro IS NOT NULL
	 ) TRN
	ON TNN.numeroFactura = TRN.Nro_Factura
	WHEN MATCHED THEN
   UPDATE 
      SET TNN.rendicion = TRN.numeroRendicion;


	
	--Migrar Item
	INSERT INTO WEST_WORLD.Item(numeroFactura, monto, cantidad, importe)
	SELECT DISTINCT Nro_Factura, ROUND(ROUND(ItemFactura_Monto,2)/ROUND(ItemFactura_Cantidad, 2),2), ItemFactura_Cantidad, ItemFactura_Monto
	from gd_esquema.Maestra
	order by Nro_Factura
	

	


END

CREATE TRIGGER validarMail ON West_World.Cliente
INSTEAD OF INSERT
AS
BEGIN


DECLARE @MAIL VARCHAR(255)
SELECT @MAIL = mail
FROM inserted

IF NOT EXISTS (SELECT * FROM WEST_WORLD.Cliente WHERE mail = @mail)

BEGIN

	INSERT INTO WEST_WORLD.Cliente (nombre, apellido, mail, direccion, codigoPostal, DNI, telefono, fecha_nac, habilitado)
	SELECT nombre, apellido, mail, direccion, codigoPostal, DNI, telefono, fecha_nac, habilitado
	FROM inserted
END

ELSE

BEGIN

RAISERROR('Mail repetido, por favor ingrese uno nuevo',14,2)

END


END


CREATE TRIGGER validacionDePago ON WEST_WORLD.Factura
INSTEAD OF UPDATE
AS
BEGIN

DECLARE @FECHACOBRO DATETIME
DECLARE @FECHAVENCIMIENTO DATETIME
DECLARE @PAGO INT
DECLARE @NUMEROFACTURA INT

SELECT @FECHACOBRO = P.FechaCobro, @FECHAVENCIMIENTO = I.FechaVencimiento, @PAGO = P.numeroPago, @NUMEROFACTURA = I.numeroFactura
FROM inserted I
JOIN WEST_WORLD.Pago P ON I.pago = P.numeroPago

IF (@FECHAVENCIMIENTO < @FECHACOBRO)
BEGIN

DELETE FROM WEST_WORLD.Pago
WHERE numeroPago = @PAGO

RAISERROR('No se puede pagar una factura fuera de termino', 14, 2)

END
ELSE
BEGIN

UPDATE WEST_WORLD.Factura 
SET pago = @PAGO
WHERE numeroFactura = @NUMEROFACTURA

END

END

