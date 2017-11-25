SELECT FPE.empresa, FPE.FacturasPagadas / FT.FacturasTotales * 100 as PorcentajeEmpresa
FROM (  SELECT e.empresa, COUNT(e.pago) as FacturasPagadas
		FROM WEST_WORLD.FACTURA e
		JOIN WEST_WORLD.Pago p ON (e.pago = p.numeroPago)
		WHERE YEAR(p.fechaCobro) = 2016 AND 
		MONTH(p.FechaCobro) BETWEEN 7 AND (7 + 3)
		GROUP BY e.empresa) as FPE
JOIN (	SELECT e.empresa, COUNT(numeroFactura) as FacturasTotales
		FROM WEST_WORLD.FACTURA e
		JOIN WEST_WORLD.Pago p ON (e.pago = p.numeroPago)
		WHERE YEAR(p.fechaCobro) = 2016 AND 
		MONTH(p.FechaCobro) BETWEEN 7 AND (7 + 3)		
		GROUP BY e.empresa) as FT ON (FPE.empresa = FT.empresa)


CREATE PROCEDURE porcentajeFacturasPorEmpresa
@unTrimestre int, @anio int
AS
BEGIN


SELECT FPE.empresa, FPE.FacturasPagadas / FT.FacturasTotales * 100 as PorcentajeEmpresa
FROM (  SELECT e.empresa, COUNT(e.pago) as FacturasPagadas
		FROM WEST_WORLD.FACTURA e
		JOIN WEST_WORLD.Pago p ON (e.pago = p.numeroPago)
		WHERE YEAR(p.fechaCobro) = @anio AND 
		MONTH(p.FechaCobro) BETWEEN @unTrimestre AND (@unTrimestre + 3)
		GROUP BY e.empresa) as FPE
JOIN (	SELECT e.empresa, COUNT(numeroFactura) as FacturasTotales
		FROM WEST_WORLD.FACTURA e
		JOIN WEST_WORLD.Pago p ON (e.pago = p.numeroPago)
		WHERE YEAR(p.fechaCobro) = @anio AND 
		MONTH(p.FechaCobro) BETWEEN @unTrimestre AND (@unTrimestre + 3)		
		GROUP BY e.empresa) as FT ON (FPE.empresa = FT.empresa)

END

DROP PROCEDURE porcentajeFacturasPorEmpresa

execute porcentajeFacturasPorEmpresa 8, 2016


SELECT *
FROM WEST_WORLD.FACTURA
