CREATE PROCEDURE WEST_WORLD.insertUsuarioAdmin
AS
BEGIN
    INSERT INTO WEST_WORLD.Usuario(
			[user], 
			pass,
            failedLogins 
		
		)
		VALUES(
			'admin',
		    (SELECT HASHBYTES('SHA2_256', 'w23e')),
			0
		)
	
END  




