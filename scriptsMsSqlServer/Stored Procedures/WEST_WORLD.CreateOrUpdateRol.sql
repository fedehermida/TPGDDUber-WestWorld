CREATE PROCEDURE WEST_WORLD.CreateOrUpdateRol
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