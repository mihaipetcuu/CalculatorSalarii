USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[AdaugarePlataSalariu]    Script Date: 31/07/2021 09:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdaugarePlataSalariu] 
@MarcaSalariat int,
@Nume nvarchar(50),
@Prenume nvarchar(50),
@CNP  nvarchar(50),
@DataPlatii  datetime,
@PerioadaPlata   nvarchar(50),
@LunaPlata nvarchar(50),
@TarifOrar  decimal(18, 2),
@TarifOreSuplimentare decimal(18, 2),
@OreContract	decimal(18, 2),
@OreSuplimentare decimal(18, 2),
@OreLucrate	  decimal(18, 2),
@SalariuIncadrare money,
@Sporuri	 money,
@SalariuBrutRealizat		 money,
@ImpozitVenit			money,
@CAS  money,
@CASS	money,
@DeducerePersonala	money,
@TotalDeducere			money,
@SalariuNet			money
AS
BEGIN
INSERT INTO PlatiSalariu(MarcaSalariat, Nume, Prenume, CNP, DataPlatii, PeriodaPlata, LunaPlata, 
TarifOrar, TarifOreSuplimentare ,OreContract, OreSuplimentare,OreLucrate, SalariuIncadrare, Sporuri, 
SalariuBrutRealizat, ImpozitVenit, CAS, CASS, DeducerePersonala,TotalDeducere, SalariuNet)
	VALUES(@MarcaSalariat, @Nume, @Prenume, @CNP, @DataPlatii, @PerioadaPlata, @LunaPlata,
@TarifOrar, @TarifOreSuplimentare , @OreContract, @OreSuplimentare, @OreLucrate, @SalariuIncadrare, 
@Sporuri, @SalariuBrutRealizat, @ImpozitVenit, @CAS, @CASS, @DeducerePersonala,
@TotalDeducere, @SalariuNet);	
END

