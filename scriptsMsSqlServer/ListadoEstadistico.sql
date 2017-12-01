/* Punto 11 
Listado Estadístico
Esta funcionalidad nos debe permitir consultar el TOP 5 de:
 Porcentaje de facturas cobradas por empresa.
 Empresas con mayor monto rendido.
 Clientes con mas pagos
 Clientes con mayor porcentaje de facturas pagadas (clientes
cumplidores).
Dichas consultas son a nivel trimestral, para lo cual la pantalla debe permitirnos
selección el trimestre a consultar.
El listado se debe ordenar en forma descendente según sea el campo principal de
la consulta.
Además de ingresar el año a consultar, el sistema nos debe permitir seleccionar
que tipo de listado se quiere visualizar.
12
Cabe aclarar que los campos a visualizar en la tabla del listado para las 3 consultas
no son los mismo, y al momento de seleccionar un tipo solo deben visualizarse las
columnas pertinentes al tipo de listado elegido.
Las columnas del listado para cada una de las consultas quedan a cargo del
alumno y dichas columnas deben ser lo suficientemente descriptivas para poder brindar
un informe detallado a la gerencia de la tropa.
*/

CREATE PROCEDURE WEST_WORLD.FacturasCobradasPorEmpresa
@trimestre INT, @ANIO INT
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

SELECT TOP 5 empresa 'Empresa', E.nombre 'Nombre', count(pago) 'Cantidad de Facturas Pagadas', count(numeroFactura) 'Cantidad de facturas totales', CAST(COUNT(pago) AS numeric(12,2))/CAST(COUNT(numeroFactura) AS numeric(12,2)) * 100 as 'Porcentaje de facturas cobradas'
FROM WEST_WORLD.Factura F
JOIN WEST_WORLD.Pago P ON (F.pago = P.numeroPago)
JOIN WEST_WORLD.Empresa E ON (F.empresa = E.idEmpresa)
WHERE	DATEPART(YEAR, P.FechaCobro) = @ANIO AND
		DATEPART(MONTH, P.FechaCobro) BETWEEN @MESDESDE AND @MESHASTA  
GROUP BY empresa, E.nombre
ORDER BY 5 DESC

END



CREATE PROCEDURE WEST_WORLD.EmpresasConMayorMontoRendido
@trimestre int, @anio int
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

SELECT TOP 5 empresa 'Empresa', e.nombre 'Nombre', SUM(importeNeto) AS 'Cantidad Rendida'
FROM WEST_WORLD.Rendicion r
JOIN WEST_WORLD.Empresa e ON (e.idEmpresa = r.empresa)
WHERE	DATEPART(YEAR, FechaRendicion) = @ANIO AND
		DATEPART(MONTH, FechaRendicion) BETWEEN @MESDESDE AND @MESHASTA  
GROUP BY empresa, e.nombre
ORDER BY 3
end


--execute empresasConMayorMontoRendido 2, 2017

CREATE PROCEDURE WEST_WORLD.ClientesConMasPagos
@trimestre INT, @ANIO INT
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

SELECT TOP 5 C.idCliente, C.nombre, c.apellido, C.DNI, COUNT(numeroPago) AS 'Cantidad de Pagos'
FROM WEST_WORLD.Pago P
JOIN WEST_WORLD.Cliente C on (C.idCliente = P.cliente)
WHERE DATEPART(YEAR, FechaCobro) = @ANIO AND
		DATEPART(MONTH, FechaCobro) BETWEEN @MESDESDE AND @MESHASTA

GROUP BY C.idCliente, C.nombre, c.apellido, C.DNI
ORDER BY 5 DESC

END

--EXECUTE ClientesConMasPagos 2, 2017

CREATE PROCEDURE WEST_WORLD.ClientesCumplidores
@trimestre INT, @ANIO INT
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


SELECT TOP 5 f.cliente, C.nombre, C.apellido, C.DNI, CAST(COUNT(pago) AS decimal(12,2))/CAST(COUNT(numeroFactura) AS decimal(12,2)) * 100 as PorcentajeDeFacturasCobradas
FROM WEST_WORLD.Factura F
JOIN WEST_WORLD.Cliente C on (C.idCliente = F.cliente)
JOIN WEST_WORLD.Pago P ON (F.pago = P.numeroPago)
WHERE DATEPART(YEAR, P.FechaCobro) = @ANIO AND
		DATEPART(MONTH, P.FechaCobro) BETWEEN @MESDESDE AND @MESHASTA
group by f.cliente, C.nombre, C.apellido, C.DNI
ORDER BY 5 DESC

END



