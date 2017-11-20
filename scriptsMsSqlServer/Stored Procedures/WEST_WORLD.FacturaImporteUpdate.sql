CREATE PROCEDURE WEST_WORLD.FacturaImporteUpdate
	@NUMEROFACTURA bigint,
	@TOTAL numeric(15,2)

AS
	IF EXISTS (SELECT * FROM WEST_WORLD.Factura 
				WHERE numeroFactura = @NUMEROFACTURA)
		BEGIN
			UPDATE WEST_WORLD.Factura
			SET total=@TOTAL
			WHERE numeroFactura = @NUMEROFACTURA
		END
