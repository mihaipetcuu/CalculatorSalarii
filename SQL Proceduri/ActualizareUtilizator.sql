USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[ActualizareUtilizator]    Script Date: 31/07/2021 09:22:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizareUtilizator]
@UtilizatorID as int,
@NumeUtilizator as nvarchar(50),
@Parola	as nvarchar(50),
@Pozitie as nvarchar(50)
AS
BEGIN
	UPDATE Utilizator SET NumeUtilizator = @NumeUtilizator, Parola = @Parola,
	Pozitie = @Pozitie
	WHERE UtilizatorID = @UtilizatorID
END

