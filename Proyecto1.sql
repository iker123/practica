USE [master]
GO
/****** Object:  Database [dbProyecto1]    Script Date: 03/06/2020 19:11:42 ******/
CREATE DATABASE [dbProyecto1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbProyecto1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbProyecto1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbProyecto1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbProyecto1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [dbProyecto1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbProyecto1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbProyecto1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbProyecto1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbProyecto1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbProyecto1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbProyecto1] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbProyecto1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbProyecto1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbProyecto1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbProyecto1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbProyecto1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbProyecto1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbProyecto1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbProyecto1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbProyecto1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbProyecto1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbProyecto1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbProyecto1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbProyecto1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbProyecto1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbProyecto1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbProyecto1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbProyecto1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbProyecto1] SET RECOVERY FULL 
GO
ALTER DATABASE [dbProyecto1] SET  MULTI_USER 
GO
ALTER DATABASE [dbProyecto1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbProyecto1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbProyecto1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbProyecto1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbProyecto1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbProyecto1', N'ON'
GO
ALTER DATABASE [dbProyecto1] SET QUERY_STORE = OFF
GO
USE [dbProyecto1]
GO
/****** Object:  Table [dbo].[ciudades]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ciudades](
	[idciudades] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idciudades] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[idclientes] [int] IDENTITY(1,1) NOT NULL,
	[ciorud] [varchar](15) NOT NULL,
	[razonsocial] [varchar](250) NOT NULL,
	[direccion] [varchar](250) NULL,
	[telefono] [varchar](50) NULL,
	[correo] [varchar](250) NULL,
	[idprofesionales] [int] NULL,
	[idciudades] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idclientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesionales]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesionales](
	[idprofesionales] [int] IDENTITY(1,1) NOT NULL,
	[ciprofesional] [varchar](15) NULL,
	[nombres] [varchar](30) NULL,
	[apellidos] [varchar](70) NULL,
	[direccion] [varchar](250) NULL,
	[telefono] [varchar](50) NULL,
	[correo] [varchar](30) NULL,
	[idciudades] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idprofesionales] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[idusuarios] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](15) NOT NULL,
	[contrasena] [varchar](15) NOT NULL,
	[acceso] [varchar](20) NOT NULL,
	[idprofesionales] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [fk_idciudades2] FOREIGN KEY([idciudades])
REFERENCES [dbo].[ciudades] ([idciudades])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [fk_idciudades2]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [fk_idprofesionales] FOREIGN KEY([idprofesionales])
REFERENCES [dbo].[profesionales] ([idprofesionales])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [fk_idprofesionales]
GO
ALTER TABLE [dbo].[profesionales]  WITH CHECK ADD  CONSTRAINT [fk_idciudades] FOREIGN KEY([idciudades])
REFERENCES [dbo].[ciudades] ([idciudades])
GO
ALTER TABLE [dbo].[profesionales] CHECK CONSTRAINT [fk_idciudades]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [fk_idprofesionales2] FOREIGN KEY([idprofesionales])
REFERENCES [dbo].[profesionales] ([idprofesionales])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [fk_idprofesionales2]
GO
/****** Object:  StoredProcedure [dbo].[sp_mostarusuarios]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_mostarusuarios]
as
select dbo.usuarios.idusuarios, dbo.usuarios.usuario, dbo.usuarios.contrasena, dbo.usuarios.acceso, dbo.usuarios.idprofesionales,
		(dbo.profesionales.nombres+', '+dbo.profesionales.apellidos) as Profesional
from dbo.usuarios inner join dbo.profesionales on dbo.usuarios.idusuarios = dbo.profesionales.idprofesionales
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_cliente]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_cliente]
@textobuscarc varchar(50)
as
select * from clientes
where razonsocial like @textobuscarc + '%' or ciorud like @textobuscarc + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_clientes]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_clientes]
@textobuscarc varchar(50)
as
select * from clientes
where razonsocial=@textobuscarc + '%' or ciorud=@textobuscarc + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_profesionales]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--BUSCAR REGISTRO--
create proc [dbo].[spbuscar_profesionales]
@textobuscar varchar (50)
as
select * from profesionales
where nombres like @textobuscar + '%' or apellidos like @textobuscar + '%' or ciprofesional like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_registro]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spbuscar_registro]
@textobuscar varchar(50)
as
select * from clientes
where razonsocial=@textobuscar + '%' or ciorud=@textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[speditar_ciudades]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA EDITAR REGISTROS ==>> CIUDADES

CREATE proc [dbo].[speditar_ciudades]
@idciudades int,
@descripcion varchar(100)
as
update ciudades set descripcion=@descripcion where idciudades=@idciudades
GO
/****** Object:  StoredProcedure [dbo].[speditar_clientes]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----SP EDITAR REGISTROS ==> CLIENTES--
create proc [dbo].[speditar_clientes]
@idclientes int,
@ciorud varchar(15),
@razonsocial varchar(250),
@direccion varchar(250),
@telefono varchar (50),
@correo varchar (30),
@idprofesionales int,
@idciudades int
as
update clientes set ciorud=@ciorud, razonsocial=@razonsocial, direccion=@direccion, telefono=@telefono, correo=@correo, idprofesionales=@idprofesionales, idciudades=@idciudades
where idclientes=@idclientes
GO
/****** Object:  StoredProcedure [dbo].[speditar_profesionales]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EDITAR REGISTRO--
create proc [dbo].[speditar_profesionales]
@idprofesionales int,
@ciprofesional varchar(15),
@nombres varchar (30),
@apellidos varchar(70),
@direccion varchar(250),
@telefono varchar(50),
@correo varchar(30),
@idciudades int 
as
update profesionales set ciprofesional=@ciprofesional, nombres=@nombres, apellidos=@apellidos, direccion=@direccion, telefono=@telefono, correo=@correo, idciudades=@idciudades
where idprofesionales= @idprofesionales
GO
/****** Object:  StoredProcedure [dbo].[speditar_usuario]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[speditar_usuario]
@idusuarios int,
@usuario varchar(15),
@contrasena varchar(15),
@acceso varchar(20),
@idprofesionales int
as
update usuarios set usuario=@usuario,  contrasena=@contrasena, acceso=@acceso, idprofesionales=@idprofesionales where idusuarios=@idusuarios
GO
/****** Object:  StoredProcedure [dbo].[speliminar_ciudades]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--PROCEDIMIENTO ALMACENADO PARA ELIMINAR REGISTROS ==>> CIUDADES
CREATE proc [dbo].[speliminar_ciudades]
@idciudades int
as
delete ciudades where idciudades=@idciudades
GO
/****** Object:  StoredProcedure [dbo].[speliminar_clientes]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----SP EDITAR REGISTROS ==> CLIENTES--
create proc [dbo].[speliminar_clientes]
@idclientes int
as
delete clientes where idclientes=@idclientes
GO
/****** Object:  StoredProcedure [dbo].[speliminar_profesionales]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---ELIMINAR PROFESIONALES--
create proc [dbo].[speliminar_profesionales]
@idprofesionales int
as
delete from profesionales where idprofesionales=@idprofesionales
GO
/****** Object:  StoredProcedure [dbo].[speliminar_usuario]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[speliminar_usuario]
@idusuarios int
as
delete usuarios where idusuarios=@idusuarios
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_ciudades]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA INSERTAR REGISTROS ==>> CIUDADES

CREATE proc [dbo].[spinsertar_ciudades]
@descripcion varchar(100)
as
insert into ciudades values(@descripcion)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_clientes]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----SP INSERTAR REGISTROS ==> CLIENTES--
create proc [dbo].[spinsertar_clientes]
@ciorud varchar(15),
@razonsocial varchar(250),
@direccion varchar(250),
@telefono varchar (50),
@correo varchar (30),
@idprofesionales int,
@idciudades int
as
insert into clientes values(@ciorud, @razonsocial, @direccion, @telefono, @correo, @idprofesionales, @idciudades)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_profesionales]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--INSERTAR PROFESIONALES
create proc [dbo].[spinsertar_profesionales]
@ciprofesional varchar(15),
@nombres varchar (30),
@apellidos varchar(70),
@direccion varchar(250),
@telefono varchar(50),
@correo varchar(30),
@idciudades int 
as
insert into profesionales values(@ciprofesional, @nombres,@apellidos, @direccion, @telefono,@correo,@idciudades)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_usuarios]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spinsertar_usuarios]
@usuario varchar(15),
@contrasena varchar(15),
@acceso varchar(20),
@idprofesionales int
as
insert into usuarios values(@usuario, @contrasena, @acceso, @idprofesionales)
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_ciudades]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PROCEDIMIENTO ALMACENADO PARA MOSTRAR REGISTROS ==>> CIUDADES
CREATE proc [dbo].[spmostrar_ciudades]
as
select * from ciudades
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_clientes]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----SP MOSTRAR REGISTROS ==> CLIENTES--
create proc [dbo].[spmostrar_clientes]
as 
select * from clientes
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_profesionales]    Script Date: 03/06/2020 19:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--MOSTRAR REGISTROS--

create proc [dbo].[spmostrar_profesionales]
as
select * from profesionales
GO
USE [master]
GO
ALTER DATABASE [dbProyecto1] SET  READ_WRITE 
GO
