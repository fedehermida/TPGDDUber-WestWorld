CREATE PROCEDURE WEST_WORLD.SeleccionarCliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(15)
AS
	SELECT idCliente, nombre as 'Nombre', apellido as 'Apellido', DNI
	FROM WEST_WORLD.Cliente
	WHERE nombre LIKE @nombre + '%' 
			AND apellido LIKE @apellido + '%' 
			AND (@dni IS NULL OR (DNI = @dni))
    OPTION (RECOMPILE)
			
RETURN 0