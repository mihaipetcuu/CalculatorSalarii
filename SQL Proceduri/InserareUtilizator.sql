USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[InserareUtilizator]    Script Date: 31/07/2021 09:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserareUtilizator]
@NumeUtilizator as nvarchar(50),
@Parola as nvarchar(50),
@Pozitie as nvarchar(50)

AS
BEGIN
	INSERT INTO Utilizator(NumeUtilizator, Parola, Pozitie)
	VALUES(@NumeUtilizator, @Parola, @Pozitie);	
END

