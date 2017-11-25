ALTER PROCEDURE WEST_WORLD.CreateOrUpdateRol 
@nombre VARCHAR(50)
as
INSERT INTO WEST_WORLD.Rol(nombre,habilitado) values(@nombre,1)
RETURN Scope_identity()