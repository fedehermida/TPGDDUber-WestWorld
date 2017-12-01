CREATE PROCEDURE WEST_WORLD.EmpresasConMayorMontoRendido
@trimestre int, @anio int
AS
BEGIN

	DECLARE @MESDESDE INT, @MESHASTA INT

	SET @MESDESDE = CASE @trimestre  
	  WHEN 1 THEN 1 
	  WHEN 2 THEN 4 
	  WHEN 3 THEN 7 
	  WHEN 4 THEN 10  
	END

	set @MESHASTA = @MESDESDE + 2

	SELECT TOP 5 empresa 'idEmpresa',  e.nombre 'Nombre', e.cuit 'CUIT', SUM(importeNeto) AS 'Cantidad Rendida'
	FROM WEST_WORLD.Rendicion r
	JOIN WEST_WORLD.Empresa e ON (e.idEmpresa = r.empresa)
	WHERE DATEPART(YEAR, FechaRendicion) = @anio AND
		  DATEPART(MONTH, FechaRendicion) BETWEEN @MESDESDE AND @MESHASTA  
	GROUP BY empresa, e.nombre, e.cuit
	ORDER BY 4
END