using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class FrmCalculatorSalarii : Form
    {
        //Declarare variabile pentru ore contractuale
        double contrOS1, contrOS2, contrOS3, contrOS4;
        //Declarare variabile pentru ore suplimentare
        double suplOS1, suplOS2, suplOS3, suplOS4;

        //Declarare variabile total ore lucrate
        public static double totalOreLucrate;
        public static double totalOreSuplimentare;
        public static double totalOreContractuale;

        //Declarare variabile pentru Castig Salarial
        double contrSumaS1, contrSumaS2, contrSumaS3, contrSumaS4;
        double SuplSumaS1, SuplSumaS2, SuplSumaS3, SuplSumaS4;


        //Declarare variabile pentru total castiguri
        double totalCastig;
        double totalCastigSuplimentar;
        double totalCastigContractual;

        //Declarare variabile for deduceri
        double impozit, cas, cass, deducerePersonala;

        double totalDeduceri;

        //Declarare variabila pentru tarif Orar ore suplimentare
        double tarifOrarSupl;

        //Declare variable for Net Pay
        double castigNet;

        FrmPontajOre obTarifOrar = new FrmPontajOre();

        List<DateAngajati> obCautaSalariat = new List<DateAngajati>();

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            ProcesareDate inserareSalariu = new ProcesareDate();

            if (esteValid())
            {
                try
                {
                inserareSalariu.InserareSalariu(Convert.ToInt32(txtCalcSalariiMarcaSalariat.Text), txtCalcSalariiNume.Text, txtCalcSalariiPrenume.Text,
                txtCalcSalariiCNP.Text, dtpDataPlata.Value.ToString("MM/dd/yyyy"), cmbPerioadaPlata.SelectedItem.ToString(), cmbLunaPlata.SelectedItem.ToString(),
                FrmPontajOre.tarifOrar.ToString(), tarifOrarSupl.ToString(), txtOreContractuale.Text, txtOreSuplimentare.Text, txtOreLucrate.Text, txtSalariuIncadrare.Text, txtSporuri.Text,
                txtSalariuBrutRealizat.Text, txtImpozitVenit.Text, txtCAS.Text, txtCASS.Text, txtDeducerePersonala.Text, txtTotalDeduceri.Text, txtSalariuNet.Text);

                
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
               

                MessageBox.Show("Salariatul: " + txtCalcSalariiNume.Text + " " + txtCalcSalariiPrenume.Text + " cu MarcaSalariat " +
                txtCalcSalariiMarcaSalariat.Text + " a fost salvat în baza de date cu succes!");
            }
        }

        private void btnPrinteaza_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void dgvCalculatorSalarii_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSalveaza.Enabled = false;
            btnCalculeaza.Enabled = false;

            decimal castigContractual, castigOreSuplimentare, totalSalariu, impozit, cas, cass, deducerePersonala,
                    totalDeduceri, salariuNet;

            try
            {
                DataGridViewCellCollection celula = dgvCalculatorSalarii.CurrentRow.Cells;
                txtCalcSalariiMarcaSalariat.Text = celula[1].Value.ToString();
                txtCalcSalariiNume.Text = celula[2].Value.ToString();
                txtCalcSalariiPrenume.Text = celula[3].Value.ToString();
                txtCalcSalariiCNP.Text = celula[4].Value.ToString();
                dtpDataPlata.Text = celula[5].Value.ToString();
                cmbPerioadaPlata.Text = celula[6].Value.ToString();
                cmbLunaPlata.Text = celula[7].Value.ToString();
                txtTarifOreSuplimentare.Text = celula[9].Value.ToString();
                txtOreContractuale.Text = celula[10].Value.ToString();
                txtOreSuplimentare.Text = celula[11].Value.ToString();
                txtOreLucrate.Text = celula[12].Value.ToString();
                castigContractual = (decimal)celula[13].Value;
                txtSalariuIncadrare.Text = String.Format("{0:F2}", castigContractual);
                castigOreSuplimentare = (decimal)celula[14].Value;
                txtSporuri.Text = String.Format("{0:F2}", castigOreSuplimentare);
                totalSalariu = (decimal)celula[15].Value;
                txtSalariuBrutRealizat.Text = String.Format("{0:F2}", totalSalariu);
                impozit = (decimal)celula[16].Value;
                txtImpozitVenit.Text = String.Format("{0:F2}", impozit);
                cas = (decimal)celula[17].Value;
                txtCAS.Text = String.Format("{0:F2}", cas);
                cass = (decimal)celula[18].Value;
                txtCASS.Text = String.Format("{0:F2}", cass);
                deducerePersonala = (decimal)celula[19].Value;
                txtDeducerePersonala.Text = String.Format("{0:F2}", deducerePersonala);
                totalDeduceri = (decimal)celula[20].Value;
                txtTotalDeduceri.Text = String.Format("{0:F2}", totalDeduceri);
                salariuNet = (decimal)celula[21].Value;
                txtSalariuNet.Text = String.Format("{0:F2}", salariuNet);
            }
            catch (Exception)
            {

            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            btnSalveaza.Enabled = true;
            btnCalculeaza.Enabled = true;
            txtCalcSalariiMarcaSalariat.Clear();
            txtCalcSalariiNume.Clear();
            txtCalcSalariiPrenume.Clear();
            txtCalcSalariiCNP.Clear();
            txtOreContractuale.Clear();
            txtOreSuplimentare.Clear();
            txtOreLucrate.Clear();
            txtSporuri.Clear();
            txtDeducerePersonala.Clear();
            txtImpozitVenit.Clear();
            txtCAS.Clear();
            txtCASS.Clear();
            txtTarifOreSuplimentare.Clear();
            txtTotalDeduceri.Clear();
            txtOreLucrate.Clear();
            txtSalariuBrutRealizat.Clear();
            cmbPerioadaPlata.SelectedIndex = 0;
            cmbLunaPlata.SelectedIndex = 0;
            txtSalariuNet.Clear();
        }

        private void btnFluturas_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        //Metoda care va crea fluturasul de plata a salariului
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 4), 40, 95, 820, 95);
            e.Graphics.DrawString("Student SRL ", new Font("Arial", 24, FontStyle.Bold), Brushes.Red, new Point(150, 110));
            e.Graphics.DrawLine(new Pen(Color.Black, 4), 40, 190, 820, 190);
            e.Graphics.DrawString("Data de Plata : " + dtpDataPlata.Value.ToString("MM/dd/yyyy"), new Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, new Point(500, 200));
            //Deseneaza un dreptunghi pentru detaliile angajatului
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), 40, 230, 780, 50); //x, y, latime, inaltime
            e.Graphics.DrawString("MarcaSalariat : " + txtCalcSalariiMarcaSalariat.Text + "    Nume: " + txtCalcSalariiNume.Text + " " + txtCalcSalariiPrenume.Text +
                "    CNP: " + txtCalcSalariiCNP.Text, new Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, new Point(60, 240));
            //Cap de tabel pentru detalile de plata a salalriului
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 40, 350, 820, 350);
            e.Graphics.DrawString("CASTIG", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(40, 320));
            e.Graphics.DrawString("ORE", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(180, 320));
            e.Graphics.DrawString("TARIF", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(260, 320));
            e.Graphics.DrawString("CASTIGURI", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(350, 320));
            e.Graphics.DrawString("DEDUCERI", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 320));
            e.Graphics.DrawString("SUME", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(650, 320));
            //Castiguri contractuale, tariful Orara si impozit
            e.Graphics.DrawString("Baza :", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(40, 360));
            e.Graphics.DrawString(txtOreContractuale.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(180, 360));
           // e.Graphics.DrawString(obTarifOrar.npdTarifOrar.Value.ToString("F"), new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(260, 360));
            e.Graphics.DrawString(txtSalariuIncadrare.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(350, 360));
            e.Graphics.DrawString("Impozit:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 360));
            e.Graphics.DrawString(txtImpozitVenit.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(650, 360));
            //Castiguri suplimentare si deduceri
            e.Graphics.DrawString("Ore Supl.:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(40, 400));
            e.Graphics.DrawString(txtOreSuplimentare.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(180, 400));
            e.Graphics.DrawString(txtTarifOreSuplimentare.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(260, 400));
            e.Graphics.DrawString(txtSporuri.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(350, 400));
            e.Graphics.DrawString("CAS:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 390));
            e.Graphics.DrawString(txtCAS.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(650, 390));
            e.Graphics.DrawString("CASS:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 420));
            e.Graphics.DrawString(txtCASS.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(650, 420));
            e.Graphics.DrawString("Deducere Pers.:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 450));
            e.Graphics.DrawString(txtDeducerePersonala.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(650, 450));
            //Deseneaza o linie
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 40, 520, 820, 520); //(x1, y1, x2, y2)
            //Castiguri Totale
            e.Graphics.DrawString("Total Castiguri:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(40, 550));
            e.Graphics.DrawString(txtSalariuBrutRealizat.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(350, 550));
            e.Graphics.DrawString("Total Deduceri: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 550));
            e.Graphics.DrawString(txtTotalDeduceri.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(660, 550));
            //Deseneaza o linie
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 40, 580, 820, 580); //(x1=40, y1=580, x2=750, y2=580)
            //Deseneaza un dreptunghi            
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), 40, 610, 780, 50); //(x, y, width, height)
            e.Graphics.DrawString("Salariul Net: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 620)); //(X=500, Y=620)
            e.Graphics.DrawString(txtSalariuNet.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(650, 620));
        }

        private void FrmCalculatorSalarii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorSalariiDataSet4.PlatiSalariu' table. You can move, or remove it, as needed.
            this.platiSalariuTableAdapter.Fill(this.calculatorSalariiDataSet4.PlatiSalariu);
            Lunile();
        }

        public FrmCalculatorSalarii()
        {
            InitializeComponent();
            btnSalveaza.Enabled = false;
            btnCalculeaza.Enabled = false;
        }

        List<DateAngajati> obCautareSalariat = new List<DateAngajati>();
        
        private bool esteValid()
        {
            if (String.IsNullOrEmpty(txtCalcSalariiMarcaSalariat.Text))
            {
                MessageBox.Show("Te rugăm să introduci MarcaSalariat", "Eroare Date de Intrare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCalcSalariiMarcaSalariat.Focus();

                return false;
            }
            if (cmbPerioadaPlata.SelectedIndex == 0)
            {
                MessageBox.Show("Vă rugăm selectați perioda de plată", "Eroare Date de Intrare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbPerioadaPlata.Focus();

                return false;
            }
            if (cmbLunaPlata.SelectedIndex == 0)
            {
                MessageBox.Show("Vă rugăm selectați luna de plată", "Eroare Date de Intrare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbLunaPlata.Focus();

                return false;
            }
            return true;
        }

        private void btnCalcSalariiTablouPrincipal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPontaj_Click(object sender, EventArgs e)
        {
            FrmPontajOre obPontajOre = new FrmPontajOre();
            obPontajOre.Show();
        }

        private void btnConvertor_Click(object sender, EventArgs e)
        {
            FrmConvertor obConvertor = new FrmConvertor();
            //this.Hide();
            obConvertor.Show();
        }

        private void btnCautarePlataSalariu_Click(object sender, EventArgs e)
        {
            FrmCautarePlataSalariu obCautareSalariu = new FrmCautarePlataSalariu();
            this.Hide();
            obCautareSalariu.Show();
        }

        private void btnCautareSalariat_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesareDate obSalariatDB = new ProcesareDate();
                obCautareSalariat = obSalariatDB.CautareSalariat(Convert.ToInt32(txtCalcSalariiMarcaSalariat.Text));

                if (obCautareSalariat.Count > 0)
                {
                    foreach(var dateSalariat in obCautareSalariat)
                    {
                        txtCalcSalariiNume.Text = dateSalariat.Nume;
                        txtCalcSalariiPrenume.Text = dateSalariat.Prenume;
                        txtCalcSalariiCNP.Text = dateSalariat.CNP;
                    }
                }
                else
                {
                    MessageBox.Show("Nu au fost găsite înregistrări cu MarcaSalariat: " + txtCalcSalariiMarcaSalariat.Text, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message");
            }
        }

        private void Lunile()
        {
            //Implementare Lista
            List<string> lunile = new List<string>();
            lunile.Add("Selectează Luna....");
            lunile.Add("Ianuarie");
            lunile.Add("Februarie");
            lunile.Add("Martie");
            lunile.Add("Aprilie");
            lunile.Add("Mai");
            lunile.Add("Iunie");
            lunile.Add("Iulie");
            lunile.Add("August");
            lunile.Add("Septembrie");
            lunile.Add("Octobrie");
            lunile.Add("Noiembrie");
            lunile.Add("Decembrie");

            lunile.ForEach(i => cmbLunaPlata.Items.Add(i));
            lunile.ElementAt(cmbLunaPlata.SelectedIndex = 0);
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            if(esteValid())
            {
                //Tarif orar ptr. ore suplimentare
                tarifOrarSupl = FrmPontajOre.tarifOrar * 1.5;

                #region ------- Calculare Saptamana 1 ---------
                //Ore contractuale lucrate si castigul aferent sapt 1
                if (FrmPontajOre.totalOreSapt1 <= 40)
                {
                    contrOS1 = FrmPontajOre.totalOreSapt1;  //Ore Contractuale Saptaman 1
                    contrSumaS1 = FrmPontajOre.tarifOrar * contrOS1; //Castig contractual Sapt. 1
                    suplOS1 = 0.00; //Ore Suplimentare Sapt 1
                    SuplSumaS1 = 0.00; //Castig suplimentar Sapt 1
                }
                //Ore suplimentare lucrate si castigul aferent sapt 1
                else if (FrmPontajOre.totalOreSapt1 > 40)
                {
                    contrOS1 = 40;
                    contrSumaS1 = FrmPontajOre.tarifOrar * contrOS1; //Castig contractual Sapt. 1
                    suplOS1 = FrmPontajOre.totalOreSapt1 - contrOS1;
                    SuplSumaS1 = suplOS1 * tarifOrarSupl;

                }
                #endregion
                #region ------- Calculare Saptamana 2 ---------
                //Ore contractuale lucrate si castigul aferent sapt 2
                if (FrmPontajOre.totalOreSapt2 <= 40)
                {
                    contrOS2 = FrmPontajOre.totalOreSapt2;  //Ore Contractuale Saptaman 2
                    contrSumaS2 = FrmPontajOre.tarifOrar * contrOS2; //Castig contractual Sapt. 2
                    suplOS2 = 0.00; //Ore Suplimentare Sapt 2
                    SuplSumaS2 = 0.00; //Castig suplimentar Sapt 2
                }
                //Ore suplimentare lucrate si castigul aferent sapt 2
                else if (FrmPontajOre.totalOreSapt2 > 40)
                {
                    contrOS2 = 40;
                    contrSumaS2 = FrmPontajOre.tarifOrar * contrOS2; //Castig contractual Sapt. 2
                    suplOS2 = FrmPontajOre.totalOreSapt2 - contrOS2;
                    SuplSumaS2 = suplOS2 * tarifOrarSupl;

                }
                #endregion
                #region ------- Calculare Saptamana 3 ---------
                //Ore contractuale lucrate si castigul aferent sapt 3
                if (FrmPontajOre.totalOreSapt3 <= 40)
                {
                    contrOS3 = FrmPontajOre.totalOreSapt3;  //Ore Contractuale Saptamana 3
                    contrSumaS3 = FrmPontajOre.tarifOrar * contrOS3; //Castig contractual Sapt. 3
                    suplOS3 = 0.00; //Ore Suplimentare Sapt 3
                    SuplSumaS3 = 0.00; //Castig suplimentar Sapt 3
                }
                //Ore suplimentare lucrate si castigul aferent sapt 3
                else if (FrmPontajOre.totalOreSapt3 > 40)
                {
                    contrOS3 = 40;
                    contrSumaS3 = FrmPontajOre.tarifOrar * contrOS3; //Castig contractual Sapt. 3
                    suplOS3 = FrmPontajOre.totalOreSapt3 - contrOS3;
                    SuplSumaS3 = suplOS3 * tarifOrarSupl;

                }
                #endregion
                #region ------- Calculare Saptamana 4 ---------
                //Ore contractuale lucrate si castigul aferent sapt 4
                if (FrmPontajOre.totalOreSapt4 <= 40)
                {
                    contrOS4 = FrmPontajOre.totalOreSapt4;  //Ore Contractuale Saptamana 4
                    contrSumaS4 = FrmPontajOre.tarifOrar * contrOS4; //Castig contractual Sapt. 4
                    suplOS4 = 0.00; //Ore Suplimentare Sapt 4
                    SuplSumaS4 = 0.00; //Castig suplimentar Sapt 4
                }
                //Ore suplimentare lucrate si castigul aferent sapt 4
                else if (FrmPontajOre.totalOreSapt4 > 40)
                {
                    contrOS4 = 40;
                    contrSumaS4 = FrmPontajOre.tarifOrar * contrOS4; //Castig contractual Sapt. 4
                    suplOS4 = FrmPontajOre.totalOreSapt4 - contrOS4;
                    SuplSumaS4 = suplOS4 * tarifOrarSupl;

                }
                #endregion

                //Calculare total ore si sumele aferente
                totalOreContractuale = contrOS1 + contrOS2 + contrOS3 + contrOS4;
                totalOreSuplimentare = suplOS1 + suplOS2 + suplOS3 + suplOS4;
                totalCastigContractual = contrSumaS1 + contrSumaS2 + contrSumaS3 + contrSumaS4;
                totalCastigSuplimentar = SuplSumaS1 + SuplSumaS2 + SuplSumaS3 + SuplSumaS4;
                totalOreLucrate = totalOreContractuale + totalOreSuplimentare;
                totalCastig = totalCastigContractual + totalCastigSuplimentar;

                //Calculare deduceri
                #region------- Calculare deduceri -------

                if (totalCastig < 3000)
                {
                    cas = totalCastig * .25;
                    cass = totalCastig * .10;
                    deducerePersonala = DeduceriPersonaleVenit();
                    totalDeduceri = cas + cass + deducerePersonala;
                    impozit = (totalCastig - totalDeduceri) * .10;
                    castigNet = totalCastig - cas - cass - impozit;

                }
                else if (totalCastig >= 3001 && totalCastig < 4950)
                {
                    cas = totalCastig * .25;
                    cass = totalCastig * .10;
                    deducerePersonala = DeduceriPersonaleVenit();
                    totalDeduceri = cas + cass + deducerePersonala;
                    impozit = (totalCastig - totalDeduceri) * .10;
                    castigNet = totalCastig - cas - cass - impozit;
                }
                else if (totalCastig >= 4951)
                {
                    cas = totalCastig * .25;
                    cass = totalCastig * .10;
                    deducerePersonala = 0.00;
                    totalDeduceri = cas + cass + deducerePersonala;
                    impozit = (totalCastig - totalDeduceri) * .10;
                    castigNet = totalCastig - cas - cass - impozit;
                }
                #endregion

                //Afiseaza informatiile salariale in cutiile de text
                txtOreContractuale.Text = totalOreContractuale.ToString("F2");
                txtOreSuplimentare.Text = totalOreSuplimentare.ToString("F2");
                txtOreLucrate.Text = totalOreLucrate.ToString("F2");
                txtSalariuIncadrare.Text = totalCastigContractual.ToString("F2");
                txtSporuri.Text = totalCastigSuplimentar.ToString("F2");
                txtSalariuBrutRealizat.Text = totalCastig.ToString("F2");
                txtTarifOreSuplimentare.Text = tarifOrarSupl.ToString("F2");
                txtCAS.Text = cas.ToString("F2");
                txtCASS.Text = cass.ToString("F2");
                txtDeducerePersonala.Text = deducerePersonala.ToString("F2");
                txtImpozitVenit.Text = impozit.ToString("F2");
                txtTotalDeduceri.Text = totalDeduceri.ToString("F2");
                txtSalariuNet.Text = castigNet.ToString("F2");
            }
        }

        #region --------- Deduceri Personale Venit ---------
        public int DeduceriPersonaleVenit()
        {
            int deducerePersonalaVenit = 0;

            if (totalCastig >= 1 && totalCastig < 3000)
                deducerePersonalaVenit = 600;
            else if (totalCastig >= 3001 && totalCastig < 3050)
                deducerePersonalaVenit = 585;
            else if (totalCastig >= 3051 && totalCastig < 3100)
                deducerePersonalaVenit = 570;
            else if (totalCastig >= 3101 && totalCastig < 3150)
                deducerePersonalaVenit = 555;
            else if (totalCastig >= 3151 && totalCastig < 3200)
                deducerePersonalaVenit = 540;
            else if (totalCastig >= 3201 && totalCastig < 3250)
                deducerePersonalaVenit = 525;
            else if (totalCastig >= 3251 && totalCastig < 3300)
                deducerePersonalaVenit = 510;
            else if (totalCastig >= 3301 && totalCastig < 3350)
                deducerePersonalaVenit = 495;
            else if (totalCastig >= 3351 && totalCastig < 3400)
                deducerePersonalaVenit = 480;
            else if (totalCastig >= 3401 && totalCastig < 3450)
                deducerePersonalaVenit = 465;
            else if (totalCastig >= 3451 && totalCastig < 3500)
                deducerePersonalaVenit = 450;
            else if (totalCastig >= 3501 && totalCastig < 3550)
                deducerePersonalaVenit = 435;
            else if (totalCastig >= 3551 && totalCastig < 3600)
                deducerePersonalaVenit = 420;
            else if (totalCastig >= 3601 && totalCastig < 3650)
                deducerePersonalaVenit = 405;
            else if (totalCastig >= 3651 && totalCastig < 3700)
                deducerePersonalaVenit = 390;
            else if (totalCastig >= 3701 && totalCastig < 3750)
                deducerePersonalaVenit = 375;
            else if (totalCastig >= 3751 && totalCastig < 3800)
                deducerePersonalaVenit = 360;
            else if (totalCastig >= 3801 && totalCastig < 3850)
                deducerePersonalaVenit = 345;
            else if (totalCastig >= 3851 && totalCastig < 3900)
                deducerePersonalaVenit = 330;
            else if (totalCastig >= 3901 && totalCastig < 3950)
                deducerePersonalaVenit = 315;
            else if (totalCastig >= 3951 && totalCastig < 4000)
                deducerePersonalaVenit = 300;
            else if (totalCastig >= 4001 && totalCastig < 4050)
                deducerePersonalaVenit = 285;
            else if (totalCastig >= 4051 && totalCastig < 4100)
                deducerePersonalaVenit = 270;
            else if (totalCastig >= 4101 && totalCastig < 4150)
                deducerePersonalaVenit = 255;
            else if (totalCastig >= 4151 && totalCastig < 4200)
                deducerePersonalaVenit = 240;
            else if (totalCastig >= 4201 && totalCastig < 4250)
                deducerePersonalaVenit = 225;
            else if (totalCastig >= 4251 && totalCastig < 4300)
                deducerePersonalaVenit = 210;
            else if (totalCastig >= 4301 && totalCastig < 4350)
                deducerePersonalaVenit = 195;
            else if (totalCastig >= 4351 && totalCastig < 4400)
                deducerePersonalaVenit = 180;
            else if (totalCastig >= 4401 && totalCastig < 4450)
                deducerePersonalaVenit = 165;
            else if (totalCastig >= 4451 && totalCastig < 4500)
                deducerePersonalaVenit = 150;
            else if (totalCastig >= 4501 && totalCastig < 4550)
                deducerePersonalaVenit = 135;
            else if (totalCastig >= 4551 && totalCastig < 4600)
                deducerePersonalaVenit = 120;
            else if (totalCastig >= 4601 && totalCastig < 4650)
                deducerePersonalaVenit = 105;
            else if (totalCastig >= 4651 && totalCastig < 4700)
                deducerePersonalaVenit = 90;
            else if (totalCastig >= 4701 && totalCastig < 4750)
                deducerePersonalaVenit = 75;
            else if (totalCastig >= 4751 && totalCastig < 4800)
                deducerePersonalaVenit = 60;
            else if (totalCastig >= 4801 && totalCastig < 4850)
                deducerePersonalaVenit = 45;
            else if (totalCastig >= 4851 && totalCastig < 4900)
                deducerePersonalaVenit = 30;
            else if (totalCastig >= 4901 && totalCastig < 4950)
                deducerePersonalaVenit = 15;
            else if (totalCastig >= 4951 && totalCastig < 5000)
                deducerePersonalaVenit = 0;

            return deducerePersonalaVenit;
        }
        #endregion
    }
}
