USE [Academia]
GO
ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK_Usuarios_Personas]
GO
ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [fk_PlanId]
GO
ALTER TABLE [dbo].[Planes] DROP CONSTRAINT [FK_Planes_Especialidades]
GO
ALTER TABLE [dbo].[Modulos_Usuarios] DROP CONSTRAINT [FK_Modulos_Usuarios_Usuarios]
GO
ALTER TABLE [dbo].[Modulos_Usuarios] DROP CONSTRAINT [FK_Modulos_Usuarios_Modulos]
GO
ALTER TABLE [dbo].[Materias] DROP CONSTRAINT [FK_Materias_Planes]
GO
ALTER TABLE [dbo].[Docentes_Cursos] DROP CONSTRAINT [FK_Docentes_Cursos_Docente]
GO
ALTER TABLE [dbo].[Docentes_Cursos] DROP CONSTRAINT [FK_Docentes_Cursos_Cursos]
GO
ALTER TABLE [dbo].[Cursos] DROP CONSTRAINT [FK_Cursos_Materias]
GO
ALTER TABLE [dbo].[Cursos] DROP CONSTRAINT [FK_Cursos_Comisiones]
GO
ALTER TABLE [dbo].[Alumnos_Inscripciones] DROP CONSTRAINT [FK_Alumnos_Inscripciones_Cursos]
GO
ALTER TABLE [dbo].[Alumnos_Inscripciones] DROP CONSTRAINT [FK_Alumnos_Inscripciones_Alumnos]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Planes]') AND type in (N'U'))
DROP TABLE [dbo].[Planes]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Personas]') AND type in (N'U'))
DROP TABLE [dbo].[Personas]
GO
/****** Object:  Table [dbo].[Modulos_Usuarios]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modulos_Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Modulos_Usuarios]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modulos]') AND type in (N'U'))
DROP TABLE [dbo].[Modulos]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Materias]') AND type in (N'U'))
DROP TABLE [dbo].[Materias]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Especialidades]') AND type in (N'U'))
DROP TABLE [dbo].[Especialidades]
GO
/****** Object:  Table [dbo].[Docentes_Cursos]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Docentes_Cursos]') AND type in (N'U'))
DROP TABLE [dbo].[Docentes_Cursos]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cursos]') AND type in (N'U'))
DROP TABLE [dbo].[Cursos]
GO
/****** Object:  Table [dbo].[Comisiones]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Comisiones]') AND type in (N'U'))
DROP TABLE [dbo].[Comisiones]
GO
/****** Object:  Table [dbo].[Alumnos_Inscripciones]    Script Date: 08/11/2023 23:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Alumnos_Inscripciones]') AND type in (N'U'))
DROP TABLE [dbo].[Alumnos_Inscripciones]
GO
USE [master]
GO
/****** Object:  Database [Academia]    Script Date: 08/11/2023 23:01:57 ******/
DROP DATABASE [Academia]
GO
/****** Object:  Database [Academia]    Script Date: 08/11/2023 23:01:57 ******/
CREATE DATABASE [Academia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Academia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Academia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Academia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Academia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Academia] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Academia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Academia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Academia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Academia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Academia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Academia] SET ARITHABORT OFF 
GO
ALTER DATABASE [Academia] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Academia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Academia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Academia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Academia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Academia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Academia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Academia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Academia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Academia] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Academia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Academia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Academia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Academia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Academia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Academia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Academia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Academia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Academia] SET  MULTI_USER 
GO
ALTER DATABASE [Academia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Academia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Academia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Academia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Academia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Academia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Academia] SET QUERY_STORE = ON
GO
ALTER DATABASE [Academia] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Academia]
GO
/****** Object:  Table [dbo].[Alumnos_Inscripciones]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos_Inscripciones](
	[IdInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[IdAlumno] [int] NOT NULL,
	[IdCurso] [int] NOT NULL,
	[Condicion] [nvarchar](max) NOT NULL,
	[Nota] [int] NOT NULL,
 CONSTRAINT [PK_Alumnos_Inscripciones] PRIMARY KEY CLUSTERED 
(
	[IdInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comisiones]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comisiones](
	[IdComision] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[AnioEspecialidad] [int] NOT NULL,
	[IDPlan] [int] NOT NULL,
 CONSTRAINT [PK_Comisiones] PRIMARY KEY CLUSTERED 
(
	[IdComision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[IdMateria] [int] NOT NULL,
	[IdComision] [int] NOT NULL,
	[AnioCalendario] [int] NOT NULL,
	[Cupo] [int] NOT NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docentes_Cursos]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docentes_Cursos](
	[IdDictado] [int] IDENTITY(1,1) NOT NULL,
	[IdCurso] [int] NOT NULL,
	[IdDocente] [int] NOT NULL,
	[Cargo] [int] NOT NULL,
 CONSTRAINT [PK_Docentes_Cursos] PRIMARY KEY CLUSTERED 
(
	[IdDictado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[IdEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED 
(
	[IdEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[IdMateria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[HsSemanales] [int] NOT NULL,
	[HsTotales] [int] NOT NULL,
	[IdPlan] [int] NOT NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[IdMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulos](
	[IdModulo] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Ejecuta] [nvarchar](max) NULL,
 CONSTRAINT [PK_Modulos] PRIMARY KEY CLUSTERED 
(
	[IdModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulos_Usuarios]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulos_Usuarios](
	[IdModuloUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdModulo] [int] NOT NULL,
	[IdUsuarrio] [int] NOT NULL,
	[Alta] [bit] NOT NULL,
	[Baja] [bit] NOT NULL,
	[Modificacion] [bit] NOT NULL,
	[Consulta] [bit] NOT NULL,
 CONSTRAINT [PK_Modulos_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdModuloUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[PersonasId] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [int] NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[PersonasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planes](
	[IDPlan] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[IdEspecialidad] [int] NOT NULL,
 CONSTRAINT [PK_Planes] PRIMARY KEY CLUSTERED 
(
	[IDPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/11/2023 23:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](max) NOT NULL,
	[Legajo] [int] NOT NULL,
	[Clave] [nvarchar](max) NOT NULL,
	[TipoUsuario] [nvarchar](max) NOT NULL,
	[Habilitado] [bit] NOT NULL,
	[PersonaId] [int] NOT NULL,
	[PlanId] [int] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumnos_Inscripciones] ON 

INSERT [dbo].[Alumnos_Inscripciones] ([IdInscripcion], [IdAlumno], [IdCurso], [Condicion], [Nota]) VALUES (9, 14, 1, N'Aprobado', 9)
INSERT [dbo].[Alumnos_Inscripciones] ([IdInscripcion], [IdAlumno], [IdCurso], [Condicion], [Nota]) VALUES (10, 22, 6, N'Aprobado', 9)
INSERT [dbo].[Alumnos_Inscripciones] ([IdInscripcion], [IdAlumno], [IdCurso], [Condicion], [Nota]) VALUES (11, 19, 1, N'Libre', 0)
SET IDENTITY_INSERT [dbo].[Alumnos_Inscripciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Comisiones] ON 

INSERT [dbo].[Comisiones] ([IdComision], [Descripcion], [AnioEspecialidad], [IDPlan]) VALUES (4, N'403 turno tarde', 2023, 3)
INSERT [dbo].[Comisiones] ([IdComision], [Descripcion], [AnioEspecialidad], [IDPlan]) VALUES (5, N'401 turno noche', 2023, 2)
INSERT [dbo].[Comisiones] ([IdComision], [Descripcion], [AnioEspecialidad], [IDPlan]) VALUES (6, N'403 turno tarde', 2023, 2)
SET IDENTITY_INSERT [dbo].[Comisiones] OFF
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([IdCurso], [IdMateria], [IdComision], [AnioCalendario], [Cupo]) VALUES (1, 1, 4, 2023, 40)
INSERT [dbo].[Cursos] ([IdCurso], [IdMateria], [IdComision], [AnioCalendario], [Cupo]) VALUES (2, 1, 4, 2022, 35)
INSERT [dbo].[Cursos] ([IdCurso], [IdMateria], [IdComision], [AnioCalendario], [Cupo]) VALUES (3, 1, 5, 2023, 50)
INSERT [dbo].[Cursos] ([IdCurso], [IdMateria], [IdComision], [AnioCalendario], [Cupo]) VALUES (4, 1, 5, 2023, 2)
INSERT [dbo].[Cursos] ([IdCurso], [IdMateria], [IdComision], [AnioCalendario], [Cupo]) VALUES (6, 2, 6, 2023, 2)
SET IDENTITY_INSERT [dbo].[Cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidades] ON 

INSERT [dbo].[Especialidades] ([IdEspecialidad], [Descripcion]) VALUES (1, N'Ingenieria Quimica')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Descripcion]) VALUES (4, N'Ingenieria en Sistemas de Informacion')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Descripcion]) VALUES (5, N'Ingenieria Electrica')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Descripcion]) VALUES (6, N'Ingeniería Electronica')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Descripcion]) VALUES (7, N'Ingenieria Mecanica')
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Materias] ON 

INSERT [dbo].[Materias] ([IdMateria], [Descripcion], [HsSemanales], [HsTotales], [IdPlan]) VALUES (1, N'gestion de datos', 4, 60, 2)
INSERT [dbo].[Materias] ([IdMateria], [Descripcion], [HsSemanales], [HsTotales], [IdPlan]) VALUES (2, N'desarrollo', 4, 120, 2)
SET IDENTITY_INSERT [dbo].[Materias] OFF
GO
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (1, N'Alumnos_Inscripciones', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (2, N'Comisiones', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (3, N'Cursos', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (4, N'Docentes_Cursos', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (5, N'Especialidades', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (6, N'Materias', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (7, N'Personas', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (8, N'Planes', NULL)
INSERT [dbo].[Modulos] ([IdModulo], [Descripcion], [Ejecuta]) VALUES (9, N'Usuarios', NULL)
GO
SET IDENTITY_INSERT [dbo].[Modulos_Usuarios] ON 

INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (1, 1, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (2, 2, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (3, 3, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (4, 4, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (5, 5, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (6, 6, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (7, 7, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (8, 8, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (9, 9, 19, 1, 1, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (10, 1, 20, 1, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (11, 2, 20, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (12, 3, 20, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (13, 4, 20, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (14, 5, 20, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (15, 6, 20, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (16, 7, 20, 0, 0, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (17, 8, 20, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (18, 9, 20, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (19, 1, 21, 1, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (20, 2, 21, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (21, 3, 21, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (22, 4, 21, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (23, 5, 21, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (24, 6, 21, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (25, 7, 21, 0, 0, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (26, 8, 21, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (27, 9, 21, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (28, 1, 22, 1, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (29, 2, 22, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (30, 3, 22, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (31, 4, 22, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (32, 5, 22, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (33, 6, 22, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (34, 7, 22, 0, 0, 1, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (35, 8, 22, 0, 0, 0, 1)
INSERT [dbo].[Modulos_Usuarios] ([IdModuloUsuario], [IdModulo], [IdUsuarrio], [Alta], [Baja], [Modificacion], [Consulta]) VALUES (36, 9, 22, 0, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Modulos_Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([PersonasId], [DNI], [Nombre], [Apellido], [Telefono], [Direccion], [Email], [FechaNacimiento]) VALUES (7, 12345678, N'Jose', N'Carlos', N'1234567890', N'Francia 456', N'carjose@gmail.com', CAST(N'1990-03-12T17:14:16.2366667' AS DateTime2))
INSERT [dbo].[Personas] ([PersonasId], [DNI], [Nombre], [Apellido], [Telefono], [Direccion], [Email], [FechaNacimiento]) VALUES (12, 99999999, N'admin', N'admin', N'2348798678', N'adsihfdjk', N'asdfjha@gmail.com', CAST(N'2023-11-02T15:12:59.5566667' AS DateTime2))
INSERT [dbo].[Personas] ([PersonasId], [DNI], [Nombre], [Apellido], [Telefono], [Direccion], [Email], [FechaNacimiento]) VALUES (13, 88888888, N'admin1', N'admin1', N'1233124253', N'sadfasdf', N'sdfsadf@gmail.com', CAST(N'2023-11-02T15:12:59.5566667' AS DateTime2))
INSERT [dbo].[Personas] ([PersonasId], [DNI], [Nombre], [Apellido], [Telefono], [Direccion], [Email], [FechaNacimiento]) VALUES (14, 12343434, N'juan', N'torres', N'123123124', N'asdasd', N'asdas@gmail.com', CAST(N'1900-11-02T15:23:21.5133333' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
SET IDENTITY_INSERT [dbo].[Planes] ON 

INSERT [dbo].[Planes] ([IDPlan], [Descripcion], [IdEspecialidad]) VALUES (2, N'2023', 4)
INSERT [dbo].[Planes] ([IDPlan], [Descripcion], [IdEspecialidad]) VALUES (3, N'2008', 5)
INSERT [dbo].[Planes] ([IDPlan], [Descripcion], [IdEspecialidad]) VALUES (6, N'1998', 4)
SET IDENTITY_INSERT [dbo].[Planes] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (14, N'primeruser', 66666, N'primer', N'Alumno', 1, 7, 2)
INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (16, N'admin', 12345, N'admin', N'Administrador', 1, 7, 2)
INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (17, N'profe', 11111, N'profe', N'Docente', 1, 7, 2)
INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (19, N'admin1', 88765, N'admin1', N'Administrador', 1, 12, 2)
INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (20, N'aaaaa', 34343, N'aaaaa', N'Docente', 1, 13, 2)
INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (21, N'juanitorres', 78765, N'aaaaa', N'Docente', 1, 14, 2)
INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (22, N'alum1', 22113, N'alum1', N'Alumno', 1, 7, 2)
INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Legajo], [Clave], [TipoUsuario], [Habilitado], [PersonaId], [PlanId]) VALUES (25, N'usuarioweb', 22223, N'usuarioweb', N'Alumno', 1, 7, 3)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Alumnos_Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Alumnos_Inscripciones_Alumnos] FOREIGN KEY([IdAlumno])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
GO
ALTER TABLE [dbo].[Alumnos_Inscripciones] CHECK CONSTRAINT [FK_Alumnos_Inscripciones_Alumnos]
GO
ALTER TABLE [dbo].[Alumnos_Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Alumnos_Inscripciones_Cursos] FOREIGN KEY([IdCurso])
REFERENCES [dbo].[Cursos] ([IdCurso])
GO
ALTER TABLE [dbo].[Alumnos_Inscripciones] CHECK CONSTRAINT [FK_Alumnos_Inscripciones_Cursos]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Comisiones] FOREIGN KEY([IdComision])
REFERENCES [dbo].[Comisiones] ([IdComision])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Comisiones]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([IdMateria])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Materias]
GO
ALTER TABLE [dbo].[Docentes_Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Docentes_Cursos_Cursos] FOREIGN KEY([IdCurso])
REFERENCES [dbo].[Cursos] ([IdCurso])
GO
ALTER TABLE [dbo].[Docentes_Cursos] CHECK CONSTRAINT [FK_Docentes_Cursos_Cursos]
GO
ALTER TABLE [dbo].[Docentes_Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Docentes_Cursos_Docente] FOREIGN KEY([IdDocente])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
GO
ALTER TABLE [dbo].[Docentes_Cursos] CHECK CONSTRAINT [FK_Docentes_Cursos_Docente]
GO
ALTER TABLE [dbo].[Materias]  WITH CHECK ADD  CONSTRAINT [FK_Materias_Planes] FOREIGN KEY([IdPlan])
REFERENCES [dbo].[Planes] ([IDPlan])
GO
ALTER TABLE [dbo].[Materias] CHECK CONSTRAINT [FK_Materias_Planes]
GO
ALTER TABLE [dbo].[Modulos_Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Modulos_Usuarios_Modulos] FOREIGN KEY([IdModulo])
REFERENCES [dbo].[Modulos] ([IdModulo])
GO
ALTER TABLE [dbo].[Modulos_Usuarios] CHECK CONSTRAINT [FK_Modulos_Usuarios_Modulos]
GO
ALTER TABLE [dbo].[Modulos_Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Modulos_Usuarios_Usuarios] FOREIGN KEY([IdUsuarrio])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
GO
ALTER TABLE [dbo].[Modulos_Usuarios] CHECK CONSTRAINT [FK_Modulos_Usuarios_Usuarios]
GO
ALTER TABLE [dbo].[Planes]  WITH CHECK ADD  CONSTRAINT [FK_Planes_Especialidades] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[Especialidades] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[Planes] CHECK CONSTRAINT [FK_Planes_Especialidades]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_PlanId] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Planes] ([IDPlan])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_PlanId]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Personas] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas] ([PersonasId])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Personas]
GO
USE [master]
GO
ALTER DATABASE [Academia] SET  READ_WRITE 
GO
