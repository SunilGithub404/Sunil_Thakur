
CREATE DATABASE [Demo] 

USE [Demo]

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NULL,
	[Phone_No] [varchar](10) NULL,
	[Location] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [Phone_No], [Location]) VALUES (1, N'Sunil', N'Sunil4466', N'Sunil', N'Thakur', N'Sunil@d.com', N'2345678901', N'Pune')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [Phone_No], [Location]) VALUES (2, N'Rakesh', N'44444444', N'Raaaaaaaa', N'fdgh', N'r@gmail.com', N'2323232323', N'pune')
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[UserRegistration]    Script Date: 03/07/2017 01:25:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
