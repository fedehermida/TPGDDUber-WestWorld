CREATE PROCEDURE WEST_WORLD.FacturasCobradasPorEmpresa
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

	SELECT TOP 5 empresa 'idEmpresa', E.nombre 'Nombre', count(pago) 'Cantidad de Facturas Pagadas', count(numeroFactura) 'Cantidad de facturas totales', ROUND(ROUND(COUNT(pago), 2)/ROUND(COUNT(numeroFactura) ,2) * 100 , 2) as 'Porcentaje de facturas cobradas'
	FROM WEST_WORLD.Factura F
	JOIN WEST_WORLD.Pago P ON (F.pago = P.numeroPago)
	JOIN WEST_WORLD.Empresa E ON (F.empresa = E.idEmpresa)
	WHERE	DATEPART(YEAR, P.FechaCobro) = @anio AND
			DATEPART(MONTH, P.FechaCobro) BETWEEN @MESDESDE AND @MESHASTA  
	GROUP BY empresa, E.nombre
	ORDER BY 5 DESC

END

