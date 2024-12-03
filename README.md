# PT_Mr_Desarrollo_sacero

Manual

El proyecto es un CRUD simple dividido en capas para mejorar la flexibilidad, mantebilidad, escalabilidad, Desarrollo más organizado / estructurado, desacoplamiento, integración con otros sistemas, Control de versiones, despliegues más fáciles y Desarrollo más organizado y estructurado.

Por esta parte se realizó una integración con EntityFramework para mayor facilidad de integración con el motor de base de datos sin embargo no es la unica manera, también puede realizarse un SP (stored Procedure) en el cual dependiendo de un valor ingresado realice una acción como consultar, eliminar, actualizar o crear. Por motivos de rapidez se precisa entity framework.

NOTA: LA PARTE DE BOOSTRAB NO LA ALCANCÉ A REALIZAR PERO SE ENCUENTRA EN EL PROYECTO. -Perdón si no puse como ID el documento en la tabla, el corre corre y el tiempo me hicieron pensar en una solución rapida 😥

-- ------------------------------------------------------------------------------------------ --
Para correr el proyecto unicamente se debe descragar los nugetsque se muestran acontinuación:
-- ------------------------------------------------------------------------------------------ --

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
