USE [ApiTest]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 26/11/2023 3:57:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SharedKey] [nvarchar](max) NOT NULL,
	[BusinessId] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [bigint] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id], [SharedKey], [BusinessId], [Email], [Phone], [StartDate], [EndDate]) VALUES (1, N'ogutierrez7', N'oscar gutierrez alba', N'ozkrg@gmail.com', 3016780459, CAST(N'2023-11-25T03:04:53.6280000' AS DateTime2), CAST(N'2023-11-30T03:04:53.6280000' AS DateTime2))
INSERT [dbo].[Clientes] ([Id], [SharedKey], [BusinessId], [Email], [Phone], [StartDate], [EndDate]) VALUES (2, N'alianzat', N'test alianza', N'test@alianza.com', 7878674535, CAST(N'2023-11-17T07:00:00.0000000' AS DateTime2), CAST(N'2023-11-28T05:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
