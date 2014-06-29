USE [GD1C2014]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

if exists(select * from sys.objects where name ='SP_LOGIN' and type = 'P')
	drop procedure [C_R].[SP_LOGIN]
go

if exists(select * from sys.objects where name ='SP_Visibilidad_SAVE' and type = 'P')
	drop procedure [C_R].[SP_Visibilidad_SAVE]
go

if exists(select * from sys.objects where name ='SP_Rol_SAVE' and type = 'P')
	drop procedure [C_R].[SP_Rol_SAVE]
go

if exists(select * from sys.objects where name ='SP_ALTA_CLIENTE' and type = 'P')
	drop procedure [C_R].[SP_ALTA_CLIENTE]
go

if exists(select * from sys.objects where name ='SP_ALTA_EMPRESA' and type = 'P')
	drop procedure [C_R].[SP_ALTA_EMPRESA]
go

if exists(select * from sys.objects where name ='Inconsistencias_Calificaciones' and type = 'u')
	drop table [C_R].[Inconsistencias_Calificaciones]
go

if exists (select * from sys.objects where name = 'Factura_Items' and type = 'u')
    drop table [C_R].[Factura_Items]
go

if exists (select * from sys.objects where name = 'Factura' and type = 'u')
    drop table [C_R].[Factura]
go

if exists (select * from sys.objects where name = 'Factura_FormaPago' and type = 'u')
    drop table [C_R].[Factura_FormaPago]
go

if exists(select * from sys.objects where name ='Calificaciones' and type='u')
	drop table [C_R].[Calificaciones]
go

if exists (select * from sys.objects where name = 'Ventas' and type = 'u')
    drop table  [C_R].[Ventas]
go

if exists (select * from sys.objects where name = 'Ofertas' and type = 'u')
    drop table  [C_R].[Ofertas]
go

if exists (select * from sys.objects where name = 'Publicaciones' and type = 'u')
    drop table [C_R].[Publicaciones]
go

if exists (select * from sys.objects where name = 'Publicaciones_Estados' and type = 'u')
    drop table [C_R].[Publicaciones_Estados]
go

if exists (select * from sys.objects where name = 'Publicaciones_Tipo' and type = 'u')
    drop table [C_R].[Publicaciones_Tipo]
go

if exists (select * from sys.objects where name = 'Publicaciones_Rubro' and type = 'u')
    drop table [C_R].[Publicaciones_Rubro]
go

if exists (select * from sys.objects where name = 'Publicaciones_Visibilidad' and type = 'u')
    drop table [C_R].[Publicaciones_Visibilidad]
go

If Exists (select * from sys.objects where name='RL_Roles_Funciones' and type = 'u')
	drop table [C_R].[RL_Roles_Funciones]
go

if exists( select * from sys.objects where name = 'Sis_Funciones' and type ='u')
	drop table [C_R].[Sis_Funciones]
go

if exists (select * from sys.objects  where name='RL_Usuarios_Roles' and type ='u')
	drop table [C_R].[RL_Usuarios_Roles]
go

IF exists ( select * from sys.objects where name='Clientes' and type ='u')
	drop table [C_R].[Clientes]
go

IF exists ( select * from sys.objects where name='Empresas' and type ='u')
	drop table [C_R].[Empresas]
go

IF exists ( select * from sys.objects where name='Usuarios' and type ='u')
	drop table [C_R].[Usuarios]
go

if exists (select * from sys.objects where name= 'Tipo_Docs' and type ='u')
	drop table [C_R].[Tipo_Docs]
go

if exists(select * from sys.objects where name='Roles' and type ='u')
	drop table [C_R].[Roles]
go

if exists(select * from sys.schemas where name ='C_R')
	drop schema [C_R]
go

CREATE SCHEMA [C_R] AUTHORIZATION [gd]
GO

CREATE TABLE [C_R].[Usuarios]
( 
	[User_Id]             int		   NOT NULL  IDENTITY ( 1,1 ) ,
	[User_Name]           varchar(255) NOT NULL ,
	[User_Password]       varchar(255) NOT NULL ,
	[User_CambioPass]     bit		   NULL default 1,
	[User_Estado]         varchar(10)  NULL  default 'ACTIVO',
	[User_Log_Error]	  int          NOT NULL default 0,
	[User_Ultimo_Ingreso] datetime 	   NULL default NULL
	CONSTRAINT [PK_Ususarios] PRIMARY KEY  CLUSTERED ([User_Id] ASC),
	CONSTRAINT [UQ_Usuario_Name] UNIQUE ([User_Name]  ASC)
)
go

CREATE TABLE [C_R].[Clientes]
( 
	[Cli_Id]             int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Cli_TipoDoc]        int  NULL ,
	[Cli_Doc]            numeric(18)	NULL ,
	[Cli_Nombre]         varchar(255)	NULL ,
	[Cli_Apellido]       varchar(255)   NULL ,
	[Cli_Fecha_Nac]      datetime		NULL ,
	[Cli_Mail]           varchar(255)   NULL ,
	[Cli_User_Id]        int			NULL ,
	[Cli_Dir_Calle]      varchar(255)   NULL ,
	[Cli_Dir_Nro]        numeric(18)    NULL ,
	[Cli_Dir_Piso]       numeric(18)    NULL ,
	[Cli_Dir_CodPostal]  varchar(50)    NULL ,
	[Cli_Dir_Depto]      varchar(50)    NULL ,
	[Cli_Dir_Localidad]	 varchar(50)    NULL ,
	[Cli_Telefono]		 varchar(50)	NULL default 'MIG-' +substring(convert(varchar(50), newID()),1,20)
	CONSTRAINT [PK_Clientes] PRIMARY KEY  CLUSTERED ([Cli_Id] ASC),
	CONSTRAINT [UQ_Cliente_Tel] UNIQUE ([Cli_Telefono] ASC),
	CONSTRAINT [UQ_Cliente_Doc] UNIQUE ([Cli_TipoDoc] ASC, [Cli_Doc] ASC)
)
go

CREATE TABLE [C_R].[Empresas]
( 
	[Emp_Id]             int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Emp_Fecha_Creacion] datetime		NULL ,
	[Emp_Mail]           varchar(255)   NULL ,
	[Emp_Telefono]		 varchar(50)	NULL default 'MIG-' +substring(convert(varchar(50), newID()),1,20),
	[Emp_RazonSocial]    varchar(255)	NULL ,
	[Emp_User_Id]        int			NULL ,
	[Emp_Dir_Calle]      varchar(255)   NULL ,
	[Emp_Dir_Nro]        numeric(18)    NULL ,
	[Emp_Dir_Piso]       numeric(18)    NULL ,
	[Emp_Dir_CodPostal]  varchar(50)    NULL ,
	[Emp_Dir_Depto]      varchar(50)    NULL ,
	[Emp_Dir_Localidad]	 varchar(50)    NULL ,
	[Emp_Cuit]           varchar(50)	NULL
	CONSTRAINT [PK_Empresas] PRIMARY KEY  CLUSTERED ([Emp_Id] ASC),
	CONSTRAINT [UQ_Empresa_Tel] UNIQUE ([Emp_Telefono] ASC)
)
go

CREATE PROCEDURE C_R.SP_ALTA_CLIENTE
@Cli_TipoDoc int,
@Cli_Doc numeric(18),
@Cli_Nombre varchar(255),
@Cli_Apellido varchar(255),
@Cli_Fecha_Nac datetime,
@Cli_Mail varchar(255),
@Cli_Dir_Calle varchar(255),
@Cli_Dir_Nro numeric(18),
@Cli_Dir_Piso numeric(18),
@Cli_Dir_CodPostal varchar(50),
@Cli_Dir_Depto varchar(50),
@Cli_Dir_Localidad varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	
	-- hash para password "changeme"
	INSERT INTO C_R.Usuarios(User_Name, User_Password) values
	(SUBSTRING(@Cli_Nombre,1,1)+@Cli_Apellido +Convert(varchar,(YEAR(@Cli_Fecha_Nac))),'057ba03d6c44104863dc7361fe4578965d1887360f90a0895882e58a6248fc86')
	
	INSERT INTO C_R.Clientes ( Cli_TipoDoc, Cli_Doc, Cli_Nombre, Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_User_Id, Cli_Dir_Calle, Cli_Dir_Nro, Cli_Dir_Piso, Cli_Dir_CodPostal, Cli_Dir_Depto, Cli_Dir_Localidad) values
	(@Cli_TipoDoc, @Cli_Doc, @Cli_Nombre, @Cli_Apellido, @Cli_Fecha_Nac, @Cli_Mail, SCOPE_IDENTITY(), @Cli_Dir_Calle, @Cli_Dir_Nro, @Cli_Dir_Piso, @Cli_Dir_CodPostal, @Cli_Dir_Depto, @Cli_Dir_Localidad)
	
END
GO

CREATE PROCEDURE C_R.SP_ALTA_EMPRESA
@Emp_Cuit varchar(50),
@Emp_RazonSocial varchar(255),
@Emp_Fecha_Creacion datetime,
@Emp_Mail varchar(255),
@Emp_Dir_Calle varchar(255),
@Emp_Dir_Nro numeric(18),
@Emp_Dir_Piso numeric(18),
@Emp_Dir_CodPostal varchar(50),
@Emp_Dir_Depto varchar(50),
@Emp_Dir_Localidad varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	
	-- hash para password "changeme"
	INSERT INTO C_R.Usuarios(User_Name, User_Password) values
	(REPLACE(@Emp_Cuit,'-',''),'057ba03d6c44104863dc7361fe4578965d1887360f90a0895882e58a6248fc86')
	
	INSERT INTO C_R.Empresas ( Emp_Fecha_Creacion, Emp_Mail, Emp_RazonSocial, Emp_Cuit, Emp_User_Id, Emp_Dir_Calle, Emp_Dir_Nro, Emp_Dir_Piso, Emp_Dir_CodPostal, Emp_Dir_Depto, Emp_Dir_Localidad) values
	(@Emp_Fecha_Creacion, @Emp_Mail, @Emp_RazonSocial, @Emp_Cuit, SCOPE_IDENTITY(),@Emp_Dir_Calle, @Emp_Dir_Nro, @Emp_Dir_Piso, @Emp_Dir_CodPostal, @Emp_Dir_Depto, @Emp_Dir_Localidad)
	
END
GO


CREATE TABLE [C_R].[Factura]
( 
	[Factura_Nro]       numeric(18)  NOT NULL ,
	[Factura_FP_ID]     int  NOT NULL ,
	[Factura_Fecha]     datetime  NOT NULL ,
	[Factura_Total]     numeric(18,2)  NOT NULL
	CONSTRAINT [PK_Factura] PRIMARY KEY  CLUSTERED ([Factura_Nro] ASC)
)
go

CREATE TABLE [C_R].[Factura_Items]
( 
	[Item_Id]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Factura_Nro]        numeric(18)  NOT NULL ,
	[Item_Cantidad]      numeric(18)  NOT NULL ,
	[Item_Monto]         numeric(18,2)  NULL ,
	[Item_Desc]          varchar(50)  NULL,
	[Pub_Codigo]         numeric(18)  NOT NULL  
	CONSTRAINT [PK_Factura_Items] PRIMARY KEY  CLUSTERED ([Item_Id] ASC)
)
go

CREATE TABLE [C_R].[Factura_FormaPago]
( 
	[Factura_FP_ID]      int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Factura_FP_Desc]    varchar(255)  NULL 
	CONSTRAINT [PK_Factura_FormaPago] PRIMARY KEY  CLUSTERED ([Factura_FP_ID] ASC)
)
go

CREATE TABLE [C_R].[Publicaciones]
( 
	[Pub_Codigo]         numeric(18)  NOT NULL ,
	[Pub_Descripcion]    nvarchar(255) NULL ,
	[Pub_Stock]          numeric(18)  NOT NULL ,
	[Pub_Fecha]          datetime  NOT NULL ,
	[Pub_Fecha_Venc]     date  NOT NULL ,
	[Pub_Precio]         numeric(18,2)  NOT NULL ,
	[Pub_Visible_Cod]    numeric(18)  NOT NULL ,
	[Pub_Rubro_Id]       int  NOT NULL ,
	[Pub_Tipo_Id]        int  NOT NULL ,
	[Pub_Estado_Id]      int  NOT NULL ,
	[Pub_User_Id]            int  NULL 
	CONSTRAINT [PK_Publicaciones] PRIMARY KEY  CLUSTERED ([Pub_Codigo] ASC)
)
go

CREATE TABLE [C_R].[Ofertas]
( 
	[Ofe_Codigo]         numeric(18) IDENTITY(1,1) NOT NULL ,
	[Pub_Codigo]         numeric(18)  NULL ,
	[Ofe_User_Id]        int  NULL ,
	[Ofe_Fecha]          datetime  NULL ,
	[Ope_Monto]          numeric(18,2)  NULL
	CONSTRAINT [PK_Ofertas] PRIMARY KEY  CLUSTERED ([Ofe_Codigo] ASC)
)
go

CREATE TABLE [C_R].[Ventas]
( 
	[Ven_Codigo]         numeric(18) IDENTITY(1,1) NOT NULL ,
	[Pub_Codigo]         numeric(18) NOT NULL ,
	[Ven_User_Id]        int NOT NULL ,
	[Ven_Fecha]          datetime NOT NULL ,
	[Ven_Monto]          numeric(18,2) NOT NULL ,
	[Ven_Cantidad]       numeric(18) NOT NULL 
	CONSTRAINT [PK_Ventas] PRIMARY KEY  CLUSTERED ([Ven_Codigo] ASC)
)
go

CREATE TABLE [C_R].[Publicaciones_Estados]
( 
	[Pub_Estado_Id]      int  NOT NULL ,
	[Pub_Estado_Desc]    nvarchar(255) NULL 
	CONSTRAINT [PK_Publicaciones_Estados] PRIMARY KEY  CLUSTERED ([Pub_Estado_Id] ASC)
)
go

CREATE TABLE [C_R].[Publicaciones_Visibilidad]
( 
	[Pub_Visible_Cod]    numeric(18) IDENTITY (1,1)  NOT NULL ,
	[Pub_Visible_Descripcion] nvarchar(255) NOT NULL ,
	[Pub_Visible_Precio] numeric(18,2)  NOT NULL ,
	[Pub_Visible_Porcentaje] numeric(18,2)  NOT NULL 
	CONSTRAINT [PK_Publicaciones_Visibilidad] PRIMARY KEY  CLUSTERED ([Pub_Visible_Cod] ASC)
)
go

CREATE TABLE [C_R].[Publicaciones_Rubro]
( 
	[Pub_RubroId]        int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Pub_Descripcion]    nvarchar(255) NULL 
	CONSTRAINT [PK_Publicaciones_Rubro] PRIMARY KEY  CLUSTERED ([Pub_RubroId] ASC)
)
go

CREATE TABLE [C_R].[Publicaciones_Tipo]
( 
	[Pub_Tipo]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Pub_Descripcion]    nvarchar(255) NULL 
	CONSTRAINT [PK_Publicaciones_Tipo] PRIMARY KEY  CLUSTERED ([Pub_Tipo] ASC)
)
go

CREATE TABLE [C_R].[Roles]
( 
	[Rol_Id]             int  NOT NULL IDENTITY,
	[Rol_Descripcion]    nvarchar(50)   NULL ,
	[Rol_Estado]         varchar(50)  NULL 
	CONSTRAINT [PK_Roles] PRIMARY KEY  CLUSTERED ([Rol_Id] ASC)
)
go

CREATE TABLE [C_R].[RL_Usuarios_Roles]
( 
	[Rol_Id]             int  NOT NULL ,
	[User_Id]            int  NOT NULL 
	CONSTRAINT [PK_RL_Usuarios_Roles] PRIMARY KEY  CLUSTERED ([Rol_Id] ASC,[User_Id] ASC)
)
go

CREATE TABLE [C_R].[Sis_Funciones]
( 
	[Sis_Fun_Id]         int  NOT NULL IDENTITY ( 1,1 ),
	[Sis_Fun_Des]        varchar(255)   NULL 
	CONSTRAINT [PK_Sis_Funciones] PRIMARY KEY  CLUSTERED ([Sis_Fun_Id] ASC)
)
go

CREATE TABLE [C_R].[RL_Roles_Funciones]
( 
	[Sis_Fun_Id]         int  NOT NULL ,
	[Rol_Id]             int  NOT NULL ,
	[Estado]             nvarchar(50)  NULL 
	CONSTRAINT [PK_RL_Roles_Funciones] PRIMARY KEY  CLUSTERED ([Sis_Fun_Id] ASC,[Rol_Id] ASC)
)
go

CREATE TABLE [C_R].[Tipo_Docs]
(	
	[Cli_TipoDoc]        int  NOT NULL IDENTITY (1,1) ,
	[Descripcion]        varchar(100) NULL,
	[Des_Corta]			 varchar(10) null
	CONSTRAINT [PK_Tipo_Docs] PRIMARY KEY  CLUSTERED ([Cli_TipoDoc] ASC)
)
go

CREATE TABLE [C_R].[Inconsistencias_Calificaciones]
( 
	[Inc_Id]                          int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Inc_Publicacion_Cod]             numeric(18) NOT NULL ,
	[Inc_User_Id]                     int NOT NULL ,
	[Inc_Compra_Fecha]                datetime NOT NULL ,
	[Inc_Compra_Cantidad]             numeric(18) NOT NULL ,
	[Inc_Calificacion_Codigo]         numeric(18) NULL ,
	[Inc_Calificacion_Cant_Estrellas] numeric(18) NULL,
	CONSTRAINT [PK_Inconsistencias_Calificaciones] PRIMARY KEY CLUSTERED ([Inc_Id] ASC),
	CONSTRAINT [FK_Inconsistencias_Calificaciones_Publicaciones] FOREIGN KEY ([Inc_Publicacion_Cod]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT [FK_Inconsistencias_Calificaciones_Usuarios] FOREIGN KEY ([Inc_User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go

ALTER TABLE [C_R].[Clientes]
	ADD CONSTRAINT [FK_Clientes_TipoDoc] FOREIGN KEY ([Cli_TipoDoc]) REFERENCES [C_R].[Tipo_Docs]([Cli_TipoDoc])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Clientes]
	ADD CONSTRAINT [FK_Clientes_Usuarios] FOREIGN KEY ([Cli_User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Empresas]
	ADD CONSTRAINT [FK_Empresas_Usuarios] FOREIGN KEY ([Emp_User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Factura] WITH CHECK 
	ADD CONSTRAINT [FK_Factura_Factura_FormaPago] FOREIGN KEY ([Factura_FP_ID]) REFERENCES [C_R].[Factura_FormaPago]([Factura_FP_ID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Factura]
	  WITH CHECK CHECK CONSTRAINT [FK_Factura_Factura_FormaPago]
go

ALTER TABLE [C_R].[Factura_Items]
	ADD CONSTRAINT [FK_Factura_Items_Publicaciones] FOREIGN KEY ([Pub_Codigo]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [C_R].[Factura_Items] WITH CHECK 
	ADD CONSTRAINT [FK_Factura_Items_Factura] FOREIGN KEY ([Factura_Nro]) REFERENCES [C_R].[Factura]([Factura_Nro])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Factura_Items]
	  WITH CHECK CHECK CONSTRAINT [FK_Factura_Items_Factura]
go


ALTER TABLE [C_R].[Publicaciones] WITH CHECK 
	ADD CONSTRAINT [FK_Publicaciones_Publicaciones_Visibilidad] FOREIGN KEY ([Pub_Visible_Cod]) REFERENCES [C_R].[Publicaciones_Visibilidad]([Pub_Visible_Cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Publicaciones]
	  WITH CHECK CHECK CONSTRAINT [FK_Publicaciones_Publicaciones_Visibilidad]
go

ALTER TABLE [C_R].[Publicaciones] WITH CHECK 
	ADD CONSTRAINT [FK_Publicaciones_Publicaciones_Rubro] FOREIGN KEY ([Pub_Rubro_Id]) REFERENCES [C_R].[Publicaciones_Rubro]([Pub_RubroId])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Publicaciones]
	  WITH CHECK CHECK CONSTRAINT [FK_Publicaciones_Publicaciones_Rubro]
go

ALTER TABLE [C_R].[Publicaciones] WITH CHECK 
	ADD CONSTRAINT [FK_Publicaciones_Publicaciones_Tipo] FOREIGN KEY ([Pub_Tipo_Id]) REFERENCES [C_R].[Publicaciones_Tipo]([Pub_Tipo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Publicaciones]
	  WITH CHECK CHECK CONSTRAINT [FK_Publicaciones_Publicaciones_Tipo]
go

ALTER TABLE [C_R].[Publicaciones] WITH CHECK 
	ADD CONSTRAINT [FK_Publicaciones_Publicaciones_Estados] FOREIGN KEY ([Pub_Estado_Id]) REFERENCES [C_R].[Publicaciones_Estados]([Pub_Estado_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Publicaciones]
	  WITH CHECK CHECK CONSTRAINT [FK_Publicaciones_Publicaciones_Estados]
go

ALTER TABLE [C_R].[Publicaciones]
	ADD CONSTRAINT [FK_Publicaciones_Usuarios] FOREIGN KEY ([Pub_User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Ofertas]
	ADD CONSTRAINT [FK_Ofertas_Usuarios] FOREIGN KEY ([Ofe_User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Ofertas]
	ADD CONSTRAINT [FK_Ofertas_Publicaciones] FOREIGN KEY ([Pub_Codigo]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Ventas]
	ADD CONSTRAINT [FK_Ventas_Usuarios] FOREIGN KEY ([Ven_User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Ventas]
	ADD CONSTRAINT [FK_Ventas_Publicaciones] FOREIGN KEY ([Pub_Codigo]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[RL_Usuarios_Roles]
	ADD CONSTRAINT [FK_Usuarios_Roles_Roles] FOREIGN KEY ([Rol_Id]) REFERENCES [C_R].[Roles]([Rol_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[RL_Usuarios_Roles]
	ADD CONSTRAINT [FK_Usuarios_Roles_Usuarios] FOREIGN KEY ([User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [C_R].[RL_Roles_Funciones]
	ADD CONSTRAINT [FK_Roles_Funciones_Funciones] FOREIGN KEY ([Sis_Fun_Id]) REFERENCES [C_R].[Sis_Funciones]([Sis_Fun_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[RL_Roles_Funciones]
	ADD CONSTRAINT [FK_Roles_Funciones_Roles] FOREIGN KEY ([Rol_Id]) REFERENCES [C_R].[Roles]([Rol_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

CREATE TABLE [C_R].[Calificaciones]
(
	[Cal_Codigo] numeric(18) NOT NULL,
	[Cal_CantEstrellas] numeric(18)  NULL ,
	[Cal_Descripcion] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Ven_Codigo] numeric(18) NOT NULL
	CONSTRAINT [PK_Calificaciones] PRIMARY KEY CLUSTERED ([Cal_Codigo]) 
	CONSTRAINT [FK_Calificaciones_Ventas] FOREIGN KEY ([Ven_Codigo])  REFERENCES [C_R].[Ventas]([Ven_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

--Insercion de Roles
SET IDENTITY_INSERT C_R.Roles on;
INSERT INTO C_R.Roles(Rol_Id, Rol_Descripcion, Rol_Estado)
VALUES(1,'Empresa','ACTIVO')

INSERT INTO C_R.Roles(Rol_Id, Rol_Descripcion, Rol_Estado)
VALUES(2,'Administrativo','ACTIVO')

INSERT INTO C_R.Roles(Rol_Id, Rol_Descripcion, Rol_Estado)
VALUES(3,'Cliente','ACTIVO')
SET IDENTITY_INSERT C_R.Roles off;
Go

INSERT INTO C_R.Tipo_Docs
VALUES ('Documento Nacional de Identidad','DNI')

INSERT INTO C_R.Tipo_Docs
VALUES ('Libreta Civica','LC')

INSERT INTO C_R.Tipo_Docs
VALUES ('Libreta de Enrolamiento','LE')


INSERT INTO C_R.Tipo_Docs
VALUES ('Cedula de Identidad','CI')


INSERT INTO C_R.Tipo_Docs
VALUES ('Pasaporte Argentino','PA')


INSERT INTO C_R.Tipo_Docs
VALUES ('Pasaporte Extrangero','PE')

INSERT INTO C_R.Tipo_Docs
VALUES ('Otro','OT')
GO

-- Insercion de clientes
DECLARE @Cli_TipoDoc int,
		@Cli_Doc numeric(18),
		@Cli_Nombre varchar(255),
		@Cli_Apellido varchar(255),
		@Cli_Fecha_Nac datetime,
		@Cli_Mail varchar(255),
		@Cli_Dir_Calle varchar(255),
		@Cli_Dir_Nro numeric(18),
		@Cli_Dir_Piso numeric(18),
		@Cli_Dir_CodPostal varchar(50),
		@Cli_Dir_Depto varchar(50),
		@Cli_Dir_Localidad varchar(50)

DECLARE clientes_cursor CURSOR FOR  
select DISTINCT	1 Cli_TipoDoc,
Publ_Cli_Dni Cli_Doc,
Publ_Cli_Nombre Cli_Nombre,
Publ_Cli_Apeliido Cli_Apellido,
Publ_Cli_Fecha_Nac Cli_Fecha_Nac,
Publ_Cli_Mail Cli_Mail,
Publ_Cli_Dom_Calle, 
Publ_Cli_Nro_Calle, 
Publ_Cli_Piso, 
Publ_Cli_Cod_Postal, 
Publ_Cli_Depto,'LOC No asignada'
 from gd_esquema.Maestra
where  Publ_Cli_Dni is not null or Publ_Cli_Apeliido is not null or Publ_Cli_Nombre is not null
order by 1

OPEN clientes_cursor		
FETCH NEXT FROM clientes_cursor INTO @Cli_TipoDoc, @Cli_Doc, @Cli_Nombre, @Cli_Apellido, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dir_Calle, @Cli_Dir_Nro, @Cli_Dir_Piso, @Cli_Dir_CodPostal, @Cli_Dir_Depto, @Cli_Dir_Localidad
WHILE @@FETCH_STATUS = 0   
BEGIN   
   EXEC C_R.SP_ALTA_CLIENTE @Cli_TipoDoc, @Cli_Doc, @Cli_Nombre, @Cli_Apellido, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dir_Calle, @Cli_Dir_Nro, @Cli_Dir_Piso, @Cli_Dir_CodPostal, @Cli_Dir_Depto, @Cli_Dir_Localidad
   FETCH NEXT FROM clientes_cursor INTO @Cli_TipoDoc, @Cli_Doc, @Cli_Nombre, @Cli_Apellido, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dir_Calle, @Cli_Dir_Nro, @Cli_Dir_Piso, @Cli_Dir_CodPostal, @Cli_Dir_Depto, @Cli_Dir_Localidad 
   
END   

CLOSE clientes_cursor   
DEALLOCATE clientes_cursor
GO

-- Insert de Empresas
DECLARE @Emp_Cuit varchar(50),
		@Emp_RazonSocial varchar(255),
		@Emp_Fecha_Creacion datetime,
		@Emp_Mail varchar(255),
		@Emp_Dir_Calle varchar(255),
		@Emp_Dir_Nro numeric(18),
		@Emp_Dir_Piso numeric(18),
		@Emp_Dir_CodPostal varchar(50),
		@Emp_Dir_Depto varchar(50),
		@Emp_Dir_Localidad varchar(50)

DECLARE empresas_cursor CURSOR FOR  
select DISTINCT
Publ_Empresa_Cuit,
Publ_Empresa_Razon_Social,
Publ_Empresa_Fecha_Creacion,
Publ_Empresa_Mail,
Publ_Empresa_Dom_Calle, 
Publ_Empresa_Nro_Calle, 
Publ_Empresa_Piso,  
Publ_Empresa_Cod_Postal,
Publ_Empresa_Depto,
'LOC No asignada'
 from gd_esquema.Maestra
where  Publ_Empresa_Cuit is not null or Publ_Empresa_Razon_Social is not null 
order by 1,2,3

OPEN empresas_cursor		
FETCH NEXT FROM empresas_cursor INTO @Emp_Cuit, @Emp_RazonSocial, @Emp_Fecha_Creacion, @Emp_Mail, @Emp_Dir_Calle, @Emp_Dir_Nro, @Emp_Dir_Piso, @Emp_Dir_CodPostal, @Emp_Dir_Depto, @Emp_Dir_Localidad
WHILE @@FETCH_STATUS = 0   
BEGIN   
   EXEC C_R.SP_ALTA_EMPRESA @Emp_Cuit, @Emp_RazonSocial, @Emp_Fecha_Creacion, @Emp_Mail, @Emp_Dir_Calle, @Emp_Dir_Nro, @Emp_Dir_Piso, @Emp_Dir_CodPostal, @Emp_Dir_Depto, @Emp_Dir_Localidad
   FETCH NEXT FROM empresas_cursor INTO @Emp_Cuit, @Emp_RazonSocial, @Emp_Fecha_Creacion, @Emp_Mail, @Emp_Dir_Calle, @Emp_Dir_Nro, @Emp_Dir_Piso, @Emp_Dir_CodPostal, @Emp_Dir_Depto, @Emp_Dir_Localidad
   
END   

CLOSE empresas_cursor   
DEALLOCATE empresas_cursor
GO

-- Relacional de  Usuarios - ROLES

INSERT INTO C_R.RL_Usuarios_Roles
SELECT 3, U.User_Id
FROM C_R.Usuarios U INNER JOIN C_R.Clientes C on U.User_Id = C.Cli_User_Id
GO

INSERT INTO C_R.RL_Usuarios_Roles
SELECT 1, U.User_Id
FROM C_R.Usuarios U INNER JOIN C_R.Empresas E on U.User_Id = E.Emp_User_Id
GO

-- Insercion de rubros publicaciones

INSERT INTO C_R.Publicaciones_Rubro
SELECT gd_esquema.Maestra.Publicacion_Rubro_Descripcion from gd_esquema.Maestra
 GROUP BY gd_esquema.Maestra.Publicacion_Rubro_Descripcion
 GO
 
-- Insercion de Tipos de publicacion 
INSERT INTO C_R.Publicaciones_Tipo  
 select   gd_esquema.Maestra.Publicacion_Tipo 
 from gd_esquema.Maestra
 group by gd_esquema.Maestra.Publicacion_Tipo
 Go
 
 -- Insercion de Estados de publicacion
 INSERT INTO C_R.Publicaciones_Estados (Pub_Estado_Id,Pub_Estado_Desc )
 Values (1,'Borrador')
 
  INSERT INTO C_R.Publicaciones_Estados (Pub_Estado_Id,Pub_Estado_Desc )
 Values (2,'Activa')
 
  INSERT INTO C_R.Publicaciones_Estados (Pub_Estado_Id,Pub_Estado_Desc )
 Values (3,'Pausada')
 
  INSERT INTO C_R.Publicaciones_Estados (Pub_Estado_Id,Pub_Estado_Desc )
 Values (4,'Finalizada')
 Go
 --  Insercion de Visibilidad
INSERT INTO C_R.Publicaciones_Visibilidad (Pub_Visible_Descripcion,Pub_Visible_Precio,Pub_Visible_Porcentaje)
SELECT gd_esquema.Maestra.Publicacion_Visibilidad_Desc ,Publicacion_Visibilidad_Precio,Publicacion_Visibilidad_Porcentaje 
FROM gd_esquema.Maestra
GROUP BY gd_esquema.Maestra.Publicacion_Visibilidad_Desc ,Publicacion_Visibilidad_Precio,Publicacion_Visibilidad_Porcentaje 
GO

--Publicaciones Clientes 
INSERT INTO C_R.Publicaciones 
SELECT  Publicacion_Cod,
		Publicacion_Descripcion,
		Publicacion_Stock,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Precio,
		(SELECT C_R.Publicaciones_Visibilidad.Pub_Visible_Cod  FROM C_R.Publicaciones_Visibilidad WHERE C_R.Publicaciones_Visibilidad.Pub_Visible_Descripcion = gd_esquema.Maestra.Publicacion_Visibilidad_Desc),  
		(SELECT C_R.Publicaciones_Rubro.Pub_RubroId FROM C_R.Publicaciones_Rubro WHERE C_R.Publicaciones_Rubro.Pub_Descripcion = gd_esquema.Maestra.Publicacion_Rubro_Descripcion ) IDRUBRO,
		(SELECT C_R.Publicaciones_Tipo.Pub_Tipo FROM C_R.Publicaciones_Tipo where C_R.Publicaciones_Tipo.Pub_Descripcion = gd_esquema.Maestra.Publicacion_Tipo ) TIPO,
		 CASE WHEN (SELECT isnull(sum(M2.Compra_Cantidad),0) FROM gd_esquema.Maestra M2 WHERE M2.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod and M2.Calificacion_Codigo is not null) < gd_esquema.Maestra.Publicacion_Stock THEN 2--'ACTIVA'
			  WHEN (SELECT isnull(sum(M2.Compra_Cantidad),0) FROM gd_esquema.Maestra M2 WHERE M2.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod and M2.Calificacion_Codigo is not null) = gd_esquema.Maestra.Publicacion_Stock THEN 4 --'FINALIZADA'
			  WHEN (SELECT isnull(sum(M2.Compra_Cantidad),0) FROM gd_esquema.Maestra M2 WHERE M2.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod and M2.Calificacion_Codigo is not null) > gd_esquema.Maestra.Publicacion_Stock THEN 1 --'BORRADOR'
			  END
			    'ESTADO',
		(SELECT C.Cli_User_Id FROM C_R.Clientes C WHERE C.Cli_TipoDoc = 1 and 
		 C.Cli_Doc = gd_esquema.Maestra.Publ_Cli_Dni 
				 )'IDCLIENTE'  
 FROM gd_esquema.Maestra
 WHERE Compra_Fecha is null and Oferta_Fecha is null  and Publ_Cli_Dni is not null and Factura_Nro is null
GO


--Publicaciones empresas
INSERT  INTO C_R.Publicaciones
SELECT  Publicacion_Cod,
		Publicacion_Descripcion,
		Publicacion_Stock,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Precio,
		(SELECT C_R.Publicaciones_Visibilidad.Pub_Visible_Cod  FROM C_R.Publicaciones_Visibilidad WHERE C_R.Publicaciones_Visibilidad.Pub_Visible_Descripcion = gd_esquema.Maestra.Publicacion_Visibilidad_Desc),  
		(SELECT C_R.Publicaciones_Rubro.Pub_RubroId FROM C_R.Publicaciones_Rubro WHERE C_R.Publicaciones_Rubro.Pub_Descripcion = gd_esquema.Maestra.Publicacion_Rubro_Descripcion ) IDRUBRO,
		(SELECT C_R.Publicaciones_Tipo.Pub_Tipo FROM C_R.Publicaciones_Tipo WHERE C_R.Publicaciones_Tipo.Pub_Descripcion = gd_esquema.Maestra.Publicacion_Tipo ) TIPO,
		 CASE WHEN (select isnull(sum(M2.Compra_Cantidad),0) FROM gd_esquema.Maestra M2 WHERE M2.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod and M2.Calificacion_Codigo is not null) < gd_esquema.Maestra.Publicacion_Stock THEN 2 --'ACTIVA'
			  WHEN (select isnull(sum(M2.Compra_Cantidad),0) FROM gd_esquema.Maestra M2 WHERE M2.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod and M2.Calificacion_Codigo is not null) = gd_esquema.Maestra.Publicacion_Stock THEN 4 --'FINALIZADA'
			  WHEN (select isnull(sum(M2.Compra_Cantidad),0) FROM gd_esquema.Maestra M2 WHERE M2.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod and M2.Calificacion_Codigo is not null) > gd_esquema.Maestra.Publicacion_Stock THEN 1 --'BORRADOR'
			  END
			    'ESTADO',
		(SELECT E.Emp_User_Id FROM C_R.Empresas E
			WHERE E.Emp_Cuit  = gd_esquema.Maestra.Publ_Empresa_Cuit 
				 )'IDCLIENTE'  
 FROM gd_esquema.Maestra
WHERE Compra_Fecha is null and Oferta_Fecha is null  and Publ_Empresa_Cuit  is not null and Factura_Nro is null 
GO
 
INSERT INTO C_R.Ofertas ( Pub_Codigo, Ofe_User_Id, Ofe_Fecha, Ope_Monto ) 
select Publicacion_Cod, 
(SELECT C.Cli_User_Id from C_R.Clientes C where C.Cli_Doc = gd_esquema.Maestra.Cli_Dni ),
oferta_fecha,
Oferta_Monto
from gd_esquema.Maestra
where publicacion_tipo = 'subasta' and Oferta_Fecha is not null
GO

-- esto esta tirando un warning 
INSERT INTO C_R.Ventas ( Pub_Codigo, Ven_User_Id, Ven_Fecha, Ven_Monto, Ven_Cantidad ) 
select Publicacion_Cod, 
(SELECT C.Cli_User_Id from C_R.Clientes C where C.Cli_Doc = gd_esquema.Maestra.Cli_Dni ),
Compra_Fecha,
case 
	when publicacion_tipo = 'compra inmediata' then Publicacion_Precio
	when publicacion_tipo = 'subasta' then ( SELECT MAX(M1.Oferta_Monto) FROM gd_esquema.Maestra M1 WHERE  M1.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod )
end,
Compra_Cantidad 
from gd_esquema.Maestra
where Compra_Fecha is not null and Calificacion_Codigo is null
GO

-- distinta calificacion del mismo producto, por el mismo cliente, en la misma fecha y misma cantidad
insert into C_R.Inconsistencias_Calificaciones ( Inc_Publicacion_Cod, Inc_User_Id, Inc_Compra_Fecha, Inc_Compra_Cantidad, Inc_Calificacion_Codigo, Inc_Calificacion_Cant_Estrellas )
select M.Publicacion_Cod,
(select C.Cli_User_Id from C_R.Clientes C where C.Cli_Doc = M.Cli_Dni),
M.Compra_Fecha,M.Compra_Cantidad, M.Calificacion_Codigo, M.Calificacion_Cant_Estrellas
from gd_esquema.Maestra M inner join
(select Publicacion_Cod,Cli_Dni,Compra_Fecha,Compra_Cantidad 
 from gd_esquema.Maestra
 where Calificacion_Codigo is not null
 group by Publicacion_Cod,Cli_Dni,Compra_Fecha,Compra_Cantidad
 having COUNT(*) > 1) INC
on M.Publicacion_Cod = INC.Publicacion_Cod and M.Cli_Dni = INC.Cli_Dni and M.Compra_Fecha = INC.Compra_Fecha and M.Compra_Cantidad = INC.Compra_Cantidad
GO
 
-- CALIFICACIONES
insert into C_R.Calificaciones
select m.Calificacion_Codigo,m.Calificacion_Cant_Estrellas,m.Calificacion_Descripcion,v.Ven_Codigo 
from gd_esquema.Maestra m inner join C_R.Ventas v
on m.Publicacion_Cod = v.Pub_Codigo and m.Compra_Fecha = v.Ven_Fecha and m.Compra_Cantidad = v.Ven_Cantidad
where m.Calificacion_Codigo is not null
and m.Calificacion_Codigo not in ( select Inc_Calificacion_Codigo from C_R.Inconsistencias_Calificaciones where Inc_Calificacion_Codigo is not null )
and v.Ven_User_Id = ( select c.Cli_User_Id from C_R.Clientes c where c.Cli_Doc = m.Cli_Dni )

-- FORMAS DE PAGO
insert into C_R.Factura_FormaPago(Factura_FP_Desc) values ('Efectivo')
insert into C_R.Factura_FormaPago(Factura_FP_Desc) values ('Tarjeta');

-- FACTURAS
insert into C_R.Factura(Factura_Nro, Factura_Fecha, Factura_Total, Factura_FP_ID)
select distinct M.Factura_Nro, M.Factura_Fecha, M.Factura_Total, 
(select Factura_FP_ID from C_R.Factura_FormaPago where Factura_FP_Desc = M.Forma_Pago_Desc) as FP
from gd_esquema.Maestra M
where M.Factura_Nro is not null

-- ITEMS
insert into C_R.Factura_Items(Item_Monto, Item_Cantidad, Factura_Nro, Item_Desc, Pub_Codigo)
select Item_Factura_Monto, Item_Factura_Cantidad, Factura_Nro, 'ITEM-MIG', Publicacion_Cod
from gd_esquema.Maestra M
where M.Factura_Nro is not null
GO

CREATE PROCEDURE C_R.SP_LOGIN
@nombre varchar(255),
@password varchar(255),
@nuevo_password varchar(255),
@resultado tinyint OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @hash varchar(255)
	DECLARE @estado varchar(10)
	DECLARE @cambio_pass bit
	
	select @hash = User_Password, @estado = User_Estado, @cambio_pass = User_CambioPass
	from C_R.Usuarios 
	where User_Name = @nombre
	
	IF ( @estado IS NULL )
	BEGIN
		SET @resultado = 2
		RETURN
	END
	
	IF ( @estado = 'INACTIVO' )
	BEGIN
		SET @resultado = 5
		RETURN
	END
	
	IF ( @hash = @password COLLATE Latin1_General_CS_AS )
	BEGIN
	
		update C_R.Usuarios set User_Log_Error = '0' 
		where User_Name = @nombre
		
		IF ( @cambio_pass =	1 )
		BEGIN
			IF ( @nuevo_password IS NULL )
			BEGIN
				SET @resultado = 10
				RETURN
			END
			
			update C_R.Usuarios
			set User_Password = @nuevo_password, User_CambioPass = 0
			where User_Name = @nombre
			
		END
		
		SET @resultado = 0
		
		RETURN
	END
	
	SET @resultado = 3
	DECLARE @logins_fallidos int
	
	select @logins_fallidos = (User_Log_Error + 1) 
	from C_R.Usuarios 
	where User_Name = @nombre
	
	update C_R.Usuarios set User_Log_Error = @logins_fallidos
	where User_Name = @nombre
	
	IF ( @logins_fallidos > 2 )
	BEGIN
		SET @resultado = 4
		update C_R.Usuarios set User_Estado = 'INACTIVO'
		where User_Name = @nombre
	END
END
GO

CREATE PROCEDURE C_R.SP_Visibilidad_SAVE(@Codigo int,@Descripcion char(255),@Precio numeric(18,2),@Porc numeric(18,2))
AS
BEGIN
  if (@Codigo =-1)
  Begin
	INSERT INTO [GD1C2014].[C_R].[Publicaciones_Visibilidad]
		   ([Pub_Visible_Descripcion]
		   ,[Pub_Visible_Precio]
		   ,[Pub_Visible_Porcentaje])
	 VALUES
		   (@Descripcion,
			@Precio,
		   @Porc)
	end
	else
	begin
		UPDATE Publicaciones_Visibilidad
		set 
			Pub_Visible_Descripcion = @Descripcion ,
			Pub_Visible_Precio = @Precio,
			Pub_Visible_Porcentaje = @Porc 
		
		where 
		Publicaciones_Visibilidad.Pub_Visible_Cod = @Codigo
	end

END
GO

CREATE PROCEDURE C_R.SP_Rol_SAVE(@Codigo int,@Descripcion nvarchar(50),@Estado varchar(50))
AS
BEGIN
  if (@Codigo =-1)
  Begin
	INSERT INTO Roles
		   (Rol_Descripcion
		   ,Rol_Estado)
	 VALUES
		   (@Descripcion,
			@Estado)
	end
	else
	begin
		UPDATE Roles
		set 
			Rol_Descripcion = @Descripcion ,
			Rol_Estado = @Estado
		where 
		Rol_Id = @Codigo
	end
END
GO

