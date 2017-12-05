
CREATE PROCEDURE WEST_WORLD.FacturaViewOrSearch
	@ESTADO nvarchar(30),
	@NUMEROFACTURA BIGINT,
	@IDEMPRESA BIGINT,
	@IDCLIENTE BIGINT,
	@MES TINYINT,
	@ANIO INT
AS	
	IF @ESTADO = 'Sin Pago'
		IF EXISTS (SELECT 1 FROM WEST_WORLD.Cliente WHERE idCliente = @IDCLIENTE AND habilitado = 0)
			RAISERROR('El cliente seleccionado se encuentra inactivo, por lo cual no puede pagar facturas', 16,2)
		ELSE
			SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', fechaVencimiento as 'Fecha Venc', total as 'Total' 
			FROM WEST_WORLD.Factura f JOIN WEST_WORLD.Empresa e ON (f.empresa = e.idEmpresa)
				WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
					AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
					AND (cliente = @IDCLIENTE)
					AND (pago IS NULL) AND (rendicion IS NULL)
					AND (e.habilitado = 1)
					AND (f.fechaVencimiento <= SYSDATETIME())
	ELSE IF @ESTADO = 'Con Pago Y Sin Rendicion'
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', pago as 'Pago' 
		FROM WEST_WORLD.Factura f JOIN WEST_WORLD.Empresa e ON (f.empresa = e.idEmpresa)
		WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
			AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
			AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))
			AND (pago IS NOT NULL) AND (rendicion IS NULL)
			AND (e.habilitado = 1)
			AND (@MES = 0 OR MONTH(fechaAlta) = @MES)
			AND (@ANIO = 0 OR YEAR(fechaAlta) = @ANIO)
	ELSE 
		SELECT numeroFactura as 'Num Fact', cliente as 'Cliente', empresa as 'Empresa', fechaAlta as 'Fecha Alta', FechaVencimiento as 'Fecha Venc', total as 'Total', rendicion as 'Rendicion', pago as 'Pago' 
		FROM WEST_WORLD.Factura
			WHERE (@NUMEROFACTURA IS NULL OR (numeroFactura = @NUMEROFACTURA))
				AND (@IDEMPRESA IS NULL OR (empresa = @IDEMPRESA))
				AND (@IDCLIENTE IS NULL OR (cliente = @IDCLIENTE))	
    
	OPTION (RECOMPILE)
RETURN 0