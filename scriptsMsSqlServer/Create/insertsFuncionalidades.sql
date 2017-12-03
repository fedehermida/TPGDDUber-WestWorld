USE GD2C2017;
GO
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Empresa')
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Cliente');
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Sucursal');
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Rol');
INSERT INTO WEST_WORLD.Funcionalidad values ('ABM Factura');
INSERT INTO WEST_WORLD.Funcionalidad values ('Registro de Pago');
INSERT INTO WEST_WORLD.Funcionalidad values ('Rendición de Facturas');
INSERT INTO WEST_WORLD.Funcionalidad values ('Devoluciones');
GO
INSERT INTO WEST_WORLD.Rol values ('Administrador',1);
INSERT INTO WEST_WORLD.Rol values ('Cobrador',1);
GO
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (1,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (2,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (3,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (4,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (5,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (6,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (7,1);
INSERT INTO WEST_WORLD.Rol_Funcionalidad values (8,1);
GO
INSERT INTO WEST_WORLD.Usuario([user], pass, failedLogins)
						VALUES('admin', (SELECT HASHBYTES('SHA2_256', 'w23e')), 0)

INSERT INTO WEST_WORLD.Rol_Usuario VALUES (1,1);
GO
