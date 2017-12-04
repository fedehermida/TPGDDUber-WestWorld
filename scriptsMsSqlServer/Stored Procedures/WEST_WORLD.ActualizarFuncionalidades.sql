CREATE PROCEDURE WEST_WORLD.ActualizarFuncionalidades
@idRol BIGINT 
as
DELETE FROM WEST_WORLD.Rol_Funcionalidad
WHERE idRol=@idRol