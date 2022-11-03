USE [MicroFix]
GO
/****** Object:  User [mairon]    Script Date: 02/11/2022 20:03:04 ******/
CREATE USER [mairon] FOR LOGIN [mairon] WITH DEFAULT_SCHEMA=[mairon]
GO
/****** Object:  Schema [mairon]    Script Date: 02/11/2022 20:03:04 ******/
CREATE SCHEMA [mairon]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 02/11/2022 20:03:04 ******/
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
/****** Object:  Table [dbo].[Funcionario]    Script Date: 02/11/2022 20:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[IdFunc] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NULL,
	[Area] [nvarchar](50) NULL,
	[Senha] [nchar](50) NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[IdFunc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Microscopio]    Script Date: 02/11/2022 20:03:04 ******/
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
/****** Object:  Table [dbo].[Servico]    Script Date: 02/11/2022 20:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[IdServico] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NULL,
	[Prazo] [nvarchar](50) NULL,
	[Valor] [float] NULL,
	[IdEmpresa] [int] NULL,
	[IdFunc] [int] NULL,
	[DataChegada] [date] NULL,
 CONSTRAINT [PK_Servico] PRIMARY KEY CLUSTERED 
(
	[IdServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 02/11/2022 20:03:04 ******/
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
ALTER TABLE [dbo].[Servico]  WITH CHECK ADD  CONSTRAINT [FK_Servico_Empresa] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Servico] CHECK CONSTRAINT [FK_Servico_Empresa]
GO
ALTER TABLE [dbo].[Servico]  WITH CHECK ADD  CONSTRAINT [FK_Servico_Funcionario] FOREIGN KEY([IdFunc])
REFERENCES [dbo].[Funcionario] ([IdFunc])
GO
ALTER TABLE [dbo].[Servico] CHECK CONSTRAINT [FK_Servico_Funcionario]
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
