USE [G2-DK-Recruitment]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2021-01-21 10:36:58 ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[Characters]    Script Date: 2021-01-21 10:36:58 ******/
DROP TABLE [dbo].[Characters]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2021-01-21 10:36:58 ******/
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2021-01-21 10:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Characters]    Script Date: 2021-01-21 10:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Characters](
	[CharacterId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Characters] PRIMARY KEY CLUSTERED 
(
	[CharacterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2021-01-21 10:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210120075242_InitDatabase', N'5.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210120220111_SeedAdminUserData', N'5.0.2')
SET IDENTITY_INSERT [dbo].[Characters] ON 

INSERT [dbo].[Characters] ([CharacterId], [Name], [Description]) VALUES (1, N'Xardas', N'Necromancer')
INSERT [dbo].[Characters] ([CharacterId], [Name], [Description]) VALUES (2, N'Gorn', N'Warrior')
INSERT [dbo].[Characters] ([CharacterId], [Name], [Description]) VALUES (3, N'Diego', N'Thief')
SET IDENTITY_INSERT [dbo].[Characters] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Login], [Password]) VALUES (1, N'admin', N'AL2VQb6sLPN7W8pMtKdEwnXoHT3IPvneF2cTJogEdcM41Dy27bxPzaL9B0aKhVtGKQ==')
SET IDENTITY_INSERT [dbo].[Users] OFF
