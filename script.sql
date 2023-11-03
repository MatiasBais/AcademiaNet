/****** Object:  Table [dbo].[Usuarios]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[TipoUsuarios]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoUsuarios]') AND type in (N'U'))
DROP TABLE [dbo].[TipoUsuarios]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Planes]') AND type in (N'U'))
DROP TABLE [dbo].[Planes]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Personas]') AND type in (N'U'))
DROP TABLE [dbo].[Personas]
GO
/****** Object:  Table [dbo].[ModulosUsuario]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModulosUsuario]') AND type in (N'U'))
DROP TABLE [dbo].[ModulosUsuario]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modulos]') AND type in (N'U'))
DROP TABLE [dbo].[Modulos]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Materias]') AND type in (N'U'))
DROP TABLE [dbo].[Materias]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Especialidades]') AND type in (N'U'))
DROP TABLE [dbo].[Especialidades]
GO
/****** Object:  Table [dbo].[DocentesCursos]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DocentesCursos]') AND type in (N'U'))
DROP TABLE [dbo].[DocentesCursos]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cursos]') AND type in (N'U'))
DROP TABLE [dbo].[Cursos]
GO
/****** Object:  Table [dbo].[Comisiones]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Comisiones]') AND type in (N'U'))
DROP TABLE [dbo].[Comisiones]
GO
/****** Object:  Table [dbo].[AlumnosInscripciones]    Script Date: 3/11/2023 09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlumnosInscripciones]') AND type in (N'U'))
DROP TABLE [dbo].[AlumnosInscripciones]
GO
/****** Object:  Database [academia2]    Script Date: 3/11/2023 09:45 ******/
DROP DATABASE [academia2]
GO
/****** Object:  Database [academia2]    Script Date: 3/11/2023 09:45 ******/
CREATE DATABASE [academia2]  (EDITION = 'GeneralPurpose', SERVICE_OBJECTIVE = 'GP_S_Gen5_1', MAXSIZE = 12 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [academia2] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [academia2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [academia2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [academia2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [academia2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [academia2] SET ARITHABORT OFF 
GO
ALTER DATABASE [academia2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [academia2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [academia2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [academia2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [academia2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [academia2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [academia2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [academia2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [academia2] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [academia2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [academia2] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [academia2] SET  MULTI_USER 
GO
ALTER DATABASE [academia2] SET ENCRYPTION ON
GO
ALTER DATABASE [academia2] SET QUERY_STORE = ON
GO
ALTER DATABASE [academia2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[AlumnosInscripciones]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comisiones]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocentesCursos]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 3/11/2023 09:45 ******/
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
/****** Object:  Table [dbo].[Materias]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModulosUsuario]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 3/11/2023 09:45 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoUsuarios]    Script Date: 3/11/2023 09:45 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 3/11/2023 09:45 ******/
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
SET IDENTITY_INSERT [dbo].[AlumnosInscripciones] ON 

INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (4, NULL, N'Aprobado', 2, 3, 5)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (5, NULL, N'Inscripto', 5, 3, 0)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (6, NULL, N'Inscripto', 2, 1, 0)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (7, NULL, N'Inscripto', 2, 2, 0)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (8, NULL, N'Inscripto', 5, 4, 0)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (9, NULL, N'Aprobado', 2, 6, 6)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (10, NULL, N'Inscripto', 5, 2, 0)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (11, NULL, N'Regular', 10, 6, 0)
INSERT [dbo].[AlumnosInscripciones] ([ID], [State], [Condicion], [IDAlumno], [IDCurso], [Nota]) VALUES (12, NULL, N'Inscripto', 10, 1, 0)
SET IDENTITY_INSERT [dbo].[AlumnosInscripciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Comisiones] ON 

INSERT [dbo].[Comisiones] ([ID], [State], [AñoEspecialidad], [Descripcion], [IDPlan]) VALUES (3, NULL, 1, N'1k01', 1)
INSERT [dbo].[Comisiones] ([ID], [State], [AñoEspecialidad], [Descripcion], [IDPlan]) VALUES (4, NULL, 1, N'1k02', 1)
INSERT [dbo].[Comisiones] ([ID], [State], [AñoEspecialidad], [Descripcion], [IDPlan]) VALUES (5, NULL, 1, N'1k03', 1)
INSERT [dbo].[Comisiones] ([ID], [State], [AñoEspecialidad], [Descripcion], [IDPlan]) VALUES (6, NULL, 3, N'3kE5', 1)
SET IDENTITY_INSERT [dbo].[Comisiones] OFF
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (1, NULL, 2023, 2, N'AMI', 3, 1)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (2, NULL, 2023, 2, N'AMII', 3, 3)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (3, NULL, 2023, 2, N'FISI', 3, 2)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (4, NULL, 2023, 2, N'a', 4, 1)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (5, NULL, 2023, 3, N'a', 5, 1)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (6, NULL, 2023, 10, N'NET', 6, 4)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (7, NULL, 2023, 5, N'a', 4, 4)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (8, NULL, 2023, 8, N'-', 5, 3)
INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (9, NULL, 2023, 5, N'net', 3, 4)
SET IDENTITY_INSERT [dbo].[Cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[DocentesCursos] ON 

INSERT [dbo].[DocentesCursos] ([ID], [State], [Cargo], [IDCurso], [IDDocente]) VALUES (5, NULL, N'Auxiliar', 3, 7)
INSERT [dbo].[DocentesCursos] ([ID], [State], [Cargo], [IDCurso], [IDDocente]) VALUES (8, NULL, N'Titular', 3, 3)
INSERT [dbo].[DocentesCursos] ([ID], [State], [Cargo], [IDCurso], [IDDocente]) VALUES (10, NULL, N'Titular', 6, 3)
INSERT [dbo].[DocentesCursos] ([ID], [State], [Cargo], [IDCurso], [IDDocente]) VALUES (11, NULL, N'Auxiliar', 6, 7)
INSERT [dbo].[DocentesCursos] ([ID], [State], [Cargo], [IDCurso], [IDDocente]) VALUES (13, NULL, N'Titular', 1, 9)
INSERT [dbo].[DocentesCursos] ([ID], [State], [Cargo], [IDCurso], [IDDocente]) VALUES (15, NULL, N'Auxiliar', 3, 13)
INSERT [dbo].[DocentesCursos] ([ID], [State], [Cargo], [IDCurso], [IDDocente]) VALUES (16, NULL, N'Auxiliar', 1, 8)
SET IDENTITY_INSERT [dbo].[DocentesCursos] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidades] ON 

INSERT [dbo].[Especialidades] ([ID], [Descripcion], [State]) VALUES (1, N'Sistemas', NULL)
INSERT [dbo].[Especialidades] ([ID], [Descripcion], [State]) VALUES (2, N'Civil', NULL)
INSERT [dbo].[Especialidades] ([ID], [Descripcion], [State]) VALUES (0, N'-', NULL)
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Materias] ON 

INSERT [dbo].[Materias] ([ID], [State], [Descripcion], [HSSemanales], [HSTotales], [IDPlan]) VALUES (1, NULL, N'Análisis Matemático I', 8, 200, 1)
INSERT [dbo].[Materias] ([ID], [State], [Descripcion], [HSSemanales], [HSTotales], [IDPlan]) VALUES (2, NULL, N'Fisica 1', 8, 200, 1)
INSERT [dbo].[Materias] ([ID], [State], [Descripcion], [HSSemanales], [HSTotales], [IDPlan]) VALUES (3, NULL, N'Analisis Matemático II', 8, 200, 1)
INSERT [dbo].[Materias] ([ID], [State], [Descripcion], [HSSemanales], [HSTotales], [IDPlan]) VALUES (4, NULL, N'NET', 8, 200, 1)
INSERT [dbo].[Materias] ([ID], [State], [Descripcion], [HSSemanales], [HSTotales], [IDPlan]) VALUES (5, N'E', N'a', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Materias] OFF
GO
SET IDENTITY_INSERT [dbo].[Modulos] ON 

INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (1, NULL, N'Personas')
INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (2, NULL, N'Usuarios')
INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (3, NULL, N'Especialidades')
INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (4, NULL, N'Planes')
INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (5, NULL, N'Materias')
INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (6, NULL, N'Cursos')
INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (7, NULL, N'Inscripciones')
INSERT [dbo].[Modulos] ([ID], [State], [Descripcion]) VALUES (8, NULL, N'Notas')
SET IDENTITY_INSERT [dbo].[Modulos] OFF
GO
SET IDENTITY_INSERT [dbo].[ModulosUsuario] ON 

INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (1, NULL, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (2, NULL, 2, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (3, NULL, 3, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (4, NULL, 4, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (5, NULL, 5, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (6, NULL, 6, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (7, NULL, 7, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (8, NULL, 8, 1, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (9, NULL, 1, 3, 0, 0, 0, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (10, NULL, 2, 3, 0, 0, 0, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (11, NULL, 3, 3, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (12, NULL, 4, 3, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (13, NULL, 5, 3, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (14, NULL, 6, 3, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (15, NULL, 7, 3, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (16, NULL, 8, 3, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (17, NULL, 1, 4, 0, 0, 0, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (18, NULL, 2, 4, 0, 0, 0, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (19, NULL, 3, 4, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (20, NULL, 4, 4, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (21, NULL, 5, 4, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (22, NULL, 6, 4, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (23, NULL, 7, 4, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (24, NULL, 8, 4, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (25, NULL, 1, 5, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (26, NULL, 2, 5, 0, 0, 0, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (27, NULL, 3, 5, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (28, NULL, 4, 5, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (29, NULL, 5, 5, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (30, NULL, 6, 5, 0, 0, 1, 0)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (31, NULL, 7, 5, 1, 1, 1, 1)
INSERT [dbo].[ModulosUsuario] ([ID], [State], [IDModulo], [IDTipoUsuario], [PermiteAlta], [PermiteBaja], [PermiteConsulta], [PermiteModificacion]) VALUES (32, NULL, 8, 5, 0, 0, 1, 0)
SET IDENTITY_INSERT [dbo].[ModulosUsuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (6, NULL, N'Ezequiell', N'Porta', N'', CAST(N'1990-12-13T00:00:00.000' AS DateTime), N'215616', N'porta@gmail.com')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (9, NULL, N'Matias', N'Bais', N'Mar del plata 665', CAST(N'1998-09-25T00:00:00.000' AS DateTime), N'2474492062', N'matiasbais1998@gmail.com')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (10, NULL, N'Agustin', N'Luzzini', N'montevideo 161', CAST(N'2002-02-15T00:00:00.000' AS DateTime), N'76123762', N'as@dsafff.com')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (11, NULL, N'Juan', N'Perez', N'123', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'123', N'123@gmail.com')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (12, NULL, N'Carlos', N'Garcia', N'123', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'123', N'123@gmail.com')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (13, NULL, N'Luis', N'Spinetta', N'123', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'12', N'123@gmail.com')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (14, NULL, N'Pedro', N'Aznar', N'123', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'123', N'123@gmail.com')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (15, NULL, N'Carlos Salvador', N'Bilardo', N'Mexico 1986', CAST(N'1940-08-15T00:00:00.000' AS DateTime), N'1986', N'casd@gmail.com')
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
SET IDENTITY_INSERT [dbo].[Planes] ON 

INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (0, N'E', N'-', 0)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (1, NULL, N'2008', 1)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (2011, NULL, N'2000', 1)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (2013, NULL, N'2012', 2)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (2014, NULL, N'2023', 1)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (2015, N'E', N'3232', 1)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (2016, N'E', N'a', 1)
SET IDENTITY_INSERT [dbo].[Planes] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoUsuarios] ON 

INSERT [dbo].[TipoUsuarios] ([ID], [State], [Descripcion]) VALUES (1, NULL, N'Administrador')
INSERT [dbo].[TipoUsuarios] ([ID], [State], [Descripcion]) VALUES (3, NULL, N'Alumno')
INSERT [dbo].[TipoUsuarios] ([ID], [State], [Descripcion]) VALUES (4, NULL, N'Profesor')
INSERT [dbo].[TipoUsuarios] ([ID], [State], [Descripcion]) VALUES (5, NULL, N'Alumnado')
SET IDENTITY_INSERT [dbo].[TipoUsuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (1, NULL, N'matias', N'1234', N'Habilitado', 9, 46241, 1, 1)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (2, NULL, N'alumno', N'1234', N'Habilitado', 9, 45611, 1, 3)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (3, NULL, N'profesor', N'1234', N'Habilitado', 6, 1231, 0, 4)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (4, NULL, N'admin', N'admin', N'Habilitado', 6, 1, 0, 1)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (5, NULL, N'alumno2', N'1234', N'Habilitado', 9, 23121, 1, 3)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (6, NULL, N'alumno3', N'1234', N'Habilitado', 9, 1233213, 1, 3)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (7, NULL, N'juan', N'1234', N'Habilitado', 11, 861981, 0, 4)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (8, NULL, N'carlos', N'carlos', N'Habilitado', 12, 7983, 0, 4)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (9, NULL, N'luis', N'luis', N'Habilitado', 13, 1351, 0, 4)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (10, NULL, N'agus', N'123', N'Habilitado', 10, 1891, 1, 3)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (11, NULL, N'pedro', N'pedro', N'Habilitado', 14, 9411, 1, 3)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (12, NULL, N'123123', N'12312', N'Habilitado', 9, 123123, 2013, 3)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (13, NULL, N'bilardo', N'123', N'Habilitado', 15, 1986, 0, 4)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (14, NULL, N'agus2', N'123', N'Habilitado', 10, 444, 0, 4)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (15, NULL, N'aaaa', N'aaaa', N'Habilitado', 6, 1231, 0, 4)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER DATABASE [academia2] SET  READ_WRITE 
GO
