/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4206)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [GD2C2017]
GO
/****** Object:  StoredProcedure [WEST_WORLD].[AgregarRolAUsuario]    Script Date: 03/12/2017 23:57:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [WEST_WORLD].[AgregarRolAUsuario] 
@idUser BIGINT, 
@idRol BIGINT
as
BEGIN
INSERT INTO WEST_WORLD.Rol_Usuario (idRol,idUsuario)
VALUES(@idRol,@idUser)
END