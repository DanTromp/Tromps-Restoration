USE [master]
GO
/****** Object:  Database [Tromps]    Script Date: 2019/05/31 09:50:53 AM ******/
CREATE DATABASE [Tromps]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tromps', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQL\MSSQL\DATA\Tromps.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Tromps_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQL\MSSQL\DATA\Tromps_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Tromps] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tromps].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tromps] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tromps] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tromps] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tromps] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tromps] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tromps] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tromps] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tromps] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tromps] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tromps] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tromps] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tromps] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tromps] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tromps] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tromps] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tromps] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tromps] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tromps] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tromps] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tromps] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tromps] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tromps] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tromps] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tromps] SET  MULTI_USER 
GO
ALTER DATABASE [Tromps] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tromps] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tromps] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tromps] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Tromps] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Tromps]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2019/05/31 09:50:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[First Name] [nvarchar](50) NOT NULL,
	[Last Name] [nvarchar](50) NOT NULL,
	[ID Number] [nvarchar](13) NOT NULL,
	[Telphone Number] [nvarchar](50) NOT NULL,
	[Email Address] [nvarchar](250) NULL,
	[Address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hire Orders]    Script Date: 2019/05/31 09:50:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hire Orders](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[Customer ID] [int] NOT NULL,
	[Machine ID] [int] NOT NULL,
	[Date Booked Out] [date] NOT NULL,
	[Date Booked In] [date] NOT NULL,
	[Invoice Number] [nvarchar](50) NOT NULL,
	[Cost Per Day] [smallmoney] NOT NULL,
	[Total Cost] [smallmoney] NULL,
 CONSTRAINT [PK_Hire Orders] PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 2019/05/31 09:50:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[InvoiceNo] [nvarchar](10) NOT NULL,
	[HirerName] [nvarchar](max) NOT NULL,
	[HirerAddress] [nvarchar](max) NOT NULL,
	[HirerTelNo] [nvarchar](50) NOT NULL,
	[HirerIdentityNo] [nvarchar](13) NOT NULL,
	[HirerCarReg] [nvarchar](50) NOT NULL,
	[HirerCarMakeModel] [nvarchar](50) NOT NULL,
	[AddressWhereUsed] [nvarchar](max) NOT NULL,
	[SpecialInstructions] [nvarchar](max) NULL,
	[InitialPaymentReceived] [smallmoney] NULL,
	[StartOfHire] [datetime] NOT NULL,
	[EquipmentDueBack] [datetime] NOT NULL,
	[EndOfHire] [datetime] NOT NULL,
	[EquipmentNos] [nvarchar](50) NOT NULL,
	[EquipmentSubtotal] [smallmoney] NOT NULL,
	[Accessories] [nvarchar](50) NULL,
	[AccessoriesSubtotal] [smallmoney] NULL,
	[Discount] [smallmoney] NULL,
	[Delivery] [smallmoney] NULL,
	[Collection] [smallmoney] NULL,
	[Other] [smallmoney] NULL,
	[GrandTotal] [smallmoney] NOT NULL,
	[HowDidYouKnowUs] [nvarchar](max) NULL,
	[InvoiceDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Machine Services]    Script Date: 2019/05/31 09:50:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machine Services](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[Machine ID] [int] NOT NULL,
	[Day Booked Out] [date] NOT NULL,
	[Day Booked In] [date] NOT NULL,
	[Cost of Service] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Machine Services] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Machines]    Script Date: 2019/05/31 09:50:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machines](
	[Machine Id] [int] IDENTITY(1,1) NOT NULL,
	[Machine Number] [int] NOT NULL,
	[Machine Name] [nvarchar](50) NOT NULL,
	[Machine Classification] [nvarchar](50) NOT NULL,
	[Machine Serial Number] [nvarchar](150) NULL,
	[Daily Rate] [smallmoney] NULL,
	[Deposit] [smallmoney] NULL,
 CONSTRAINT [PK_Machines] PRIMARY KEY CLUSTERED 
(
	[Machine Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [First Name], [Last Name], [ID Number], [Telphone Number], [Email Address], [Address]) VALUES (1, N'Ben', N'Smith', N'9209255131065', N'(064) 658-8277', NULL, N'86 Cook Road')
INSERT [dbo].[Customers] ([CustomerId], [First Name], [Last Name], [ID Number], [Telphone Number], [Email Address], [Address]) VALUES (2, N'Amy', N'Smurf', N'9209255131062', N'(064) 658-8277', NULL, N'88 Templeton Road')
INSERT [dbo].[Customers] ([CustomerId], [First Name], [Last Name], [ID Number], [Telphone Number], [Email Address], [Address]) VALUES (3, N'Amy', N'Smurf', N'9209255131064', N'(064) 658-8277', NULL, N'88 Templeton Road')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Machines] ON 

INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (1, 19, N'Hilti Rotary Drill Kit', N'Drills', N'228819', 130.0000, 500.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (2, 25, N'Bosch Jigsaw Kit', N'Power Tools', NULL, 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (3, 32, N'Makita Belt Sander', N'Sander', NULL, 130.0000, 400.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (4, 89, N'Makita Mitre Saw', N'Power Tools', N'174384', 200.0000, 600.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (5, 97, N'Makita Cut-Off Saw', N'Power Tools', N'84641E', 120.0000, 400.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (6, 98, N'Makita Cut-Off Saw', N'Power Tools', N'900153E', 120.0000, 400.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (7, 10, N'Hitachi Electromagnetic Drill Kit', N'Drills', NULL, 130.0000, 500.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (8, 11, N'Bosch Heat Gun', N'Power Tools', NULL, 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (9, 12, N'Bosch Heat Gun', N'Power Tools', NULL, 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (10, 34, N'Stihl Weed Wacker', N'Lawn & Garden', N'434741673', 250.0000, 750.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (11, 22, N'Bosch Breaker Medium', N'Breakers', N'604000232', 250.0000, 750.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (12, 23, N'Bosch Breaker Large', N'Breakers', N'605000266', 350.0000, 1500.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (13, 24, N'Hilti Pull Tester', N'Pull Tester', N'596040400594212', NULL, NULL)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (14, 26, N'Hilti Nail Gun', N'Miscellaneous', N'2329840717356600', 120.0000, 550.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (15, 3, N'Makita Angle Grinder', N'Power Tools', N'1139475', 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (16, 4, N'Makita Angle Grinder', N'Power Tools', N'1083852', 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (17, 2, N'Makita Electric Orbital Sander', N'Sanders', N'19887E', 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (18, 1, N'Makita Electric Orbital Sander', N'Sanders', N'19896E', 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (19, 5, N'Makita Electric Wood Planer', N'Power Tools', N'22873G', 100.0000, 300.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (20, 18, N'Stihl Petrol Chainsaw', N'Lawn & Garden', NULL, 400.0000, 1600.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (21, 20, N'Stihl Petrol Chainsaw', N'Lawn & Garden', NULL, 400.0000, 1600.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (22, 17, N'Stihl Electric Chainsaw', N'Lawn & Garden', NULL, 250.0000, 750.0000)
INSERT [dbo].[Machines] ([Machine Id], [Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number], [Daily Rate], [Deposit]) VALUES (23, 21, N'Stihl Hedge Trimmer', N'Lawn & Garden', NULL, 160.0000, 500.0000)
SET IDENTITY_INSERT [dbo].[Machines] OFF
ALTER TABLE [dbo].[Hire Orders]  WITH CHECK ADD  CONSTRAINT [FK_Hire Orders_Customers] FOREIGN KEY([Customer ID])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Hire Orders] CHECK CONSTRAINT [FK_Hire Orders_Customers]
GO
ALTER TABLE [dbo].[Hire Orders]  WITH CHECK ADD  CONSTRAINT [FK_Hire Orders_Machines] FOREIGN KEY([Machine ID])
REFERENCES [dbo].[Machines] ([Machine Id])
GO
ALTER TABLE [dbo].[Hire Orders] CHECK CONSTRAINT [FK_Hire Orders_Machines]
GO
ALTER TABLE [dbo].[Machine Services]  WITH CHECK ADD  CONSTRAINT [FK_Machine Services_Machines] FOREIGN KEY([Machine ID])
REFERENCES [dbo].[Machines] ([Machine Id])
GO
ALTER TABLE [dbo].[Machine Services] CHECK CONSTRAINT [FK_Machine Services_Machines]
GO
USE [master]
GO
ALTER DATABASE [Tromps] SET  READ_WRITE 
GO
