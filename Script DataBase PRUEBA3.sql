USE [master]
GO
/****** Object:  Database [PRUEBA3]    Script Date: 06-06-2019 7:46:27 ******/
CREATE DATABASE [PRUEBA3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRUEBA3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PRUEBA3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRUEBA3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PRUEBA3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PRUEBA3] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRUEBA3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRUEBA3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRUEBA3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRUEBA3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRUEBA3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRUEBA3] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRUEBA3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRUEBA3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRUEBA3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRUEBA3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRUEBA3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRUEBA3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRUEBA3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRUEBA3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRUEBA3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRUEBA3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PRUEBA3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRUEBA3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRUEBA3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRUEBA3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRUEBA3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRUEBA3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRUEBA3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRUEBA3] SET RECOVERY FULL 
GO
ALTER DATABASE [PRUEBA3] SET  MULTI_USER 
GO
ALTER DATABASE [PRUEBA3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRUEBA3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRUEBA3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRUEBA3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRUEBA3] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PRUEBA3', N'ON'
GO
ALTER DATABASE [PRUEBA3] SET QUERY_STORE = OFF
GO
USE [PRUEBA3]
GO
/****** Object:  Table [dbo].[camion]    Script Date: 06-06-2019 7:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[camion](
	[id_camion] [int] NOT NULL,
	[matricula] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
	[potencia] [varchar](50) NULL,
 CONSTRAINT [PK_camion] PRIMARY KEY CLUSTERED 
(
	[id_camion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[camionero]    Script Date: 06-06-2019 7:46:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[camionero](
	[id_camionero] [int] NOT NULL,
	[rut] [nchar](10) NULL,
	[nombre] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[salario] [varchar](50) NULL,
	[poblacion] [varchar](50) NULL,
 CONSTRAINT [PK_camionero] PRIMARY KEY CLUSTERED 
(
	[id_camionero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paquete]    Script Date: 06-06-2019 7:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paquete](
	[id_paquete] [int] NOT NULL,
	[descripcion] [nchar](200) NULL,
	[destinatario] [nvarchar](50) NULL,
	[direccion_destino] [nvarchar](50) NULL,
	[id_camionero] [int] NULL,
	[id_provincia] [int] NULL,
 CONSTRAINT [PK_paquete] PRIMARY KEY CLUSTERED 
(
	[id_paquete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paquete_transporte]    Script Date: 06-06-2019 7:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paquete_transporte](
	[id_paquete] [int] NULL,
	[id_transporte] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[provincia]    Script Date: 06-06-2019 7:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provincia](
	[id_provincia] [int] NOT NULL,
	[nombre_provincia] [varchar](50) NULL,
 CONSTRAINT [PK_provincia] PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transporte]    Script Date: 06-06-2019 7:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transporte](
	[id_transporte] [int] NOT NULL,
	[id_camion] [int] NULL,
	[id_camionero] [int] NULL,
	[id_paquete] [int] NULL,
	[fecha] [nchar](10) NULL,
	[id_provincia] [int] NULL,
 CONSTRAINT [PK_transporte] PRIMARY KEY CLUSTERED 
(
	[id_transporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[camion] ([id_camion], [matricula], [modelo], [tipo], [potencia]) VALUES (1, N'c11', N'c11', N'c11', N'c11')
INSERT [dbo].[camion] ([id_camion], [matricula], [modelo], [tipo], [potencia]) VALUES (2, N'c2', N'c2', N'c2', N'c2')
INSERT [dbo].[camionero] ([id_camionero], [rut], [nombre], [telefono], [direccion], [salario], [poblacion]) VALUES (1, N'q1        ', N'q1', N'q1', N'q1', N'q1', N'q1')
INSERT [dbo].[camionero] ([id_camionero], [rut], [nombre], [telefono], [direccion], [salario], [poblacion]) VALUES (2, N'q222      ', N'q222', N'q222', N'q222', N'q222', N'q222')
INSERT [dbo].[paquete] ([id_paquete], [descripcion], [destinatario], [direccion_destino], [id_camionero], [id_provincia]) VALUES (1, N'p1                                                                                                                                                                                                      ', N'p1', N'p1', 1, 1)
INSERT [dbo].[paquete] ([id_paquete], [descripcion], [destinatario], [direccion_destino], [id_camionero], [id_provincia]) VALUES (2, N'p222                                                                                                                                                                                                    ', N'p222', N'p222', 2, 2)
INSERT [dbo].[provincia] ([id_provincia], [nombre_provincia]) VALUES (1, N'w1')
INSERT [dbo].[provincia] ([id_provincia], [nombre_provincia]) VALUES (2, N'w222')
INSERT [dbo].[transporte] ([id_transporte], [id_camion], [id_camionero], [id_paquete], [fecha], [id_provincia]) VALUES (1, 1, 1, 1, N't1        ', 1)
INSERT [dbo].[transporte] ([id_transporte], [id_camion], [id_camionero], [id_paquete], [fecha], [id_provincia]) VALUES (2, 2, 2, 2, N't2        ', 2)
ALTER TABLE [dbo].[paquete_transporte]  WITH CHECK ADD  CONSTRAINT [FK_paquete_transporte_paquete] FOREIGN KEY([id_paquete])
REFERENCES [dbo].[paquete] ([id_paquete])
GO
ALTER TABLE [dbo].[paquete_transporte] CHECK CONSTRAINT [FK_paquete_transporte_paquete]
GO
ALTER TABLE [dbo].[paquete_transporte]  WITH CHECK ADD  CONSTRAINT [FK_paquete_transporte_transporte] FOREIGN KEY([id_paquete])
REFERENCES [dbo].[transporte] ([id_transporte])
GO
ALTER TABLE [dbo].[paquete_transporte] CHECK CONSTRAINT [FK_paquete_transporte_transporte]
GO
ALTER TABLE [dbo].[transporte]  WITH CHECK ADD  CONSTRAINT [FK_transporte_camion] FOREIGN KEY([id_camion])
REFERENCES [dbo].[camion] ([id_camion])
GO
ALTER TABLE [dbo].[transporte] CHECK CONSTRAINT [FK_transporte_camion]
GO
ALTER TABLE [dbo].[transporte]  WITH CHECK ADD  CONSTRAINT [FK_transporte_camionero] FOREIGN KEY([id_camionero])
REFERENCES [dbo].[camionero] ([id_camionero])
GO
ALTER TABLE [dbo].[transporte] CHECK CONSTRAINT [FK_transporte_camionero]
GO
ALTER TABLE [dbo].[transporte]  WITH CHECK ADD  CONSTRAINT [FK_transporte_provincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[provincia] ([id_provincia])
GO
ALTER TABLE [dbo].[transporte] CHECK CONSTRAINT [FK_transporte_provincia]
GO
USE [master]
GO
ALTER DATABASE [PRUEBA3] SET  READ_WRITE 
GO
