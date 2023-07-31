USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[VerificaUtilizator]    Script Date: 31/07/2021 09:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerificaUtilizator]
@NumeUtilizator as nvarchar(50),
@Parola as nvarchar(50)	
AS
BEGIN
	SELECT * FROM Utilizator
	WHERE NumeUtilizator = @NumeUtilizator OR
	Parola = @Parola	
END