USE [master]
GO
/****** Object:  Database [gamesrental]    Script Date: 5/30/2022 10:14:38 PM ******/
CREATE DATABASE [gamesrental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gamesrental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gamesrental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gamesrental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gamesrental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gamesrental] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gamesrental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gamesrental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gamesrental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gamesrental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gamesrental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gamesrental] SET ARITHABORT OFF 
GO
ALTER DATABASE [gamesrental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gamesrental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gamesrental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gamesrental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gamesrental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gamesrental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gamesrental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gamesrental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gamesrental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gamesrental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gamesrental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gamesrental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gamesrental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gamesrental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gamesrental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gamesrental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gamesrental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gamesrental] SET RECOVERY FULL 
GO
ALTER DATABASE [gamesrental] SET  MULTI_USER 
GO
ALTER DATABASE [gamesrental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gamesrental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gamesrental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gamesrental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gamesrental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gamesrental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'gamesrental', N'ON'
GO
ALTER DATABASE [gamesrental] SET QUERY_STORE = OFF
GO
USE [gamesrental]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 5/30/2022 10:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[admin_name] [varchar](150) NOT NULL,
	[day] [int] NOT NULL,
	[month] [int] NOT NULL,
	[year] [int] NOT NULL,
	[admin_ID] [int] NOT NULL,
	[admin_phonenum] [int] NOT NULL,
	[admin_gender] [varchar](150) NOT NULL,
	[admin_country] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[admin_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 5/30/2022 10:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[client_name] [varchar](150) NOT NULL,
	[client_gender] [varchar](100) NOT NULL,
	[client_country] [varchar](150) NOT NULL,
	[client_phonenum] [int] NOT NULL,
	[day] [int] NOT NULL,
	[month] [int] NOT NULL,
	[year] [int] NOT NULL,
	[client_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[game]    Script Date: 5/30/2022 10:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[game](
	[game_name] [varchar](150) NOT NULL,
	[game_ID] [int] NOT NULL,
	[category] [varchar](150) NOT NULL,
	[day] [int] NULL,
	[month] [int] NULL,
	[year] [int] NULL,
	[vendorname] [varchar](150) NOT NULL,
	[vendor_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[game_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rent]    Script Date: 5/30/2022 10:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rent](
	[game_name] [varchar](150) NOT NULL,
	[game_ID] [int] NOT NULL,
	[client_name] [varchar](150) NULL,
	[client_ID] [int] NOT NULL,
	[vendor_ID] [int] NOT NULL,
	[vendor_name] [varchar](150) NULL,
	[rent_month] [int] NULL,
	[return_month] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 5/30/2022 10:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[username] [varchar](150) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[password] [varchar](250) NOT NULL,
	[client_ID] [int] NULL,
	[admin_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendor]    Script Date: 5/30/2022 10:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendor](
	[vendorname] [varchar](150) NOT NULL,
	[vendor_ID] [int] NULL,
	[vendorcountry] [varchar](150) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD FOREIGN KEY([admin_ID])
REFERENCES [dbo].[admin] ([admin_ID])
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD FOREIGN KEY([client_ID])
REFERENCES [dbo].[client] ([client_ID])
GO
USE [master]
GO
ALTER DATABASE [gamesrental] SET  READ_WRITE 
GO
