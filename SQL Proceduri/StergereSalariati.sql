USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[StergereSalariati]    Script Date: 14.07.2023 08:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[StergereSalariati]
@MarcaSalariat int
AS
BEGIN
	DELETE FROM Salariati where MarcaSalariat=@MarcaSalariat
END

