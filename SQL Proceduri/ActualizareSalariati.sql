CREATE PROCEDURE ActualizareAngajat
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
	UPDATE Salariati SET MarcaSalariat=@MarcaSalariat, Nume=@Nume, Prenume=@Prenume, CNP=@CNP, Adresa=@Adresa, Telefon=@Telefon, [Data Nasterii]=@DataNasterii, Sex=@Sex, CI=@CI, ContBancar=@ContBancar, NumeFisier=@NumeFisier, Imagine=@Imagine
	WHERE MarcaSalariat=@MarcaSalariat
END

