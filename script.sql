USE [academia]
GO
/****** Object:  User [net]    Script Date: 28/09/2023 11:16:35 ******/
CREATE USER [net] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[AlumnosInscripciones]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Comisiones]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Cursos]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[DocentesCursos]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Especialidades]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Materias]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Modulos]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[ModulosUsuario]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Personas]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Planes]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[TipoUsuarios]    Script Date: 28/09/2023 11:16:35 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 28/09/2023 11:16:35 ******/
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
SET IDENTITY_INSERT [dbo].[Comisiones] ON 

INSERT [dbo].[Comisiones] ([ID], [State], [AñoEspecialidad], [Descripcion], [IDPlan]) VALUES (3, NULL, 1, N'1k01', 1)
SET IDENTITY_INSERT [dbo].[Comisiones] OFF
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([ID], [State], [AñoCalendario], [Cupo], [Descripcion], [IDComision], [IDMateria]) VALUES (1, NULL, 2023, 2, N'1', 3, 1)
SET IDENTITY_INSERT [dbo].[Cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidades] ON 

INSERT [dbo].[Especialidades] ([ID], [Descripcion], [State]) VALUES (1, N'Sistemas', NULL)
INSERT [dbo].[Especialidades] ([ID], [Descripcion], [State]) VALUES (2, N'Civil', NULL)
INSERT [dbo].[Especialidades] ([ID], [Descripcion], [State]) VALUES (0, N'-', NULL)
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Materias] ON 

INSERT [dbo].[Materias] ([ID], [State], [Descripcion], [HSSemanales], [HSTotales], [IDPlan]) VALUES (1, NULL, N'Análisis Matemático I', 8, 200, 1)
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

INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (6, NULL, N'Ezequiell', N'Porta', N'', CAST(N'1990-12-13T00:00:00.000' AS DateTime), N'215616', N'asdas 123')
INSERT [dbo].[Personas] ([ID], [State], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Email]) VALUES (9, NULL, N'Matias', N'Bais', N'Mar del plata 665', CAST(N'1998-09-25T00:00:00.000' AS DateTime), N'2474492062', N'asdasda@gmail.com')
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
SET IDENTITY_INSERT [dbo].[Planes] ON 

INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (0, NULL, N'-', 0)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (1, NULL, N'2008', 1)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (2011, NULL, N'2000', 1)
INSERT [dbo].[Planes] ([ID], [State], [Descripcion], [IDEspecialidad]) VALUES (2013, NULL, N'2012', 2)
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
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (2, NULL, N'alumno', N'alumno', N'Habilitado', 9, 45611, 1, 3)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (3, NULL, N'dasda', N'12313', N'Habilitado', 6, 1231, 0, 4)
INSERT [dbo].[Usuarios] ([ID], [State], [NombreUsuario], [Clave], [Habilitado], [idPersona], [Legajo], [IDPlan], [IDTipoPersona]) VALUES (4, NULL, N'admin', N'admin', N'Habilitado', 6, 1, 0, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
