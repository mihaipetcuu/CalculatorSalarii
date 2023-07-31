using Microsoft.Office.Interop.Excel;
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
    public partial class FrmRapoarte : Form
    {
        public FrmRapoarte()
        {
            InitializeComponent();
        }

        private void FrmRapoarte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorSalariiDataSet2.PlatiSalariu' table. You can move, or remove it, as needed.
            this.platiSalariuTableAdapter.Fill(this.calculatorSalariiDataSet2.PlatiSalariu);

        }

        private void btnRapoarteExportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelExport;
            Workbook registruDeLucru;
            Worksheet foaieDeCalcul;

            try
            {
                ExcelExport = new Microsoft.Office.Interop.Excel.Application();
                registruDeLucru = ExcelExport.Workbooks.Add(Type.Missing);
                foaieDeCalcul = null;

                foaieDeCalcul = registruDeLucru.Sheets["Sheet1"];
                foaieDeCalcul = registruDeLucru.ActiveSheet;
                foaieDeCalcul.Name = "DatePlatiSalarii";
                ExcelExport.Visible = true;

                for (int i = 1; i < dgbRaportExcel.Columns.Count + 1; i++)
                {
                    foaieDeCalcul.Cells[1, i] = dgbRaportExcel.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgbRaportExcel.RowCount; i++)
                {
                    for (int j = 0; j < dgbRaportExcel.ColumnCount; j++)
                    {
                        foaieDeCalcul.Cells[i + 2, j + 1] = dgbRaportExcel.Rows[i].Cells[j].Value;
                    }
                }

                ExcelExport.Columns.AutoFit();

            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        private void btnRapoarteTablouBord_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
