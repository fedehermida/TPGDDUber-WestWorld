CREATE PROCEDURE WEST_WORLD.RendicionCreate
@FECHA_RENDICION datetime,
@IDEMPRESA bigint,
@CANT_FACTURAS smallint,
@IMPORTE_NETO numeric(15,2),
@IMPORTE_TOTAL numeric(15,2),
@PORCENTAJE_COMISION nvarchar(50)

AS
	
	DECLARE @ID int
	SET @ID = (SELECT MAX(numeroRendicion) + 1 FROM WEST_WORLD.Rendicion)
	INSERT INTO WEST_WORLD.Rendicion(numeroRendicion, cantidadFacturas, empresa, FechaRendicion, importeNeto, importeTotal, porcentajeComision)
		VALUES(@ID, @CANT_FACTURAS, @IDEMPRESA, @FECHA_RENDICION, @IMPORTE_NETO, @IMPORTE_TOTAL, @PORCENTAJE_COMISION)

RETURN @ID