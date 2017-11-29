ALTER PROCEDURE WEST_WORLD.FuncionalidadesRol 
@idRol BIGINT
as
SELECT f.nombre FROM  WEST_WORLD.Rol r 
JOIN WEST_WORLD.Rol_Funcionalidad rf ON (@idRol=rf.idRol)
JOIN WEST_WORLD.Funcionalidad f ON (rf.idFuncionalidad=f.idFuncionalidad)

