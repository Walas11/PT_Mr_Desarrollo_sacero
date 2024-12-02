# PT_Mr_Desarrollo_sacero

Manual

Para correr el proyecto unicamente se debe descragar los nugetsque se muestran acontinuación:


-- ----------------------------- --
-- Paquetes de nuget a descargar --
-- ----------------------------- --

1. EntityFramework.Core
2. EntityFrameworkCore.SQLServer

Para la creación de la Base de Datos es la siguiente

-- --------------------------------- --
-- Parte de Base de Datos SQL SERVER --
-- --------------------------------- --

use DB_PT_Mr_Desarrollo_sacero

create table Usuario (
ID int primary key identity (1,1),
NombreCompleto nVarchar(100) not null,
TipoDocumento nvarchar(50) not null,
Documento int not null,
FechaNacimiento DateTime not null,
ValorGanar money null,
EstadoCivil nvarchar(50) null
)

USE [DB_PT_Mr_Desarrollo_sacero]
GO

INSERT INTO [dbo].[Usuario]
           ([NombreCompleto]
           ,[TipoDocumento]
           ,[Documento]
           ,[FechaNacimiento]
           ,[ValorGanar]
           ,[EstadoCivil])
     VALUES
           ('Sebastian Acero León'
           ,'C.C'
           ,1014304449
           ,'1999/03/28'
           ,7000000
           ,'Soltero')
GO

select * from Usuario
