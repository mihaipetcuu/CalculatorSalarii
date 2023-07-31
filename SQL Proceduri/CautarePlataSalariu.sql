USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[CautarePlataSalariu]    Script Date: 26/07/2021 09:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE  [dbo].[CautarePlataSalariu]
@Nume as nvarchar(50)
AS
BEGIN
	select *
	from PlatiSalariu
	where  @Nume = '' or
	Nume = @Nume
END

