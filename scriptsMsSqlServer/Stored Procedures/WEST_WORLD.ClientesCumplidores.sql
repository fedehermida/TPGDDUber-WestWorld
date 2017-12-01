CREATE PROCEDURE WEST_WORLD.ClientesCumplidores
@trimestre INT, @anio INT
AS
BEGIN
	DECLARE @MESDESDE INT, @MESHASTA INT

	SET @MESDESDE = CASE @trimestre  
	  WHEN 1 THEN 1 
	  WHEN 2 THEN 4 
	  WHEN 3 THEN 7 
	  WHEN 4 THEN 10  
	END

	SET @MESHASTA = @MESDESDE + 2


	SELECT TOP 5 f.cliente 'idCliente', C.nombre 'Nombre', C.apellido 'Apellido', C.DNI, C.mail, ROUND(ROUND(COUNT(pago) ,2)/ROUND(COUNT(numeroFactura) ,2) * 100, 2) as 'Porcentaje De Facturas Cobradas'
	FROM WEST_WORLD.Factura F
	JOIN WEST_WORLD.Cliente C on (C.idCliente = F.cliente)
	JOIN WEST_WORLD.Pago P ON (F.pago = P.numeroPago)
	WHERE DATEPART(YEAR, P.FechaCobro) = @anio AND
		  DATEPART(MONTH, P.FechaCobro) BETWEEN @MESDESDE AND @MESHASTA
	GROUP BY f.cliente, C.nombre, C.apellido, C.DNI, c.mail
	ORDER BY 6 DESC

END