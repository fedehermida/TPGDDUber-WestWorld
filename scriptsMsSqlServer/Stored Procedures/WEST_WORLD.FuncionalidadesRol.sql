CREATE PROCEDURE WEST_WORLD.FuncionalidadesRol 
@idRol BIGINT

AS
BEGIN
	SELECT f.nombre,f.idFuncionalidad 
	FROM WEST_WORLD.Rol_Funcionalidad rf
	JOIN WEST_WORLD.Funcionalidad f ON (rf.idFuncionalidad=f.idFuncionalidad)
	WHERE rf.idRol = @idRol
END