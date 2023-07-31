using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class frmDetaliiSalariati : Form
    {
        string numeFisier;
        //bool EsteValid;

        public frmDetaliiSalariati()
        {
            InitializeComponent();
            btnSalvare.Enabled = false;
        }

        //Metoda care converteste imaginea catre formatul binar
        public byte[] ConversieBinara(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);

                return ms.ToArray();
            }
        }

        //MarcaSalariat cerinte Regex:
        //Numere de la 0 la 9
        //Minim 1, maximum 6 numere
        Regex obMarcaSalariat = new Regex("^[0-9]{1,6}$");

        //Cerinte Regex pentru Nume:
        //Prima litera trebuie sa fie o litera mare de la A la Z
        //Urmatoarele litere pot sa fie mici sau mari de la A la Z
        Regex obNume = new Regex("^[A-Z][a-zA-z]*$");

        //Cerinte Regex pentru Prenume
        Regex obPrenume = new Regex("^[A-Z][a-zA-z]*$");

        //Cerinte Regex pentru validare CNP:
        //Prima componenta reprezinta sexul de la 1 la 2
        //Urmatoarele trei componente se refera la datele de nastere
        //A cincea componenta reprezinta judetul sau sectorul
        //A sasea componenta reprezinta un numar secvential cuprins intre 001-999
        //A saptea componenta reprezinta cifra de control pentru depistarea erorilor
        //Totalul de cifre al CNP-ului este de 13
        Regex obCNP = new Regex("^[1-2]{1}[0-9]{12}$");

        //Cerinte Regex pentru validare numar de telefon
        //Acesta este compus din 10 numere
        Regex obTelefon = new Regex("^[0-9]{10}$");

        //Metoda care valideaza datele de intrare
        private bool esteValid()
        {
            //Validare MarcaSalariat
            if(Convert.ToInt32(txtMarcaSalariat.Text.Length)<1)
            {
                MessageBox.Show("Te rugăm introduce MarcaSalariat", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarcaSalariat.Focus();
                txtMarcaSalariat.BackColor = Color.Red;

                return false;
            }
            else if(!obMarcaSalariat.IsMatch(txtMarcaSalariat.Text))
            {
                MessageBox.Show("Te rugăm MarcaSalariat trebuie să aibă între 1 și 6 numere", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarcaSalariat.Focus();
                txtMarcaSalariat.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtMarcaSalariat.BackColor = Color.White;
            }

            //Validare Nume
            if (string.IsNullOrEmpty(txtNume.Text))
            {
                MessageBox.Show("Te rugăm introduce Numele", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Focus();
                txtNume.BackColor = Color.Red;

                return false;
            }
            else if (!obNume.IsMatch(txtNume.Text))
            {
                MessageBox.Show("Te rugăm Numele trebuie să înceapă cu literă mare", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Focus();
                txtNume.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtNume.BackColor = Color.White;
            }

            //Validare Prenume
            if (string.IsNullOrEmpty(txtPrenume.Text))
            {
                MessageBox.Show("Te rugăm introduce Prenumele", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrenume.Focus();
                txtPrenume.BackColor = Color.Red;

                return false;
            }
            else if (!obPrenume.IsMatch(txtPrenume.Text))
            {
                MessageBox.Show("Te rugăm Prenumele trebuie să înceapă cu literă mare", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrenume.Focus();
                txtPrenume.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtPrenume.BackColor = Color.White;
            }

            //Validare CNP
            if (string.IsNullOrEmpty(txtCNP.Text))
            {
                MessageBox.Show("Te rugăm introduce CNP-ul", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCNP.Focus();
                txtCNP.BackColor = Color.Red;

                return false;
            }
            else if (!obCNP.IsMatch(txtCNP.Text))
            {
                MessageBox.Show("Te rugăm CNP-ul trebuie să aibă 13 numere", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCNP.Focus();
                txtCNP.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtCNP.BackColor = Color.White;
            }

            //Validare Adresa
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                MessageBox.Show("Te rugăm introduce Adresa", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdresa.Focus();
                txtAdresa.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtAdresa.BackColor = Color.White;
            }

            //Validare Telefon
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Te rugăm introduce numărul de telefon", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus();
                txtTelefon.BackColor = Color.Red;

                return false;
            }
            else if (!obTelefon.IsMatch(txtTelefon.Text))
            {
                MessageBox.Show("Te rugăm Telefonul trebuie să aibă 10 numere", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus();
                txtTelefon.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtTelefon.BackColor = Color.White;
            }

            //Validare Sex
            if (cmbSex.SelectedIndex==-1)
            {
                MessageBox.Show("Te rugăm selectează fie M sau F", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Validare CI
            if (string.IsNullOrEmpty(txtCI.Text))
            {
                MessageBox.Show("Te rugăm introduce CI", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCI.Focus();
                txtCI.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtCI.BackColor = Color.White;
            }
            //Validare ContBancar
            if (string.IsNullOrEmpty(txtContBancar.Text))
            {
                MessageBox.Show("Te rugăm introduce Contul Bancar", "Eroare de Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContBancar.Focus();
                txtContBancar.BackColor = Color.Red;

                return false;
            }
            else
            {
                txtContBancar.BackColor = Color.White;
            }
            return true;
        }

        private void btnPoza_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog obPoza = new OpenFileDialog() { Filter = "JPEG|*.jpg",
                ValidateNames = true, Multiselect = false })
            {
                if(obPoza.ShowDialog() == DialogResult.OK)
                {
                    numeFisier = obPoza.FileName;
                    picPoza.Image = Image.FromFile(numeFisier);
                }

                lblNumeFisier.Text=numeFisier;
            }
        }

        private void btnStergePoza_Click(object sender, EventArgs e)
        {
            picPoza.Image = null;
        }

        private void btnTablouBord_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Validare eveniment KeyPress
        //Numere si stergere (backspace) vor fi permise
        private void txtMarcaSalariat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EsteValid = false;

            if(char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                //EsteValid = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Validare eveniment KeyPress
        //Numere si stergere (backspace) vor fi permise
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EsteValid = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                //EsteValid = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Validare eveniment KeyPress
        //Numere si stergere (backspace) vor fi permise
        private void txtCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EsteValid = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                //EsteValid = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if(esteValid())
            {
                ProcesareDate dbInserare = new ProcesareDate();

                byte[] bc = ConversieBinara(picPoza.Image);

                dbInserare.InserareSalariati(Convert.ToInt32(txtMarcaSalariat.Text), txtNume.Text,
                    txtPrenume.Text, txtCNP.Text, txtAdresa.Text, txtTelefon.Text,
                    dtpDataNasterii.Value.ToString("MM/dd/yy"), cmbSex.SelectedItem.ToString(),
                    txtCI.Text, txtContBancar.Text, numeFisier, bc);

                MessageBox.Show("Salariatul: " + txtNume.Text + " " + txtPrenume.Text + " cu MarcaSalariat " +
                txtMarcaSalariat.Text + " a fost Inserat cu succes!");

                // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Salariati' table. You can move, or remove it, as needed.
                this.salariatiTableAdapter.Fill(this.calculatorSalariiDataSet.Salariati);

                btnSalvare.Enabled = false;
                btnActualizare.Enabled = true;
                btnStergeSalariat.Enabled = true;
                btnAdauga.Enabled = true;
            }

        }

        private void CurataControale()
        {
            txtMarcaSalariat.Clear();
            txtNume.Clear();
            txtPrenume.Clear();
            txtCNP.Clear();
            txtAdresa.Clear();
            txtTelefon.Clear();
            dtpDataNasterii.Value = DateTime.Now;
            cmbSex.SelectedIndex = -1;
            txtCI.Clear();
            txtContBancar.Clear();
            picPoza.Image = null;

        }

        private void frmDetaliiSalariati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Salariati' table. You can move, or remove it, as needed.
            this.salariatiTableAdapter.Fill(this.calculatorSalariiDataSet.Salariati);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            CurataControale();
            btnSalvare.Enabled = true;
            btnActualizare.Enabled = false;
            btnStergeSalariat.Enabled = false;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            ProcesareDate dbActualizare = new ProcesareDate();

            numeFisier = lblNumeFisier.Text;

            byte[] bc = ConversieBinara(picPoza.Image);

            dbActualizare.ActualizareSalariat(Convert.ToInt32(txtMarcaSalariat.Text),
                txtNume.Text, txtPrenume.Text, txtCNP.Text, txtAdresa.Text, txtTelefon.Text,
                dtpDataNasterii.Value.ToString("MM/dd/yy"), cmbSex.SelectedItem.ToString(),
                txtCI.Text, txtContBancar.Text, numeFisier, bc);

            MessageBox.Show("Salariatul: " + txtNume.Text + " " + txtPrenume.Text + " cu MarcaSalariat " +
                txtMarcaSalariat.Text + " a fost Actualizat cu succes!");

            // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Salariati' table. You can move, or remove it, as needed.
            this.salariatiTableAdapter.Fill(this.calculatorSalariiDataSet.Salariati);

            btnSalvare.Enabled = false;
        }

        private void btnStergeSalariat_Click(object sender, EventArgs e)
        {
            ProcesareDate dbStergere = new ProcesareDate();

            dbStergere.StergereSalariat(Convert.ToInt32(txtMarcaSalariat.Text));

            MessageBox.Show("Salariatul: " + txtNume.Text + " " + txtPrenume.Text + " cu MarcaSalariat " +
                txtMarcaSalariat.Text + " a fost Sters cu succes!");

            // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Salariati' table. You can move, or remove it, as needed.
            this.salariatiTableAdapter.Fill(this.calculatorSalariiDataSet.Salariati);

            btnSalvare.Enabled = false;
        }

        private void dgvDetaliiSalariati_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection celule = dgvDetaliiSalariati.CurrentRow.Cells;
                txtMarcaSalariat.Text = celule[0].Value.ToString();
                txtNume.Text = celule[1].Value.ToString();
                txtPrenume.Text = celule[2].Value.ToString();
                txtCNP.Text = celule[3].Value.ToString();
                txtAdresa.Text = celule[4].Value.ToString();
                txtTelefon.Text = celule[5].Value.ToString();
                dtpDataNasterii.Text = celule[6].Value.ToString();
                cmbSex.Text = celule[7].Value.ToString();
                txtCI.Text = celule[8].Value.ToString();
                txtContBancar.Text = celule[9].Value.ToString();
                lblNumeFisier.Text = celule[10].Value.ToString();
                picPoza.Image = Image.FromFile(celule[10].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
        
    }
}
