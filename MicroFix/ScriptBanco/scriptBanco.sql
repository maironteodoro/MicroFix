USE [MicroFix]
GO
/****** Object:  User [mairon]    Script Date: 05/11/2022 18:09:34 ******/
CREATE USER [mairon] FOR LOGIN [mairon] WITH DEFAULT_SCHEMA=[mairon]
GO
/****** Object:  Schema [mairon]    Script Date: 05/11/2022 18:09:34 ******/
CREATE SCHEMA [mairon]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 05/11/2022 18:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NULL,
	[Localizacao] [nvarchar](50) NULL,
	[CNPJ] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NomeResp] [nvarchar](50) NULL,
	[Telefone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Microscopio]    Script Date: 05/11/2022 18:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Microscopio](
	[IdMicroscopio] [int] IDENTITY(1,1) NOT NULL,
	[Sala] [nvarchar](50) NULL,
	[Marca] [nvarchar](50) NULL,
	[NumSerie] [nvarchar](50) NULL,
	[Modelo] [nvarchar](50) NULL,
	[NumPatrimonio] [nvarchar](50) NULL,
 CONSTRAINT [PK_Microscopio] PRIMARY KEY CLUSTERED 
(
	[IdMicroscopio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 05/11/2022 18:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[IdServico] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NULL,
	[Prazo] [datetime] NULL,
	[Valor] [float] NULL,
	[IdEmpresa] [int] NULL,
	[IdFunc] [nvarchar](50) NULL,
	[DataChegada] [datetime] NULL,
 CONSTRAINT [PK_Servico] PRIMARY KEY CLUSTERED 
(
	[IdServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 05/11/2022 18:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[IdStatus] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[IdMicroscopio] [int] NOT NULL,
	[IdServico] [int] NOT NULL,
	[DescricaoProblema] [nchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([IdEmpresa], [Nome], [Localizacao], [CNPJ], [Email], [NomeResp], [Telefone]) VALUES (2, N'Burgão do seu Zé', N'Na rua de cima de casa', N'456987', N'Burgãodoze@gmail.com', N'Seu Zé', N'32589416')
SET IDENTITY_INSERT [dbo].[Empresa] OFF
GO
SET IDENTITY_INSERT [dbo].[Microscopio] ON 

INSERT [dbo].[Microscopio] ([IdMicroscopio], [Sala], [Marca], [NumSerie], [Modelo], [NumPatrimonio]) VALUES (2, N'20', N'hilton', N'123456', N'octogonal', N'78963')
SET IDENTITY_INSERT [dbo].[Microscopio] OFF
GO
ALTER TABLE [dbo].[Servico]  WITH CHECK ADD  CONSTRAINT [FK_Servico_Empresa] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Servico] CHECK CONSTRAINT [FK_Servico_Empresa]
GO
ALTER TABLE [dbo].[Status]  WITH CHECK ADD  CONSTRAINT [FK_Status_Microscopio] FOREIGN KEY([IdMicroscopio])
REFERENCES [dbo].[Microscopio] ([IdMicroscopio])
GO
ALTER TABLE [dbo].[Status] CHECK CONSTRAINT [FK_Status_Microscopio]
GO
ALTER TABLE [dbo].[Status]  WITH CHECK ADD  CONSTRAINT [FK_Status_Servico] FOREIGN KEY([IdServico])
REFERENCES [dbo].[Servico] ([IdServico])
GO
ALTER TABLE [dbo].[Status] CHECK CONSTRAINT [FK_Status_Servico]
GO
