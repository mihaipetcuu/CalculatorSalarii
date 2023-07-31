USE [CalculatorSalarii]
GO

/****** Object:  Table [dbo].[PlatiSalariu]    Script Date: 31/07/2021 09:18:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PlatiSalariu](
	[CodBorderou] [int] IDENTITY(1,1) NOT NULL,
	[MarcaSalariat] [int] NOT NULL,
	[Nume] [nvarchar](50) NOT NULL,
	[Prenume] [nvarchar](50) NOT NULL,
	[CNP] [nvarchar](50) NOT NULL,
	[DataPlatii] [date] NOT NULL,
	[PeriodaPlata] [nvarchar](50) NOT NULL,
	[LunaPlata] [nvarchar](50) NOT NULL,
	[TarifOrar] [decimal](18, 2) NOT NULL,
	[TarifOreSuplimentare] [decimal](18, 2) NOT NULL,
	[OreContract] [decimal](18, 2) NOT NULL,
	[OreSuplimentare] [decimal](18, 2) NOT NULL,
	[OreLucrate] [decimal](18, 2) NOT NULL,
	[SalariuIncadrare] [money] NOT NULL,
	[Sporuri] [money] NOT NULL,
	[SalariuBrutRealizat] [money] NOT NULL,
	[ImpozitVenit] [money] NOT NULL,
	[CAS] [money] NOT NULL,
	[CASS] [money] NOT NULL,
	[DeducerePersonala] [money] NOT NULL,
	[TotalDeducere] [money] NOT NULL,
	[SalariuNet] [money] NOT NULL,
 CONSTRAINT [PK_PlatiSalariu] PRIMARY KEY CLUSTERED 
(
	[CodBorderou] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PlatiSalariu]  WITH CHECK ADD  CONSTRAINT [FK_PlatiSalariu_Salariati] FOREIGN KEY([MarcaSalariat])
REFERENCES [dbo].[Salariati] ([MarcaSalariat])
GO

ALTER TABLE [dbo].[PlatiSalariu] CHECK CONSTRAINT [FK_PlatiSalariu_Salariati]
GO


