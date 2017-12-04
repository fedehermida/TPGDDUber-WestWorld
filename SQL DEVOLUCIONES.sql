
/*

10. Devoluciones
Funcionalidad que permite a los administradores realizar devoluciones sobre las
facturas cobradas a los clientes, siempre y cuando estas no hayan sido rendidas.
Las facturas seleccionadas para realizar la devolución puede ser cobradas
nuevamente. La razón por la cual se desarrolla esta funcionalidad puede ser por errores
de cobro o simplemente que el cliente decida retrotraer el pago efectuado.
Para ambos casos debe quedar registrado el motivo de la devolución.

(La devolucion es solo de facturas pagadas. Solo los cobradores pueden devolver facturas pagadas.)

*/
GO

CREATE TABLE WEST_WORLD.Devolucion (
	numeroDevolucion INT IDENTITY(1,1) PRIMARY KEY,
	fechaDevolucion DATE DEFAULT getdate(),
	factura INT NOT NULL,
	pago INT NOT NULL,
	cliente INT NOT NULL,
	importe decimal(15,2),
	motivo VARCHAR(255)
	)

GO

CREATE PROCEDURE WEST_WORLD.DevolucionDeFactura
@numeroFactura int, @motivo VARCHAR(255)
AS
BEGIN

	DECLARE @pago int, @numeroCliente int, @importe decimal(10,2), @rendicion INT

	SELECT @pago = pago, @numeroCliente = cliente, @importe = total, @rendicion = rendicion
	FROM WEST_WORLD.Factura
	WHERE numeroFactura = @numeroFactura

	IF(@rendicion IS NULL AND @pago IS NOT NULL)
	BEGIN
		INSERT INTO WEST_WORLD.Devolucion(factura, pago, cliente, importe, motivo)
		VALUES (@numeroFactura, @pago, @numeroCliente, @importe, @motivo)

		UPDATE WEST_WORLD.Factura
		SET pago = NULL
		WHERE numeroFactura = @numeroFactura

		--DELETE FROM WEST_WORLD.Pago
		--WHERE numeroPago = @pago
	END

	ELSE IF(@rendicion IS NOT NULL AND @pago IS NOT NULL)
	BEGIN 
		RAISERROR('Esta factura ya fue rendida y no puede ser devuelta', 12, 2)
	END

	ELSE 
	BEGIN
		RAISERROR('Esta factura no fue pagada aun', 12, 2)
	END
END

GO