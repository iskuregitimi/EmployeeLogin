﻿USE [master]
GO
/****** Object:  Database [EmployeeLogin]    Script Date: 20.05.2019 14:46:03 ******/
CREATE DATABASE [EmployeeLogin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeLogin', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EmployeeLogin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeLogin_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EmployeeLogin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EmployeeLogin] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeLogin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeLogin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeLogin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeLogin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeLogin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeLogin] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeLogin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeLogin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeLogin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeLogin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeLogin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeLogin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeLogin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeLogin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeLogin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeLogin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeLogin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeLogin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeLogin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeLogin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeLogin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeLogin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeLogin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeLogin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EmployeeLogin] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeLogin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeLogin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeLogin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeLogin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmployeeLogin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EmployeeLogin] SET QUERY_STORE = OFF
GO
USE [EmployeeLogin]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [EmployeeLogin]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 20.05.2019 14:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeRole]    Script Date: 20.05.2019 14:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeRole](
	[EmployeeRoleID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeRole] PRIMARY KEY CLUSTERED 
(
	[EmployeeRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 20.05.2019 14:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([EmployeeID], [Name], [Email], [Password]) VALUES (1, N'Hasan', N'hasan@gmail.com', N'123')
GO
INSERT [dbo].[Employee] ([EmployeeID], [Name], [Email], [Password]) VALUES (2, N'Mehmet', N'mehmet@gmail.com', N'123')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[EmployeeRole] ON 
GO
INSERT [dbo].[EmployeeRole] ([EmployeeRoleID], [EmployeeID], [RoleID]) VALUES (1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[EmployeeRole] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([RoleID], [Name]) VALUES (1, N'Admin     ')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
USE [master]
GO
ALTER DATABASE [EmployeeLogin] SET  READ_WRITE 
GO
