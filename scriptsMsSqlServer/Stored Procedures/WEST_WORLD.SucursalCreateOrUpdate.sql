
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
