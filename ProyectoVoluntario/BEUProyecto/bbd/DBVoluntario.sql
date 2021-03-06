USE [master]
GO
/****** Object:  Database [DBVoluntarios]    Script Date: 5/8/2020 13:54:09 ******/
CREATE DATABASE [DBVoluntarios]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBVoluntarios', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBVoluntarios.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBVoluntarios_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBVoluntarios_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBVoluntarios] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBVoluntarios].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBVoluntarios] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBVoluntarios] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBVoluntarios] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBVoluntarios] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBVoluntarios] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBVoluntarios] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBVoluntarios] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBVoluntarios] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBVoluntarios] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBVoluntarios] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBVoluntarios] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBVoluntarios] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBVoluntarios] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBVoluntarios] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBVoluntarios] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBVoluntarios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBVoluntarios] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBVoluntarios] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBVoluntarios] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBVoluntarios] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBVoluntarios] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBVoluntarios] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBVoluntarios] SET RECOVERY FULL 
GO
ALTER DATABASE [DBVoluntarios] SET  MULTI_USER 
GO
ALTER DATABASE [DBVoluntarios] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBVoluntarios] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBVoluntarios] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBVoluntarios] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBVoluntarios] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBVoluntarios', N'ON'
GO
ALTER DATABASE [DBVoluntarios] SET QUERY_STORE = OFF
GO
USE [DBVoluntarios]
GO
/****** Object:  Table [dbo].[Aporte]    Script Date: 5/8/2020 13:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aporte](
	[idaporte] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[tiempo_actividad] [varchar](50) NULL,
 CONSTRAINT [PK_Aporte] PRIMARY KEY CLUSTERED 
(
	[idaporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 5/8/2020 13:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 5/8/2020 13:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[idevento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[fecha_inicio] [datetime] NULL,
	[fecha_final] [datetime] NULL,
	[organizador] [varchar](50) NULL,
	[idcategoria] [int] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[idevento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 5/8/2020 13:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[idregistro] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[estado] [varchar](50) NULL,
	[idvoluntario] [int] NULL,
	[idevento] [int] NULL,
	[idaporte] [int] NULL,
 CONSTRAINT [PK_Registro] PRIMARY KEY CLUSTERED 
(
	[idregistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voluntario]    Script Date: 5/8/2020 13:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voluntario](
	[idvoluntario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[cedula] [nchar](15) NULL,
	[telefono] [nchar](10) NULL,
	[fecha_nacimiento] [datetime] NULL,
	[direccion] [varchar](100) NULL,
	[sexo] [nchar](1) NULL,
 CONSTRAINT [PK_Voluntario] PRIMARY KEY CLUSTERED 
(
	[idvoluntario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aporte] ON 

INSERT [dbo].[Aporte] ([idaporte], [descripcion], [tiempo_actividad]) VALUES (1, N'Trabajo con Niños', NULL)
INSERT [dbo].[Aporte] ([idaporte], [descripcion], [tiempo_actividad]) VALUES (2, N'Desarrollo Comunitario', NULL)
INSERT [dbo].[Aporte] ([idaporte], [descripcion], [tiempo_actividad]) VALUES (3, N'Trabajo con Adultos Mayores', NULL)
SET IDENTITY_INSERT [dbo].[Aporte] OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([idcategoria], [nombre]) VALUES (1, N'Ingeniería')
INSERT [dbo].[Categoria] ([idcategoria], [nombre]) VALUES (2, N'Medicina')
INSERT [dbo].[Categoria] ([idcategoria], [nombre]) VALUES (3, N'Abogado')
INSERT [dbo].[Categoria] ([idcategoria], [nombre]) VALUES (4, N'Estudiante')
INSERT [dbo].[Categoria] ([idcategoria], [nombre]) VALUES (5, N'Neuropsicólogo empresarial.')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Evento] ON 

INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (3, N'Percusión', CAST(N'2020-06-30T00:00:00.000' AS DateTime), CAST(N'2020-07-31T00:00:00.000' AS DateTime), N'Cristian Herrera', 4)
INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (4, N'Robotica', CAST(N'2020-06-29T00:00:00.000' AS DateTime), CAST(N'2020-06-30T00:00:00.000' AS DateTime), N'Joel Herrera', 4)
INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (5, N'ESCOLAR', CAST(N'2020-06-03T00:00:00.000' AS DateTime), CAST(N'2020-07-04T00:00:00.000' AS DateTime), N'XXXXXXX', 2)
INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (1005, N'Charla sobre atención pacientes COVID', CAST(N'2020-07-01T00:00:00.000' AS DateTime), CAST(N'2020-07-05T00:00:00.000' AS DateTime), N'Municipio de Quito ', 2)
INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (1006, N'JUAN', CAST(N'2020-08-01T00:00:00.000' AS DateTime), CAST(N'2020-07-03T00:00:00.000' AS DateTime), N'ESPE-L', 4)
INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (1007, N'ESPEFEST', CAST(N'2020-07-10T00:00:00.000' AS DateTime), CAST(N'2020-07-05T00:00:00.000' AS DateTime), N'ESPE', 4)
INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (1008, N'gdfgdf', CAST(N'2020-08-09T00:00:00.000' AS DateTime), CAST(N'2020-08-09T00:00:00.000' AS DateTime), N'Municipio de Quito ', 3)
INSERT [dbo].[Evento] ([idevento], [nombre], [fecha_inicio], [fecha_final], [organizador], [idcategoria]) VALUES (1009, N'Cocina', CAST(N'2020-07-03T00:00:00.000' AS DateTime), CAST(N'2020-07-26T00:00:00.000' AS DateTime), N'La colmena', 4)
SET IDENTITY_INSERT [dbo].[Evento] OFF
GO
SET IDENTITY_INSERT [dbo].[Registro] ON 

INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (3, CAST(N'2020-06-14T00:00:00.000' AS DateTime), N'Registrado', 3, 3, 1)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (4, CAST(N'2020-06-16T00:00:00.000' AS DateTime), N'Registrado', 3, 5, 1)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1003, CAST(N'2020-07-15T00:00:00.000' AS DateTime), N'registrado', 1008, 5, 2)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1004, CAST(N'2020-07-20T22:08:03.553' AS DateTime), N'Registrado', 1007, 4, 2)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1005, CAST(N'2020-07-20T22:07:47.697' AS DateTime), N'Registrado', 8, 3, 3)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1006, CAST(N'2020-07-20T22:46:47.173' AS DateTime), N'Registrado', 3, 3, 1)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1007, CAST(N'2020-07-20T22:49:56.877' AS DateTime), N'Registrado', 8, 3, 1)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1008, CAST(N'2020-07-20T22:56:35.353' AS DateTime), N'Registrado', 3, 1005, 2)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1009, CAST(N'2020-07-20T22:57:48.167' AS DateTime), N'Registrado', 3, 1007, 1)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1010, CAST(N'2020-07-20T23:18:03.823' AS DateTime), N'Registrado', 1008, 5, 2)
INSERT [dbo].[Registro] ([idregistro], [fecha], [estado], [idvoluntario], [idevento], [idaporte]) VALUES (1011, CAST(N'2020-07-22T11:21:28.663' AS DateTime), N'Registrado', 1010, 1009, 2)
SET IDENTITY_INSERT [dbo].[Registro] OFF
GO
SET IDENTITY_INSERT [dbo].[Voluntario] ON 

INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (3, N'Jefferson Stalin', N'Herrera Vela', N'1724169469     ', N'0995639348', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'La colmena', N'M')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (6, N'Mario Joel', N'Herrera Vela', N'1724145214     ', N'098773252 ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'San diego', N'M')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (8, N'Mayra', N'Herrera', N'1724169469     ', N'2515452   ', CAST(N'2020-06-18T00:00:00.000' AS DateTime), N'ESPE', N'M')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1007, N'Jorge Luis', N'Chicaiza', N'0512364123     ', N'0987451236', CAST(N'1998-06-10T00:00:00.000' AS DateTime), N'Latacunga', N'H')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1008, N'dasds', N'dasdasd', N'1724169469     ', N'098773252 ', CAST(N'2020-07-05T00:00:00.000' AS DateTime), N'Patate', N'H')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1010, N'nellly', N'vela', N'000000000      ', N'1111111111', CAST(N'2020-07-04T00:00:00.000' AS DateTime), N'Patate', N'M')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1011, N'Naraly ', N'Ramos', N'1010101010     ', N'0210215412', CAST(N'2020-07-22T00:00:00.000' AS DateTime), N'Patate', N'M')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1014, N'Antonnela', N'Ramos', N'1251225412336  ', N'0213652102', CAST(N'2002-11-10T00:00:00.000' AS DateTime), N'la colmena', N'M')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1017, N'Carla', N'Andrade', N'1010101010     ', N'0899999654', CAST(N'2020-07-27T00:00:00.000' AS DateTime), N'san diego', N'M')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1018, N'Ivone', N'Pazmiño', N'1712645987     ', N'0254126   ', CAST(N'2020-07-28T00:00:00.000' AS DateTime), N'cayetano cestaris', N'G')
INSERT [dbo].[Voluntario] ([idvoluntario], [nombres], [apellidos], [cedula], [telefono], [fecha_nacimiento], [direccion], [sexo]) VALUES (1020, N'Paola', N'Zambrao', N'12541254125    ', N'0988563214', CAST(N'2020-08-01T00:00:00.000' AS DateTime), N'Latacunga', N'M')
SET IDENTITY_INSERT [dbo].[Voluntario] OFF
GO
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Categoria] FOREIGN KEY([idcategoria])
REFERENCES [dbo].[Categoria] ([idcategoria])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Categoria]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Aporte] FOREIGN KEY([idaporte])
REFERENCES [dbo].[Aporte] ([idaporte])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Aporte]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Evento] FOREIGN KEY([idevento])
REFERENCES [dbo].[Evento] ([idevento])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Evento]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Voluntario] FOREIGN KEY([idvoluntario])
REFERENCES [dbo].[Voluntario] ([idvoluntario])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Voluntario]
GO
USE [master]
GO
ALTER DATABASE [DBVoluntarios] SET  READ_WRITE 
GO
