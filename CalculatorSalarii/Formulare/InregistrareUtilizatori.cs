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
    public partial class FrmInregistrareUtilizatori : Form
    {
        //Variabile Class
        private Utilizator obUtilizator;
        private static int utilizatorID;

        public FrmInregistrareUtilizatori()
        {
            InitializeComponent();
        }

        private void DateUtilizator()
        {
            obUtilizator.NumeUtilizator = txtNumeUtilizator.Text;
            obUtilizator.Parola = txtUtilizatoriParola.Text;
            obUtilizator.Pozitie = txtPozitie.Text;
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

        private bool esteUtilizatorulValid()
        {
            const int lungimeaMinima = 8;

            //Validare Nume Utilizator
            if (txtNumeUtilizator.Text.Length < 1)
            {
                MessageBox.Show("Vă rugăm, Introduceți Numele de Utilizator.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeUtilizator.Focus();

                return false;
            }

            //Parola trebuie să conțină minimul 8 caractere.
            //Parola trebuie să conțină cel putin un caracter mare.
            //Parola trebuie să conțină cel puțin un caracter mic.
            //Parola trebuie să conțină cel puțin un număr.

            //Validare Parola
            if (txtUtilizatoriParola.Text.Length < 1)
            {
                MessageBox.Show("Vă rugăm, Introduceți parola.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUtilizatoriParola.Focus();

                return false;
            }
            else
            {
                //Verifica daca parola are o lungime de 8 caractere
                if (txtUtilizatoriParola.Text.Length < lungimeaMinima ||
                    //Verifica numarul de caractere mari 
                    caractereMari(txtUtilizatoriParola.Text) < 1 ||
                    //Verifica numarul de caractere mici 
                    caractereMici(txtUtilizatoriParola.Text) < 1 ||
                    //Verifica numarul de numere 
                    Numere(txtUtilizatoriParola.Text) < 1)
                {
                    MessageBox.Show("Vă Rugăm, Introduceți o parolă Validă. \n\n Sugestie: \n\t " +
                        "Parola trebuie să contină cel puțin 8 caractere \n\t " +
                        "Parola trebuie să conțină cel puțin un caracter mare. \n\t " +
                        "Parola trebuie să conțină cel puțin un caracter mic. \n\t" +
                        "Parola trebuie să conțină cel puțin un număr.",
                        "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUtilizatoriParola.Focus();

                    return false;
                }
            }

            //Validare confirmare parola
            if (txtUtilizatorConfirmaParola.Text.Length < 1)
            {
                MessageBox.Show("Vă rugăm, Confirmați Parola.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUtilizatorConfirmaParola.Focus();

                return false;
            }
            else
            {
                //Compara valoarea celor doua parole introduse
                if (txtUtilizatorConfirmaParola.Text != txtUtilizatoriParola.Text)
                {
                    MessageBox.Show("Cele două parole introduse nu corespund, Vă rugăm să încercați din nou!", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUtilizatorConfirmaParola.Focus();

                    return false;
                }
            }

            //Validare Pozitie
            if (txtPozitie.Text.Length < 1)
            {
                MessageBox.Show("Vă rugăm, Introduceți poziția.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPozitie.Focus();

                return false;
            }
            return true;
        }

        private void FrmInregistrareUtilizatori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorSalariiDataSet3.Utilizator' table. You can move, or remove it, as needed.
            this.utilizatorTableAdapter.Fill(this.calculatorSalariiDataSet3.Utilizator);

        }

        private void btnUtilizatoriInchide_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInregistrareUtilizator_Click(object sender, EventArgs e)
        {
            obUtilizator = new Utilizator();
            DateUtilizator();

            if (esteUtilizatorulValid())
            {
                obUtilizator.AdaugaUtilizator();
            }

            // TODO: This line of code loads data into the 'calculatorSalariiDataSet3.Utilizator' table. You can move, or remove it, as needed.
            this.utilizatorTableAdapter.Fill(this.calculatorSalariiDataSet3.Utilizator);
        }

        private void btnActualizareUtilizator_Click(object sender, EventArgs e)
        {
            obUtilizator = new Utilizator();
            DateUtilizator();

            if (esteUtilizatorulValid())
            {
                obUtilizator.ActualizareUtilizator(utilizatorID);
            }

            // TODO: This line of code loads data into the 'calculatorSalariiDataSet3.Utilizator' table. You can move, or remove it, as needed.
            this.utilizatorTableAdapter.Fill(this.calculatorSalariiDataSet3.Utilizator);
        }

        private void btnResetareUtilizator_Click(object sender, EventArgs e)
        {
            txtNumeUtilizator.Clear();
            txtUtilizatoriParola.Clear();
            txtUtilizatorConfirmaParola.Clear();
            txtPozitie.Clear();
        }

        private void btnStergereUtilizator_Click(object sender, EventArgs e)
        {
            obUtilizator = new Utilizator();
            DateUtilizator();

            if (esteUtilizatorulValid())
            {
                obUtilizator.StergereUtilizator(utilizatorID);
            }

            // TODO: This line of code loads data into the 'calculatorSalariiDataSet3.Utilizator' table. You can move, or remove it, as needed.
            this.utilizatorTableAdapter.Fill(this.calculatorSalariiDataSet3.Utilizator);
        }

        private void dgvUtilizatoriInregistrati_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection celula = dgvUtilizatoriInregistrati.CurrentRow.Cells;
            utilizatorID = Convert.ToInt32(celula[0].Value.ToString());
            txtNumeUtilizator.Text = celula[1].Value.ToString();
            txtUtilizatoriParola.Text = celula[2].Value.ToString();
            txtUtilizatorConfirmaParola.Text = celula[2].Value.ToString();
            txtPozitie.Text = celula[3].Value.ToString();
        }
    }
}
