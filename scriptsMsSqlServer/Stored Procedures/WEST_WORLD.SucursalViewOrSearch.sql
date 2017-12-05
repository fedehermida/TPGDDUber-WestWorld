CREATE PROCEDURE WEST_WORLD.SucursalViewOrSearch
	@nombre nvarchar(50),
	@direccion nvarchar(50),
	@codigoPostal nvarchar(50)
AS
	SELECT idSucursal, nombre as 'Nombre', direccion as 'Direccion', codigoPostal as 'Codigo Postal', habilitado as 'Habilitado'
	FROM WEST_WORLD.Sucursal
	WHERE nombre LIKE @nombre + '%' 
			 AND direccion LIKE @direccion + '%'
			 AND (@codigoPostal IS NULL OR (codigoPostal = @codigoPostal))
        OPTION (RECOMPILE)
RETURN 0