USE [master]
GO
/****** Object:  Database [academia]    Script Date: 28/09/2023 11:13:35 ******/
CREATE DATABASE [academia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'academia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\academia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'academia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\academia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [academia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [academia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [academia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [academia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [academia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [academia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [academia] SET ARITHABORT OFF 
GO
ALTER DATABASE [academia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [academia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [academia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [academia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [academia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [academia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [academia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [academia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [academia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [academia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [academia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [academia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [academia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [academia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [academia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [academia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [academia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [academia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [academia] SET  MULTI_USER 
GO
ALTER DATABASE [academia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [academia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [academia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [academia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [academia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [academia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [academia] SET QUERY_STORE = OFF
GO
USE [academia]
GO
/****** Object:  User [net]    Script Date: 28/09/2023 11:13:35 ******/
CREATE USER [net] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[AlumnosInscripciones]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlumnosInscripciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[Condicion] [varchar](50) NULL,
	[IDAlumno] [int] NULL,
	[IDCurso] [int] NULL,
	[Nota] [int] NULL,
 CONSTRAINT [PK_AlumnosInscripciones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comisiones]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comisiones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[AñoEspecialidad] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[IDPlan] [int] NULL,
 CONSTRAINT [PK_Comisiones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[AñoCalendario] [int] NULL,
	[Cupo] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[IDComision] [int] NULL,
	[IDMateria] [int] NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocentesCursos]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocentesCursos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[IDCurso] [int] NULL,
	[IDDocente] [int] NULL,
 CONSTRAINT [PK_DocentesCursos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[State] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[HSSemanales] [int] NULL,
	[HSTotales] [int] NULL,
	[IDPlan] [int] NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Modulos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModulosUsuario]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModulosUsuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[IDModulo] [int] NULL,
	[IDTipoUsuario] [int] NULL,
	[PermiteAlta] [bit] NULL,
	[PermiteBaja] [bit] NULL,
	[PermiteConsulta] [bit] NULL,
	[PermiteModificacion] [bit] NULL,
 CONSTRAINT [PK_ModulosUsuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Telefono] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[IDEspecialidad] [int] NULL,
 CONSTRAINT [PK_Planes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoUsuarios]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoUsuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 28/09/2023 11:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NULL,
	[NombreUsuario] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[Habilitado] [varchar](50) NULL,
	[idPersona] [int] NULL,
	[Legajo] [int] NULL,
	[IDPlan] [int] NULL,
	[IDTipoPersona] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Usuarios]    Script Date: 28/09/2023 11:13:35 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Usuarios] ON [dbo].[Usuarios]
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [academia] SET  READ_WRITE 
GO
