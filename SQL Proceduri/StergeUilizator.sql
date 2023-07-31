USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[StergereUtilizator]    Script Date: 31/07/2021 09:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StergereUtilizator]
@UtilizatorID as int
AS
BEGIN
	DELETE FROM Utilizator
	WHERE UtilizatorID = @UtilizatorID
END

