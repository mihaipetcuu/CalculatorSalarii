using CalculatorSalarii.Formulare;
using System;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class frmTablouPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public frmTablouPrincipal()
        {
            InitializeComponent();
        }

        public bool autorizareUtilizator;
        public bool autorizareAdmin;

        private void btnSalariati_Click(object sender, EventArgs e)
        {
            frmDetaliiSalariati obDetaliiSalariati = new frmDetaliiSalariati();
            obDetaliiSalariati.Show();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            FrmLogin obLogin = new FrmLogin();
            obLogin.Show();
        }

        private void btnSalarii_Click(object sender, EventArgs e)
        {
            FrmCalculatorSalarii obCalculatorSalarii = new FrmCalculatorSalarii();
            obCalculatorSalarii.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmInregistrareUtilizatori obUtilizatori = new FrmInregistrareUtilizatori();
            obUtilizatori.Show();
        }

        private void btnRapoarte_Click(object sender, EventArgs e)
        {
            FrmRapoarte obRapoarte = new FrmRapoarte();
            obRapoarte.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnAdmin.Visible = true;
        }


        private void frmTablouPrincipal_Load(object sender, EventArgs e)
        {
            if (autorizareUtilizator)
            {
                btnAdmin.Enabled = false;
            }
            else
            {
                btnAdmin.Enabled = true;
            }
        }
    }
}
