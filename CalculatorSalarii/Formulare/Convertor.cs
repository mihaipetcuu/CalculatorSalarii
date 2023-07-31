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
    public partial class FrmConvertor : Form
    {
        public FrmConvertor()
        {
            InitializeComponent();
        }

        private void btnConvertorCalculatorSalarii_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertor_Click(object sender, EventArgs e)
        {
            decimal ore, minute, OreZecimal = 0.00M;

            if (decimal.TryParse(txtConvertorOre.Text, out ore))
            {
                if (decimal.TryParse(txtConvertorMinute.Text, out minute))
                {
                    OreZecimal = ConvertTimpCatreZecimal(ore, minute);
                    txtConvertorNrZecimal.Text = OreZecimal.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Vă rugăm, Introduceți numere");
                    txtConvertorMinute.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm, Introduceți numere");
                txtConvertorOre.Focus();
            }
        }

        private decimal ConvertTimpCatreZecimal(decimal ore, decimal minute)
        {
            return ore + (minute / 60);
        }
    }
}
