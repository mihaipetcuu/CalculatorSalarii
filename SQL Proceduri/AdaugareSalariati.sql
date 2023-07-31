CREATE PROCEDURE AdaugareSalariati
@MarcaSalariat int,
@Nume nvarchar(50),
@Prenume nvarchar(50),
@CNP nvarchar(50),
@Adresa nvarchar(50),
@Telefon nvarchar(50),
@DataNasterii date,
@Sex nvarchar(50),
@CI nvarchar(50),
@ContBancar nvarchar(50),
@NumeFisier nvarchar(50),
@Imagine image
AS
BEGIN
	INSERT INTO Salariati (MarcaSalariat, Nume, Prenume, CNP, Adresa, Telefon, [Data Nasterii], Sex, CI, ContBancar, NumeFisier, Imagine)
	values (@MarcaSalariat, @Nume, @Prenume, @CNP, @Adresa, @Telefon, @DataNasterii, @Sex, @CI, @ContBancar, @NumeFisier, @Imagine);
END
