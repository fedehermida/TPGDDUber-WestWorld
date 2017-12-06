USE GD2C2017

--IMPORTANTE: SE DEBE MANTENER EL ORDEN DE LOS DROP PARA QUE NO ROMPA
--Primero se eliminan las tablas que tengan una fk hacia otra tabla 
-- y que ninguna otra tabla la referencie mediante una fk
GO
IF OBJECT_ID('WEST_WORLD.Rol_Funcionalidad', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Rol_Funcionalidad 
GO
IF OBJECT_ID('WEST_WORLD.Funcionalidad', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Funcionalidad 
GO
IF OBJECT_ID('WEST_WORLD.Sucursal_Usuario', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Sucursal_Usuario 
GO
IF OBJECT_ID('WEST_WORLD.Rol_Usuario', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Rol_Usuario
GO
IF OBJECT_ID('WEST_WORLD.Rol', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Rol
GO
IF OBJECT_ID('WEST_WORLD.Factura_Item', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Factura_Item
GO
IF OBJECT_ID('WEST_WORLD.Item', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Item
GO
IF OBJECT_ID('WEST_WORLD.Devolucion', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Devolucion
GO
IF OBJECT_ID('WEST_WORLD.Factura', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Factura
GO
IF OBJECT_ID('WEST_WORLD.Rendicion', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Rendicion
GO
IF OBJECT_ID('WEST_WORLD.Empresa', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Empresa 
GO
IF OBJECT_ID('WEST_WORLD.Rubro', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Rubro 
GO
IF OBJECT_ID('WEST_WORLD.Pago', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Pago 
GO
IF OBJECT_ID('WEST_WORLD.FormaPago', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.FormaPago
GO
IF OBJECT_ID('WEST_WORLD.Cliente', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Cliente
GO
IF OBJECT_ID('WEST_WORLD.Sucursal', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Sucursal
GO
IF OBJECT_ID('WEST_WORLD.Usuario', 'U') IS NOT NULL
DROP TABLE WEST_WORLD.Usuario

----------------------------------------- CREATE TABLES --------------------------------------------------------
GO
CREATE TABLE "WEST_WORLD"."Cliente"( 
	"idCliente"   	BIGINT IDENTITY(1,1) NOT NULL,
	"nombre"      	nvarchar(255) NOT NULL,
	"apellido"    	nvarchar(255) NOT NULL,
	"mail"        	nvarchar(255) NOT NULL,
	"direccion"   	nvarchar(255) NOT NULL,
	"codigoPostal"	nvarchar(255) NOT NULL,
	"DNI"         	bigint NOT NULL,
	"telefono"    	numeric(15) NOT NULL,
	"fecha_nac"   	datetime NOT NULL,
	"habilitado"	bit NOT NULL,
	CONSTRAINT "id" PRIMARY KEY CLUSTERED("idCliente")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Empresa" (
	"idEmpresa"		bigint IDENTITY(1,1) NOT NULL, 
	"cuit"      	nvarchar(50) NOT NULL,
	"nombre"    	nvarchar(255) NOT NULL,
	"direccion" 	nvarchar(255) NOT NULL,
	"idRubro"   	BIGINT NOT NULL,
	"habilitado"	bit NOT NULL,
	"diaRendicion"  tinyint NOT NULL,
	CONSTRAINT "empresaPK" PRIMARY KEY CLUSTERED("idEmpresa")
ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Factura"  ( 
	"numeroFactura"   	bigint NOT NULL,
	"cliente"         	bigint NULL,
	"empresa"         	bigint NULL,
	"fechaAlta"       	datetime NOT NULL,
	"fechaVencimiento"	datetime NOT NULL,
	"total"           	numeric(15,2) NOT NULL,
	"rendicion"       	bigint,
	"pago"				bigint,
	CONSTRAINT "facturaPK" PRIMARY KEY CLUSTERED("numeroFactura")
 ON [PRIMARY])
GO
CREATE TABLE WEST_WORLD.Devolucion (
	"numeroDevolucion" INT IDENTITY(1,1),
	"fechaDevolucion" DATE DEFAULT getdate() NOT NULL,
	"factura" bigint NOT NULL,
	"pago" INT NOT NULL,
	"cliente" INT NOT NULL,
	"importe" decimal(15,2) NOT NULL,
	"motivo" VARCHAR(255) NOT NULL,
	CONSTRAINT "devolucionPK" PRIMARY KEY CLUSTERED("numeroDevolucion")
	ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Item"( 
	"idItem"       	bigint IDENTITY(1,1) NOT NULL,
	"numeroFactura"	bigint NOT NULL,
	"monto"         numeric(15,2) NOT NULL,
	"cantidad"     	smallint NOT NULL,
	"importe"		numeric(15,2) NOT NULL,
	CONSTRAINT "FacturaItemPK" PRIMARY KEY CLUSTERED("idItem")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."FormaPago"  ( 
	"idFormaPago"	bigint IDENTITY(1,1) NOT NULL,
	"descripcion"	nvarchar(50) NOT NULL,
	CONSTRAINT "idFormaPagoPK" PRIMARY KEY CLUSTERED("idFormaPago")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Funcionalidad"  ( 
	"idFuncionalidad"	bigint IDENTITY(1,1) NOT NULL,
	"nombre"         	nvarchar(50) NOT NULL,
	CONSTRAINT "idFuncPK" PRIMARY KEY CLUSTERED("idFuncionalidad")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Pago"  ( 
	"numeroPago"       	bigint NOT NULL,
	"fechaCobro"      	datetime NOT NULL,
	"cliente"         	bigint NOT NULL,
	"sucursal"        	bigint NOT NULL,
	"importe"         	numeric(15,2) NOT NULL,
	"formaPago"       	bigint NOT NULL,
	CONSTRAINT "pagoPK" PRIMARY KEY CLUSTERED("numeroPago")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rendicion"  ( 
	"numeroRendicion"      	bigint IDENTITY(1,1) NOT NULL,
	"FechaRendicion"    	datetime NOT NULL,
	"cantidadFacturas"  	int NOT NULL,
	"importeNeto"       	numeric(15,2) NOT NULL,
	"empresa"           	bigint NOT NULL,
	"porcentajeComision"	numeric(5,2) NOT NULL,
	"importeTotal"      	numeric(15,2) NOT NULL,
	CONSTRAINT "RendicionPK" PRIMARY KEY CLUSTERED("numeroRendicion")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rol"  ( 
	"idRol"     	bigint IDENTITY(1,1) NOT NULL,
	"nombre"    	nvarchar(50) NOT NULL,
	"habilitado"	bit NOT NULL,
	CONSTRAINT "idRolPK" PRIMARY KEY CLUSTERED("idRol")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rol_Funcionalidad"  ( 
	"idFuncionalidad"	bigint NOT NULL,
	"idRol"          	bigint NOT NULL,
	CONSTRAINT "RolFuncionalidadPK" PRIMARY KEY CLUSTERED("idFuncionalidad","idRol")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rol_Usuario"  ( 
	"idUsuario"	bigint NOT NULL,
	"idRol"    	bigint NOT NULL,
	CONSTRAINT "RolUsuarioPK" PRIMARY KEY CLUSTERED("idUsuario","idRol")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rubro"  ( 
	"idRubro"	bigint IDENTITY(1,1) NOT NULL,
	"nombre" 	nvarchar(50) NOT NULL,
	CONSTRAINT "idRubro" PRIMARY KEY CLUSTERED("idRubro")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Sucursal_Usuario"  ( 
	"idUsuario"	bigint NOT NULL,
	"idSucursal" bigint NOT NULL,
	CONSTRAINT "SucursalUsuarioPK" PRIMARY KEY CLUSTERED("idUsuario","idSucursal")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Sucursal"  (  
	"idSucursal"  	bigint IDENTITY(1,1) NOT NULL,
	"nombre"      	nvarchar(50) NOT NULL,
	"direccion"   	nvarchar(50) NOT NULL,
	"codigoPostal"	nvarchar(10) NOT NULL,
	"habilitado"  	bit NOT NULL,
	CONSTRAINT "PKSucursal" PRIMARY KEY NONCLUSTERED("idSucursal")
ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Usuario"  ( 
	"idUser"      	bigint IDENTITY (1, 1) NOT NULL,
	"user"        	nvarchar(50) NOT NULL,
	"pass"        	BINARY (50) NOT NULL,
	"failedLogins"	int NOT NULL,
	CONSTRAINT "idUserPK" PRIMARY KEY CLUSTERED("idUser")
 ON [PRIMARY])
GO

ALTER TABLE "WEST_WORLD"."Usuario"
	ADD CONSTRAINT "UQ_Usuario"
	UNIQUE ("user")
	WITH (
		DATA_COMPRESSION = NONE
	) ON [PRIMARY]
GO
ALTER TABLE "WEST_WORLD"."Factura"
	ADD CONSTRAINT "empresaFK"
	FOREIGN KEY("empresa")
	REFERENCES "WEST_WORLD"."Empresa"("idEmpresa")
	ON DELETE SET NULL 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura"
	ADD CONSTRAINT "clienteFK"
	FOREIGN KEY("cliente")
	REFERENCES "WEST_WORLD"."Cliente"("idCliente")
	ON DELETE SET NULL
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Item"
	ADD CONSTRAINT "nroFacturaFK"
	FOREIGN KEY("numeroFactura")
	REFERENCES "WEST_WORLD"."Factura"("numeroFactura")
	ON DELETE CASCADE
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Pago"
	ADD CONSTRAINT "sucursalFK"
	FOREIGN KEY("sucursal")
	REFERENCES "WEST_WORLD"."Sucursal"("idSucursal")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Pago"
	ADD CONSTRAINT "FKFormaPago"
	FOREIGN KEY("formaPago")
	REFERENCES "WEST_WORLD"."FormaPago"("idFormaPago")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Pago"
	ADD CONSTRAINT "FKCliente"
	FOREIGN KEY("cliente")
	REFERENCES "WEST_WORLD"."Cliente"("idCliente")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rendicion"
	ADD CONSTRAINT "empresaFK2"
	FOREIGN KEY("empresa")
	REFERENCES "WEST_WORLD"."Empresa"("idEmpresa")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Funcionalidad"
	ADD CONSTRAINT "FKRol"
	FOREIGN KEY("idRol")
	REFERENCES "WEST_WORLD"."Rol"("idRol")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Funcionalidad"
	ADD CONSTRAINT "FKFunc"
	FOREIGN KEY("idFuncionalidad")
	REFERENCES "WEST_WORLD"."Funcionalidad"("idFuncionalidad")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Usuario"
	ADD CONSTRAINT "UsuarioFK"
	FOREIGN KEY("idUsuario")
	REFERENCES "WEST_WORLD"."Usuario"("idUser")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Usuario"
	ADD CONSTRAINT "RolFK"
	FOREIGN KEY("idRol")
	REFERENCES "WEST_WORLD"."Rol"("idRol")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Sucursal_Usuario"
	ADD CONSTRAINT "FKSucursalusuario"
	FOREIGN KEY("idUsuario")
	REFERENCES "WEST_WORLD"."Usuario"("idUser")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Sucursal_Usuario"
	ADD CONSTRAINT "FKSucursalusuario1"
	FOREIGN KEY("idSucursal")
	REFERENCES "WEST_WORLD"."Sucursal"("idSucursal")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Empresa"
	ADD CONSTRAINT "rubroFK"
	FOREIGN KEY("idRubro")
	REFERENCES "WEST_WORLD"."Rubro"("idRubro")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura"
	ADD CONSTRAINT "rendicionFK"
	FOREIGN KEY("rendicion")
	REFERENCES "WEST_WORLD"."Rendicion"("numeroRendicion")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura"
	ADD CONSTRAINT "pagoFK"
	FOREIGN KEY("pago")
	REFERENCES "WEST_WORLD"."Pago"("numeroPago")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Devolucion"
	ADD CONSTRAINT "nroFacturaFK2"
	FOREIGN KEY("factura")
	REFERENCES "WEST_WORLD"."Factura"("numeroFactura")
	ON DELETE CASCADE
	ON UPDATE NO ACTION 
GO
-------------------------------- MIGRACION -------------------------------------------------------------------------------------------------------
GO	
	/*MIGRACION CLIENTE*/
	INSERT INTO WEST_WORLD.Cliente (nombre, apellido, mail, direccion, codigoPostal, DNI, telefono, fecha_nac, habilitado)
	SELECT DISTINCT [Cliente-Nombre], [Cliente-Apellido], Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, [Cliente-Dni], 0, [Cliente-Fecha_Nac], 1
	FROM gd_esquema.Maestra

	
GO
	-- Migrar rubro
	INSERT INTO WEST_WORLD.Rubro
	SELECT DISTINCT Rubro_Descripcion
	FROM gd_esquema.Maestra

GO
	-- Migrar Empresa
	INSERT INTO WEST_WORLD.Empresa
	SELECT DISTINCT Empresa_Cuit, Empresa_Nombre, Empresa_Direccion, Empresa_Rubro, 1 AS 'Habilitado', DAY(MAX(ISNULL(Rendicion_Fecha,0))) as 'Dia de Rendicion'
	FROM gd_esquema.Maestra
	GROUP BY Empresa_Cuit, Empresa_Nombre, Empresa_Direccion, Empresa_Rubro

GO
	--Migrar Sucursal
	INSERT INTO WEST_WORLD.Sucursal
	SELECT DISTINCT Sucursal_Nombre, Sucursal_Dirección, Sucursal_Codigo_Postal, 1
	FROM gd_esquema.Maestra
	WHERE Sucursal_Codigo_Postal IS NOT NULL

GO
	--Migrar FormaPago
	INSERT INTO WEST_WORLD.FormaPago
	SELECT DISTINCT FormaPagoDescripcion
	FROM gd_esquema.Maestra
	WHERE FormaPagoDescripcion IS NOT NULL

GO
	--Migrar Pagos
	INSERT INTO WEST_WORLD.Pago
	SELECT DISTINCT Pago_nro, Pago_Fecha, wc.idCliente, ws.idSucursal, Total, fp.idFormaPago
	FROM gd_esquema.Maestra
	JOIN WEST_WORLD.Cliente wc ON (wc.DNI = [Cliente-Dni])
	JOIN WEST_WORLD.Sucursal ws ON (ws.codigoPostal = Sucursal_Codigo_Postal)
	JOIN WEST_WORLD.FormaPago fp ON (fp.descripcion = FormaPagoDescripcion)
	WHERE Pago_nro IS NOT NULL
	ORDER BY Pago_nro

GO
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

GO	
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

GO	
	--Migrar Items
	INSERT INTO WEST_WORLD.Item(numeroFactura, monto, cantidad, importe)
	SELECT DISTINCT Nro_Factura, ROUND(ROUND(ItemFactura_Monto,2)/ROUND(ItemFactura_Cantidad, 2),2), ItemFactura_Cantidad, ItemFactura_Monto
	from gd_esquema.Maestra
	order by Nro_Factura
	

------------- CONSTRAINTS (no fk) ------------------------------------------------------------------
GO
--ALTER TABLE [WEST_WORLD].[Factura]  WITH CHECK ADD CHECK  (([fechaVencimiento]>=sysdatetime()))
GO
ALTER TABLE [WEST_WORLD].[Factura]  WITH CHECK ADD CHECK  (([total]>(0)))
GO
ALTER TABLE [WEST_WORLD].[Pago]  WITH CHECK ADD CHECK  (([importe]>(0)))
GO
ALTER TABLE [WEST_WORLD].[Pago] ADD DEFAULT (sysdatetime()) FOR [fechaCobro]
GO
ALTER TABLE [WEST_WORLD].[Cliente] ADD DEFAULT (0) FOR [telefono]
GO
ALTER TABLE [WEST_WORLD].[Empresa] ADD UNIQUE ([cuit])
GO
--ALTER TABLE [WEST_WORLD].[Cliente] ADD UNIQUE ([mail])
GO
ALTER TABLE [WEST_WORLD].[Factura] ADD UNIQUE ([numeroFactura])
GO
ALTER TABLE [WEST_WORLD].[Sucursal] ADD UNIQUE ([codigoPostal]);

---------------------------- TRIGGERS ----------------------------------
GO

CREATE TRIGGER validarMailInsert ON WEST_WORLD.Cliente
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
--------------------------------------- INSERT FUNCIONALIDADES Y ROLES -----------------------------------------------
GO
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Empresa')
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Cliente');
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Sucursal');
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Rol');
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Factura');
INSERT INTO WEST_WORLD.Funcionalidad values ('Registro de Pago');
INSERT INTO WEST_WORLD.Funcionalidad values ('Rendicion de Facturas');
INSERT INTO WEST_WORLD.Funcionalidad values ('Devoluciones');
INSERT INTO WEST_WORLD.Funcionalidad values ('Listado Estadistico');
GO
INSERT INTO WEST_WORLD.Rol values ('Administrador',1);
INSERT INTO WEST_WORLD.Rol values ('Cobrador',1);
GO
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (1,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (2,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (3,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (4,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (5,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (6,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (7,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (8,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (9,1);
GO
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (5,2);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (6,2);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (8,2);
GO
INSERT INTO WEST_WORLD.Usuario([user], pass, failedLogins)
						VALUES('admin', (SELECT HASHBYTES('SHA2_256', 'w23e')), 0)
INSERT INTO WEST_WORLD.Rol_Usuario VALUES (1,1);
INSERT INTO WEST_WORLD.Rol_Usuario VALUES (1,2);

INSERT INTO WEST_WORLD.Sucursal_Usuario VALUES (1,1);

GO

