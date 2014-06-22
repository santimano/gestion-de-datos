USE [GD1C2014]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--CREATE SCHEMA [C_R] AUTHORIZATION [gd]
--GO

if exists(select * from sys.objects where name ='Inconsistencias_Operaciones' and type = 'u')
	drop table [C_R].[Inconsistencias_Operaciones]
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

if exists(select * from sys.objects where name ='Operaciones_Calificadas' and type='u')
	drop table [C_R].[Operaciones_Calificadas]
go

if exists (select * from sys.objects where name = 'Operaciones' and type = 'u')
    drop table  [C_R].[Operaciones]
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

if exists (select * from sys.objects where name = 'RL_Clientes_Direccion' and type ='u')
	drop Table [C_R].[RL_Clientes_Direccion]
go

If exists( select * from Sys.objects where name='Direcciones' and type ='u')
	drop table [C_R].[Direcciones]
go

if exists (select * from sys.objects  where name='RL_Clientes_Roles' and type ='u')
	drop table [C_R].[RL_Clientes_Roles]
go

IF exists ( select * from sys.objects where name='Clientes' and type ='u')
	drop table [C_R].[Clientes]
go

if exists (select * from sys.objects where name= 'Tipo_Docs' and type ='u')
	drop table [C_R].[Tipo_Docs]
go

if exists(select * from sys.objects where name='Roles' and type ='u')
	drop table [C_R].[Roles]
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
	[Cli_UserName]       varchar(255)   NOT NULL ,
	[Cli_Password]       varchar(255)   NULL ,
	[Cli_Telefono]		 varchar(50)	NULL default 'MIG-' +substring(convert(varchar(50), newID()),1,20),
	[Emp_RazonSocial]    varchar(255)	NULL ,
	[Emp_Cuit]           varchar(50)	NULL ,
	[Cli_CambioPass]     bit			NULL ,
	[Cli_Estado]         varchar(10)  NULL  default 'ACTIVO',
	[Cli_Log_Error]		int  default 0 NOT NULL,
	[Cli_Ultimo_Ingreso]datetime		NULL
)
go

ALTER TABLE [C_R].[Clientes]
	ADD CONSTRAINT [PK_Clientes] PRIMARY KEY  CLUSTERED ([Cli_Id] ASC)
go

ALTER TABLE [C_R].[Clientes]
	ADD CONSTRAINT [UQ_Clientes_Usuario] UNIQUE ([Cli_UserName]  ASC)
go

ALTER TABLE [C_R].[Clientes]
	ADD CONSTRAINT [UQ_Cliente_Tel] UNIQUE ([Cli_Telefono] ASC)

CREATE TABLE [C_R].[Direcciones]
( 
	[Dir_Id]             int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Dir_Calle]          varchar(255)  NULL ,
	[Dir_Nro]            numeric(18)   NULL ,
	[Dir_Piso]           numeric(18)   NULL ,
	[Dir_CodPostal]      varchar(50)   NULL ,
	[Dir_Depto]          varchar(50)   NULL ,
	[Dir_Localidad]		 varchar(50)   NULL
)
go

ALTER TABLE [C_R].[Direcciones]
	ADD CONSTRAINT [PK_Direcciones] PRIMARY KEY  CLUSTERED ([Dir_Id] ASC)
go

CREATE TABLE [C_R].[Factura]
( 
	[Factura_Nro]       numeric(18)  NOT NULL ,
	[Factura_FP_ID]     int  NOT NULL ,
	[Factura_Fecha]     datetime  NOT NULL ,
	[Factura_Total]     numeric(18,2)  NOT NULL ,
	[Pub_Codigo]        numeric(18)  NOT NULL 
)
go

ALTER TABLE [C_R].[Factura]
	ADD CONSTRAINT [PK_Factura] PRIMARY KEY  CLUSTERED ([Factura_Nro] ASC)
go

CREATE TABLE [C_R].[Factura_Items]
( 
	[Item_Id]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Factura_Nro]        numeric(18)  NOT NULL ,
	[Item_Cantidad]      numeric(18)  NOT NULL ,
	[Item_Monto]         numeric(18,2)  NULL ,
	[Item_Desc]          varchar(50)  NULL 
)
go

ALTER TABLE [C_R].[Factura_Items]
	ADD CONSTRAINT [PK_Factura_Items] PRIMARY KEY  CLUSTERED ([Item_Id] ASC)
go

CREATE TABLE [C_R].[Factura_FormaPago]
( 
	[Factura_FP_ID]      int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Factura_FP_Desc]    varchar(255)  NULL 
)
go

ALTER TABLE [C_R].[Factura_FormaPago]
	ADD CONSTRAINT [PK_Factura_FormaPago] PRIMARY KEY  CLUSTERED ([Factura_FP_ID] ASC)
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
	[Cli_Id]             int  NULL 
)
go

ALTER TABLE [C_R].[Publicaciones]
	ADD CONSTRAINT [PK_Publicaciones] PRIMARY KEY  CLUSTERED ([Pub_Codigo] ASC)
go

CREATE TABLE [C_R].[Operaciones]
( 
	[Ope_Codigo]         numeric(18) IDENTITY(1,1) NOT NULL ,
	[Pub_Codigo]         numeric(18)  NULL ,
	[Cli_Id]             int  NULL ,
	[Ope_Fecha]          datetime  NULL ,
	[Ope_Tipo]           varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL ,
	[Ope_Monto]          numeric(18,2)  NULL ,
	[Ope_Cantidad]       numeric(18)  NULL 
)
go

ALTER TABLE [C_R].[Operaciones]
	ADD CONSTRAINT [PK_Operaciones] PRIMARY KEY  CLUSTERED ([Ope_Codigo] ASC)
go

CREATE TABLE [C_R].[Publicaciones_Estados]
( 
	[Pub_Estado_Id]      int  NOT NULL ,
	[Pub_Estado_Desc]    nvarchar(255) NULL 
)
go


ALTER TABLE [C_R].[Publicaciones_Estados]
	ADD CONSTRAINT [PK_Publicaciones_Estados] PRIMARY KEY  CLUSTERED ([Pub_Estado_Id] ASC)
go

CREATE TABLE [C_R].[Publicaciones_Visibilidad]
( 
	[Pub_Visible_Cod]    numeric(18) IDENTITY (1,1)  NOT NULL ,
	[Pub_Visible_Descripcion] nvarchar(255) NOT NULL ,
	[Pub_Visible_Precio] numeric(18,2)  NOT NULL ,
	[Pub_Visible_Porcentaje] numeric(18,2)  NOT NULL 
)
go

ALTER TABLE [C_R].[Publicaciones_Visibilidad]
	ADD CONSTRAINT [PK_Publicaciones_Visibilidad] PRIMARY KEY  CLUSTERED ([Pub_Visible_Cod] ASC)
go

CREATE TABLE [C_R].[RL_Clientes_Direccion]
( 
	[Cli_Id]             int  NOT NULL ,
	[Dir_Id]             int  NOT NULL ,
	[Estado]             varchar(20) NULL 
)
go

ALTER TABLE [C_R].[RL_Clientes_Direccion]
	ADD CONSTRAINT [PK_RL_Clientes_Direccion] PRIMARY KEY  CLUSTERED ([Cli_Id] ASC,[Dir_Id] ASC)
go

CREATE TABLE [C_R].[Publicaciones_Rubro]
( 
	[Pub_RubroId]        int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Pub_Descripcion]    nvarchar(255) NULL 
)
go

ALTER TABLE [C_R].[Publicaciones_Rubro]
	ADD CONSTRAINT [PK_Publicaciones_Rubro] PRIMARY KEY  CLUSTERED ([Pub_RubroId] ASC)
go

CREATE TABLE [C_R].[Publicaciones_Tipo]
( 
	[Pub_Tipo]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Pub_Descripcion]    nvarchar(255) NULL 
)
go

ALTER TABLE [C_R].[Publicaciones_Tipo]
	ADD CONSTRAINT [PK_Publicaciones_Tipo] PRIMARY KEY  CLUSTERED ([Pub_Tipo] ASC)
go

CREATE TABLE [C_R].[Roles]
( 
	[Rol_Id]             int  NOT NULL ,
	[Rol_Descrupcion]    nvarchar(50)   NULL ,
	[Rol_Estado]         varchar(50)  NULL 
)
go

ALTER TABLE [C_R].[Roles]
	ADD CONSTRAINT [PK_Roles] PRIMARY KEY  CLUSTERED ([Rol_Id] ASC)
go

CREATE TABLE [C_R].[RL_Clientes_Roles]
( 
	[Rol_Id]             int  NOT NULL ,
	[Cli_Id]             int  NOT NULL 
)
go

ALTER TABLE [C_R].[RL_Clientes_Roles]
	ADD CONSTRAINT [PK_RL_Clientes_Roles] PRIMARY KEY  CLUSTERED ([Rol_Id] ASC,[Cli_Id] ASC)
go

CREATE TABLE [C_R].[Sis_Funciones]
( 
	[Sis_Fun_Id]         int  NOT NULL ,
	[Sis_Fun_Des]        varchar(255)   NULL 
)
go

ALTER TABLE [C_R].[Sis_Funciones]
	ADD CONSTRAINT [PK_Sis_Funciones] PRIMARY KEY  CLUSTERED ([Sis_Fun_Id] ASC)
go

CREATE TABLE [C_R].[RL_Roles_Funciones]
( 
	[Sis_Fun_Id]         int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Rol_Id]             int  NOT NULL ,
	[Estado]             nvarchar(50)  NULL 
)
go

ALTER TABLE [C_R].[RL_Roles_Funciones]
	ADD CONSTRAINT [PK_RL_Roles_Funciones] PRIMARY KEY  CLUSTERED ([Sis_Fun_Id] ASC,[Rol_Id] ASC)
go

CREATE TABLE [C_R].[Tipo_Docs]
(	
	[Cli_TipoDoc]        int  NOT NULL IDENTITY (1,1) ,
	[Descripcion]        varchar(100) NULL,
	[Des_Corta]			 varchar(10) null
	
)
go

ALTER TABLE [C_R].[Tipo_Docs]
	ADD CONSTRAINT [PK_Tipo_Docs] PRIMARY KEY  CLUSTERED ([Cli_TipoDoc] ASC)
go

CREATE TABLE [C_R].[Inconsistencias_Operaciones]
( 
	[Inc_Id]                          int  NOT NULL  IDENTITY ( 1,1 ) ,
	[Inc_Publicacion_Cod]             numeric(18) NOT NULL ,
	[Inc_Cli_Dni]                     numeric(18) NOT NULL ,
	[Inc_Compra_Fecha]                datetime NOT NULL ,
	[Inc_Compra_Cantidad]             numeric(18) NOT NULL ,
	[Inc_Calificacion_Codigo]         numeric(18) NULL ,
	[Inc_Calificacion_Cant_Estrellas] numeric(18) NULL,
	PRIMARY KEY CLUSTERED ([Inc_Id] ASC),
	FOREIGN KEY ([Inc_Publicacion_Cod]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go

ALTER TABLE [C_R].[Clientes]
	ADD CONSTRAINT [FK_Clientes_TipoDoc] FOREIGN KEY ([Cli_TipoDoc]) REFERENCES [C_R].[Tipo_Docs]([Cli_TipoDoc])
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

ALTER TABLE [C_R].[Factura]
	ADD CONSTRAINT [FK_Factura_Clientes] FOREIGN KEY ([Pub_Codigo]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
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
	ADD CONSTRAINT [FK_Publicaciones_Clientes] FOREIGN KEY ([Cli_Id]) REFERENCES [C_R].[Clientes]([Cli_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [C_R].[Operaciones]
	ADD CONSTRAINT [FK_Opercaiones_Clientes] FOREIGN KEY ([Cli_Id]) REFERENCES [C_R].[Clientes]([Cli_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[Operaciones]
	ADD CONSTRAINT [FK_Operaciones_Peblicaciones] FOREIGN KEY ([Pub_Codigo]) REFERENCES [C_R].[Publicaciones]([Pub_Codigo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [C_R].[RL_Clientes_Direccion]
	ADD CONSTRAINT [FK_Clientes_Direccion_Direcciones] FOREIGN KEY ([Dir_Id]) REFERENCES [C_R].[Direcciones]([Dir_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[RL_Clientes_Direccion]
	ADD CONSTRAINT [FK_Clientes_Drirecion_Clientes] FOREIGN KEY ([Cli_Id]) REFERENCES [C_R].[Clientes]([Cli_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [C_R].[RL_Clientes_Roles]
	ADD CONSTRAINT [FK_Clientes_Roles_Roles] FOREIGN KEY ([Rol_Id]) REFERENCES [C_R].[Roles]([Rol_Id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [C_R].[RL_Clientes_Roles]
	ADD CONSTRAINT [FK_Clientes_Roles_Clientes] FOREIGN KEY ([Cli_Id]) REFERENCES [C_R].[Clientes]([Cli_Id])
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

CREATE TABLE [C_R].[Operaciones_Calificadas]
	(
	[Ope_Cal_Codigo] numeric(18) NOT NULL,
	[Ope_Cal_CantEstrellas] numeric(18)  NULL ,
	[Ope_Cal_Descripcion] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL ,
	[Ope_Codigo] numeric(18) NOT NULL
	)
GO
ALTER TABLE  [C_R].[Operaciones_Calificadas]
	ADD Constraint [PK_Operaciones_Calificadas] PRIMARY KEY CLUSTERED ([Ope_Cal_Codigo]) 
	
GO

ALTER TABLE [C_R].[Operaciones_Calificadas] WITH CHECK
	ADD CONSTRAINT [FK_Operaciones_Califiacion] FOREIGN KEY ([Ope_Codigo])  REFERENCES [C_R].[Operaciones]([Ope_Codigo])
	ON DELETE NO ACTION
	ON UPDATE NO ACTION
GO


--Insercion de Roles
INSERT INTO C_R.Roles
VALUES(1,'Empresa','ACT')

INSERT INTO C_R.Roles
VALUES(2,'Administrativo','ACT')

INSERT INTO C_R.Roles
VALUES(3,'Cliente','ACT')
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
INSERT  C_R.Clientes ( Cli_TipoDoc, Cli_Doc, Cli_Nombre, Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_UserName, Cli_Password,  Emp_RazonSocial, Emp_Cuit, Cli_CambioPass, Cli_Estado, Cli_Log_Error,Cli_Ultimo_Ingreso )
select DISTINCT		1 Cli_TipoDoc,
Publ_Cli_Dni Cli_Doc,
Publ_Cli_Nombre Cli_Nombre,
Publ_Cli_Apeliido Cli_Apellido,
Publ_Cli_Fecha_Nac Cli_Fecha_Nac,
Publ_Cli_Mail Cli_Mail,
SUBSTRING(Publ_Cli_Nombre,1,1)+Publ_Cli_Apeliido +Convert(varchar,(YEAR(Publ_Cli_Fecha_Nac))) Cli_UserName,
'P4SSM1GR4D0' Cli_Password,
null Emp_RazonSocial,
null Emp_Cuit,
 1 Cli_CambioPass,'ACTIVO' Cli_Estado ,0 Cli_Log_Error,GETDATE()Cli_Ultimo_Ingreso
 from gd_esquema.Maestra
where  Publ_Cli_Dni is not null or Publ_Cli_Apeliido is not null or Publ_Cli_Nombre is not null
order by 1
Go

-- Insert de Empresas
insert  C_R.Clientes ( Cli_TipoDoc, Cli_Fecha_Nac, Cli_Mail, Cli_UserName, Cli_Password,  Emp_RazonSocial, Emp_Cuit, Cli_CambioPass, Cli_Estado, Cli_Log_Error,Cli_Ultimo_Ingreso )
select DISTINCT
7 tipodoc,
Publ_Empresa_Fecha_Creacion,
Publ_Empresa_Mail,
REPLACE(Publ_Empresa_Cuit,'-','') Usuario,
 'P4SSM1GR4D0' Pass,
Publ_Empresa_Razon_Social,
Publ_Empresa_Cuit,1,'ACTIVO',0,GETDATE()
 from gd_esquema.Maestra
where  Publ_Empresa_Cuit is not null or Publ_Empresa_Razon_Social is not null 
order by 1,2,3
Go

-- INSERCION DE DIRECIONES DE CLIENTE
INSERT INTO C_R.Direcciones (Dir_Calle,Dir_Nro,Dir_Piso,Dir_CodPostal,Dir_Depto,Dir_Localidad)
SELECT distinct  Publ_Cli_Dom_Calle, Publ_Cli_Nro_Calle, Publ_Cli_Piso, Publ_Cli_Cod_Postal, Publ_Cli_Depto,'LOC No asignada'
FROM gd_esquema.Maestra
WHERE Publ_Cli_Dom_Calle is not null
GO
-- INSERCION DE RELACION CLIENTE DIRECCION
INSERT INTO C_R.RL_Clientes_Direccion (Cli_Id,Dir_Id,Estado) 
SELECT distinct C.Cli_Id, D.Dir_Id,'ACTIVO'
FROM  gd_esquema.Maestra M join C_R.Clientes  C on ( M.Publ_Cli_Apeliido = C.Cli_Apellido and M.Publ_Cli_Nombre = C.Cli_Nombre and M.Publ_Cli_Dni = C.Cli_Doc)
	  join   C_R.Direcciones  D  on (M.Publ_Cli_Dom_Calle = D.Dir_Calle and M.Publ_Cli_Nro_Calle = D.Dir_Nro and M.Publ_Cli_Cod_Postal = d.Dir_CodPostal)
	  WHERE Publ_Cli_Dom_Calle is not null
GO

--Direciones empresas
INSERT INTO C_R.Direcciones (Dir_Calle,Dir_Nro,Dir_Piso,Dir_CodPostal,Dir_Depto,Dir_Localidad)
SELECT distinct Publ_Empresa_Dom_Calle, Publ_Empresa_Nro_Calle, Publ_Empresa_Piso,  Publ_Empresa_Cod_Postal,Publ_Empresa_Depto,'LOC No asignada'
FROM gd_esquema.Maestra
WHERE Publ_Empresa_Dom_Calle is not null
GO
-- Relaciones entre empresas y direcciones
INSERT INTO C_R.RL_Clientes_Direccion (Cli_Id,Dir_Id,Estado) 
SELECT distinct C.Cli_Id, D.Dir_Id,'ACTIVO'
FROM  gd_esquema.Maestra M join C_R.Clientes  C on ( m.Publ_Empresa_Razon_Social = C.Emp_RazonSocial and M.Publ_Empresa_Cuit  = C.Emp_Cuit  )
	  join   C_R.Direcciones  D  on (M.Publ_Empresa_Dom_Calle = D.Dir_Calle and M.Publ_Empresa_Nro_Calle = D.Dir_Nro and M.Publ_Empresa_Cod_Postal  = d.Dir_CodPostal)
	  WHERE m.Publ_Empresa_Dom_Calle  is not null
GO

-- Relacional de  Clientes- ROLES

INSERT INTO C_R.RL_Clientes_Roles 
SELECT  CASE (C_R.Clientes.Cli_TipoDoc ) 			
				WHEN 1 THEN  3 
				WHEN 7 THEN 1 END ,
		 C_R.Clientes.Cli_Id	
FROM C_R.Clientes
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
		(SELECT C_R.Clientes.Cli_Id FROM C_R.Clientes WHERE C_R.Clientes.Cli_TipoDoc= 1 and 
		 C_R.Clientes.Cli_Doc = gd_esquema.Maestra.Publ_Cli_Dni 
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
		(SELECT C_R.Clientes.Cli_Id FROM C_R.Clientes  
			WHERE C_R.Clientes.Cli_TipoDoc= 7 and 
				 C_R.Clientes.Emp_Cuit  = gd_esquema.Maestra.Publ_Empresa_Cuit 
				 )'IDCLIENTE'  
 FROM gd_esquema.Maestra
WHERE Compra_Fecha is null and Oferta_Fecha is null  and Publ_Empresa_Cuit  is not null and Factura_Nro is null 
GO


INSERT INTO C_R.Operaciones ( Pub_Codigo, Cli_Id, Ope_Fecha, Ope_Tipo, Ope_Monto, Ope_Cantidad) 
select Publicacion_Cod, 
(SELECT Cli_Id from C_R.Clientes where C_R.Clientes.Cli_Doc = gd_esquema.Maestra.Cli_Dni),
isnull(Compra_Fecha,oferta_fecha),
case 
when oferta_fecha is null then 'VENTA'
when Compra_Fecha is null then 'OFERTA'
end,
case 
	when publicacion_tipo = 'compra inmediata' then Publicacion_Precio
	when publicacion_tipo = 'subasta' and Compra_Fecha is not null then (SELECT MAX(M1.Oferta_Monto) FROM gd_esquema.Maestra M1 WHERE  M1.Publicacion_Cod = gd_esquema.Maestra.Publicacion_Cod )
	when publicacion_tipo = 'subasta' and Oferta_Fecha is not null then Oferta_Monto
	end,
Compra_Cantidad 
 from gd_esquema.Maestra
 where (Compra_Fecha is not null or Oferta_Fecha is not null) and Calificacion_Codigo is null
 GO
 
insert into C_R.Inconsistencias_Operaciones ( Inc_Publicacion_Cod, Inc_Cli_Dni, Inc_Compra_Fecha, Inc_Compra_Cantidad, Inc_Calificacion_Codigo, Inc_Calificacion_Cant_Estrellas )
select M.Publicacion_Cod,M.Cli_Dni,M.Compra_Fecha,M.Compra_Cantidad, M.Calificacion_Codigo, M.Calificacion_Cant_Estrellas
from gd_esquema.Maestra M inner join
(select Publicacion_Cod,Cli_Dni,Compra_Fecha,Compra_Cantidad 
 from gd_esquema.Maestra
 where Calificacion_Codigo is not null
 group by Publicacion_Cod,Cli_Dni,Compra_Fecha,Compra_Cantidad
 having COUNT(*) > 1) INC
on M.Publicacion_Cod = INC.Publicacion_Cod and M.Cli_Dni = INC.Cli_Dni and M.Compra_Fecha = INC.Compra_Fecha and M.Compra_Cantidad = INC.Compra_Cantidad
GO
 
insert into C_R.Operaciones_Calificadas
select m.Calificacion_Codigo,m.Calificacion_Cant_Estrellas,m.Calificacion_Descripcion,o.Ope_Codigo 
from gd_esquema.Maestra m inner join C_R.Operaciones o
on m.Publicacion_Cod = o.Pub_Codigo and m.Compra_Fecha = o.Ope_Fecha and m.Compra_Cantidad = o.Ope_Cantidad
where m.Calificacion_Codigo is not null
and m.Calificacion_Codigo not in ( select Inc_Calificacion_Codigo from C_R.Inconsistencias_Operaciones where Inc_Calificacion_Codigo is not null )
and o.Ope_Tipo = 'VENTA'
and o.Cli_Id = ( select c.Cli_Id from C_R.Clientes c where c.Cli_Doc = m.Cli_Dni )

-- FORMAS DE PAGO
insert into C_R.Factura_FormaPago(Factura_FP_Desc) values ('Efectivo')
insert into C_R.Factura_FormaPago(Factura_FP_Desc) values ('Tarjeta');

-- FACTURAS
insert into C_R.Factura(Factura_Nro, Factura_Fecha, Factura_Total, Factura_FP_ID, Pub_Codigo)
select distinct M.Factura_Nro, M.Factura_Fecha, M.Factura_Total, 
(select Factura_FP_ID from C_R.Factura_FormaPago where Factura_FP_Desc = M.Forma_Pago_Desc) as FP
, Publicacion_Cod 
from gd_esquema.Maestra M
where M.Factura_Nro is not null

-- ITEMS
insert into C_R.Factura_Items(Item_Monto, Item_Cantidad, Factura_Nro, Item_Desc)
select Item_Factura_Monto, Item_Factura_Cantidad, Factura_Nro, 'ITEM-MIG'
from gd_esquema.Maestra M
where M.Factura_Nro is not null
GO

if exists(select * from sys.objects where name ='SP_LOGIN' and type = 'P')
	drop procedure [C_R].[SP_LOGIN]
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	
	select @hash = Cli_Password, @estado = Cli_Estado, @cambio_pass = Cli_CambioPass
	from C_R.Clientes 
	where Cli_UserName = @nombre
	
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
	
		update C_R.Clientes set Cli_Log_Error = '0' 
		where Cli_UserName = @nombre
		
		IF ( @cambio_pass =	1 )
		BEGIN
			IF ( @nuevo_password IS NULL )
			BEGIN
				SET @resultado = 10
				RETURN
			END
			
			update C_R.Clientes 
			set Cli_Password = @nuevo_password, Cli_CambioPass = 0
			where Cli_UserName = @nombre
			
		END
		
		SET @resultado = 0
		
		RETURN
	END
	
	SET @resultado = 3
	DECLARE @logins_fallidos int
	
	select @logins_fallidos = (Cli_Log_Error + 1) 
	from C_R.Clientes 
	where Cli_UserName = @nombre
	
	update C_R.Clientes set Cli_Log_Error = @logins_fallidos
	where Cli_UserName = @nombre
	
	IF ( @logins_fallidos > 2 )
	BEGIN
		SET @resultado = 4
		update C_R.Clientes set Cli_Estado = 'INACTIVO'
		where Cli_UserName = @nombre
	END
END
GO
