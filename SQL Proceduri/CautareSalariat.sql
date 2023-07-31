CREATE PROCEDURE CautareSalariat
@MarcaSalariat int
AS
BEGIN
	select *
	from Salariati
	where MarcaSalariat=@MarcaSalariat
END
