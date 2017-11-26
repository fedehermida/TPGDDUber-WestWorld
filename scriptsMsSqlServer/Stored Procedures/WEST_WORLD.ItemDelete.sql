CREATE PROCEDURE WEST_WORLD.ItemDelete
@NUMEROFACTURA bigint,
@IDITEM bigint

AS
	IF((SELECT COUNT(idItem) FROM WEST_WORLD.Item WHERE numeroFactura = @NUMEROFACTURA) > 1)
		DELETE FROM WEST_WORLD.Item
		WHERE numeroFactura = @NUMEROFACTURA and idItem = @IDITEM
	ELSE
		RAISERROR('La factura no puede quedar sin items. Puede actualizar el seleccionado', 15, 2)
