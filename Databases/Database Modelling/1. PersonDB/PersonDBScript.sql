USE [master]
GO
/****** Object:  Database [PersonDB]    Script Date: 06/10/2015 13:01:30 ******/
CREATE DATABASE [PersonDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PersonDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PersonDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PersonDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PersonDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PersonDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PersonDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonDB] SET RECOVERY FULL 
GO
ALTER DATABASE [PersonDB] SET  MULTI_USER 
GO
ALTER DATABASE [PersonDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PersonDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PersonDB', N'ON'
GO
USE [PersonDB]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 06/10/2015 13:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[AddressText] [nvarchar](150) NOT NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continent]    Script Date: 06/10/2015 13:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[ContinentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[ContinentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 06/10/2015 13:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 06/10/2015 13:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 06/10/2015 13:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([AddressId], [AddressText], [TownId]) VALUES (1, N'2316 Oak Drive', 2)
INSERT [dbo].[Address] ([AddressId], [AddressText], [TownId]) VALUES (2, N'970 Smith Street', 15)
INSERT [dbo].[Address] ([AddressId], [AddressText], [TownId]) VALUES (3, N'972 Progress Way', 1)
INSERT [dbo].[Address] ([AddressId], [AddressText], [TownId]) VALUES (4, N'Meininger Strasse 32', 6)
INSERT [dbo].[Address] ([AddressId], [AddressText], [TownId]) VALUES (5, N'Rua Adélia Zaninelli Vons, 901', 4)
INSERT [dbo].[Address] ([AddressId], [AddressText], [TownId]) VALUES (6, N'2243 Eglinton Avenue', 17)
INSERT [dbo].[Address] ([AddressId], [AddressText], [TownId]) VALUES (7, N'Via Scala, 78', 10)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (2, N'Asia')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (3, N'North America')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (4, N'South America')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (5, N'Africa')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (6, N'Australia')
INSERT [dbo].[Continent] ([ContinentId], [Name]) VALUES (7, N'Antarctica')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (2, N'United States', 3)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (3, N'India', 2)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (4, N'Brazil', 4)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (5, N'Italy', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (6, N'Canada', 3)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (7, N'Argentina', 4)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (8, N'France', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (9, N'Spain', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (10, N'Mexico', 3)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (11, N'Ecuador', 4)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (12, N'Germany', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (13, N'China', 2)
INSERT [dbo].[Country] ([CountryId], [Name], [ContinentId]) VALUES (14, N'Japan', 2)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (1, N'Peter', N'Petrov', 3)
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (2, N'Matthew', N'Collins', 6)
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (3, N'Brenda', N'Ford', 1)
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (4, N'David', N'Jones', 2)
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (5, N'Christian', N'Cole', 4)
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (6, N'Antônio', N'Ferreira', 5)
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (8, N'Silvia', N'Milanesi', 7)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (2, N'New York', 2)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (3, N'Chicago', 2)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (4, N'Rio de Janeiro', 4)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (5, N'Vancouver', 6)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (6, N'München', 12)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (7, N'Barcelona', 9)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (8, N'Delhi', 3)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (9, N'Paris', 8)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (10, N'Rome', 5)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (11, N'Plovdiv', 1)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (13, N'Beijing', 13)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (14, N'Tokyo', 14)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (15, N'Seattle', 2)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (16, N'Ottawa', 6)
INSERT [dbo].[Town] ([TownId], [Name], [CountryId]) VALUES (17, N'Toronto', 6)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([TownId])
REFERENCES [dbo].[Town] ([TownId])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continent] ([ContinentId])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [PersonDB] SET  READ_WRITE 
GO
