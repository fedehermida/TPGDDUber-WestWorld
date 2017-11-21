CREATE PROCEDURE WEST_WORLD.AgregarFuncionalidad 
@IdRol BIGINT,
@IdFuncionalidad BIGINT
as
INSERT INTO WEST_WORLD.Rol_Funcionalidad(idRol,idFuncionalidad) values(@IdRol,@IdFuncionalidad)