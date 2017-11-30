CREATE PROCEDURE WEST_WORLD.EmpresaViewOrSearch
	@nombre nvarchar(255),
	@cuit nvarchar(50),
	@idRubro bigint
AS
	SELECT idEmpresa, cuit 'Cuit', nombre 'Nombre', direccion 'Direccion', idRubro, habilitado 'Habilitado', diaRendicion 'Día de Rendición'
	FROM WEST_WORLD.Empresa
	WHERE nombre LIKE @nombre + '%' 
			 AND (@cuit IS NULL OR cuit LIKE @cuit)
			 AND (@idRubro IS NULL OR (idRubro = @idRubro))
        OPTION (RECOMPILE)
RETURN 0