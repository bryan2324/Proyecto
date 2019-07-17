Create database Proyecto;

Use Proyecto;


--Tablas=======================================================================================================================================
Create table Perfil
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Cedula] [int] NULL unique,
	[ProfesionPrinc] [varchar](100) null,
	[CantidadTitulos]int,
	[ConocimientoAdic][varchar](100),
	[Telefono][int],
	[Mail] [varchar](100),
	[Fecha_Nacimiento] [Date] null,
	[Residencia] varchar(200),
	[Universidad] varchar(200),
	[AnoGraduacion] date,
	[AnoExperiencia] int,
	[CantidadEmpleos] int,
	[CantidadDespidos] int,
	[Idiomas] [varchar](20),
	[Pasaporte] [varchar](5),
	[IngresoSis] datetime
)
USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
Create table Concursos(
IdConcurso int  IDENTITY(1,1),
Empresa varchar(100),
Idiomas varchar(20),
Pasaporte varchar(5),
PuestoReq varchar(100),
AnoExperienciaReq int,
UniversidadProc varchar(25),
Edad int,
IngRequerida varchar(100),
FechaInicio datetime,
FechaFinalizacion datetime
)


-----------------------------------------------------------------------------
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------------------------
create table Usuario(
nombre varchar (20),
username varchar(20) primary key ,
pass varchar(10)
)
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Insert into Usuario(nombre,username,pass)Values('Administrador','admin','admin')

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Table RegistrosHistoricos(
IdHistorico int Identity(1,1),
CedulaPerfil int,
Nombre varchar (200),
IdPerfil int,
FechaRegistro datetime,

)
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------------------------------------------------------------------------


--Procedimientos Tabla Usuario=======================================================================================================================================
USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [insertarUsuario]
@nombre varchar(20),
@Username varchar(20),
@pass varchar(10)

AS
BEGIN
	
INSERT INTO Usuario(nombre,username,pass)
             VALUES(@nombre,@Username,@pass);

END

GO

USE [Proyecto]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

---------------

CREATE PROCEDURE [LoginInfo]

AS
BEGIN


    select * from [dbo].[Usuario]

END

GO
USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------------------------------------------------------------------------------







--Procedimientos Tabla Perfil====================================================================================================================================================================================

CREATE PROCEDURE [insertarPerfil]
	@Nombre varchar (20) ,
	@Cedula int  ,
	@ProfesionPrinc varchar (100),
	@CantidadTitulos int,
	@ConocimientoAdic varchar (100),
	@Telefono int ,
	@Mail  varchar (100),
	@Fecha_Nacimiento date,
	@Residencia  varchar(200),
	@Universidad  varchar(200),
	@AnoGraduacion  date,
	@AnoExperiencia  int,
	@CantidadEmpleos  int,
	@CantidadDespidos  int,
	@Idiomas varchar(20),
	@Pasaporte varchar(5)


AS
BEGIN
	
INSERT INTO Perfil(Nombre,Cedula,ProfesionPrinc,CantidadTitulos,ConocimientoAdic,Telefono,Mail,Fecha_Nacimiento
					,Residencia,Universidad,AnoGraduacion,AnoExperiencia,CantidadEmpleos,CantidadDespidos
					,Idiomas,Pasaporte,IngresoSis)
             VALUES(@Nombre,@Cedula,@ProfesionPrinc,@CantidadTitulos,@ConocimientoAdic,@Telefono,@Mail,
			 @Fecha_Nacimiento,@Residencia,@Universidad,@AnoGraduacion,@AnoExperiencia,@CantidadEmpleos,@CantidadDespidos,@Idiomas,
			 @Pasaporte,GETDATE());


END

GO
USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



------------------------------------------------------------------------------------------

CREATE PROCEDURE [ActualizarPerfil]
	
	@ID int,
	@Nombre varchar (20) ,
	@Cedula int  ,
	@ProfesionPrinc varchar (100),
	@CantidadTitulos int,
	@ConocimientoAdic varchar (100),
	@Telefono int ,
	@Mail  varchar (100),
	@Fecha_Nacimiento date ,
	@Residencia  varchar(200),
	@Universidad  varchar(200),
	@AnoGraduacion  date,
	@AnoExperiencia  int,
	@CantidadEmpleos  int,
	@CantidadDespidos  int,
	@Idiomas varchar(20),
	@Pasaporte varchar(5)
	

AS
BEGIN
	
UPDATE       Perfil
SET         Nombre=@Nombre ,
	Cedula=@Cedula,
	ProfesionPrinc=@ProfesionPrinc ,
	CantidadTitulos=@CantidadTitulos,
	ConocimientoAdic=@ConocimientoAdic,
	Telefono=@Telefono,
	Mail=@Mail,
	Fecha_Nacimiento=@Fecha_Nacimiento,
	Residencia=@Residencia,
	Universidad=@Universidad,
	AnoGraduacion=@AnoGraduacion,
	AnoExperiencia=@AnoExperiencia,
	CantidadEmpleos=@CantidadEmpleos,
	CantidadDespidos=@CantidadDespidos,
	Idiomas=@Idiomas,
	Pasaporte=@Pasaporte
	
WHERE        (ID = @ID);

END
GO
USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------------------------------------

CREATE PROCEDURE [disablePerfil]
@ID int

AS
BEGIN
	
Delete from   Perfil
WHERE        (ID = @ID);

END

GO

USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------------------------------------


CREATE PROCEDURE [MostrarPerfiles]

AS
BEGIN


    select * from [dbo].[Perfil]

END

GO

USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--Procedimiento tabla Concursos==========================================================================================



CREATE PROCEDURE [insertarConcurso]
@Empresa varchar(100),
@Idiomas varchar(20),
@Pasaporte varchar(5),
@PuestoReq varchar(100),
@AnoExperienciaReq int,
@UniversidadProc varchar(25),
@Edad int,
@IngRequerida varchar(100),
@FechaFinalizacion datetime


AS
BEGIN
	
INSERT INTO Concursos(Empresa,Idiomas,Pasaporte,PuestoReq,AnoExperienciaReq,UniversidadProc,Edad,IngRequerida,FechaInicio,FechaFinalizacion)
             VALUES(@Empresa,@Idiomas,@Pasaporte,@PuestoReq,@AnoExperienciaReq,@UniversidadProc,@Edad,@IngRequerida,Getdate(),@FechaFinalizacion);


END

GO

USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


------------------------------------------------------------------------------------------

CREATE PROCEDURE [ActualizarConcurso]
	
@IdConcurso int,
@Empresa varchar(100),
@Idiomas varchar(20),
@Pasaporte varchar(5),
@PuestoReq varchar(100),
@AnoExperienciaReq int,
@UniversidadProc varchar(25),
@Edad int,
@IngRequerida varchar(100),

@FechaFinalizacion datetime
	

AS
BEGIN
	
UPDATE       Concursos
SET         Empresa=@Empresa ,
	Idiomas=@Idiomas,
	Pasaporte=@Pasaporte ,
	PuestoReq=@PuestoReq,
	AnoExperienciaReq=@AnoExperienciaReq,
	UniversidadProc=@UniversidadProc,
	Edad=@Edad,
	IngRequerida=@IngRequerida,

	FechaFinalizacion=@FechaFinalizacion

	
WHERE        (IdConcurso = @IdConcurso);

END

GO

USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

------------------------------------------------------------------------------------------------

CREATE PROCEDURE [disableConcurso]
@IdConcurso int

AS
BEGIN
	
Delete from   Concursos
WHERE        (IdConcurso = @IdConcurso);

END

GO

USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------------------------------------------------


CREATE PROCEDURE [MostrarConcurso]

AS
BEGIN


    select * from [dbo].[Concursos]

END

GO
USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-------------------------------TRIGGER--REGISTROS/HISTORICOS-PERFIL--------------------------------------------------------
CREATE TRIGGER tr1 ON Perfil
AFTER Insert
AS
	declare @PCedula int;
	declare @Pid int;
	declare @PFechaIngreso datetime;
	declare @Pname varchar(200);
	

	select @PCedula=i.Cedula from inserted i;	
	select @PFechaIngreso=i.IngresoSis from inserted i;
	select @Pid=i.ID from inserted i;		
	select @Pname=i.Nombre from inserted i;
	

	insert into RegistrosHistoricos
(CedulaPerfil,FechaRegistro,IdPerfil,Nombre) 
	values(@PCedula,@PFechaIngreso,@Pid,@Pname);

	


GO
USE [Proyecto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO