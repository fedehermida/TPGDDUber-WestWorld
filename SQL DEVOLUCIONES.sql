
/*

10. Devoluciones
Funcionalidad que permite a los administradores realizar devoluciones sobre las
facturas cobradas a los clientes, siempre y cuando estas no hayan sido rendidas.
Las facturas seleccionadas para realizar la devolución puede ser cobradas
nuevamente. La razón por la cual se desarrolla esta funcionalidad puede ser por errores
de cobro o simplemente que el cliente decida retrotraer el pago efectuado.
Para ambos caso debe quedar registrado el motivo de la devolución.
Los datos a ingresar dependerán si la devolución es del tipo rendición o factura.
Solo los administradores pueden devolver rendiciones y solo los cobradores
pueden devolver facturas pagadas.

*/

CREATE TABLE WEST_WORLD.Devoluciones (
	numeroDevolucion INT IDENTITY(1,1) PRIMARY KEY,
	FechaDevolucion DATE DEFAULT getdate(),
	idFactura INT NOT NULL,
	idPago INT NOT NULL,
	idCliente int,
	importe decimal(10,2),
	motivo VARCHAR(255)
	)

CREATE OR ALTER PROCEDURE DevolucionDeFactura 
@numeroFactura int, @motivo VARCHAR(255)
AS
BEGIN

DECLARE @numeroPago int, @numeroCliente int, @importe decimal(10,2), @rendicion INT

DECLARE pagosDevolver CURSOR FOR
SELECT pago, cliente, total, rendicion
FROM WEST_WORLD.Factura
WHERE numeroFactura = @numeroFactura

OPEN pagosDevolver
FETCH NEXT FROM pagosDevolver INTO @numeroPago, @numeroCliente, @importe, @rendicion

WHILE @@FETCH_STATUS = 0
BEGIN

IF(@rendicion IS NULL AND @numeroPago IS NOT NULL)
BEGIN
INSERT INTO WEST_WORLD.Devoluciones (idFactura, idPago, idCliente, importe, motivo)
VALUES (@numeroFactura, @numeroPago, @numeroCliente, @importe, @motivo)

UPDATE WEST_WORLD.Factura
SET pago = NULL
WHERE numeroFactura = @numeroFactura

DELETE FROM WEST_WORLD.Pago
WHERE numeroPago = @numeroPago

END
ELSE IF(@rendicion IS NOT NULL AND @numeroPago IS NOT NULL)
BEGIN 
RAISERROR('Esta factura ya fue rendida y no puede ser devuelta', 12, 2)
END
ELSE 
BEGIN
RAISERROR('Esta factura no fue pagada aun', 12, 2)
END
FETCH NEXT FROM pagosDevolver INTO @numeroPago, @numeroCliente, @importe

END

CLOSE pagosDevolver
DEALLOCATE pagosDevolver

END

