CREATE PROCEDURE WEST_WORLD.ItemDelete
@NUMEROFACTURA bigint,
@IDITEM bigint

AS
	
	DELETE FROM WEST_WORLD.Item
	WHERE numeroFactura = @NUMEROFACTURA and idItem = @IDITEM

RETURN 0

