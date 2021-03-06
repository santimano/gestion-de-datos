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

if exists(select * from sys.objects where name ='SP_Publicacion_SAVE' and type = 'P')
	drop procedure [C_R].[SP_Publicacion_SAVE]
go

if exists(select * from sys.objects where name ='SP_Rol_SAVE' and type = 'P')
	drop procedure [C_R].[SP_Rol_SAVE]
go

if exists(select * from sys.objects where name like '%FuncionesTableType%' and type = 'TT')
	drop type [C_R].[FuncionesTableType]
go

if exists(select * from sys.objects where name ='SP_CLIENTE_SAVE' and type = 'P')
	drop procedure [C_R].[SP_CLIENTE_SAVE]
go

if exists(select * from sys.objects where name ='SP_EMPRESA_SAVE' and type = 'P')
	drop procedure [C_R].[SP_EMPRESA_SAVE]
go

if exists(select * from sys.objects where name ='SP_FACTURAR' and type = 'P')
	drop procedure [C_R].[SP_FACTURAR]
go

if exists(select * from sys.objects where name ='SP_COMPRAR' and type = 'P')
	drop procedure [C_R].[SP_COMPRAR]
go

if exists(select * from sys.objects where name='Contador_Visibilidad_VW' and type ='v')
	drop view [C_R].[Contador_Visibilidad_VW]
go

if exists(select * from sys.objects where name like '%PublicacionesTableType%' and type = 'TT')
	drop type [C_R].[PublicacionesTableType]
go

if exists(select * from sys.objects where name like '%RubrosTableType%' and type = 'TT')
	drop type [C_R].[RubrosTableType]
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

if exists(select * from sys.objects where name='Respuestas' and type ='u')
	drop table [C_R].[Respuestas]
go

if exists(select * from sys.objects where name='Preguntas' and type ='u')
	drop table [C_R].[Preguntas]
go

if exists (select * from sys.objects where name = 'RL_Publicaciones_Rubros' and type = 'u')
    drop table [C_R].[RL_Publicaciones_Rubros]
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

if exists(select * from sys.objects where name='Ofertas_Estado_VW' and type ='v')
	drop view [C_R].[Ofertas_Estado_VW]
go

if exists(select * from sys.objects where name='Compras_VW' and type ='v')
	drop view [C_R].[Compras_VW]
go

if exists(select * from sys.objects where name='Calificaciones_VW' and type ='v')
	drop view [C_R].[Calificaciones_VW]
go

if exists(select * from sys.objects where name='Calificaciones_Pendientes_VW' and type ='v')
	drop view [C_R].[Calificaciones_Pendientes_VW]
go

if exists(select * from sys.objects where name='Inhabilitados_Compra_Oferta_VW' and type ='v')
	drop view [C_R].[Inhabilitados_Compra_Oferta_VW]
go

if exists(select * from sys.objects where name='Preguntas_Pendientes_VW' and type ='v')
	drop view [C_R].[Preguntas_Pendientes_VW]
go

if exists(select * from sys.objects where name='Respondidas_VW' and type ='v')
	drop view [C_R].[Respondidas_VW]
go

if exists(select * from sys.objects where name='Ventas_No_Facturadas_VW' and type ='v')
	drop view [C_R].[Ventas_No_Facturadas_VW]
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
	[User_CambioPass]     bit		   NOT NULL default 1,
	[User_Eliminado]      bit		   NOT NULL default 0,
	[User_Estado]         varchar(10)  NOT NULL default 'ACTIVO',
	[User_Log_Error]	  int          NOT NULL default 0,
	[User_Ultimo_Ingreso] datetime 	   NULL default NULL
	CONSTRAINT [PK_Ususarios] PRIMARY KEY  CLUSTERED ([User_Id] ASC),
	CONSTRAINT [UQ_Usuario_Name] UNIQUE ([User_Name]  ASC)
)
go

CREATE TABLE [C_R].[Clientes]
( 
	[Cli_Id]             int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Cli_TipoDoc]        int  NOT NULL ,
	[Cli_Doc]            numeric(18)	NOT NULL ,
	[Cli_Cuil]           varchar(18)	NOT NULL ,
	[Cli_Nombre]         varchar(255)	NOT NULL ,
	[Cli_Apellido]       varchar(255)   NOT NULL ,
	[Cli_Fecha_Nac]      datetime		NOT NULL ,
	[Cli_Mail]           varchar(255)   NOT NULL ,
	[Cli_User_Id]        int			NOT NULL ,
	[Cli_Dir_Calle]      varchar(255)   NOT NULL ,
	[Cli_Dir_Nro]        numeric(18)    NOT NULL ,
	[Cli_Dir_Piso]       numeric(18)    NULL ,
	[Cli_Dir_CodPostal]  varchar(50)    NOT NULL ,
	[Cli_Dir_Depto]      varchar(50)    NULL ,
	[Cli_Dir_Localidad]	 varchar(50)    NULL ,
	[Cli_Telefono]		 varchar(50)	NOT NULL 
	CONSTRAINT [PK_Clientes] PRIMARY KEY  CLUSTERED ([Cli_Id] ASC),
	CONSTRAINT [UQ_Cliente_Tel] UNIQUE ([Cli_Telefono] ASC),
	CONSTRAINT [UQ_Cliente_Doc] UNIQUE ([Cli_TipoDoc] ASC, [Cli_Doc] ASC),
	CONSTRAINT [UQ_Cliente_Cuil] UNIQUE ([Cli_Cuil] ASC)
)
go

CREATE TABLE [C_R].[Empresas]
( 
	[Emp_Id]             int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Emp_Fecha_Creacion] datetime		NOT NULL ,
	[Emp_Mail]           varchar(255)   NOT NULL ,
	[Emp_Contacto]       varchar(255)   NOT NULL ,
	[Emp_Telefono]		 varchar(50)	NOT NULL ,
	[Emp_RazonSocial]    varchar(255)	NOT NULL ,
	[Emp_User_Id]        int			NOT NULL ,
	[Emp_Dir_Ciudad]	 varchar(255)   NOT NULL ,
	[Emp_Dir_Calle]      varchar(255)   NOT NULL ,
	[Emp_Dir_Nro]        numeric(18)    NOT NULL ,
	[Emp_Dir_Piso]       numeric(18)    NULL ,
	[Emp_Dir_CodPostal]  varchar(50)    NOT NULL ,
	[Emp_Dir_Depto]      varchar(50)    NULL ,
	[Emp_Dir_Localidad]	 varchar(50)    NULL ,
	[Emp_Cuit]           varchar(50)	NOT NULL
	CONSTRAINT [PK_Empresas] PRIMARY KEY  CLUSTERED ([Emp_Id] ASC),
	CONSTRAINT [UQ_Empresa_Tel] UNIQUE ([Emp_Telefono] ASC),
	CONSTRAINT [UQ_Empresa_Cuit] UNIQUE ([Emp_Cuit] ASC),
	CONSTRAINT [UQ_Empresa_RazonSocial] UNIQUE ([Emp_RazonSocial] ASC)
)
go

CREATE TABLE [C_R].[Factura]
( 
	[Factura_Nro]				 numeric(18)  NOT NULL IDENTITY(1,1),
	[Factura_FP_ID]				 int  NOT NULL ,
	[Factura_Fecha]				 datetime  NOT NULL DEFAULT GETDATE(),
	[Factura_Total]				 numeric(18,2)  NOT NULL,
	[Factura_Tarjeta]			 numeric(16,0)  NULL,
	[Factura_Titular]			 varchar(255) NULL,
	[Factura_Vencimiento_Tarj]   varchar(7) NULL
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
	[Pub_Codigo]         numeric(18)  NOT NULL IDENTITY(1,1),
	[Pub_Descripcion]    nvarchar(255) NULL ,
	[Pub_Stock]          numeric(18)  NOT NULL ,
	[Pub_Fecha]          datetime  NOT NULL ,
	[Pub_Fecha_Venc]     date  NOT NULL ,
	[Pub_Precio]         numeric(18,2)  NOT NULL ,
	[Pub_Visible_Cod]    numeric(18)  NOT NULL ,
	[Pub_Tipo_Id]        int  NOT NULL ,
	[Pub_Estado_Id]      int  NOT NULL ,
	[Pub_User_Id]        int  NULL,
	[Pub_Preguntas]      bit  NOT NULL DEFAULT 1 
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
	[Pub_Visible_Porcentaje] numeric(18,2)  NOT NULL,
	[Pub_Visible_Estado] nvarchar(10) DEFAULT 'ACTIVO' NOT NULL,
	[Pub_Visible_Duracion] int NOT NULL,
	CONSTRAINT [PK_Publicaciones_Visibilidad] PRIMARY KEY  CLUSTERED ([Pub_Visible_Cod] ASC),
	CONSTRAINT [UQ_Publicaciones_Visibilidad_Descripcion] UNIQUE ([Pub_Visible_Descripcion] ASC)
)
go

CREATE TABLE [C_R].[Publicaciones_Rubro]
( 
	[Pub_RubroId]        int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Pub_Descripcion]    nvarchar(255) NULL 
	CONSTRAINT [PK_Publicaciones_Rubro] PRIMARY KEY  CLUSTERED ([Pub_RubroId] ASC)
)
go

CREATE TABLE [C_R].[RL_Publicaciones_Rubros]
( 
	[Pub_RubroId]        int			NOT NULL,
	[Pub_Codigo]		 numeric(18)	NOT NULL
	CONSTRAINT [PK_RL_Publicaciones_Rubros] PRIMARY KEY  CLUSTERED ([Pub_RubroId] ASC, [Pub_Codigo] ASC)
	CONSTRAINT [FK_RL_Rubros_Publicaciones] FOREIGN KEY ([Pub_RubroId]) REFERENCES [C_R].[Publicaciones_Rubro]([Pub_RubroId])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT [FK_RL_Publicaciones_Rubros] FOREIGN KEY ([Pub_Codigo]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
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
	[Cal_Codigo] numeric(18) NOT NULL IDENTITY,
	[Cal_CantEstrellas] numeric(18)  NULL ,
	[Cal_Descripcion] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Ven_Codigo] numeric(18) NOT NULL
	CONSTRAINT [PK_Calificaciones] PRIMARY KEY CLUSTERED ([Cal_Codigo]) 
	CONSTRAINT [FK_Calificaciones_Ventas] FOREIGN KEY ([Ven_Codigo])  REFERENCES [C_R].[Ventas]([Ven_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

ALTER TABLE [C_R].[Calificaciones]
	ADD CONSTRAINT [UQ_Venta] UNIQUE ([Ven_Codigo]  ASC)
GO

CREATE TABLE [C_R].[Preguntas]
( 
	[Pre_Id]              int		     NOT NULL  IDENTITY ( 1,1 ) ,
	[Pub_Codigo]          numeric(18,0)  NOT NULL ,
	[Pre_Texto]           varchar(255)   NOT NULL ,
	[Pre_Fecha]           datetime       NOT NULL DEFAULT GETDATE(),
	[User_Id]             int		     NOT NULL
	CONSTRAINT [PK_Preguntas] PRIMARY KEY  CLUSTERED ([Pre_Id] ASC),
	CONSTRAINT [FK_Preguntas_Publicaciones] FOREIGN KEY ([Pub_Codigo]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT [FK_Preguntas_Usuarios] FOREIGN KEY ([User_Id]) REFERENCES [C_R].[Usuarios]([User_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

CREATE TABLE [C_R].[Respuestas]
( 
	[Res_Id]              int		     NOT NULL  IDENTITY ( 1,1 ) ,
	[Pre_Id]              int			 NOT NULL ,
	[Res_Fecha]           datetime       NOT NULL DEFAULT GETDATE(),
	[Res_Texto]           varchar(255)   NOT NULL
	CONSTRAINT [PK_Respuestas] PRIMARY KEY  CLUSTERED ([Res_Id] ASC),
	CONSTRAINT [FK_Respuestas_Preguntas] FOREIGN KEY ([Pre_Id]) REFERENCES [C_R].[Preguntas]([Pre_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT [UQ_Respuesta_Pregunta] UNIQUE ([Pre_Id] ASC)
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
GO
-- FUNCIONALIDADES
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('ABM Roles');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('ABM Clientes');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('ABM Empresas');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('ABM Visibilidad');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Publicacion Nueva');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Publicacion Editar');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Historial Ofertas');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Historial Compras');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Historial Calificaciones');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Calificar Vendedor');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Preguntas Recibidas');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Preguntas Hechas');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Cliente Facturar Publicaciones');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Empresa Publicacion Nueva');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Empresa Publicacion Editar');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Empresa Historial Calificaciones');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Empresa Preguntas Recibidas');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Empresa Facturar Publicaciones');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Admin Facturar Publicaciones');
INSERT INTO C_R.Sis_Funciones(Sis_Fun_Des) VALUES ('Admin Estadisticas');

INSERT INTO C_R.RL_Roles_Funciones(Rol_Id, Sis_Fun_Id, Estado)
SELECT CASE
		WHEN Sis_Fun_Des LIKE 'ABM%' THEN 2 -- Administrativo  
		WHEN Sis_Fun_Des LIKE 'Cliente%' THEN 3 -- Cliente
		WHEN Sis_Fun_Des LIKE 'Empresa%' THEN 1 -- Empresa
		WHEN Sis_Fun_Des LIKE 'Admin%' THEN 2 -- Administrativo
	   END,
	  Sis_Fun_Id, 'ACTIVO'
FROM C_R.Sis_Funciones;

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

-- creacion usuario admin
-- hash para password "w23a"
INSERT INTO C_R.Usuarios(User_Name, User_Password, User_CambioPass) values
	('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0)
GO

INSERT INTO C_R.RL_Usuarios_Roles(Rol_Id, User_Id) VALUES (2,1)
GO

CREATE PROCEDURE C_R.SP_CLIENTE_SAVE
@Cli_Id int,
@Cli_Nombre varchar(255),
@Cli_Apellido varchar(255),
@Des_Corta varchar(10),
@Cli_Doc numeric(18),
@Cli_Cuil varchar(18),
@Cli_Fecha_Nac datetime,
@Cli_Mail varchar(255),
@Cli_Dir_Calle varchar(255),
@Cli_Dir_Nro numeric(18),
@Cli_Dir_Piso numeric(18),
@Cli_Dir_CodPostal varchar(50),
@Cli_Dir_Depto varchar(50),
@Cli_Dir_Localidad varchar(50),
@Cli_Telefono varchar(50),
@User_Estado varchar(10),
@User_Nombre varchar(255),
@User_Password varchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @Cli_TipoDoc int
	DECLARE @User_Id int
	
	SELECT @Cli_TipoDoc = Cli_TipoDoc FROM C_R.Tipo_Docs WHERE Des_Corta = @Des_Corta
	
	IF (@Cli_Id IS NULL)
	BEGIN
	
		DECLARE @Cambio_Pass int
		
		SET @Cambio_Pass = 0
		
		IF ( @User_Nombre IS NULL )
		BEGIN
			SET @User_Nombre = SUBSTRING(@Cli_Nombre,1,1)+@Cli_Apellido +Convert(varchar,(YEAR(@Cli_Fecha_Nac)))
			-- hash para password "changeme"
			SET @User_Password = '057ba03d6c44104863dc7361fe4578965d1887360f90a0895882e58a6248fc86'
			SET @Cambio_Pass = 1
		END
		
		BEGIN TRANSACTION TR_CLIENTE
		
		INSERT INTO C_R.Usuarios
			(User_Name
			,User_Password
			,User_CambioPass) 
		VALUES
			(@User_Nombre
			,@User_Password
			,@Cambio_Pass)
			
		SET @User_Id = SCOPE_IDENTITY()
		
		INSERT INTO C_R.Clientes 
			(Cli_TipoDoc
			,Cli_Doc
			,Cli_Cuil
			,Cli_Nombre
			,Cli_Apellido
			,Cli_Fecha_Nac
			,Cli_Mail
			,Cli_User_Id
			,Cli_Dir_Calle
			,Cli_Dir_Nro
			,Cli_Dir_Piso
			,Cli_Dir_CodPostal
			,Cli_Dir_Depto
			,Cli_Dir_Localidad
			,Cli_Telefono)
		VALUES
			(@Cli_TipoDoc
			,@Cli_Doc
			,@Cli_Cuil
			,@Cli_Nombre
			,@Cli_Apellido
			,@Cli_Fecha_Nac
			,@Cli_Mail
			,@User_Id
			,@Cli_Dir_Calle
			,@Cli_Dir_Nro
			,@Cli_Dir_Piso
			,@Cli_Dir_CodPostal
			,@Cli_Dir_Depto
			,@Cli_Dir_Localidad
			,@Cli_Telefono)
			

		INSERT INTO C_R.RL_Usuarios_Roles
			(Rol_Id
			,User_Id)
		VALUES
			((SELECT Rol_Id FROM C_R.Roles WHERE Rol_Descripcion = 'cliente')
			,@User_Id)
			
		COMMIT TRANSACTION TR_CLIENTE
		
		RETURN

	END
	
	SELECT @User_Id = Cli_User_Id FROM C_R.Clientes where Cli_Id = @Cli_Id
	
	UPDATE C_R.Clientes
	SET
		Cli_Nombre = @Cli_Nombre,
		Cli_Apellido = @Cli_Apellido,
		Cli_TipoDoc = @Cli_TipoDoc,
		Cli_Doc = @Cli_Doc,
		Cli_Cuil = @Cli_Cuil,
		Cli_Fecha_Nac = @Cli_Fecha_Nac,
		Cli_Mail = @Cli_Mail,
		Cli_Dir_Calle = @Cli_Dir_Calle,
		Cli_Dir_Nro = @Cli_Dir_Nro,
		Cli_Dir_CodPostal = @Cli_Dir_CodPostal,
		Cli_Dir_Depto = @Cli_Dir_Depto,
		Cli_Dir_Localidad = @Cli_Dir_Localidad,
		Cli_Telefono = @Cli_Telefono
	WHERE
		Cli_Id = @Cli_Id
		
	UPDATE C_R.Usuarios
	SET
		User_Estado = @User_Estado
	WHERE
		User_Id = @User_Id
	
END
GO

-- Insercion de clientes
DECLARE @Des_Corta varchar(10),
		@Cli_Doc numeric(18),
		@Cli_Cuil varchar(18),
		@Cli_Nombre varchar(255),
		@Cli_Apellido varchar(255),
		@Cli_Fecha_Nac datetime,
		@Cli_Mail varchar(255),
		@Cli_Dir_Calle varchar(255),
		@Cli_Dir_Nro numeric(18),
		@Cli_Dir_Piso numeric(18),
		@Cli_Dir_CodPostal varchar(50),
		@Cli_Dir_Depto varchar(50),
		@Cli_Dir_Localidad varchar(50),
		@Cli_Telefono varchar(50)

DECLARE clientes_cursor CURSOR FOR  
select DISTINCT	'DNI' Des_Corta,
Publ_Cli_Dni Cli_Doc,
Publ_Cli_Nombre Cli_Nombre,
Publ_Cli_Apeliido Cli_Apellido,
Publ_Cli_Fecha_Nac Cli_Fecha_Nac,
Publ_Cli_Mail Cli_Mail,
Publ_Cli_Dom_Calle, 
Publ_Cli_Nro_Calle, 
Publ_Cli_Piso, 
Publ_Cli_Cod_Postal, 
Publ_Cli_Depto,
'LOC No asignada'
from gd_esquema.Maestra
where  Publ_Cli_Dni is not null or Publ_Cli_Apeliido is not null or Publ_Cli_Nombre is not null
order by 1

OPEN clientes_cursor		
FETCH NEXT FROM clientes_cursor INTO @Des_Corta, @Cli_Doc, @Cli_Nombre, @Cli_Apellido, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dir_Calle, @Cli_Dir_Nro, @Cli_Dir_Piso, @Cli_Dir_CodPostal, @Cli_Dir_Depto, @Cli_Dir_Localidad
WHILE @@FETCH_STATUS = 0   
BEGIN   
   SET @Cli_Telefono = 'MIG-' + substring(convert(varchar(50), newID()),1,20)
   SET @Cli_Cuil = SUBSTRING(CAST(@Cli_Doc AS varchar),1,2) + '-' + CAST(@Cli_Doc AS varchar) + '-' + SUBSTRING(CAST(@Cli_Doc AS varchar),3,1)
   EXEC C_R.SP_CLIENTE_SAVE NULL, @Cli_Nombre, @Cli_Apellido, @Des_Corta, @Cli_Doc, @Cli_Cuil, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dir_Calle, @Cli_Dir_Nro, @Cli_Dir_Piso, @Cli_Dir_CodPostal, @Cli_Dir_Depto, @Cli_Dir_Localidad, @Cli_Telefono, NULL, NULL, NULL
   FETCH NEXT FROM clientes_cursor INTO @Des_Corta, @Cli_Doc, @Cli_Nombre, @Cli_Apellido, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dir_Calle, @Cli_Dir_Nro, @Cli_Dir_Piso, @Cli_Dir_CodPostal, @Cli_Dir_Depto, @Cli_Dir_Localidad
   
END   

CLOSE clientes_cursor   
DEALLOCATE clientes_cursor
GO

CREATE PROCEDURE C_R.SP_EMPRESA_SAVE
@Emp_Id int,
@Emp_Cuit varchar(50),
@Emp_RazonSocial varchar(255),
@Emp_Fecha_Creacion datetime,
@Emp_Mail varchar(255),
@Emp_Contacto varchar(255),
@Emp_Telefono varchar(50),
@Emp_Dir_Ciudad varchar(255),
@Emp_Dir_Calle varchar(255),
@Emp_Dir_Nro numeric(18),
@Emp_Dir_Piso numeric(18),
@Emp_Dir_CodPostal varchar(50),
@Emp_Dir_Depto varchar(50),
@Emp_Dir_Localidad varchar(50),
@User_Estado varchar(10),
@User_Nombre varchar(255),
@User_Password varchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @User_Id int
	
	IF (@Emp_Id IS NULL)
	BEGIN
	
		DECLARE @Cambio_Pass int
		
		SET @Cambio_Pass = 0
	
		IF ( @User_Nombre IS NULL )
		BEGIN
			SET @User_Nombre = REPLACE(@Emp_Cuit,'-','')
			-- hash para password "changeme"
			SET @User_Password = '057ba03d6c44104863dc7361fe4578965d1887360f90a0895882e58a6248fc86'
			SET @Cambio_Pass = 1
		END
		
		BEGIN TRANSACTION TR_EMPRESA
		
		INSERT INTO C_R.Usuarios
			(User_Name
			,User_Password
			,User_CambioPass) 
		VALUES
			(@User_Nombre
			,@User_Password
			,@Cambio_Pass)
			
		SET @User_Id = SCOPE_IDENTITY()
		
		INSERT INTO C_R.Empresas 
			(Emp_Fecha_Creacion
			,Emp_Mail
			,Emp_Contacto
			,Emp_RazonSocial
			,Emp_Cuit
			,Emp_User_Id
			,Emp_Dir_Ciudad
			,Emp_Dir_Calle
			,Emp_Dir_Nro
			,Emp_Dir_Piso
			,Emp_Dir_CodPostal
			,Emp_Dir_Depto
			,Emp_Dir_Localidad
			,Emp_Telefono)
		VALUES
			(@Emp_Fecha_Creacion
			,@Emp_Mail
			,@Emp_Contacto
			,@Emp_RazonSocial
			,@Emp_Cuit
			,@User_Id
			,@Emp_Dir_Ciudad
			,@Emp_Dir_Calle
			,@Emp_Dir_Nro
			,@Emp_Dir_Piso
			,@Emp_Dir_CodPostal
			,@Emp_Dir_Depto
			,@Emp_Dir_Localidad
			,@Emp_Telefono)
			
		INSERT INTO C_R.RL_Usuarios_Roles
			(Rol_Id
			,User_Id)
		VALUES
			((SELECT Rol_Id FROM C_R.Roles WHERE Rol_Descripcion = 'empresa')
			,@User_Id)
		
		COMMIT TRANSACTION TR_EMPRESA
		
		RETURN

	END
	
	SELECT @User_Id = Emp_User_Id FROM C_R.Empresas where Emp_Id = @Emp_Id
	
	UPDATE C_R.Empresas
	SET
		Emp_Fecha_Creacion = @Emp_Fecha_Creacion,
		Emp_Mail = @Emp_Mail,
		Emp_Contacto = @Emp_Contacto,
		Emp_RazonSocial = @Emp_RazonSocial,
		Emp_Cuit = @Emp_Cuit,
		Emp_Dir_Ciudad = @Emp_Dir_Ciudad,
		Emp_Dir_Calle = @Emp_Dir_Calle,
		Emp_Dir_Nro = @Emp_Dir_Nro,
		Emp_Dir_Piso = @Emp_Dir_Piso,
		Emp_Dir_CodPostal = @Emp_Dir_CodPostal,
		Emp_Dir_Depto = @Emp_Dir_Depto,
		Emp_Dir_Localidad = @Emp_Dir_Localidad,
		Emp_Telefono = @Emp_Telefono
	WHERE
		Emp_Id = @Emp_Id
		
	UPDATE C_R.Usuarios
	SET
		User_Estado = @User_Estado
	WHERE
		User_Id = @User_Id
	
END
GO

-- Insert de Empresas
DECLARE @Emp_Cuit varchar(50),
		@Emp_RazonSocial varchar(255),
		@Emp_Fecha_Creacion datetime,
		@Emp_Contacto varchar(255),
		@Emp_Mail varchar(255),
		@Emp_Telefono varchar(50),
		@Emp_Dir_Ciudad varchar(255),
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
'CONTACTO No asignado',
REPLACE(REPLACE(Publ_Empresa_Mail,' ','_'),'�:',''),
'CIUDAD No asignada',
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
FETCH NEXT FROM empresas_cursor INTO @Emp_Cuit, @Emp_RazonSocial, @Emp_Fecha_Creacion, @Emp_Contacto, @Emp_Mail, @Emp_Dir_Ciudad, @Emp_Dir_Calle, @Emp_Dir_Nro, @Emp_Dir_Piso, @Emp_Dir_CodPostal, @Emp_Dir_Depto, @Emp_Dir_Localidad
WHILE @@FETCH_STATUS = 0   

BEGIN
   SET @Emp_Telefono = 'MIG-' + substring(convert(varchar(50), newID()),1,20)
   EXEC C_R.SP_EMPRESA_SAVE NULL, @Emp_Cuit, @Emp_RazonSocial, @Emp_Fecha_Creacion, @Emp_Mail, @Emp_Contacto, @Emp_Telefono, @Emp_Dir_Ciudad, @Emp_Dir_Calle, @Emp_Dir_Nro, @Emp_Dir_Piso, @Emp_Dir_CodPostal, @Emp_Dir_Depto, @Emp_Dir_Localidad, NULL, NULL, NULL
   FETCH NEXT FROM empresas_cursor INTO @Emp_Cuit, @Emp_RazonSocial, @Emp_Fecha_Creacion, @Emp_Contacto, @Emp_Mail, @Emp_Dir_Ciudad, @Emp_Dir_Calle, @Emp_Dir_Nro, @Emp_Dir_Piso, @Emp_Dir_CodPostal, @Emp_Dir_Depto, @Emp_Dir_Localidad
   
END   

CLOSE empresas_cursor   
DEALLOCATE empresas_cursor
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
INSERT INTO C_R.Publicaciones_Visibilidad (Pub_Visible_Descripcion,Pub_Visible_Precio,Pub_Visible_Porcentaje,Pub_Visible_Duracion)
SELECT gd_esquema.Maestra.Publicacion_Visibilidad_Desc
      ,Publicacion_Visibilidad_Precio
      ,Publicacion_Visibilidad_Porcentaje
      ,CASE WHEN Publicacion_Visibilidad_Precio = 0 THEN 7
       ELSE CAST(Publicacion_Visibilidad_Precio / 5 AS INT)
       END 
FROM gd_esquema.Maestra
GROUP BY gd_esquema.Maestra.Publicacion_Visibilidad_Desc ,Publicacion_Visibilidad_Precio,Publicacion_Visibilidad_Porcentaje
GO

--Publicaciones Clientes
SET IDENTITY_INSERT C_R.Publicaciones on; 
INSERT INTO C_R.Publicaciones(Pub_Codigo, Pub_Descripcion, Pub_Stock, Pub_Fecha, Pub_Fecha_Venc, Pub_Precio, Pub_Visible_Cod, Pub_Tipo_Id, Pub_Estado_Id, Pub_User_Id) 
SELECT  Publicacion_Cod,
		Publicacion_Descripcion,
		Publicacion_Stock,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Precio,
		(SELECT C_R.Publicaciones_Visibilidad.Pub_Visible_Cod  FROM C_R.Publicaciones_Visibilidad WHERE C_R.Publicaciones_Visibilidad.Pub_Visible_Descripcion = gd_esquema.Maestra.Publicacion_Visibilidad_Desc),  
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
SET IDENTITY_INSERT C_R.Publicaciones off;
GO


--Publicaciones empresas
SET IDENTITY_INSERT C_R.Publicaciones on;
INSERT INTO C_R.Publicaciones(Pub_Codigo, Pub_Descripcion, Pub_Stock, Pub_Fecha, Pub_Fecha_Venc, Pub_Precio, Pub_Visible_Cod, Pub_Tipo_Id, Pub_Estado_Id, Pub_User_Id)
SELECT  Publicacion_Cod,
		Publicacion_Descripcion,
		Publicacion_Stock,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Precio,
		(SELECT C_R.Publicaciones_Visibilidad.Pub_Visible_Cod  FROM C_R.Publicaciones_Visibilidad WHERE C_R.Publicaciones_Visibilidad.Pub_Visible_Descripcion = gd_esquema.Maestra.Publicacion_Visibilidad_Desc),  
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
SET IDENTITY_INSERT C_R.Publicaciones off;
GO

INSERT INTO C_R.RL_Publicaciones_Rubros(Pub_Codigo, Pub_RubroId)
SELECT Publicacion_Cod, R.Pub_RubroId from gd_esquema.Maestra, C_R.Publicaciones_Rubro R
WHERE Publicacion_Rubro_Descripcion = R.Pub_Descripcion
GROUP BY Publicacion_Cod, R.Pub_RubroId
GO

INSERT INTO C_R.Ofertas ( Pub_Codigo, Ofe_User_Id, Ofe_Fecha, Ope_Monto ) 
select Publicacion_Cod, 
(SELECT C.Cli_User_Id from C_R.Clientes C where C.Cli_Doc = gd_esquema.Maestra.Cli_Dni ),
oferta_fecha,
Oferta_Monto
from gd_esquema.Maestra
where publicacion_tipo = 'subasta' and Oferta_Fecha is not null
GO

INSERT INTO C_R.Ventas ( Pub_Codigo, Ven_User_Id, Ven_Fecha, Ven_Monto, Ven_Cantidad ) 
select Publicacion_Cod, 
(SELECT C.Cli_User_Id from C_R.Clientes C where C.Cli_Doc = gd_esquema.Maestra.Cli_Dni ),
Compra_Fecha,
case 
	when publicacion_tipo = 'compra inmediata' then Publicacion_Precio
	when publicacion_tipo = 'subasta' then ( SELECT MAX(M1.Oferta_Monto) FROM gd_esquema.Maestra M1 WHERE  M1.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod and M1.Oferta_Monto IS NOT NULL)
end,
SUM(Compra_Cantidad) 
from gd_esquema.Maestra
where Compra_Fecha is not null and Calificacion_Codigo is null
group by Publicacion_Cod, Cli_Dni, Compra_Fecha, Publicacion_Tipo, Publicacion_Precio
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
SET IDENTITY_INSERT C_R.Calificaciones ON
insert into C_R.Calificaciones(Cal_Codigo, Cal_CantEstrellas, Cal_Descripcion, Ven_Codigo)
select m.Calificacion_Codigo,m.Calificacion_Cant_Estrellas,m.Calificacion_Descripcion,v.Ven_Codigo 
from gd_esquema.Maestra m inner join C_R.Ventas v
on m.Publicacion_Cod = v.Pub_Codigo and m.Compra_Fecha = v.Ven_Fecha and m.Compra_Cantidad = v.Ven_Cantidad
where m.Calificacion_Codigo is not null
and m.Calificacion_Codigo not in ( select Inc_Calificacion_Codigo from C_R.Inconsistencias_Calificaciones where Inc_Calificacion_Codigo is not null )
and v.Ven_User_Id = ( select c.Cli_User_Id from C_R.Clientes c where c.Cli_Doc = m.Cli_Dni )
SET IDENTITY_INSERT C_R.Calificaciones OFF
GO

-- FORMAS DE PAGO
insert into C_R.Factura_FormaPago(Factura_FP_Desc) values ('Efectivo')
insert into C_R.Factura_FormaPago(Factura_FP_Desc) values ('Tarjeta');

-- FACTURAS
SET IDENTITY_INSERT C_R.Factura on;
insert into C_R.Factura(Factura_Nro, Factura_Fecha, Factura_Total, Factura_FP_ID)
select distinct M.Factura_Nro, M.Factura_Fecha, M.Factura_Total, 
(select Factura_FP_ID from C_R.Factura_FormaPago where Factura_FP_Desc = M.Forma_Pago_Desc) as FP
from gd_esquema.Maestra M
where M.Factura_Nro is not null
SET IDENTITY_INSERT C_R.Factura off;

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
@fecha datetime,
@resultado tinyint OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @hash varchar(255)
	DECLARE @estado varchar(10)
	DECLARE @eliminado bit
	DECLARE @cambio_pass bit
	
	select @hash = User_Password, @estado = User_Estado, @cambio_pass = User_CambioPass, @eliminado = User_Eliminado
	from C_R.Usuarios 
	where User_Name = @nombre
	
	IF ( @estado IS NULL )
	BEGIN
		SET @resultado = 2
		RETURN
	END
	
	IF ( @eliminado = 1 )
	BEGIN
		SET @resultado = 6
		RETURN
	END
	
	IF ( @estado = 'INACTIVO' )
	BEGIN
		SET @resultado = 5
		RETURN
	END
	
	IF ( @hash = @password COLLATE Latin1_General_CS_AS )
	BEGIN
	
		update C_R.Usuarios set User_Log_Error = '0', User_Ultimo_Ingreso = @fecha 
		where User_Name = @nombre
		
		IF ( @cambio_pass = 1 AND @nuevo_password IS NULL )
		BEGIN
			SET @resultado = 10
			RETURN
		END
		
		IF ( @nuevo_password IS NOT NULL )
		BEGIN
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

CREATE PROCEDURE C_R.SP_Visibilidad_SAVE(@Codigo int,@Descripcion varchar(255),@Precio numeric(18,2),@Porc numeric(18,2),@Estado varchar(15),@Duracion int)
AS
BEGIN
  if (@Codigo =-1)
  Begin
	INSERT INTO [GD1C2014].[C_R].[Publicaciones_Visibilidad]
		   ([Pub_Visible_Descripcion]
		   ,[Pub_Visible_Precio]
		   ,[Pub_Visible_Porcentaje]
		   ,[Pub_Visible_Estado]
		   ,[Pub_Visible_Duracion])
	 VALUES
		   (@Descripcion,
			@Precio,
		    @Porc,
		    @Estado,
		    @Duracion)
	end
	else
	begin
		UPDATE Publicaciones_Visibilidad
		set 
			Pub_Visible_Descripcion = @Descripcion,
			Pub_Visible_Precio = @Precio,
			Pub_Visible_Porcentaje = @Porc,
			Pub_Visible_Estado = @Estado,
			Pub_Visible_Duracion = @Duracion
		where 
		Publicaciones_Visibilidad.Pub_Visible_Cod = @Codigo
	end

END
GO

CREATE TYPE C_R.FuncionesTableType AS TABLE
(Funcion varchar(255))
GO

CREATE PROCEDURE C_R.SP_Rol_SAVE(@Codigo int,@Descripcion nvarchar(50),@Estado varchar(50), @Funciones C_R.FuncionesTableType READONLY)
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
	
	DECLARE @RolId int
	SET @RolId = SCOPE_IDENTITY()
	
	INSERT INTO C_R.RL_Roles_Funciones(Rol_Id,Sis_Fun_Id,Estado)
	SELECT @RolId, Sis_Fun_Id, 'ACTIVO' FROM C_R.Sis_Funciones F, @Funciones Fun
	WHERE Fun.Funcion = F.Sis_Fun_Des		
	
	end
	else
	begin
		UPDATE Roles
		set 
			Rol_Descripcion = @Descripcion ,
			Rol_Estado = @Estado
		where 
		Rol_Id = @Codigo
		
		DELETE C_R.RL_Roles_Funciones WHERE Rol_Id = @Codigo
		
		INSERT INTO C_R.RL_Roles_Funciones(Rol_Id,Sis_Fun_Id,Estado)
		SELECT @Codigo, Sis_Fun_Id, 'ACTIVO' FROM C_R.Sis_Funciones F, @Funciones Fun
		WHERE Fun.Funcion = F.Sis_Fun_Des		
		
	end
END
GO

CREATE TYPE C_R.RubrosTableType AS TABLE
(Rubro varchar(255))
GO

CREATE PROCEDURE C_R.SP_Publicacion_SAVE(@Codigo int, @Descripcion nvarchar(255)
			, @Stock numeric(18), @Fecha datetime
			, @Fecha_Venc datetime, @Precio numeric(18,2)
			, @Visibilidad nvarchar(255), @Rubros C_R.RubrosTableType READONLY
			, @Tipo nvarchar(255), @Estado nvarchar(255), @Usuario int, @Preguntas bit
			)
AS
BEGIN

	IF (@Codigo =-1)
		BEGIN
			INSERT INTO C_R.Publicaciones
				   (Pub_Descripcion
				   ,Pub_Stock
				   ,Pub_Fecha
				   ,Pub_Precio
				   ,Pub_Visible_Cod
				   ,Pub_Tipo_Id
				   ,Pub_Estado_Id
				   ,Pub_Fecha_Venc
				   ,Pub_User_Id
				   ,Pub_Preguntas)
			SELECT @Descripcion, @Stock, @Fecha, @Precio
				,(SELECT Pub_Visible_Cod FROM C_R.Publicaciones_Visibilidad where Pub_Visible_Descripcion = @Visibilidad)
				,(SELECT Pub_Tipo FROM C_R.Publicaciones_Tipo where Pub_Descripcion = @Tipo)
				,(SELECT Pub_Estado_Id FROM C_R.Publicaciones_Estados where Pub_Estado_Desc = @Estado)
				,(SELECT DATEADD(DAY, Pub_Visible_Duracion,@Fecha) FROM C_R.Publicaciones_Visibilidad where Pub_Visible_Descripcion = @Visibilidad)
				, @Usuario, @Preguntas
				
			DECLARE @Pub_Codigo numeric(18,0)	
			
			SET @Pub_Codigo = SCOPE_IDENTITY()
				
			INSERT INTO C_R.RL_Publicaciones_Rubros(Pub_Codigo, Pub_RubroId)
			SELECT @Pub_Codigo, Pub_RubroId FROM C_R.Publicaciones_Rubro P_R, @Rubros R where P_R.Pub_Descripcion = R.Rubro
				
		END
	ELSE
		BEGIN
			UPDATE C_R.Publicaciones SET
				Pub_Descripcion = @Descripcion
				,Pub_Stock = @Stock
				   ,Pub_Fecha = @Fecha
				   ,Pub_Precio = @Precio
				   ,Pub_Visible_Cod = (SELECT Pub_Visible_Cod FROM C_R.Publicaciones_Visibilidad where Pub_Visible_Descripcion = @Visibilidad)
				   ,Pub_Tipo_Id = (SELECT Pub_Tipo FROM C_R.Publicaciones_Tipo where Pub_Descripcion = @Tipo)
				   ,Pub_Estado_Id = (SELECT Pub_Estado_Id FROM C_R.Publicaciones_Estados where Pub_Estado_Desc = @Estado)
				   ,Pub_User_Id = @Usuario
				   ,Pub_Preguntas = @Preguntas
			WHERE Pub_Codigo = @Codigo
			
			DELETE C_R.RL_Publicaciones_Rubros WHERE Pub_Codigo = @Codigo
			
			INSERT INTO C_R.RL_Publicaciones_Rubros(Pub_Codigo, Pub_RubroId)
			SELECT @Codigo, Pub_RubroId FROM C_R.Publicaciones_Rubro P_R, @Rubros R where P_R.Pub_Descripcion = R.Rubro
				
		END		       
END
GO

CREATE VIEW C_R.Ofertas_Estado_VW AS
SELECT O.Ofe_Codigo, P.Pub_Descripcion, O.Ofe_User_Id, O.Ofe_Fecha, O.Ope_Monto, 
CASE
	WHEN O.Ope_Monto = (SELECT MAX(Ope_Monto) FROM C_R.Ofertas O1 WHERE O.Pub_Codigo = O1.Pub_Codigo)
	THEN 'GANADA'
	ELSE 'NO GANADA'
END Estado
FROM C_R.Ofertas O, C_R.Publicaciones P
WHERE O.Pub_Codigo = P.Pub_Codigo
GO

CREATE VIEW C_R.Compras_VW AS
SELECT P.Pub_Descripcion, V.Ven_Fecha, Ven_Monto, P.Pub_Precio, T.Pub_Descripcion Tipo, V.Ven_User_Id
FROM C_R.Ventas V, C_R.Publicaciones P, C_R.Publicaciones_Tipo T
WHERE V.Pub_Codigo = P.Pub_Codigo
AND P.Pub_Tipo_Id = T.Pub_Tipo
GO

CREATE VIEW C_R.Calificaciones_VW AS
SELECT V.Ven_Fecha Fecha, C.Cal_CantEstrellas Estrellas, 
C.Cal_Descripcion Descripcion, V.Ven_User_Id idComprador, P.Pub_User_Id idVendedor,
U_C.User_Name Comprador, U_V.User_Name Vendedor
FROM C_R.Calificaciones C, C_R.Ventas V, C_R.Publicaciones P, C_R.Usuarios U_V, C_R.Usuarios U_C
WHERE V.Ven_Codigo = C.Ven_Codigo AND P.Pub_Codigo = V.Pub_Codigo
AND U_C.User_Id = V.Ven_User_Id AND U_V.User_Id = P.Pub_User_Id
GO

CREATE VIEW C_R.Calificaciones_Pendientes_VW AS
SELECT P.Pub_Descripcion Publicacion, V.Ven_Cantidad Cantidad, V.Ven_Monto Monto, 
V.Ven_Codigo Venta, V.Ven_User_Id Comprador, U.User_Name Vendedor, V.Ven_Fecha Fecha
FROM C_R.Ventas V, C_R.Publicaciones P, C_R.Usuarios U
WHERE V.Pub_Codigo = P.Pub_Codigo AND U.User_Id = P.Pub_User_Id
AND NOT EXISTS (SELECT 1 FROM C_R.Calificaciones C WHERE C.Ven_Codigo = V.Ven_Codigo)
GO

CREATE VIEW C_R.Inhabilitados_Compra_Oferta_VW AS
SELECT Comprador FROM C_R.Calificaciones_Pendientes_VW
GROUP BY Comprador
HAVING COUNT(1) > 5
GO

-- Se agrega columan en Publicaciones_Visibilidad para eliminacion logica
-- PARCHE UPDATE
--ALTER TABLE C_R.Publicaciones_Visibilidad add	[Pub_Visible_Estado] nvarchar(10) DEFAULT 'ACTIVO'
--update C_R.Publicaciones_Visibilidad
--set Pub_Visible_Estado = 'ACTIVO'

CREATE VIEW C_R.Preguntas_Pendientes_VW AS
SELECT Pub.Pub_Descripcion, Pre.Pre_Texto, U.User_Name, Pre.Pre_Fecha, Pre.Pre_Id, Pub.Pub_User_Id 
from C_R.Publicaciones Pub, C_R.Usuarios U, C_R.Preguntas Pre 
LEFT JOIN C_R.Respuestas R ON R.Pre_Id = Pre.Pre_Id
WHERE Pre.Pub_Codigo = Pub.Pub_Codigo AND Pre.User_Id = U.User_Id
AND R.Res_Id IS NULL
GO

CREATE VIEW C_R.Respondidas_VW AS
SELECT Pub.Pub_Descripcion Publicacion, Pub.Pub_Precio Precio, Pub.Pub_Stock Stock, P_E.Pub_Estado_Desc Estado, P.Pre_Texto Pregunta, P.Pre_Fecha Fecha_Pregunta, R.Res_Texto Respuesta, P.User_Id
FROM C_R.Preguntas P LEFT JOIN C_R.Respuestas R ON R.Pre_Id = P.Pre_Id, 
C_R.Publicaciones Pub, C_R.Publicaciones_Estados P_E
WHERE Pub.Pub_Codigo = P.Pub_Codigo AND Pub.Pub_Estado_Id = P_E.Pub_Estado_Id
AND NOT Pub.Pub_Estado_Id = (SELECT Pub_Estado_Id FROM C_R.Publicaciones_Estados WHERE Pub_Estado_Desc = 'borrador')
GO

CREATE VIEW C_R.Ventas_No_Facturadas_VW AS
SELECT 
P.Pub_Descripcion Publicacion,
MAX(V.Ven_Fecha) Fecha_Finalizacion, SUM(V.Ven_Cantidad) Vendidos, 
SUM(CASE T.Pub_Descripcion WHEN 'Subasta' THEN V.Ven_Monto ELSE V.Ven_Monto * V.Ven_Cantidad END) Total, 
V.Ven_Monto Unitario, V.Pub_Codigo, P.Pub_User_Id Vendedor, P.Pub_Visible_Cod Visibilidad
FROM C_R.Publicaciones P, C_R.Publicaciones_Tipo T ,C_R.Ventas V LEFT JOIN C_R.Factura_Items F_I ON V.Pub_Codigo = F_I.Pub_Codigo
WHERE F_I.Item_Id IS NULL
AND P.Pub_Codigo = V.Pub_Codigo
AND T.Pub_Tipo = P.Pub_Tipo_Id
GROUP BY V.Pub_Codigo, P.Pub_User_Id, P.Pub_Descripcion, V.Ven_Monto, P.Pub_Visible_Cod
GO

CREATE VIEW C_R.Contador_Visibilidad_VW AS
SELECT P.Pub_User_Id, V.Pub_Visible_Cod, COUNT(P.Pub_Codigo) % 10 AS Facturadas from C_R.Factura_Items F, C_R.Publicaciones P, C_R.Publicaciones_Visibilidad V
WHERE F.Pub_Codigo = P.Pub_Codigo AND P.Pub_Visible_Cod = V.Pub_Visible_Cod
AND V.Pub_Visible_Porcentaje > 0
GROUP BY P.Pub_User_Id, V.Pub_Visible_Cod
GO

CREATE TYPE C_R.PublicacionesTableType AS TABLE
(Cantidad numeric(18,0), Unitario numeric(18,2), Publicacion varchar(50),Pub_Codigo numeric(18,0), Total numeric(18,2), Visibilidad int)
GO

CREATE PROCEDURE C_R.SP_FACTURAR
@Publicaciones C_R.PublicacionesTableType READONLY,
@FormaPago varchar(255),
@TarjetaTitular varchar(255),
@TarjetaNumero numeric(16,0),
@TarjetaVencimiento varchar(6),
@Usuario numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @FormaPagoId int
	DECLARE @TotalFactura decimal(18,2)
	DECLARE @FacturaId int
	
	SELECT @FormaPagoId = Factura_FP_ID FROM Factura_FormaPago WHERE Factura_FP_Desc = @FormaPago 
	
	DECLARE @CantidadFacturadas int, @Total numeric(18,2), @Vis_Porc numeric(18,2)
			, @Vis_Precio numeric(18,2), @Vis_Id numeric(18,0)
	
	DECLARE pub_cursor CURSOR FOR  
	SELECT P.Total, V.Pub_Visible_Porcentaje, V.Pub_Visible_Precio, P.Visibilidad FROM @Publicaciones P, C_R.Publicaciones_Visibilidad V
	WHERE P.Visibilidad = V.Pub_Visible_Cod
	SET @TotalFactura = 0
	OPEN pub_cursor		
		FETCH NEXT FROM pub_cursor INTO @Total, @Vis_Porc, @Vis_Precio, @Vis_Id
		WHILE @@FETCH_STATUS = 0   
			BEGIN
				SET @CantidadFacturadas = NULL   
				SELECT @CantidadFacturadas = Facturadas FROM C_R.Contador_Visibilidad_VW WHERE Pub_User_Id = @Usuario AND Pub_Visible_Cod = @Vis_Id;
				IF @CantidadFacturadas IS NULL OR @CantidadFacturadas < 9
				BEGIN
					SET	@TotalFactura = @TotalFactura + CAST(ROUND(@Total * @Vis_Porc,2) AS decimal(18,2)) + @Vis_Precio				
				END
				FETCH NEXT FROM pub_cursor INTO @Total, @Vis_Porc, @Vis_Precio, @Vis_Id
			END
	CLOSE pub_cursor   
	DEALLOCATE pub_cursor
	
	INSERT INTO C_R.Factura(Factura_FP_ID,Factura_Total,Factura_Tarjeta, Factura_Titular, Factura_Vencimiento_Tarj)
	VALUES (@FormaPagoId, @TotalFactura, @TarjetaNumero, @TarjetaTitular, @TarjetaVencimiento)
	
	SET @FacturaId = SCOPE_IDENTITY()
	
	INSERT INTO C_R.Factura_Items(Factura_Nro, Item_Cantidad, Item_Desc, Item_Monto, Pub_Codigo)
	SELECT @FacturaId, Cantidad, Publicacion, Unitario, Pub_Codigo FROM @Publicaciones
	
END
GO

CREATE PROCEDURE C_R.SP_Comprar
(
@Pub_Codigo numeric(18,0),
@Fecha datetime,
@Monto numeric(18,2),
@Cantidad numeric(18,0),
@Usuario int,
@Tipo varchar(255)
)
AS
BEGIN
	SET NOCOUNT ON;
	
	IF @Tipo = 'Subasta'
	BEGIN
		INSERT INTO C_R.Ofertas(Ofe_Fecha, Ofe_User_Id, Ope_Monto, Pub_Codigo)
		VALUES (@Fecha, @Usuario, @Monto, @Pub_Codigo)
	END
	ELSE
	BEGIN
		INSERT INTO C_R.Ventas(Pub_Codigo, Ven_Cantidad, Ven_Fecha, Ven_Monto, Ven_User_Id)
		VALUES(@Pub_Codigo, @Cantidad, @Fecha, @Monto, @Usuario)
		
		UPDATE C_R.Publicaciones SET Pub_Stock = Pub_Stock - @Cantidad WHERE Pub_Codigo = @Pub_Codigo
	END
	
END