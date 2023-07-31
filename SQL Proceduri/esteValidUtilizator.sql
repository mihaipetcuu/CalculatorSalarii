USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[esteValidUtilizator]    Script Date: 31/07/2021 09:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[esteValidUtilizator]
@NumeUtilizator as nvarchar(50),
@Parola as nvarchar(50)
AS
BEGIN 
	DECLARE @EsteValid BIT
	SET @EsteValid = 0
	
	IF EXISTS(SELECT * FROM Utilizator
	WHERE NumeUtilizator = @NumeUtilizator AND
	Parola = @Parola)

	BEGIN
	SET @EsteValid = 1
	END
	
	SELECT @EsteValid
END
