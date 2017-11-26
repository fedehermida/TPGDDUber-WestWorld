CREATE PROCEDURE WEST_WORLD.ItemView
	@NUMEROFACTURA bigint

AS
	IF EXISTS (SELECT numeroFactura FROM WEST_WORLD.Factura WHERE numeroFactura = @NUMEROFACTURA)
		SELECT idItem, monto, cantidad, importe
		FROM WEST_WORLD.Item i
		WHERE numeroFactura = @NUMEROFACTURA

	ELSE 
		RAISERROR(N'No existe la factura %I64i', 15,2, @NUMEROFACTURA)

RETURN 0