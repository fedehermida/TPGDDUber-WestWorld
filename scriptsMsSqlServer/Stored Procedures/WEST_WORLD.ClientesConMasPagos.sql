CREATE PROCEDURE WEST_WORLD.ClientesConMasPagos
@trimestre INT, @anio INT
AS
BEGIN
	DECLARE @MESDESDE INT, @MESHASTA INT

	set @MESDESDE = case @trimestre  
	  WHEN 1 THEN 1 
	  WHEN 2 THEN 4 
	  WHEN 3 THEN 7 
	  WHEN 4 THEN 10  
	END

	set @MESHASTA = @MESDESDE + 2

	SELECT TOP 5 C.idCliente, C.nombre 'Nombre', c.apellido 'Apellido', C.DNI, COUNT(numeroPago) AS 'Cantidad de Pagos'
	FROM WEST_WORLD.Pago P
	JOIN WEST_WORLD.Cliente C on (C.idCliente = P.cliente)
	WHERE DATEPART(YEAR, FechaCobro) = @anio AND
			DATEPART(MONTH, FechaCobro) BETWEEN @MESDESDE AND @MESHASTA

	GROUP BY C.idCliente, C.nombre, c.apellido, C.DNI
	ORDER BY 5 DESC

END
