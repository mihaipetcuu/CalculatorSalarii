using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class FrmPontajOre : Form
    {
        //Declarare variabile pentru zilele saptamanii
        double Luni01 = 0, Marti01 = 0, Miercuri01 = 0, Joi01 = 0, Vineri01 = 0, Sambata01 = 0, Duminica01 = 0;
        double Luni02 = 0, Marti02 = 0, Miercuri02 = 0, Joi02 = 0, Vineri02 = 0, Sambata02 = 0, Duminica02 = 0;
        double Luni03 = 0, Marti03 = 0, Miercuri03 = 0, Joi03 = 0, Vineri03 = 0, Sambata03 = 0, Duminica03 = 0;
        double Luni04 = 0, Marti04 = 0, Miercuri04 = 0, Joi04 = 0, Vineri04 = 0, Sambata04 = 0, Duminica04 = 0;

        //Declarare variabile pentru ore
        //Total Ore pe Saptamana
        public static double totalOreSapt1, totalOreSapt2, totalOreSapt3, totalOreSapt4;

        //Declarare variabile tarif orar
        public static double tarifOrar;

        public FrmPontajOre()
        {
            InitializeComponent();
        }

        //Converteste valorile saptamanii 1 catre tipul real double
        public void ConvertesteValorileSapt01()
        {
            Luni01 = double.Parse(npdLuni01.Value.ToString());
            Marti01 = double.Parse(npdMarti01.Value.ToString());
            Miercuri01 = double.Parse(npdMiercuri01.Value.ToString());
            Joi01 = double.Parse(npdJoi01.Value.ToString());
            Vineri01 = double.Parse(npdVineri01.Value.ToString());
            Sambata01 = double.Parse(npdSambata01.Value.ToString());
            Duminica01 = double.Parse(npdDuminica01.Value.ToString());

            return;
        }

        //Converteste valorile saptamanii 2 catre tipul real double
        public void ConvertesteValorileSapt02()
        {
            Luni02 = double.Parse(npdLuni02.Value.ToString());
            Marti02 = double.Parse(npdMarti02.Value.ToString());
            Miercuri02 = double.Parse(npdMiercuri02.Value.ToString());
            Joi02 = double.Parse(npdJoi02.Value.ToString());
            Vineri02 = double.Parse(npdVineri02.Value.ToString());
            Sambata02 = double.Parse(npdSambata02.Value.ToString());
            Duminica02 = double.Parse(npdDuminica02.Value.ToString());

            return;
        }

        //Converteste valorile saptamanii 3 catre tipul real double
        public void ConvertesteValorileSapt03()
        {
            Luni03 = double.Parse(npdLuni03.Value.ToString());
            Marti03 = double.Parse(npdMarti03.Value.ToString());
            Miercuri03 = double.Parse(npdMiercuri03.Value.ToString());
            Joi03 = double.Parse(npdJoi03.Value.ToString());
            Vineri03 = double.Parse(npdVineri03.Value.ToString());
            Sambata03 = double.Parse(npdSambata03.Value.ToString());
            Duminica03 = double.Parse(npdDuminica03.Value.ToString());

            return;
        }

        //Converteste valorile saptamanii 4 catre tipul real double
        public void ConvertesteValorileSapt04()
        {
            Luni04 = double.Parse(npdLuni04.Value.ToString());
            Marti04 = double.Parse(npdMarti04.Value.ToString());
            Miercuri04 = double.Parse(npdMiercuri04.Value.ToString());
            Joi04 = double.Parse(npdJoi04.Value.ToString());
            Vineri04 = double.Parse(npdVineri04.Value.ToString());
            Sambata04 = double.Parse(npdSambata04.Value.ToString());
            Duminica04 = double.Parse(npdDuminica04.Value.ToString());

            return;
        }

        private void btnCalculeazaOreLucrate_Click(object sender, EventArgs e)
        {
            ConvertesteValorileSapt01();
            ConvertesteValorileSapt02();
            ConvertesteValorileSapt03();
            ConvertesteValorileSapt04();

            //Calculeaza total ore pe saptamana
            totalOreSapt1 = Luni01 + Marti01 + Miercuri01 + Joi01 + Vineri01 + Sambata01 + Duminica01;
            totalOreSapt2 = Luni02 + Marti02 + Miercuri02 + Joi02 + Vineri02 + Sambata02 + Duminica02;
            totalOreSapt3 = Luni03 + Marti03 + Miercuri03 + Joi03 + Vineri03 + Sambata03 + Duminica03;
            totalOreSapt4 = Luni04 + Marti04 + Miercuri04 + Joi04 + Vineri04 + Sambata04 + Duminica04;

            double totalOre = totalOreSapt1 + totalOreSapt2 + totalOreSapt3 + totalOreSapt4;

            //Converteste catre double
            tarifOrar = double.Parse(npdTarifOrar.Value.ToString());

            MessageBox.Show($"Total Ore: {totalOre}");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
