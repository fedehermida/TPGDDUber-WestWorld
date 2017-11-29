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
/****** Object:  StoredProcedure [WEST_WORLD].[BuscarRoles]    Script Date: 29/11/2017 0:41:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [WEST_WORLD].[BuscarRoles] 
@Nombre VARCHAR(50)
as
SELECT * FROM WEST_WORLD.Rol
WHERE WEST_WORLD.Rol.nombre=@Nombre
		
