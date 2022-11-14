USE [LibraryManagement]
GO
/****** Object:  Table [dbo].[AddBook]    Script Date: 11/13/2022 8:28:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddBook](
	[BId] [int] IDENTITY(1,1) NOT NULL,
	[BName] [varchar](50) NOT NULL,
	[BAuthor] [varchar](50) NOT NULL,
	[BPurchaseDate] [varchar](50) NOT NULL,
	[BPrice] [int] NOT NULL,
	[BQuantity] [int] NOT NULL,
 CONSTRAINT [PK_AddBook] PRIMARY KEY CLUSTERED 
(
	[BId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IRBook]    Script Date: 11/13/2022 8:28:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IRBook](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Enroll] [int] NOT NULL,
	[SName] [varchar](50) NOT NULL,
	[Department] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Contact] [bigint] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[BName] [varchar](50) NOT NULL,
	[BIssueDate] [varchar](50) NOT NULL,
	[BReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_IRBook] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginTable]    Script Date: 11/13/2022 8:28:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LoginTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewStudent]    Script Date: 11/13/2022 8:28:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewStudent](
	[SId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ENo] [int] NOT NULL,
	[Department] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Contact] [bigint] NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NewStudent] PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
