USE GD2C2017
GO

CREATE or ALTER PROCEDURE WEST_WORLD.AgregarFuncionalidad 
@IdRol BIGINT,
@IdFuncionalidad BIGINT
as
BEGIN
    INSERT INTO WEST_WORLD.Rol_Funcionalidad(idRol,idFuncionalidad) values(@IdRol,@IdFuncionalidad)
END


GO
CREATE PROCEDURE WEST_WORLD.ActualizarFuncionalidades
@idRol BIGINT as
DELETE FROM WEST_WORLD.Rol_Funcionalidad
WHERE idRol=@idRol
GO
CREATE OR ALTER PROCEDURE [WEST_WORLD].[AgregarRolAUsuario] 
@idUser BIGINT, 
@idRol BIGINT
as
BEGIN
INSERT INTO WEST_WORLD.Rol_Usuario (idRol,idUsuario)
VALUES(@idRol,@idUser)
END
GO

CREATE OR ALTER PROCEDURE WEST_WORLD.BuscarRoles
@Nombre VARCHAR(50)

AS

BEGIN
	SELECT idRol, nombre as 'Nombre', habilitado as 'Habilitado'
	FROM WEST_WORLD.Rol
	WHERE (@Nombre IS NULL OR nombre LIKE CONCAT(@Nombre, '%'))
END

GO
CREATE OR ALTER PROCEDURE WEST_WORLD.CreateRol
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
CREATE OR ALTER PROCEDURE WEST_WORLD.FuncionalidadesRol 
@idRol BIGINT

AS
BEGIN
	SELECT f.nombre,f.idFuncionalidad 
	FROM WEST_WORLD.Rol_Funcionalidad rf
	JOIN WEST_WORLD.Funcionalidad f ON (rf.idFuncionalidad=f.idFuncionalidad)
	WHERE rf.idRol = @idRol
END
GO
CREATE OR ALTER PROCEDURE WEST_WORLD.ActualizarRol 
@idRol BIGINT,
@nombre VARCHAR(50),
@habilitado BIT
as
UPDATE WEST_WORLD.Rol 
SET nombre=@nombre,
	habilitado=@habilitado
WHERE idRol=@idRol
GO

CREATE or ALTER PROCEDURE WEST_WORLD.ClienteCreateOrUpdate
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
		
		

RETURN 0

GO

CREATE OR ALTER PROCEDURE WEST_WORLD.ClienteViewOrSearch
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(15)
AS
	SELECT *
	FROM WEST_WORLD.Cliente
	WHERE nombre LIKE @nombre + '%' 
			AND apellido LIKE @apellido + '%' 
			AND (@dni IS NULL OR (DNI = @dni))
    OPTION (RECOMPILE)
			
RETURN 0

GO

CREATE OR ALTER PROCEDURE WEST_WORLD.EmpresaCreateOrUpdate
@mode nvarchar(10),
@idEmpresa bigint,
@nombre nvarchar(255),
@cuit nvarchar(50),
@direccion nvarchar(255),
@idRubro bigint,
@habilitado bit

AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Empresa(
			nombre, 
			cuit, 
			direccion,
			idRubro, 
			habilitado
		)
		VALUES(
			@nombre,
			@cuit,
			@direccion,
			@idRubro,
			@habilitado
		)
	END
	ELSE IF @mode ='Edit'
	BEGIN
		UPDATE WEST_WORLD.Empresa
		SET nombre=@nombre, 
			cuit=@cuit,
			direccion=@direccion,
			idRubro=@idRubro,
			habilitado=@habilitado
		WHERE idEmpresa=@idEmpresa
	END

RETURN 0

GO

CREATE OR ALTER PROCEDURE WEST_WORLD.EmpresaViewOrSearch
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

CREATE OR ALTER PROCEDURE WEST_WORLD.FacturaAsignarPago
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
	@MES TINYINT

AS	
	IF @ESTADO = 'Sin Pago'
		SELECT numeroFactura as 'Num Fact', cliente as Cliente, empresa as Empresa, fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total' 
		FROM WEST_WORLD.Factura f JOIN WEST_WORLD.Empresa e ON (f.empresa = e.idEmpresa)
			WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
				AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
				AND (cliente = @IDCLIENTE)
				AND (pago IS NULL) AND (rendicion IS NULL)
				AND (e.habilitado = 1)
	ELSE IF @ESTADO = 'Con Pago Y Sin Rendicion'
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', rendicion as 'Rendicion', pago as 'Pago' FROM WEST_WORLD.Factura
			WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
				AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
				AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))
				AND (pago IS NOT NULL) AND (rendicion IS NULL)
				AND (@MES = 0 OR MONTH(fechaAlta) = @MES)
	ELSE 
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', rendicion as 'Rendicion', pago as 'Pago' FROM WEST_WORLD.Factura
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

CREATE OR ALTER PROCEDURE WEST_WORLD.GetFuncionalidades
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
		SELECT idItem, monto, cantidad, importe
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
	
	DECLARE @ID int
	SET @ID = (SELECT MAX(numeroRendicion) + 1 FROM WEST_WORLD.Rendicion)
	INSERT INTO WEST_WORLD.Rendicion(numeroRendicion, cantidadFacturas, empresa, FechaRendicion, importeNeto, importeTotal, porcentajeComision)
		VALUES(@ID, @CANT_FACTURAS, @IDEMPRESA, @FECHA_RENDICION, @IMPORTE_NETO, @IMPORTE_TOTAL, @PORCENTAJE_COMISION)

RETURN @ID

GO

CREATE PROCEDURE WEST_WORLD.SeleccionarCliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(15)
AS
	SELECT idCliente, nombre, apellido, DNI
	FROM WEST_WORLD.Cliente
	WHERE nombre LIKE @nombre + '%' 
			AND apellido LIKE @apellido + '%' 
			AND (@dni IS NULL OR (DNI = @dni))
    OPTION (RECOMPILE)
			
RETURN 0

GO

CREATE or ALTER   PROCEDURE WEST_WORLD.SucursalCreateOrUpdate
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
	SELECT *
	FROM WEST_WORLD.Sucursal
	WHERE nombre LIKE @nombre + '%' 
			 AND direccion LIKE @direccion + '%'
			 AND (@codigoPostal IS NULL OR (codigoPostal = @codigoPostal))
        OPTION (RECOMPILE)
RETURN 0