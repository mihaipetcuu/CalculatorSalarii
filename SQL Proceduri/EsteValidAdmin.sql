USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[esteValidAdmin]    Script Date: 31/07/2021 09:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[esteValidAdmin]
@Admin as nvarchar(50),
@Parola as nvarchar(50)
AS
BEGIN 
	DECLARE @EsteValid BIT
	SET @EsteValid = 0
	
	IF EXISTS(SELECT * FROM tblAdmin
	WHERE [Admin] = @Admin AND
	Parola = @Parola)

	BEGIN
	SET @EsteValid = 1
	END
	
	SELECT @EsteValid
END

