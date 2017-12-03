CREATE PROCEDURE WEST_WORLD.AgregarFuncionalidad 
@idRol BIGINT,
@idFuncionalidad BIGINT

AS
BEGIN
	INSERT INTO WEST_WORLD.Rol_Funcionalidad(idRol,idFuncionalidad) values(@idRol,@idFuncionalidad)
END