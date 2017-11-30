CREATE PROCEDURE WEST_WORLD.EmpresaCreateOrUpdate
@mode nvarchar(10),
@idEmpresa bigint,
@nombre nvarchar(255),
@cuit nvarchar(50),
@direccion nvarchar(255),
@idRubro bigint,
@habilitado bit,
@diaRendicion tinyint

AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Empresa(nombre, cuit, direccion, idRubro, habilitado, diaRendicion)
		VALUES(@nombre, @cuit, @direccion, @idRubro, @habilitado, @diaRendicion)
	END
	ELSE IF @mode ='Edit'
	BEGIN
		UPDATE WEST_WORLD.Empresa
		SET nombre=@nombre, 
			cuit=@cuit,
			direccion=@direccion,
			idRubro=@idRubro,
			diaRendicion=@diaRendicion
		WHERE idEmpresa=@idEmpresa
		
		--Me fijo si la empresa a modificar esta activa y se quiere dar de baja
		IF (EXISTS (SELECT idEmpresa FROM WEST_WORLD.Empresa WHERE idEmpresa=@idEmpresa AND habilitado=1)  AND (@habilitado=0))	
			BEGIN
				--Veo si tiene alguna factura no rendida. Si estan todas rendidas se puede dar de baja
				IF EXISTS (SELECT numeroFactura FROM WEST_WORLD.Factura WHERE empresa = @idEmpresa AND rendicion IS NULL)
					RAISERROR('No es posible darle de baja a una empresa con 1 o más facturas sin rendir', 16, 1)
				ELSE 
					UPDATE WEST_WORLD.Empresa
					SET habilitado=@habilitado
					WHERE idEmpresa=@idEmpresa
			END
		ELSE
			UPDATE WEST_WORLD.Empresa
			SET habilitado=@habilitado
			WHERE idEmpresa=@idEmpresa

	END

RETURN 0