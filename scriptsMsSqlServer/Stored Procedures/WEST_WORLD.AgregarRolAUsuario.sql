CREATE PROCEDURE [WEST_WORLD].[AgregarRolAUsuario] 
@idUser BIGINT, 
@idRol BIGINT
as
BEGIN
	INSERT INTO WEST_WORLD.Rol_Usuario (idRol,idUsuario)
	VALUES(@idRol,@idUser)
END