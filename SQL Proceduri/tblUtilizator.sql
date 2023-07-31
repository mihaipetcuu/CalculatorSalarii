USE [CalculatorSalarii]
GO

/****** Object:  Table [dbo].[Utilizator]    Script Date: 31/07/2021 09:21:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Utilizator](
	[UtilizatorID] [int] IDENTITY(1,1) NOT NULL,
	[NumeUtilizator] [nvarchar](50) NOT NULL,
	[Parola] [nvarchar](50) NOT NULL,
	[Pozitie] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Utilizator] PRIMARY KEY CLUSTERED 
(
	[UtilizatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO





