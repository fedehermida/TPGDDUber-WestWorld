CREATE PROCEDURE WEST_WORLD.ActualizarRol 
@idRol BIGINT,
@nombre VARCHAR(50),
@habilitado BIT
as
UPDATE WEST_WORLD.Rol 
SET nombre=@nombre,
	habilitado=@habilitado
WHERE idRol=@idRol