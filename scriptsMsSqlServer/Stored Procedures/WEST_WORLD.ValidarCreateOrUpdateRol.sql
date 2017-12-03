--Busco si ya existe algun rol que tenga las mismas funcionalidades que mi rol. 
--Si encuentro alguno envio un mensaje de que ya existe un rol con las mismas funcionalidades
--Si no encuentra entonces se puede crear el rol

CREATE PROCEDURE WEST_WORLD.ValidarCreateOrUpdateRol
@idRol bigint

AS

BEGIN
	IF EXISTS (SELECT max(rol.nombre) from (SELECT r.idRol, r.nombre
	FROM WEST_WORLD.Rol_Funcionalidad rf JOIN WEST_WORLD.Rol r ON (rf.idRol = r.idRol)
	WHERE idFuncionalidad IN (SELECT idFuncionalidad
								FROM WEST_WORLD.Rol_Funcionalidad
								WHERE idRol = @idRol) 
							AND rf.idRol != @idRol
	INTERSECT
	SELECT r.idRol, r.nombre
	FROM WEST_WORLD.Rol_Funcionalidad rf JOIN WEST_WORLD.Rol r ON (rf.idRol = r.idRol)
	GROUP BY r.idRol, r.nombre
	HAVING count(idFuncionalidad) = (
									SELECT count(idFuncionalidad)
									FROM WEST_WORLD.Rol_Funcionalidad 
									WHERE idRol = @idRol
									)
	) rol )

	BEGIN
		DELETE FROM WEST_WORLD.Rol WHERE idRol = @idRol
		RAISERROR('Ya existe un rol con las mismas funcionalidades', 16, 2)
	END
END