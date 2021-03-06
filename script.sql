USE [master]
GO
/****** Object:  Database [RentAcar]    Script Date: 3/19/2022 9:50:47 PM ******/
CREATE DATABASE [RentAcar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentAcar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentAcar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentAcar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentAcar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RentAcar] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentAcar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentAcar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentAcar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentAcar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentAcar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentAcar] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentAcar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentAcar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentAcar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentAcar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentAcar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentAcar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentAcar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentAcar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentAcar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentAcar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentAcar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentAcar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentAcar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentAcar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentAcar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentAcar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentAcar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentAcar] SET RECOVERY FULL 
GO
ALTER DATABASE [RentAcar] SET  MULTI_USER 
GO
ALTER DATABASE [RentAcar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentAcar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentAcar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentAcar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentAcar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentAcar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RentAcar', N'ON'
GO
ALTER DATABASE [RentAcar] SET QUERY_STORE = OFF
GO
USE [RentAcar]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cedula] [bigint] NOT NULL,
	[NoTarjetaCR] [bigint] NULL,
	[LimiteDeCredito] [bigint] NULL,
	[TipoPersona] [varchar](50) NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Cedula] [varchar](50) NULL,
	[TandaLabor] [varchar](50) NULL,
	[PorcientoComision] [varchar](50) NULL,
	[FechaIngreso] [datetime] NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inspeccion]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inspeccion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Idvehiculo] [int] NULL,
	[Idcliente] [int] NULL,
	[TieneRalladuras] [nvarchar](50) NULL,
	[CantidadCombustible] [nvarchar](50) NULL,
	[TieneGomaRepuesta] [varchar](50) NULL,
	[TieneGato] [varchar](50) NULL,
	[TieneRoturasCristal] [varchar](50) NULL,
	[EstadoGomas] [varchar](50) NULL,
	[Fecha] [datetime] NULL,
	[IdEmpleadoInspeccion] [int] NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Inspeccion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMarca] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentaDevolucion]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentaDevolucion](
	[NoRenta] [int] IDENTITY(1,1) NOT NULL,
	[Idempleado] [int] NOT NULL,
	[Idvehiculo] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[FechaRenta] [datetime] NOT NULL,
	[FechaDevolucion] [datetime] NOT NULL,
	[Montoxdia] [bigint] NULL,
	[CantidadDeDias] [int] NULL,
	[Comentario] [varchar](200) NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_RentaDevolucion] PRIMARY KEY CLUSTERED 
(
	[NoRenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDecombustible]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDecombustible](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_TiposDecombustible] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDeVehiculos]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDeVehiculos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposDeVehiculos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User] [varchar](50) NULL,
	[Password] [nchar](10) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 3/19/2022 9:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](300) NULL,
	[NChasis] [int] NULL,
	[NMotor] [int] NULL,
	[NPlaca] [varchar](10) NULL,
	[TipoDeVehiculo] [varchar](50) NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[TipoDeCombustible] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [RentAcar] SET  READ_WRITE 
GO
