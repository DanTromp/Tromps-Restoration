USE [Tromps]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 06-05-2019 12:39:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[First Name] [nvarchar](50) NOT NULL,
	[Last Name] [nvarchar](50) NOT NULL,
	[Telphone Number] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[Email Address] [nvarchar](150) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hire Orders]    Script Date: 06-05-2019 12:39:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hire Orders](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[Customer ID] [int] NOT NULL,
	[Machine ID] [int] NOT NULL,
	[Cost Per Day] [money] NOT NULL,
	[Date Booked Out] [date] NOT NULL,
	[Date Booked In] [date] NULL,
 CONSTRAINT [PK_Hire Orders] PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Machine Services]    Script Date: 06-05-2019 12:39:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machine Services](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[Machine ID] [int] NOT NULL,
	[Cost of Service] [money] NOT NULL,
	[Day Booked Out] [date] NOT NULL,
	[Day Booked In] [date] NULL,
 CONSTRAINT [PK_Machine Services] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Machines]    Script Date: 06-05-2019 12:39:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machines](
	[Machine Id] [int] IDENTITY(1,1) NOT NULL,
	[Machine Name] [nvarchar](50) NOT NULL,
	[Machine Classification] [nvarchar](50) NOT NULL,
	[Machine Serial Number] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Machines] PRIMARY KEY CLUSTERED 
(
	[Machine Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [First Name], [Last Name], [Telphone Number], [Address], [Email Address]) VALUES (1, N'Dan', N'Tromp', N'0646588277', N'86 Cook Road, Claremont', N'dan@tromps.co.za')
INSERT [dbo].[Customers] ([CustomerId], [First Name], [Last Name], [Telphone Number], [Address], [Email Address]) VALUES (2, N'Kevin', N'Tromp', N'0823333971', N'57 Lansdowne Road, Claremont', N'kevin@tromps.co.za')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Hire Orders] ON 

INSERT [dbo].[Hire Orders] ([orderId], [Customer ID], [Machine ID], [Cost Per Day], [Date Booked Out], [Date Booked In]) VALUES (1, 2, 1, 150.0000, CAST(N'2019-05-01' AS Date), CAST(N'2019-05-11' AS Date))
SET IDENTITY_INSERT [dbo].[Hire Orders] OFF
SET IDENTITY_INSERT [dbo].[Machines] ON 

INSERT [dbo].[Machines] ([Machine Id], [Machine Name], [Machine Classification], [Machine Serial Number]) VALUES (1, N'Chain Saw', N'Heavy Duty', N'42168768526956')
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
