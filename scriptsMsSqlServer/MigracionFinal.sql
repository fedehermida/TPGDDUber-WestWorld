CREATE PROCEDURE WEST_WORLD.Migracion
AS 
BEGIN

	/*MIGRACION CLIENTE*/
	DECLARE @clienteNombre varchar(255), @clienteApellido varchar(255), @clienteMail varchar(255),
	@clienteDireccion varchar(255), @codigoPostal varchar, @dni bigint, @fec_nac datetime, @tel numeric(15,0), @habilitado bit

	
	DECLARE CustomerCursor Cursor FOR 
	SELECT DISTINCT [Cliente-Nombre], [Cliente-Apellido], Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, [Cliente-Dni], NULL, [Cliente-Fecha_Nac], 1
	FROM gd_esquema.Maestra

	OPEN CustomerCursor;

	FETCH NEXT FROM CustomerCursor
	INTO @clienteNombre,@clienteApellido,@clienteMail,@clienteDireccion,
	@codigoPostal,@dni,@tel,@fec_nac,@habilitado

	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF EXISTS(SELECT 1 from WEST_WORLD.Cliente WHERE mail=@clienteMail)
		BEGIN
			 update WEST_WORLD.Cliente SET nombre=@clienteNombre, apellido=@clienteApellido, mail=@clienteMail, 
			 direccion=@clienteDireccion, codigoPostal=@codigoPostal, DNI=@dni,fecha_nac=@fec_nac, habilitado=@habilitado
			where mail = @clienteMail
		END
		ELSE		
			begin
				insert into WEST_WORLD.Cliente (nombre, apellido, mail,direccion,codigoPostal,DNI,fecha_nac,telefono,habilitado) values 
				(@clienteNombre,@clienteApellido, @clienteMail, @clienteDireccion, @codigoPostal, @dni,@fec_nac, null, 1)
			end


			FETCH NEXT FROM CustomerCursor
			INTO @clienteNombre,@clienteApellido,@clienteMail,@clienteDireccion,
			@codigoPostal,@dni,@tel,@fec_nac,@habilitado
	END
	CLOSE CustomerCursor
	DEALLOCATE CustomerCursor

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

	

	--Migracion Rendicion Temporal
	
	CREATE TABLE #RendicionNueva (Nro_Factura int ,Rendicion_nro int, Rendicion_Fecha datetime, RendicionNueva int DEFAULT NULL)

	INSERT INTO #RendicionNueva
	SELECT DISTINCT Nro_Factura, Rendicion_nro, Rendicion_Fecha, NULL AS 'NuevaRendicion' 
	FROM gd_esquema.Maestra
	WHERE Rendicion_Nro is not null
	ORDER BY Rendicion_Nro

	--Migrar Rendiciones
	
	DECLARE @FECHAMAXIMA DATETIME
	SELECT @FECHAMAXIMA = DATEADD(month, 1, MAX(Rendicion_Fecha)) FROM gd_esquema.Maestra
		

	DECLARE @FECHAMINIMA DATETIME
	SELECT @FECHAMINIMA = MIN(Rendicion_Fecha) FROM gd_esquema.Maestra

	DECLARE @FECHACURSOR DATETIME
	SELECT @FECHACURSOR = CONVERT(DATETIME, '2017-01-09')

	WHILE @FECHACURSOR <= @FECHAMAXIMA
	BEGIN
	INSERT INTO WEST_WORLD.Rendicion (FechaRendicion, cantidadFacturas, importeNeto, empresa, porcentajeComision, importeTotal)
	SELECT DISTINCT @FECHACURSOR, COUNT(DISTINCT Nro_Factura) as CantidadDeFacturas, SUM(Factura_Total - ItemRendicion_Importe) as ImporteRendido, we.idEmpresa, SUM(ItemFactura_Monto)/SUM(Factura_Total)  *100 as Porcentaje, SUM(Factura_Total) ImporteTotal
	FROM gd_esquema.Maestra
	JOIN WEST_WORLD.Empresa we on (Empresa_Cuit = we.cuit)
	WHERE Rendicion_Nro IS NOT NULL AND Rendicion_Fecha BETWEEN @FECHAMINIMA AND @FECHACURSOR
	GROUP BY we.idEmpresa
	
	UPDATE #RendicionNueva 
	SET RendicionNueva = (SELECT TOP 1 R.numeroRendicion FROM WEST_WORLD.Rendicion R WHERE R.FechaRendicion = @FECHACURSOR)
	WHERE Rendicion_Fecha BETWEEN @FECHAMINIMA AND @FECHACURSOR
	
	SELECT @FECHAMINIMA = @FECHACURSOR
	SELECT @FECHACURSOR = DATEADD(month, 1, @FECHACURSOR)

	END

	/*MIGRACION FACTURAS*/
	
	INSERT INTO WEST_WORLD.Factura
	SELECT DISTINCT Nro_Factura, w.idCliente, e.idEmpresa, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total, Pago_nro, Rendicion_Nro
	FROM (SELECT DISTINCT Nro_Factura, Factura_Fecha, Factura_Total, Factura_Fecha_Vencimiento, Cliente_Mail, Empresa_Cuit, Pago_nro, Rendicion_Nro
		FROM gd_esquema.Maestra
		) as TablaTemp
	JOIN WEST_WORLD.Cliente w ON (w.mail = TablaTemp.Cliente_Mail)
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
	USING ( SELECT DISTINCT g.Nro_Factura, R.RendicionNueva
			FROM gd_esquema.Maestra g
			JOIN #RendicionNueva R on R.Rendicion_nro = g.Rendicion_nro
			WHERE G.Rendicion_nro IS NOT NULL
	 ) TRN
	ON TNN.numeroFactura = TRN.Nro_Factura
	WHEN MATCHED THEN
   UPDATE 
      SET TNN.rendicion = TRN.RendicionNueva;



	/*
	SELECT DISTINCT Nro_Factura, w.idCliente, e.idEmpresa, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total, R.RendicionNueva, Pago_nro
	FROM (SELECT DISTINCT Nro_Factura, Factura_Fecha, Factura_Total, Factura_Fecha_Vencimiento, Cliente_Mail, Empresa_Cuit, Pago_nro, Rendicion_Nro
		FROM gd_esquema.Maestra
		) as TablaTemp
	JOIN WEST_WORLD.Cliente w ON (w.mail = TablaTemp.Cliente_Mail)
	JOIN WEST_WORLD.Empresa e ON (e.cuit = TablaTemp.Empresa_Cuit)
	JOIN #RendicionNueva R ON (R.Rendicion_nro = TablaTemp.Rendicion_Nro)
	ORDER BY Nro_Factura ASC
	*/

	
	--Migrar Item
	INSERT INTO WEST_WORLD.Item(numeroFactura, monto, cantidad, importe)
	SELECT DISTINCT Nro_Factura, ROUND(ROUND(ItemFactura_Monto,2)/ROUND(ItemFactura_Cantidad, 2),2), ItemFactura_Cantidad, ItemFactura_Monto
	from gd_esquema.Maestra
	order by Nro_Factura
	
	DROP TABLE #RendicionNueva

END
