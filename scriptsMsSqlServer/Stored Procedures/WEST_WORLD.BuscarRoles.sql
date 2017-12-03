CREATE PROCEDURE WEST_WORLD.BuscarRoles
@Nombre VARCHAR(50)

AS

BEGIN
	SELECT idRol, nombre as 'Nombre', habilitado as 'Habilitado'
	FROM WEST_WORLD.Rol
	WHERE (@Nombre IS NULL OR nombre LIKE CONCAT(@Nombre, '%'))
END
		
