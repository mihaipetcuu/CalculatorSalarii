using CalculatorSalarii.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSalarii.Formulare
{
    public partial class FrmLogin : Form
    {
        //Variabile Class
        private Utilizator obUtilizator;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void DateUtilizator()
        {
            obUtilizator.NumeUtilizator = txtLoginNumeUtilizator.Text;
            obUtilizator.Parola = txtLoginParola.Text;
        }

        private void CurataControale()
        {
            txtLoginNumeUtilizator.Clear();
            txtLoginParola.Clear();
        }

        //Numara cifrele
        private int Numere(string Parola)
        {
            int numar = 0;

            //Numara cifrele in parola
            foreach (char ch in Parola)
            {
                if (char.IsNumber(ch))
                {
                    //incrementeaza cu 1 cifrele gasite
                    numar++;
                }
            }

            //Returneaza numarul de cifre gasite
            return numar;
        }

        //Numara caracterele mici in parola
        private int caractereMici(string Parola)
        {
            int numarCaractereMici = 0;

            //Numara caracterele mici
            foreach (char ch in Parola)
            {
                if (char.IsLower(ch))
                {
                    //incrementeaza cu 1 caracterele mici gasite
                    numarCaractereMici++;
                }
            }

            //Returneaza numarul de caractere mici gasite
            return numarCaractereMici;
        }

        //Numara caracterele mari
        private int caractereMari(string Parola)
        {
            int numarCaractereMari = 0;

            //Numara caracterele mari
            foreach (char ch in Parola)
            {
                if (char.IsUpper(ch))
                {
                    //incrementeaza cu 1 caracterele mari gasite
                    numarCaractereMari++;
                }
            }

            //Returneaza numarul de caractere mari gasite
            return numarCaractereMari;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtLoginParola.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginParola.UseSystemPasswordChar = true;
            }
        }

        private bool esteLoginValid()
        {
            const int lungimeaMinima = 8;

            //Validare Nume Utilizator
            if (txtLoginNumeUtilizator.Text.Length < 1)
            {
                MessageBox.Show("Vă rugăm, Introduceți Numele de Utilizator.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginNumeUtilizator.Focus();

                return false;
            }

            //Parola trebuie sa contine minimul 8 caractere.
            //Parola trebuie sa contina cel putin un caracter mare.
            //Parola trebuie sa contina cel putin un caracter mic.
            //Parola trebuie sa contina cel putin un numar.

            //Validare Parola
            if (txtLoginParola.Text.Length < 1)
            {
                MessageBox.Show("Vă rugăm, Introduceți parola.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginParola.Focus();

                return false;
            }
            else
            {
                //Verifica daca parola are o lungime de 8 caractere
                if (txtLoginParola.Text.Length < lungimeaMinima ||
                    //Verifica numarul de caractere mari 
                    caractereMari(txtLoginParola.Text) < 1 ||
                    //Verifica numarul de caractere mici 
                    caractereMici(txtLoginParola.Text) < 1 ||
                    //Verifica numarul de numere 
                    Numere(txtLoginParola.Text) < 1)
                {
                    MessageBox.Show("Vă Rugăm, Introduceți o parolă Validă. \n\n Sugestie: \n\t " +
                        "Parola trebuie să conțină cel puțin 8 caractere \n\t " +
                        "Parola trebuie să conțină cel puțin un caracter mare. \n\t " +
                        "Parola trebuie să conțină cel puțin un caracter mic. \n\t" +
                        "Parola trebuie să conțină cel puțin un număr.",
                        "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginParola.Focus();

                    return false;
                }
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            obUtilizator = new Utilizator();

            DateUtilizator();

            try
            {
                if (esteLoginValid())
                {
                    if (obUtilizator.AutorizareUtilizator())
                    {
                        frmTablouPrincipal obTablouDeBord = new frmTablouPrincipal();
                        this.Hide();
                        obTablouDeBord.Show();
                        //obTablouDeBord.btnAdmin.Enabled = false;
                        obTablouDeBord.autorizareUtilizator = true;
                        
                    }
                    else if (obUtilizator.AutorizareAdmin())
                    {
                        frmTablouPrincipal obTablouDeBord = new frmTablouPrincipal();
                        this.Hide();
                        obTablouDeBord.Show();
                        //obTablouDeBord.btnAdmin.Enabled = true;
                        obTablouDeBord.autorizareUtilizator = true;
                    }
                    else
                    {
                        MessageBox.Show("Acreditare Neautorizată furnizată!!", "Utilizator Neautorizat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CurataControale();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
