CREATE PROCEDURE WEST_WORLD.ClienteViewOrSearch
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(15)
AS
	SELECT idCliente, nombre as 'Nombre', apellido as 'Apellido', mail as 'Email', direccion as 'Direccion', codigoPostal as 'Codigo Postal',
		   DNI, telefono as 'Telefono', fecha_nac as 'Fecha de Nacimiento', habilitado as 'Habilitado'
	FROM WEST_WORLD.Cliente
	WHERE nombre LIKE @nombre + '%' 
			AND apellido LIKE @apellido + '%' 
			AND (@dni IS NULL OR (DNI = @dni))
    OPTION (RECOMPILE)
			
RETURN 0