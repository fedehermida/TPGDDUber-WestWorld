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

------------------------------------- DROP STORED PROCEDURES -------------------------------------------------

GO
IF OBJECT_ID('WEST_WORLD.ActualizarFuncionalidades') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ActualizarFuncionalidades 
GO
IF OBJECT_ID('WEST_WORLD.AgregarFuncionalidad') IS NOT NULL
DROP PROCEDURE WEST_WORLD.AgregarFuncionalidad 
GO
IF OBJECT_ID('WEST_WORLD.AgregarRolAUsuario') IS NOT NULL
DROP PROCEDURE WEST_WORLD.AgregarRolAUsuario 
GO
IF OBJECT_ID('WEST_WORLD.BuscarRoles') IS NOT NULL
DROP PROCEDURE WEST_WORLD.BuscarRoles 
GO
IF OBJECT_ID('WEST_WORLD.CreateRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.CreateRol 
GO
IF OBJECT_ID('WEST_WORLD.FuncionalidadesRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FuncionalidadesRol 
GO
IF OBJECT_ID('WEST_WORLD.ActualizarRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ActualizarRol
GO 
IF OBJECT_ID('WEST_WORLD.ClienteCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClienteCreateOrUpdate
GO
IF OBJECT_ID('WEST_WORLD.ClienteViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClienteViewOrSearch
GO
IF OBJECT_ID('WEST_WORLD.EmpresaCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.EmpresaCreateOrUpdate
GO
IF OBJECT_ID('WEST_WORLD.EmpresaViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.EmpresaViewOrSearch 
GO
IF OBJECT_ID('WEST_WORLD.FacturaAsignarPago') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaAsignarPago 
GO
IF OBJECT_ID('WEST_WORLD.FacturaAsignarRendicion') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaAsignarRendicion 
GO
IF OBJECT_ID('WEST_WORLD.FacturaCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaCreateOrUpdate 
GO
IF OBJECT_ID('WEST_WORLD.FacturaDelete') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaDelete 
GO
IF OBJECT_ID('WEST_WORLD.FacturaImporteUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaImporteUpdate 
GO
IF OBJECT_ID('WEST_WORLD.FacturaViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaViewOrSearch 
GO
IF OBJECT_ID('WEST_WORLD.GetEmpresas') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetEmpresas 
GO
IF OBJECT_ID('WEST_WORLD.GetFormasDePago') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetFormasDePago 
GO
IF OBJECT_ID('WEST_WORLD.GetFuncionalidades') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetFuncionalidades 
GO
IF OBJECT_ID('WEST_WORLD.GetRubros') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetRubros 
GO
IF OBJECT_ID('WEST_WORLD.ItemCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ItemCreateOrUpdate 
GO
IF OBJECT_ID('WEST_WORLD.ItemDelete') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ItemDelete
GO
IF OBJECT_ID('WEST_WORLD.ItemView') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ItemView
GO
IF OBJECT_ID('WEST_WORLD.PagoCreate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.PagoCreate
GO
IF OBJECT_ID('WEST_WORLD.SeleccionarCliente') IS NOT NULL
DROP PROCEDURE WEST_WORLD.SeleccionarCliente
GO
IF OBJECT_ID('WEST_WORLD.SucursalCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.SucursalCreateOrUpdate
GO
IF OBJECT_ID('WEST_WORLD.SucursalViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.SucursalViewOrSearch
GO
IF OBJECT_ID('WEST_WORLD.ClientesConMasPagos') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClientesConMasPagos
GO
IF OBJECT_ID('WEST_WORLD.ClientesCumplidores') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClientesCumplidores
GO
IF OBJECT_ID('WEST_WORLD.EmpresasConMayorMontoRendido') IS NOT NULL
DROP PROCEDURE WEST_WORLD.EmpresasConMayorMontoRendido
GO
IF OBJECT_ID('WEST_WORLD.FacturasCobradasPorEmpresa') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturasCobradasPorEmpresa
GO
IF OBJECT_ID('WEST_WORLD.ValidarCreateOrUpdateRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ValidarCreateOrUpdateRol
GO
IF OBJECT_ID('WEST_WORLD.DevolucionDeFactura') IS NOT NULL
DROP PROCEDURE WEST_WORLD.DevolucionDeFactura
GO
IF OBJECT_ID('WEST_WORLD.RendicionCreate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.RendicionCreate

------------------------------------- DROP & CREATE SCHEMA ------------------------------------------
GO

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'WEST_WORLD')
		DROP SCHEMA WEST_WORLD
		
GO
CREATE SCHEMA WEST_WORLD AUTHORIZATION gd


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
INSERT INTO WEST_WORLD.Usuario([user], pass, failedLogins)
						VALUES('cobrador', (SELECT HASHBYTES('SHA2_256', 'cobrador')), 0)
INSERT INTO WEST_WORLD.Rol_Usuario VALUES (1,1);
INSERT INTO WEST_WORLD.Rol_Usuario VALUES (1,2);

INSERT INTO WEST_WORLD.Rol_Usuario VALUES (
	(SELECT u.idUser from WEST_WORLD.Usuario u where u.[user] = 'cobrador'),
	(SELECT r.idRol from WEST_WORLD.Rol r where r.nombre='Cobrador')
)

INSERT INTO WEST_WORLD.Sucursal_Usuario VALUES (1,1);
INSERT INTO WEST_WORLD.Sucursal_Usuario VALUES (
	(SELECT u.idUser from WEST_WORLD.Usuario u where u.[user] = 'cobrador'),
		1);

GO

----------------------------STORED PROCEDURES-------------------------------------------------------------------------
GO

CREATE PROCEDURE WEST_WORLD.ActualizarFuncionalidades
@idRol BIGINT 
as
DELETE FROM WEST_WORLD.Rol_Funcionalidad
WHERE idRol=@idRol

GO

CREATE PROCEDURE WEST_WORLD.AgregarFuncionalidad 
@idRol BIGINT,
@idFuncionalidad BIGINT

AS
BEGIN
	INSERT INTO WEST_WORLD.Rol_Funcionalidad(idRol,idFuncionalidad) values(@idRol,@idFuncionalidad)
END

GO

CREATE PROCEDURE [WEST_WORLD].[AgregarRolAUsuario] 
@idUser BIGINT, 
@idRol BIGINT
as
BEGIN
	INSERT INTO WEST_WORLD.Rol_Usuario (idRol,idUsuario)
	VALUES(@idRol,@idUser)
END

GO

CREATE PROCEDURE WEST_WORLD.BuscarRoles
@Nombre VARCHAR(50)

AS

BEGIN
	SELECT idRol, nombre as 'Nombre', habilitado as 'Habilitado'
	FROM WEST_WORLD.Rol
	WHERE (@Nombre IS NULL OR nombre LIKE CONCAT(@Nombre, '%'))
END

GO

CREATE PROCEDURE WEST_WORLD.CreateRol
@nombre VARCHAR(50),
@habilitado bit

AS
	
BEGIN
	IF NOT EXISTS (SELECT nombre FROM WEST_WORLD.Rol WHERE nombre = @nombre)
	BEGIN
		INSERT INTO WEST_WORLD.Rol(nombre,habilitado) 
		VALUES(@nombre, @habilitado)
		RETURN SCOPE_IDENTITY()
	END
	ELSE
		RAISERROR(N'El Rol "%s" ya existe. Intente con otro nombre', 16, 2, @nombre)
END

GO

CREATE PROCEDURE WEST_WORLD.FuncionalidadesRol 
@idRol BIGINT

AS
BEGIN
	SELECT f.nombre,f.idFuncionalidad 
	FROM WEST_WORLD.Rol_Funcionalidad rf
	JOIN WEST_WORLD.Funcionalidad f ON (rf.idFuncionalidad=f.idFuncionalidad)
	WHERE rf.idRol = @idRol
END
GO

CREATE PROCEDURE WEST_WORLD.ActualizarRol 
@idRol BIGINT,
@nombre VARCHAR(50),
@habilitado BIT
as
UPDATE WEST_WORLD.Rol 
SET nombre=@nombre,
	habilitado=@habilitado
WHERE idRol=@idRol

GO

CREATE PROCEDURE WEST_WORLD.ClienteCreateOrUpdate
@mode nvarchar(10),
@idCliente bigint,
@nombre nvarchar(255),
@apellido nvarchar(255),
@mail nvarchar(255),
@direccion nvarchar(255),
@codigoPostal nvarchar(255),
@dni numeric(15,0),
@telefono numeric(15,0),
@fec_nac dateTime,
@habilitado bit


AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Cliente(
			nombre, 
			apellido, 
			mail ,
			direccion, 
			codigoPostal, 
			dni, 
			telefono, 
			fecha_nac,
			habilitado
		)
		VALUES(
			@nombre,
			@apellido,
			@mail,
			@direccion,
			@codigoPostal,
			@dni,
			@telefono,
			@fec_nac,
			@habilitado
		)
	END
	ELSE IF @mode ='Edit'

	BEGIN
		IF EXISTS ( SELECT 1 FROM WEST_WORLD.Cliente c WHERE mail = @MAIL
												AND c.idCliente != @idCliente)
		BEGIN
			RAISERROR('Mail Repetido en otro usuario', 13, 1)
		END
		ELSE
		BEGIN
			UPDATE WEST_WORLD.Cliente
			SET nombre=@nombre, 
				apellido=@apellido, 
				mail=@mail ,
				direccion=@direccion, 
				codigoPostal=@codigoPostal, 
				dni=@dni, 
				telefono=@telefono, 
				fecha_nac=@fec_nac,
				habilitado=@habilitado
			WHERE idCliente=@idCliente
		END
	END
		
		

RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.ClienteViewOrSearch
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(15)
AS
	SELECT idCliente, nombre as 'Nombre', apellido as 'Apellido', mail as 'Email', direccion as 'Direccion', codigoPostal as 'Codigo Postal',
		   DNI, telefono as 'Telefono', fecha_nac as 'Fecha de Nacimiento', habilitado as 'Habilitado'
	FROM WEST_WORLD.Cliente
	WHERE nombre LIKE @nombre + '%' 
			AND apellido LIKE @apellido + '%' 
			AND (@dni IS NULL OR (DNI = @dni))
    OPTION (RECOMPILE)
			
RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.EmpresaCreateOrUpdate
@mode nvarchar(10),
@idEmpresa bigint,
@nombre nvarchar(255),
@cuit nvarchar(50),
@direccion nvarchar(255),
@idRubro bigint,
@habilitado bit,
@diaRendicion tinyint

AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Empresa(nombre, cuit, direccion, idRubro, habilitado, diaRendicion)
		VALUES(@nombre, @cuit, @direccion, @idRubro, @habilitado, @diaRendicion)
	END
	ELSE IF @mode ='Edit'
	BEGIN
		UPDATE WEST_WORLD.Empresa
		SET nombre=@nombre, 
			cuit=@cuit,
			direccion=@direccion,
			idRubro=@idRubro,
			diaRendicion=@diaRendicion
		WHERE idEmpresa=@idEmpresa
		
		--Me fijo si la empresa a modificar esta activa y se quiere dar de baja
		IF (EXISTS (SELECT idEmpresa FROM WEST_WORLD.Empresa WHERE idEmpresa=@idEmpresa AND habilitado=1)  AND (@habilitado=0))	
			BEGIN
				--Veo si tiene alguna factura no rendida. Si estan todas rendidas se puede dar de baja
				IF EXISTS (SELECT numeroFactura FROM WEST_WORLD.Factura WHERE empresa = @idEmpresa AND rendicion IS NULL AND pago IS NOT NULL)
					RAISERROR('No es posible darle de baja a una empresa con 1 o m�s facturas sin rendir', 16, 1)
				ELSE 
					UPDATE WEST_WORLD.Empresa
					SET habilitado=@habilitado
					WHERE idEmpresa=@idEmpresa
			END
		ELSE
			UPDATE WEST_WORLD.Empresa
			SET habilitado=@habilitado
			WHERE idEmpresa=@idEmpresa

	END

RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.EmpresaViewOrSearch
	@nombre nvarchar(255),
	@cuit nvarchar(50),
	@idRubro bigint
AS
	SELECT *
	FROM WEST_WORLD.Empresa
	WHERE nombre LIKE @nombre + '%' 
			 AND (@cuit IS NULL OR cuit LIKE @cuit)
			 AND (@idRubro IS NULL OR (idRubro = @idRubro))
        OPTION (RECOMPILE)
RETURN 0;

GO

CREATE PROCEDURE WEST_WORLD.FacturaAsignarPago
	@NUMFACTURA bigint,
	@PAGO bigint

AS

	UPDATE WEST_WORLD.Factura
	SET pago = @PAGO
	WHERE numeroFactura = @NUMFACTURA;

GO

CREATE PROCEDURE WEST_WORLD.FacturaAsignarRendicion
	@NUMFACTURA bigint,
	@RENDICION bigint
AS

	UPDATE WEST_WORLD.Factura
	SET rendicion = @RENDICION
	WHERE numeroFactura = @NUMFACTURA

GO

CREATE PROCEDURE WEST_WORLD.FacturaCreateOrUpdate
	@MODE nvarchar(10),
	@NUMEROFACTURA bigint,
	@CLIENTE bigint,
	@EMPRESA bigint,
	@FECHA_ALTA datetime,
	@FECHA_VENC datetime,
	@TOTAL numeric(15,2)

AS
	IF @mode='Add'
		BEGIN
			INSERT INTO WEST_WORLD.Factura(numeroFactura, cliente, empresa, fechaAlta, fechaVencimiento, total)
			VALUES(@NUMEROFACTURA, @CLIENTE, @EMPRESA, @FECHA_ALTA, @FECHA_VENC, @TOTAL)
			RETURN 0
		END
	ELSE IF @mode ='Edit'
		BEGIN
			IF EXISTS (SELECT * FROM WEST_WORLD.Factura
					WHERE numeroFactura=@NUMEROFACTURA AND pago IS NULL AND rendicion IS NULL)
				BEGIN
					UPDATE WEST_WORLD.Factura
					SET cliente=@CLIENTE, 
						empresa=@EMPRESA,
						fechaAlta=@FECHA_ALTA,
						fechaVencimiento=@FECHA_VENC,
						total=@TOTAL
					WHERE numeroFactura=@NUMEROFACTURA
					RETURN 0
				END
			ELSE
				RETURN -1
		END
RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.FacturaDelete
@NUMEROFACTURA bigint

AS
	IF EXISTS (SELECT * FROM WEST_WORLD.Factura
				WHERE numeroFactura=@NUMEROFACTURA AND pago IS NULL AND rendicion IS NULL)
		BEGIN
			DELETE FROM WEST_WORLD.Factura
			WHERE numeroFactura=@NUMEROFACTURA
			RETURN 0
		END
	ELSE 
		RETURN -1

GO

CREATE PROCEDURE WEST_WORLD.FacturaImporteUpdate
	@NUMEROFACTURA bigint,
	@TOTAL numeric(15,2)

AS
	IF EXISTS (SELECT * FROM WEST_WORLD.Factura 
				WHERE numeroFactura = @NUMEROFACTURA)
		BEGIN
			UPDATE WEST_WORLD.Factura
			SET total=@TOTAL
			WHERE numeroFactura = @NUMEROFACTURA
		END

GO

CREATE PROCEDURE WEST_WORLD.FacturaViewOrSearch
	@ESTADO nvarchar(30),
	@NUMEROFACTURA BIGINT,
	@IDEMPRESA BIGINT,
	@IDCLIENTE BIGINT,
	@MES TINYINT,
	@ANIO INT
AS	
	IF @ESTADO = 'Sin Pago'
		IF EXISTS (SELECT 1 FROM WEST_WORLD.Cliente WHERE idCliente = @IDCLIENTE AND habilitado = 0)
			RAISERROR('El cliente seleccionado se encuentra inactivo, por lo cual no puede pagar facturas', 16,2)
		ELSE
			SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', fechaVencimiento as 'Fecha Venc', total as 'Total' 
			FROM WEST_WORLD.Factura f JOIN WEST_WORLD.Empresa e ON (f.empresa = e.idEmpresa)
				WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
					AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
					AND (cliente = @IDCLIENTE)
					AND (pago IS NULL) AND (rendicion IS NULL)
					AND (e.habilitado = 1)
					AND (f.fechaVencimiento <= SYSDATETIME())
	ELSE IF @ESTADO = 'Con Pago Y Sin Rendicion'
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', pago as 'Pago' 
		FROM WEST_WORLD.Factura f JOIN WEST_WORLD.Empresa e ON (f.empresa = e.idEmpresa)
		WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
			AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
			AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))
			AND (pago IS NOT NULL) AND (rendicion IS NULL)
			AND (e.habilitado = 1)
			AND (@MES = 0 OR MONTH(fechaAlta) = @MES)
			AND (@ANIO = 0 OR YEAR(fechaAlta) = @ANIO)
	ELSE 
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', rendicion as 'Rendicion', pago as 'Pago' 
		FROM WEST_WORLD.Factura
			WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
				AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
				AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))	
    
	OPTION (RECOMPILE)
RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.GetEmpresas
AS
	BEGIN 
		SELECT idEmpresa, nombre
		FROM WEST_WORLD.Empresa
	END


GO 

CREATE PROCEDURE WEST_WORLD.GetFormasDePago
AS
	BEGIN 
		SELECT *
		FROM WEST_WORLD.FormaPago
	END

GO

CREATE PROCEDURE WEST_WORLD.GetFuncionalidades
as
SELECT * FROM WEST_WORLD.Funcionalidad 

GO

CREATE PROCEDURE WEST_WORLD.GetRubros
AS
	BEGIN 
		SELECT idRubro, nombre
		FROM WEST_WORLD.Rubro
	END


GO

CREATE PROCEDURE WEST_WORLD.ItemCreateOrUpdate
	@MODE nvarchar(10),
	@IDITEM bigint,
	@NUMEROFACTURA bigint,
	@MONTO numeric(15,2),
	@CANTIDAD smallint

AS
	
	IF @mode='Add'
		BEGIN
			IF EXISTS (SELECT * FROM WEST_WORLD.Item 
					   WHERE numeroFactura = @NUMEROFACTURA AND monto = @MONTO 
							 AND cantidad = @CANTIDAD)				
				RAISERROR(N'Ya existe el item ingresado para la factura %I64i', 15,2, @NUMEROFACTURA)
			ELSE IF NOT EXISTS (SELECT * FROM WEST_WORLD.Factura WHERE numeroFactura = @NUMEROFACTURA)
				RAISERROR(N'No existe la factura %I64i por lo que no se agreg� el item', 15, 2, @NUMEROFACTURA)
			ELSE
				INSERT INTO WEST_WORLD.Item(numeroFactura, cantidad, monto, importe)
				VALUES(@NUMEROFACTURA, @CANTIDAD, @MONTO, @CANTIDAD*@MONTO)

				OPTION (RECOMPILE)
		END
	
	ELSE IF @mode ='Edit'
		BEGIN

			UPDATE WEST_WORLD.Item
			SET numeroFactura = @NUMEROFACTURA,
				monto=@MONTO, 
				cantidad=@CANTIDAD,
				importe=@MONTO*@CANTIDAD
			WHERE idItem = @IDITEM
		END

GO

CREATE PROCEDURE WEST_WORLD.ItemDelete
@NUMEROFACTURA bigint,
@IDITEM bigint

AS
	IF((SELECT COUNT(idItem) FROM WEST_WORLD.Item WHERE numeroFactura = @NUMEROFACTURA) > 1)
		DELETE FROM WEST_WORLD.Item
		WHERE numeroFactura = @NUMEROFACTURA and idItem = @IDITEM
	ELSE
		RAISERROR('La factura no puede quedar sin items. Puede actualizar el seleccionado', 15, 2)	 

GO

CREATE PROCEDURE WEST_WORLD.ItemView
	@NUMEROFACTURA bigint

AS
	IF EXISTS (SELECT numeroFactura FROM WEST_WORLD.Factura WHERE numeroFactura = @NUMEROFACTURA)
		SELECT idItem, monto as 'Monto', cantidad as 'Cantidad', importe as 'Importe'
		FROM WEST_WORLD.Item i
		WHERE numeroFactura = @NUMEROFACTURA

	ELSE 
		RAISERROR(N'No existe la factura %I64i', 15,2, @NUMEROFACTURA)

RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.PagoCreate
@FECHACOBRO datetime,
@IDCLIENTE bigint,
@IDSUCURSAL bigint,
@IMPORTE numeric(15,2),
@IDFORMADEPAGO nvarchar(50)

AS
	
	DECLARE @ID int
	SET @ID = (SELECT MAX(numeroPago) + 1 FROM WEST_WORLD.Pago)
	INSERT INTO WEST_WORLD.Pago(numeroPago, FechaCobro, cliente, sucursal, importe, formaPago)
		VALUES(@ID, @FECHACOBRO, @IDCLIENTE, @IDSUCURSAL, @IMPORTE, @IDFORMADEPAGO)

RETURN @ID

GO

CREATE PROCEDURE WEST_WORLD.RendicionCreate
@FECHA_RENDICION datetime,
@IDEMPRESA bigint,
@CANT_FACTURAS smallint,
@IMPORTE_NETO numeric(15,2),
@IMPORTE_TOTAL numeric(15,2),
@PORCENTAJE_COMISION nvarchar(50)

AS
	
	INSERT INTO WEST_WORLD.Rendicion(cantidadFacturas, empresa, FechaRendicion, importeNeto, importeTotal, porcentajeComision)
		VALUES(@CANT_FACTURAS, @IDEMPRESA, @FECHA_RENDICION, @IMPORTE_NETO, @IMPORTE_TOTAL, @PORCENTAJE_COMISION)

RETURN SCOPE_IDENTITY()

GO

CREATE PROCEDURE WEST_WORLD.SeleccionarCliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(15)
AS
	SELECT idCliente, nombre as 'Nombre', apellido as 'Apellido', DNI
	FROM WEST_WORLD.Cliente
	WHERE nombre LIKE @nombre + '%' 
			AND apellido LIKE @apellido + '%' 
			AND (@dni IS NULL OR (DNI = @dni))
    OPTION (RECOMPILE)
			
RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.SucursalCreateOrUpdate
@mode nvarchar(10),
@idSucursal bigint,
@nombre nvarchar(50),
@direccion nvarchar(50),
@codigoPostal nvarchar(50),
@habilitado bit,
@operador nvarchar(50)

AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Sucursal(
			nombre, 
			direccion, 
			codigoPostal, 
			habilitado		
		)
		VALUES(
			@nombre,
			@direccion,
			@codigoPostal,
			@habilitado			
		)
		INSERT INTO WEST_WORLD.Sucursal_Usuario(
			idUsuario,
			idSucursal
		)
		VALUES(
			(SELECT idUser from WEST_WORLD.Usuario where [user]=@operador),	
			(SELECT idSucursal from WEST_WORLD.Sucursal where codigoPostal=@codigoPostal)
		)
	END
	ELSE IF @mode ='Edit'
	BEGIN
		UPDATE WEST_WORLD.Sucursal
		SET nombre=@nombre,
			direccion=@direccion, 
			codigoPostal=@codigoPostal, 
			habilitado=@habilitado
		WHERE idSucursal=@idSucursal
	END	

RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.SucursalViewOrSearch
	@nombre nvarchar(50),
	@direccion nvarchar(50),
	@codigoPostal nvarchar(50)
AS
	SELECT idSucursal, nombre as 'Nombre', direccion as 'Direccion', codigoPostal as 'Codigo Postal', habilitado as 'Habilitado'
	FROM WEST_WORLD.Sucursal
	WHERE nombre LIKE @nombre + '%' 
			 AND direccion LIKE @direccion + '%'
			 AND (@codigoPostal IS NULL OR (codigoPostal = @codigoPostal))
        OPTION (RECOMPILE)
RETURN 0

GO

CREATE PROCEDURE WEST_WORLD.ClientesConMasPagos
@trimestre INT, @anio INT
AS
BEGIN
	DECLARE @MESDESDE INT, @MESHASTA INT

	set @MESDESDE = case @trimestre  
	  WHEN 1 THEN 1 
	  WHEN 2 THEN 4 
	  WHEN 3 THEN 7 
	  WHEN 4 THEN 10  
	END

	set @MESHASTA = @MESDESDE + 2

	SELECT TOP 5 C.idCliente, C.nombre 'Nombre', c.apellido 'Apellido', C.DNI, COUNT(numeroPago) AS 'Cantidad de Pagos'
	FROM WEST_WORLD.Pago P
	JOIN WEST_WORLD.Cliente C on (C.idCliente = P.cliente)
	WHERE DATEPART(YEAR, FechaCobro) = @anio AND
			DATEPART(MONTH, FechaCobro) BETWEEN @MESDESDE AND @MESHASTA

	GROUP BY C.idCliente, C.nombre, c.apellido, C.DNI
	ORDER BY 5 DESC

END

GO

CREATE PROCEDURE WEST_WORLD.ClientesCumplidores
@trimestre INT, @anio INT
AS
BEGIN
	DECLARE @MESDESDE INT, @MESHASTA INT

	SET @MESDESDE = CASE @trimestre  
	  WHEN 1 THEN 1 
	  WHEN 2 THEN 4 
	  WHEN 3 THEN 7 
	  WHEN 4 THEN 10  
	END

	SET @MESHASTA = @MESDESDE + 2


	SELECT TOP 5 f.cliente 'idCliente', C.nombre 'Nombre', C.apellido 'Apellido', C.DNI, C.mail, ROUND(ROUND(COUNT(pago) ,2)/ROUND(COUNT(numeroFactura) ,2) * 100, 2) as 'Porcentaje De Facturas Cobradas'
	FROM WEST_WORLD.Factura F
	JOIN WEST_WORLD.Cliente C on (C.idCliente = F.cliente)
	JOIN WEST_WORLD.Pago P ON (F.pago = P.numeroPago)
	WHERE DATEPART(YEAR, P.FechaCobro) = @anio AND
		  DATEPART(MONTH, P.FechaCobro) BETWEEN @MESDESDE AND @MESHASTA
	GROUP BY f.cliente, C.nombre, C.apellido, C.DNI, c.mail
	ORDER BY 6 DESC

END

GO

CREATE PROCEDURE WEST_WORLD.EmpresasConMayorMontoRendido
@trimestre int, @anio int
AS
BEGIN

	DECLARE @MESDESDE INT, @MESHASTA INT

	SET @MESDESDE = CASE @trimestre  
	  WHEN 1 THEN 1 
	  WHEN 2 THEN 4 
	  WHEN 3 THEN 7 
	  WHEN 4 THEN 10  
	END

	set @MESHASTA = @MESDESDE + 2

	SELECT TOP 5 empresa 'idEmpresa',  e.nombre 'Nombre', e.cuit 'CUIT', SUM(importeNeto) AS 'Cantidad Rendida'
	FROM WEST_WORLD.Rendicion r
	JOIN WEST_WORLD.Empresa e ON (e.idEmpresa = r.empresa)
	WHERE DATEPART(YEAR, FechaRendicion) = @anio AND
		  DATEPART(MONTH, FechaRendicion) BETWEEN @MESDESDE AND @MESHASTA  
	GROUP BY empresa, e.nombre, e.cuit
	ORDER BY 4
END

GO

CREATE PROCEDURE WEST_WORLD.FacturasCobradasPorEmpresa
@trimestre INT, @anio INT
AS
BEGIN
DECLARE @MESDESDE INT, @MESHASTA INT

set @MESDESDE = case @trimestre  
 WHEN 1 THEN 1 
 WHEN 2 THEN 4 
 WHEN 3 THEN 7 
 WHEN 4 THEN 10  
END

set @MESHASTA = @MESDESDE + 2

SELECT TOP 5 empresa 'idEmpresa', E.nombre 'Nombre', count(pago) 'Cantidad de Facturas Pagadas', count(numeroFactura) 'Cantidad de facturas totales', CAST(
          COUNT(f.pago) * 100 / CAST(COUNT(f.numeroFactura) AS FLOAT)
            AS NUMERIC(18, 2)
        ) AS 'Porcentaje de facturas cobradas'
FROM WEST_WORLD.Factura F
JOIN WEST_WORLD.Empresa E ON (F.empresa = E.idEmpresa)
WHERE	DATEPART(YEAR, fechaAlta) = @anio AND
DATEPART(MONTH, fechaAlta) BETWEEN @MESDESDE AND @MESHASTA  
GROUP BY empresa, E.nombre
ORDER BY 5 DESC

END

GO

--Busco si ya existe algun rol que tenga las mismas funcionalidades que mi rol. 
--Si encuentro alguno envio un mensaje de que ya existe un rol con las mismas funcionalidades
--Si no encuentra entonces se puede crear el rol
CREATE PROCEDURE WEST_WORLD.ValidarCreateOrUpdateRol
@idRol bigint

AS

BEGIN
	IF EXISTS(SELECT r.idRol, r.nombre
	FROM WEST_WORLD.Rol_Funcionalidad rf JOIN WEST_WORLD.Rol r ON (rf.idRol = r.idRol)
	WHERE idFuncionalidad IN (SELECT idFuncionalidad
								FROM WEST_WORLD.Rol_Funcionalidad
								WHERE idRol = @idRol) 
							AND rf.idRol != @idRol
	INTERSECT
	SELECT r.idRol, r.nombre
	FROM WEST_WORLD.Rol_Funcionalidad rf JOIN WEST_WORLD.Rol r ON (rf.idRol = r.idRol)
	GROUP BY r.idRol, r.nombre
	HAVING count(idFuncionalidad) = (
									SELECT count(idFuncionalidad)
									FROM WEST_WORLD.Rol_Funcionalidad 
									WHERE idRol = @idRol
									)
	)

	BEGIN
		DELETE FROM WEST_WORLD.Rol_Funcionalidad WHERE idRol = @idRol
		DELETE FROM WEST_WORLD.Rol WHERE idRol = @idRol
		RAISERROR('Ya existe un rol con las mismas funcionalidades', 16, 2)
	END
END

GO

CREATE PROCEDURE WEST_WORLD.DevolucionDeFactura
@numeroFactura int, @motivo VARCHAR(255)
AS
BEGIN

	DECLARE @pago int, @numeroCliente int, @importe decimal(10,2), @rendicion INT

	SELECT @pago = pago, @numeroCliente = cliente, @importe = total, @rendicion = rendicion
	FROM WEST_WORLD.Factura
	WHERE numeroFactura = @numeroFactura

	IF(@rendicion IS NULL AND @pago IS NOT NULL)
	BEGIN
		INSERT INTO WEST_WORLD.Devolucion(factura, pago, cliente, importe, motivo)
		VALUES (@numeroFactura, @pago, @numeroCliente, @importe, @motivo)

		UPDATE WEST_WORLD.Factura
		SET pago = NULL
		WHERE numeroFactura = @numeroFactura

		DELETE FROM WEST_WORLD.Pago
		WHERE numeroPago = @pago
	END

	ELSE IF(@rendicion IS NOT NULL AND @pago IS NOT NULL)
	BEGIN 
		RAISERROR('Esta factura ya fue rendida y no puede ser devuelta', 12, 2)
	END

	ELSE 
	BEGIN
		RAISERROR('Esta factura no fue pagada aun', 12, 2)
	END
END

