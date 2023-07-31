USE [CalculatorSalarii]
GO

/****** Object:  Table [dbo].[tblAdmin]    Script Date: 31/07/2021 09:20:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblAdmin](
	[Admin] [nvarchar](50) NOT NULL,
	[Parola] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblAdmin] PRIMARY KEY CLUSTERED 
(
	[Admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

