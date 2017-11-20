CREATE PROCEDURE WEST_WORLD.FacturaViewOrSearch
	@ESTADO nvarchar(30),
	@NUMEROFACTURA BIGINT,
	@IDEMPRESA BIGINT,
	@IDCLIENTE BIGINT

AS	
	IF @ESTADO = 'Sin Pago'
		SELECT numeroFactura as 'Num Fact', empresa as Empresa, fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total' FROM WEST_WORLD.Factura
			WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
				AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
				AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))
				AND (pago IS NULL) AND (rendicion IS NULL)
	ELSE IF @ESTADO = 'Con Pago Y Sin Rendicion'
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', rendicion as 'Rendicion', pago as 'Pago' FROM WEST_WORLD.Factura
			WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
				AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
				AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))
				AND (pago IS NOT NULL) AND (rendicion IS NULL)
	ELSE 
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', rendicion as 'Rendicion', pago as 'Pago' FROM WEST_WORLD.Factura
			WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
				AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
				AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))	
    
	OPTION (RECOMPILE)
RETURN 0