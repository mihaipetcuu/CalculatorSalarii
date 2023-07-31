
namespace CalculatorSalarii.Formulare
{
    partial class FrmRapoarte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRapoarteExportExcel = new System.Windows.Forms.Button();
            this.dgbRaportExcel = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRapoarteTablouBord = new System.Windows.Forms.Button();
            this.calculatorSalariiDataSet2 = new CalculatorSalarii.CalculatorSalariiDataSet2();
            this.platiSalariuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.platiSalariuTableAdapter = new CalculatorSalarii.CalculatorSalariiDataSet2TableAdapters.PlatiSalariuTableAdapter();
            this.codBorderouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaSalariatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodaPlataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunaPlataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifOrarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifOreSuplimentareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreSuplimentareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreLucrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuIncadrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sporuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuBrutRealizatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impozitVenitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deducerePersonalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeducereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbRaportExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiSalariuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(177, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 38);
            this.label13.TabIndex = 45;
            this.label13.Text = "Rapoarte Excel";
            // 
            // btnRapoarteExportExcel
            // 
            this.btnRapoarteExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapoarteExportExcel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapoarteExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnRapoarteExportExcel.Location = new System.Drawing.Point(573, 106);
            this.btnRapoarteExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnRapoarteExportExcel.Name = "btnRapoarteExportExcel";
            this.btnRapoarteExportExcel.Size = new System.Drawing.Size(177, 42);
            this.btnRapoarteExportExcel.TabIndex = 44;
            this.btnRapoarteExportExcel.Text = "Export Excel";
            this.btnRapoarteExportExcel.UseVisualStyleBackColor = true;
            this.btnRapoarteExportExcel.Click += new System.EventHandler(this.btnRapoarteExportExcel_Click);
            // 
            // dgbRaportExcel
            // 
            this.dgbRaportExcel.AutoGenerateColumns = false;
            this.dgbRaportExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbRaportExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codBorderouDataGridViewTextBoxColumn,
            this.marcaSalariatDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.dataPlatiiDataGridViewTextBoxColumn,
            this.periodaPlataDataGridViewTextBoxColumn,
            this.lunaPlataDataGridViewTextBoxColumn,
            this.tarifOrarDataGridViewTextBoxColumn,
            this.tarifOreSuplimentareDataGridViewTextBoxColumn,
            this.oreContractDataGridViewTextBoxColumn,
            this.oreSuplimentareDataGridViewTextBoxColumn,
            this.oreLucrateDataGridViewTextBoxColumn,
            this.salariuIncadrareDataGridViewTextBoxColumn,
            this.sporuriDataGridViewTextBoxColumn,
            this.salariuBrutRealizatDataGridViewTextBoxColumn,
            this.impozitVenitDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn,
            this.cASSDataGridViewTextBoxColumn,
            this.deducerePersonalaDataGridViewTextBoxColumn,
            this.totalDeducereDataGridViewTextBoxColumn,
            this.salariuNetDataGridViewTextBoxColumn});
            this.dgbRaportExcel.DataSource = this.platiSalariuBindingSource;
            this.dgbRaportExcel.Location = new System.Drawing.Point(54, 163);
            this.dgbRaportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.dgbRaportExcel.Name = "dgbRaportExcel";
            this.dgbRaportExcel.RowHeadersWidth = 51;
            this.dgbRaportExcel.RowTemplate.Height = 24;
            this.dgbRaportExcel.Size = new System.Drawing.Size(696, 266);
            this.dgbRaportExcel.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(766, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 440);
            this.panel4.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(20, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 429);
            this.panel3.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(20, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 13);
            this.panel2.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 13);
            this.panel1.TabIndex = 39;
            // 
            // btnRapoarteTablouBord
            // 
            this.btnRapoarteTablouBord.FlatAppearance.BorderSize = 0;
            this.btnRapoarteTablouBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapoarteTablouBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapoarteTablouBord.ForeColor = System.Drawing.Color.White;
            this.btnRapoarteTablouBord.Image = global::CalculatorSalarii.Properties.Resources.turn_off;
            this.btnRapoarteTablouBord.Location = new System.Drawing.Point(668, 23);
            this.btnRapoarteTablouBord.Margin = new System.Windows.Forms.Padding(2);
            this.btnRapoarteTablouBord.Name = "btnRapoarteTablouBord";
            this.btnRapoarteTablouBord.Size = new System.Drawing.Size(82, 69);
            this.btnRapoarteTablouBord.TabIndex = 46;
            this.btnRapoarteTablouBord.UseVisualStyleBackColor = true;
            this.btnRapoarteTablouBord.Click += new System.EventHandler(this.btnRapoarteTablouBord_Click);
            // 
            // calculatorSalariiDataSet2
            // 
            this.calculatorSalariiDataSet2.DataSetName = "CalculatorSalariiDataSet2";
            this.calculatorSalariiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // platiSalariuBindingSource
            // 
            this.platiSalariuBindingSource.DataMember = "PlatiSalariu";
            this.platiSalariuBindingSource.DataSource = this.calculatorSalariiDataSet2;
            // 
            // platiSalariuTableAdapter
            // 
            this.platiSalariuTableAdapter.ClearBeforeFill = true;
            // 
            // codBorderouDataGridViewTextBoxColumn
            // 
            this.codBorderouDataGridViewTextBoxColumn.DataPropertyName = "CodBorderou";
            this.codBorderouDataGridViewTextBoxColumn.HeaderText = "CodBorderou";
            this.codBorderouDataGridViewTextBoxColumn.Name = "codBorderouDataGridViewTextBoxColumn";
            this.codBorderouDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaSalariatDataGridViewTextBoxColumn
            // 
            this.marcaSalariatDataGridViewTextBoxColumn.DataPropertyName = "MarcaSalariat";
            this.marcaSalariatDataGridViewTextBoxColumn.HeaderText = "MarcaSalariat";
            this.marcaSalariatDataGridViewTextBoxColumn.Name = "marcaSalariatDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // dataPlatiiDataGridViewTextBoxColumn
            // 
            this.dataPlatiiDataGridViewTextBoxColumn.DataPropertyName = "DataPlatii";
            this.dataPlatiiDataGridViewTextBoxColumn.HeaderText = "DataPlatii";
            this.dataPlatiiDataGridViewTextBoxColumn.Name = "dataPlatiiDataGridViewTextBoxColumn";
            // 
            // periodaPlataDataGridViewTextBoxColumn
            // 
            this.periodaPlataDataGridViewTextBoxColumn.DataPropertyName = "PeriodaPlata";
            this.periodaPlataDataGridViewTextBoxColumn.HeaderText = "PeriodaPlata";
            this.periodaPlataDataGridViewTextBoxColumn.Name = "periodaPlataDataGridViewTextBoxColumn";
            // 
            // lunaPlataDataGridViewTextBoxColumn
            // 
            this.lunaPlataDataGridViewTextBoxColumn.DataPropertyName = "LunaPlata";
            this.lunaPlataDataGridViewTextBoxColumn.HeaderText = "LunaPlata";
            this.lunaPlataDataGridViewTextBoxColumn.Name = "lunaPlataDataGridViewTextBoxColumn";
            // 
            // tarifOrarDataGridViewTextBoxColumn
            // 
            this.tarifOrarDataGridViewTextBoxColumn.DataPropertyName = "TarifOrar";
            this.tarifOrarDataGridViewTextBoxColumn.HeaderText = "TarifOrar";
            this.tarifOrarDataGridViewTextBoxColumn.Name = "tarifOrarDataGridViewTextBoxColumn";
            // 
            // tarifOreSuplimentareDataGridViewTextBoxColumn
            // 
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.DataPropertyName = "TarifOreSuplimentare";
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.HeaderText = "TarifOreSuplimentare";
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.Name = "tarifOreSuplimentareDataGridViewTextBoxColumn";
            // 
            // oreContractDataGridViewTextBoxColumn
            // 
            this.oreContractDataGridViewTextBoxColumn.DataPropertyName = "OreContract";
            this.oreContractDataGridViewTextBoxColumn.HeaderText = "OreContract";
            this.oreContractDataGridViewTextBoxColumn.Name = "oreContractDataGridViewTextBoxColumn";
            // 
            // oreSuplimentareDataGridViewTextBoxColumn
            // 
            this.oreSuplimentareDataGridViewTextBoxColumn.DataPropertyName = "OreSuplimentare";
            this.oreSuplimentareDataGridViewTextBoxColumn.HeaderText = "OreSuplimentare";
            this.oreSuplimentareDataGridViewTextBoxColumn.Name = "oreSuplimentareDataGridViewTextBoxColumn";
            // 
            // oreLucrateDataGridViewTextBoxColumn
            // 
            this.oreLucrateDataGridViewTextBoxColumn.DataPropertyName = "OreLucrate";
            this.oreLucrateDataGridViewTextBoxColumn.HeaderText = "OreLucrate";
            this.oreLucrateDataGridViewTextBoxColumn.Name = "oreLucrateDataGridViewTextBoxColumn";
            // 
            // salariuIncadrareDataGridViewTextBoxColumn
            // 
            this.salariuIncadrareDataGridViewTextBoxColumn.DataPropertyName = "SalariuIncadrare";
            this.salariuIncadrareDataGridViewTextBoxColumn.HeaderText = "SalariuIncadrare";
            this.salariuIncadrareDataGridViewTextBoxColumn.Name = "salariuIncadrareDataGridViewTextBoxColumn";
            // 
            // sporuriDataGridViewTextBoxColumn
            // 
            this.sporuriDataGridViewTextBoxColumn.DataPropertyName = "Sporuri";
            this.sporuriDataGridViewTextBoxColumn.HeaderText = "Sporuri";
            this.sporuriDataGridViewTextBoxColumn.Name = "sporuriDataGridViewTextBoxColumn";
            // 
            // salariuBrutRealizatDataGridViewTextBoxColumn
            // 
            this.salariuBrutRealizatDataGridViewTextBoxColumn.DataPropertyName = "SalariuBrutRealizat";
            this.salariuBrutRealizatDataGridViewTextBoxColumn.HeaderText = "SalariuBrutRealizat";
            this.salariuBrutRealizatDataGridViewTextBoxColumn.Name = "salariuBrutRealizatDataGridViewTextBoxColumn";
            // 
            // impozitVenitDataGridViewTextBoxColumn
            // 
            this.impozitVenitDataGridViewTextBoxColumn.DataPropertyName = "ImpozitVenit";
            this.impozitVenitDataGridViewTextBoxColumn.HeaderText = "ImpozitVenit";
            this.impozitVenitDataGridViewTextBoxColumn.Name = "impozitVenitDataGridViewTextBoxColumn";
            // 
            // cASDataGridViewTextBoxColumn
            // 
            this.cASDataGridViewTextBoxColumn.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn.Name = "cASDataGridViewTextBoxColumn";
            // 
            // cASSDataGridViewTextBoxColumn
            // 
            this.cASSDataGridViewTextBoxColumn.DataPropertyName = "CASS";
            this.cASSDataGridViewTextBoxColumn.HeaderText = "CASS";
            this.cASSDataGridViewTextBoxColumn.Name = "cASSDataGridViewTextBoxColumn";
            // 
            // deducerePersonalaDataGridViewTextBoxColumn
            // 
            this.deducerePersonalaDataGridViewTextBoxColumn.DataPropertyName = "DeducerePersonala";
            this.deducerePersonalaDataGridViewTextBoxColumn.HeaderText = "DeducerePersonala";
            this.deducerePersonalaDataGridViewTextBoxColumn.Name = "deducerePersonalaDataGridViewTextBoxColumn";
            // 
            // totalDeducereDataGridViewTextBoxColumn
            // 
            this.totalDeducereDataGridViewTextBoxColumn.DataPropertyName = "TotalDeducere";
            this.totalDeducereDataGridViewTextBoxColumn.HeaderText = "TotalDeducere";
            this.totalDeducereDataGridViewTextBoxColumn.Name = "totalDeducereDataGridViewTextBoxColumn";
            // 
            // salariuNetDataGridViewTextBoxColumn
            // 
            this.salariuNetDataGridViewTextBoxColumn.DataPropertyName = "SalariuNet";
            this.salariuNetDataGridViewTextBoxColumn.HeaderText = "SalariuNet";
            this.salariuNetDataGridViewTextBoxColumn.Name = "salariuNetDataGridViewTextBoxColumn";
            // 
            // FrmRapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRapoarteTablouBord);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRapoarteExportExcel);
            this.Controls.Add(this.dgbRaportExcel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRapoarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapoarte";
            this.Load += new System.EventHandler(this.FrmRapoarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbRaportExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiSalariuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRapoarteTablouBord;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRapoarteExportExcel;
        private System.Windows.Forms.DataGridView dgbRaportExcel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CalculatorSalariiDataSet2 calculatorSalariiDataSet2;
        private System.Windows.Forms.BindingSource platiSalariuBindingSource;
        private CalculatorSalariiDataSet2TableAdapters.PlatiSalariuTableAdapter platiSalariuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBorderouDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaSalariatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlatiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodaPlataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunaPlataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifOrarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifOreSuplimentareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreSuplimentareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreLucrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuIncadrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sporuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuBrutRealizatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impozitVenitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deducerePersonalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeducereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuNetDataGridViewTextBoxColumn;
    }
}