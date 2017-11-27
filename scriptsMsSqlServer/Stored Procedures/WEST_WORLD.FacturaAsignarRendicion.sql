CREATE PROCEDURE WEST_WORLD.FacturaAsignarRendicion
	@NUMFACTURA bigint,
	@RENDICION bigint
AS

	UPDATE WEST_WORLD.Factura
	SET rendicion = @RENDICION
	WHERE numeroFactura = @NUMFACTURA
