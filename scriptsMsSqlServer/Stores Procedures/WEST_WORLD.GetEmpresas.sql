CREATE PROCEDURE WEST_WORLD.GetEmpresas
AS
	BEGIN 
		SELECT cuit, nombre
		FROM WEST_WORLD.Empresa
	END