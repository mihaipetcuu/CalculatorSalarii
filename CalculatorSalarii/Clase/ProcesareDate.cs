using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public class ProcesareDate
    {
        public void InserareSalariati(int marcasalariat, string nume, string prenume, string cnp,
            string adresa, string telefon, string datanasterii, string sex, string ci,
            string contbancar, string numefisier, byte[] imagine)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection(Conectare.ConSir("SalariatiDB")))
            {
                List<DateAngajati> obAngajati = new List<DateAngajati>();

                obAngajati.Add(new DateAngajati
                {
                    MarcaSalariat=marcasalariat,
                    Nume=nume,
                    Prenume=prenume,
                    CNP=cnp,
                    Adresa=adresa,
                    Telefon=telefon,
                    DataNasterii=datanasterii,
                    Sex=sex,
                    CI=ci,
                    ContBancar=contbancar,
                    NumeFisier=numefisier,
                    Imagine=imagine
                });

                conectare.Execute("AdaugareSalariati @MarcaSalariat, @Nume, @Prenume, @CNP," +
                    "@Adresa, @Telefon, @DataNasterii, @Sex, @CI, @ContBancar, @NumeFisier," +
                    "@Imagine", obAngajati);

                conectare.Close();
            }
        }

        public void ActualizareSalariat(int marcasalariat, string nume, string prenume, string cnp,
            string adresa, string telefon, string datanasterii, string sex, string ci,
            string contbancar, string numefisier, byte[] imagine)
        {
            using(IDbConnection conectare = new System.Data.SqlClient.SqlConnection(Conectare.ConSir("SalariatiDB")))
            {
                List<DateAngajati> obAngajati = new List<DateAngajati>();

                obAngajati.Add(new DateAngajati
                {
                    MarcaSalariat = marcasalariat,
                    Nume = nume,
                    Prenume = prenume,
                    CNP = cnp,
                    Adresa = adresa,
                    Telefon = telefon,
                    DataNasterii = datanasterii,
                    Sex = sex,
                    CI = ci,
                    ContBancar = contbancar,
                    NumeFisier = numefisier,
                    Imagine = imagine
                });

                conectare.Execute("ActualizareSalariati @MarcaSalariat, @Nume, @Prenume, @CNP," +
                    "@Adresa, @Telefon, @DataNasterii, @Sex, @CI, @ContBancar, @NumeFisier," +
                    "@Imagine", obAngajati);
                conectare.Close();
            }
        }

        public void StergereSalariat(int marcasalariat)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection(Conectare.ConSir("SalariatiDB")))
            {
                DateAngajati StergereSalariat = new DateAngajati { MarcaSalariat = marcasalariat };

                conectare.Execute("StergereSalariati @MarcaSalariat", StergereSalariat);
                conectare.Close();
            }
        }

        public List<DateAngajati> CautareSalariat(int marcaSalariat)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection(Conectare.ConSir("SalariatiDB")))
            {
                if (conectare.State == ConnectionState.Closed)
                    conectare.Open();

                var rezultat = conectare.Query<DateAngajati>("CautareSalariat @MarcaSalariat", new { MarcaSalariat = marcaSalariat }).ToList();

                conectare.Close();

                return rezultat;
            }
        }

        public void InserareSalariu(int marcaSalariat, string nume, string prenume, string cnp, string dataplatii,
            string perioadaPlata, string lunaPlata, string tarifOrar, string tarifOreSuplimentare, string oreContract, string oreSuplimentare, string totalOre,
            string salariuOreContract, string salariuOreSuplimentare, string salariuBrut, string impozitVenit, string cas, string cass,
            string deducerePersonala, string totalDeducere, string salariuNet)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection
                (Conectare.ConSir("SalariatiDB")))
            {
                List<DatePlataSalarii> obPlataSalarii = new List<DatePlataSalarii>();

                try
                {
                    obPlataSalarii.Add(new DatePlataSalarii
                    {
                        MarcaSalariat = marcaSalariat,
                        Nume = nume,
                        Prenume = prenume,
                        CNP = cnp,
                        DataPlatii = dataplatii,
                        PerioadaPlata = perioadaPlata,
                        LunaPlata = lunaPlata,
                        TarifOrar = tarifOrar,
                        TarifOreSuplimentare = tarifOreSuplimentare,
                        OreContract = oreContract,
                        OreSuplimentare = oreSuplimentare,
                        OreLucrate = totalOre,
                        SalariuIncadrare = salariuOreContract,
                        Sporuri = salariuOreSuplimentare,
                        SalariuBrutRealizat = salariuBrut,
                        ImpozitVenit = impozitVenit,
                        CAS = cas,
                        CASS = cass,
                        DeducerePersonala = deducerePersonala,
                        TotalDeducere = totalDeducere,
                        SalariuNet = salariuNet

                    });

                    conectare.Execute("AdaugarePlataSalariu @MarcaSalariat, @Nume, @Prenume, @CNP, @DataPlatii, @PerioadaPlata," +
                        " @LunaPlata, @TarifOrar, @TarifOreSuplimentare, @OreContract, @OreSuplimentare, @OreLucrate, @SalariuIncadrare, " +
                        "@Sporuri, @SalariuBrutRealizat, @ImpozitVenit, @CAS, @CASS, @DeducerePersonala, @TotalDeducere, @SalariuNet", obPlataSalarii);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare" + ex.Message);
                }
                finally
                {
                    conectare.Close();
                }
            }
        }

        public List<DatePlataSalarii> CautarePlata(string nume)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection
                (Conectare.ConSir("SalariatiDB")))
            {
                if (conectare.State == ConnectionState.Closed)
                    conectare.Open();
                var output = conectare.Query<DatePlataSalarii>("CautarePlataSalariu @Nume",
                    new { Nume = nume }).ToList();

                conectare.Close();

                return output;
            }
        }
    }
}
