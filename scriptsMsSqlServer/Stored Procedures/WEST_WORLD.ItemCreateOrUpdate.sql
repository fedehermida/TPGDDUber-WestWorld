CREATE PROCEDURE WEST_WORLD.ItemCreateOrUpdate
	@MODE nvarchar(10),
	@IDITEM bigint,
	@NUMEROFACTURA bigint,
	@MONTO numeric(15,2),
	@CANTIDAD smallint

AS
	
	IF @mode='Add'
		BEGIN
			IF EXISTS (SELECT * FROM WEST_WORLD.Item 
					   WHERE numeroFactura = @NUMEROFACTURA AND monto = @MONTO 
							 AND cantidad = @CANTIDAD)				
				RAISERROR(N'Ya existe el item ingresado para la factura %I64i', 15,2, @NUMEROFACTURA)
			ELSE IF NOT EXISTS (SELECT * FROM WEST_WORLD.Factura WHERE numeroFactura = @NUMEROFACTURA)
				RAISERROR(N'No existe la factura %I64i por lo que no se agregó el item', 15, 2, @NUMEROFACTURA)
			ELSE
				INSERT INTO WEST_WORLD.Item(numeroFactura, cantidad, monto, importe)
				VALUES(@NUMEROFACTURA, @CANTIDAD, @MONTO, @CANTIDAD*@MONTO)

				OPTION (RECOMPILE)
		END
	
	ELSE IF @mode ='Edit'
		BEGIN

			UPDATE WEST_WORLD.Item
			SET numeroFactura = @NUMEROFACTURA,
				monto=@MONTO, 
				cantidad=@CANTIDAD,
				importe=@MONTO*@CANTIDAD
			WHERE idItem = @IDITEM
		END
