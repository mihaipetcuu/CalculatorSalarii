using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSalarii.Clase
{
    public class Utilizator
    {
        //Declarare Obiecte ADO.NET 
        SqlDataAdapter adapter;
        DataSet ds;

        //Default Constructor 
        public Utilizator()
        {

        }

        //Constructor cu parametrii
        public Utilizator(string numeUtilizator, string parola, string pozitie)
        {
            NumeUtilizator = numeUtilizator;
            Parola = parola;
            Pozitie = pozitie;
        }

        //Proprietatea UtilizatorNume
        public string NumeUtilizator { get; set; }
        //Proprietatea Parola
        public string Parola { get; set; }
        //Proprietatea Pozitie
        public string Pozitie { get; set; }

        //Metoda AdaugaUtilizator
        public void AdaugaUtilizator()
        {
            //ConnectionString
            string cs = ConfigurationManager.ConnectionStrings["SalariatiDB"].ConnectionString;
            //Creare obiect pentru conectarea cu baza de date
            SqlConnection objSqlConnection = new SqlConnection(cs);

            try
            {
                //Creare obiect SqlCommand 
                SqlCommand objSqlCommandVerificare = new SqlCommand("VerificaUtilizator", objSqlConnection);
                objSqlCommandVerificare.CommandType = CommandType.StoredProcedure;
                objSqlCommandVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                objSqlCommandVerificare.Parameters.AddWithValue("@Parola", Parola);
                objSqlConnection.Open();

                adapter = new SqlDataAdapter(objSqlCommandVerificare);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Nume Utilizator/Parola există în baza de date");

                    return;
                }
                else
                {
                    //Creare obiect SqlCommand 
                    SqlCommand objSqlCommand = new SqlCommand("InserareUtilizator", objSqlConnection);
                    objSqlCommand.CommandType = CommandType.StoredProcedure;
                    objSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    objSqlCommand.Parameters.AddWithValue("@Parola", Parola);
                    objSqlCommand.Parameters.AddWithValue("@Pozitie", Pozitie);
                    objSqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Un nou utilizator a fost adăugat cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Metoda ActualizareUtilizator
        public void ActualizareUtilizator(int id)
        {

            //ConnectionString
            string cs = ConfigurationManager.ConnectionStrings["SalariatiDB"].ConnectionString;
            //Creare obiect pentru conectarea cu baza de date
            SqlConnection objSqlConnection = new SqlConnection(cs);

            try
            {
                //Creare obiect SqlCommand 
                SqlCommand objSqlCommandVerificare = new SqlCommand("VerificaUtilizator", objSqlConnection);
                objSqlCommandVerificare.CommandType = CommandType.StoredProcedure;
                objSqlCommandVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                objSqlCommandVerificare.Parameters.AddWithValue("@Parola", Parola);
                objSqlConnection.Open();

                adapter = new SqlDataAdapter(objSqlCommandVerificare);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Nume Utilizator/Parola există în baza de date");

                    return;
                }
                else
                {
                    //Creare obiect SqlCommand                    
                    SqlCommand objSqlCommand = new SqlCommand("ActualizareUtilizator", objSqlConnection);
                    objSqlCommand.CommandType = CommandType.StoredProcedure;
                    objSqlCommand.Parameters.AddWithValue("@UtilizatorID", id);
                    objSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    objSqlCommand.Parameters.AddWithValue("@Parola", Parola);
                    objSqlCommand.Parameters.AddWithValue("@Pozitie", Pozitie);
                    objSqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Utilizatorul a fost actualizat cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message, "SQL Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Metoda StergereUtilizator
        public void StergereUtilizator(int id)
        {

            //ConnectionString
            string cs = ConfigurationManager.ConnectionStrings["SalariatiDB"].ConnectionString;
            //Crearea obiectului de conexiune cu baza de date
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Creare obiect SqlCommand 
            SqlCommand objSqlCommand = new SqlCommand("StergereUtilizator", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@UtilizatorID", id);

            try
            {
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message, "SQL Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                objSqlConnection.Close();
            }

            MessageBox.Show("Utilizatorul a fost șters cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metoda AutorizareUtilizator
        public bool AutorizareUtilizator()
        {
            bool esteUtilizatorAutorizat = false;
            //ConnectionString
            string cs = ConfigurationManager.ConnectionStrings["SalariatiDB"].ConnectionString;
            //Creare obiect pentru conexiune cu baza de date
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Creare obiect SqlCommand
            SqlCommand objSqlCommand = new SqlCommand("esteValidUtilizator", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
            objSqlCommand.Parameters.AddWithValue("@Parola", Parola);

            try
            {
                objSqlConnection.Open();
                esteUtilizatorAutorizat = (bool)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message, "Autentificare Utilizator respins", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }

            return esteUtilizatorAutorizat;
        }

        //Metoda AutorizareAdmin
        public bool AutorizareAdmin()
        {
            bool esteAdminAutorizat = false;
            //ConnectionString
            string cs = ConfigurationManager.ConnectionStrings["SalariatiDB"].ConnectionString;
            //Creare obiect pentru conexiune cu baza de date
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Creare obiect SqlCommand
            SqlCommand objSqlCommand = new SqlCommand("esteValidAdmin", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@Admin", NumeUtilizator);
            objSqlCommand.Parameters.AddWithValue("@Parola", Parola);

            try
            {
                objSqlConnection.Open();
                esteAdminAutorizat = (bool)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message, "Autentificare Administrator respins", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }

            return esteAdminAutorizat;
        }
    }
}
