USE GD2C2017
GO

IF OBJECT_ID('WEST_WORLD.ActualizarFuncionalidades') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ActualizarFuncionalidades 

GO
CREATE PROCEDURE WEST_WORLD.ActualizarFuncionalidades
@idRol BIGINT as
DELETE FROM WEST_WORLD.Rol_Funcionalidad
WHERE idRol=@idRol

GO

IF OBJECT_ID('WEST_WORLD.AgregarFuncionalidad') IS NOT NULL
DROP PROCEDURE WEST_WORLD.AgregarFuncionalidad 

GO

CREATE PROCEDURE WEST_WORLD.AgregarFuncionalidad 
@IdRol BIGINT,
@IdFuncionalidad BIGINT
as
BEGIN
    INSERT INTO WEST_WORLD.Rol_Funcionalidad(idRol,idFuncionalidad) values(@IdRol,@IdFuncionalidad)
END

GO

IF OBJECT_ID('WEST_WORLD.AgregarRolAUsuario') IS NOT NULL
DROP PROCEDURE WEST_WORLD.AgregarRolAUsuario 

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

IF OBJECT_ID('WEST_WORLD.BuscarRoles') IS NOT NULL
DROP PROCEDURE WEST_WORLD.BuscarRoles 

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

IF OBJECT_ID('WEST_WORLD.CreateRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.CreateRol 

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

IF OBJECT_ID('WEST_WORLD.FuncionalidadesRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FuncionalidadesRol 

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

IF OBJECT_ID('WEST_WORLD.ActualizarRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ActualizarRol

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

IF OBJECT_ID('WEST_WORLD.ClienteCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClienteCreateOrUpdate

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

IF OBJECT_ID('WEST_WORLD.ClienteViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClienteViewOrSearch

GO

CREATE PROCEDURE WEST_WORLD.ClienteViewOrSearch
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

IF OBJECT_ID('WEST_WORLD.EmpresaCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.EmpresaCreateOrUpdate

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
					RAISERROR('No es posible darle de baja a una empresa con 1 o más facturas sin rendir', 16, 1)
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

IF OBJECT_ID('WEST_WORLD.EmpresaViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.EmpresaViewOrSearch 

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

IF OBJECT_ID('WEST_WORLD.FacturaAsignarPago') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaAsignarPago 

GO

CREATE PROCEDURE WEST_WORLD.FacturaAsignarPago
	@NUMFACTURA bigint,
	@PAGO bigint

AS

	UPDATE WEST_WORLD.Factura
	SET pago = @PAGO
	WHERE numeroFactura = @NUMFACTURA;

GO

IF OBJECT_ID('WEST_WORLD.FacturaAsignarRendicion') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaAsignarRendicion 

GO

CREATE PROCEDURE WEST_WORLD.FacturaAsignarRendicion
	@NUMFACTURA bigint,
	@RENDICION bigint
AS

	UPDATE WEST_WORLD.Factura
	SET rendicion = @RENDICION
	WHERE numeroFactura = @NUMFACTURA

GO

IF OBJECT_ID('WEST_WORLD.FacturaCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaCreateOrUpdate 

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

IF OBJECT_ID('WEST_WORLD.FacturaDelete') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaDelete 

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

IF OBJECT_ID('WEST_WORLD.FacturaImporteUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaImporteUpdate 

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

IF OBJECT_ID('WEST_WORLD.FacturaViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturaViewOrSearch 

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

IF OBJECT_ID('WEST_WORLD.GetEmpresas') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetEmpresas 

GO

CREATE PROCEDURE WEST_WORLD.GetEmpresas
AS
	BEGIN 
		SELECT idEmpresa, nombre
		FROM WEST_WORLD.Empresa
	END


GO 

IF OBJECT_ID('WEST_WORLD.GetFormasDePago') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetFormasDePago 

GO

CREATE PROCEDURE WEST_WORLD.GetFormasDePago
AS
	BEGIN 
		SELECT *
		FROM WEST_WORLD.FormaPago
	END

GO

IF OBJECT_ID('WEST_WORLD.GetFuncionalidades') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetFuncionalidades 

GO

CREATE PROCEDURE WEST_WORLD.GetFuncionalidades
as
SELECT * FROM WEST_WORLD.Funcionalidad 


GO

IF OBJECT_ID('WEST_WORLD.GetRubros') IS NOT NULL
DROP PROCEDURE WEST_WORLD.GetRubros 

GO

CREATE PROCEDURE WEST_WORLD.GetRubros
AS
	BEGIN 
		SELECT idRubro, nombre
		FROM WEST_WORLD.Rubro
	END


GO

IF OBJECT_ID('WEST_WORLD.ItemCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ItemCreateOrUpdate 

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

IF OBJECT_ID('WEST_WORLD.ItemDelete') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ItemDelete

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

IF OBJECT_ID('WEST_WORLD.ItemView') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ItemView

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

IF OBJECT_ID('WEST_WORLD.PagoCreate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.PagoCreate

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

IF OBJECT_ID('WEST_WORLD.RendicionCreate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.RendicionCreate

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

IF OBJECT_ID('WEST_WORLD.SeleccionarCliente') IS NOT NULL
DROP PROCEDURE WEST_WORLD.SeleccionarCliente

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

IF OBJECT_ID('WEST_WORLD.SucursalCreateOrUpdate') IS NOT NULL
DROP PROCEDURE WEST_WORLD.SucursalCreateOrUpdate

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

IF OBJECT_ID('WEST_WORLD.SucursalViewOrSearch') IS NOT NULL
DROP PROCEDURE WEST_WORLD.SucursalViewOrSearch

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

GO

IF OBJECT_ID('WEST_WORLD.ClientesConMasPagos') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClientesConMasPagos

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

IF OBJECT_ID('WEST_WORLD.ClientesCumplidores') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ClientesCumplidores

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

IF OBJECT_ID('WEST_WORLD.EmpresasConMayorMontoRendido') IS NOT NULL
DROP PROCEDURE WEST_WORLD.EmpresasConMayorMontoRendido

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

IF OBJECT_ID('WEST_WORLD.FacturasCobradasPorEmpresa') IS NOT NULL
DROP PROCEDURE WEST_WORLD.FacturasCobradasPorEmpresa

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

	SELECT TOP 5 empresa 'idEmpresa', E.nombre 'Nombre', count(pago) 'Cantidad de Facturas Pagadas', count(numeroFactura) 'Cantidad de facturas totales', ROUND(ROUND(COUNT(pago), 2)/ROUND(COUNT(numeroFactura) ,2) * 100 , 2) as 'Porcentaje de facturas cobradas'
	FROM WEST_WORLD.Factura F
	JOIN WEST_WORLD.Pago P ON (F.pago = P.numeroPago)
	JOIN WEST_WORLD.Empresa E ON (F.empresa = E.idEmpresa)
	WHERE	DATEPART(YEAR, P.FechaCobro) = @anio AND
			DATEPART(MONTH, P.FechaCobro) BETWEEN @MESDESDE AND @MESHASTA  
	GROUP BY empresa, E.nombre
	ORDER BY 5 DESC

END

GO

IF OBJECT_ID('WEST_WORLD.ValidarCreateOrUpdateRol') IS NOT NULL
DROP PROCEDURE WEST_WORLD.ValidarCreateOrUpdateRol

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

IF OBJECT_ID('WEST_WORLD.DevolucionDeFactura') IS NOT NULL
DROP PROCEDURE WEST_WORLD.DevolucionDeFactura

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

		--DELETE FROM WEST_WORLD.Pago
		--WHERE numeroPago = @pago
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

