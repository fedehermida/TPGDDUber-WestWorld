CREATE PROCEDURE WEST_WORLD.BuscarRoles 
@Nombre VARCHAR(50),
@IdFuncionalidad BIGINT
as
SELECT r.idRol,r.nombre FROM WEST_WORLD.Rol r INNER JOIN WEST_WORLD.Rol_Funcionalidad rf ON
		r.idRol=rf.idRol
WHERE (Nombre LIKE @Nombre or @Nombre IS NULL)  And (idFuncionalidad= @IdFuncionalidad or @IdFuncionalidad IS NULL)
	 