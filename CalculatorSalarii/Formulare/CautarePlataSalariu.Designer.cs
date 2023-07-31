
namespace CalculatorSalarii
{
    partial class FrmCautarePlataSalariu
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCautarePlataSalariu = new System.Windows.Forms.DataGridView();
            this.btnCautarePlataSalariu = new System.Windows.Forms.Button();
            this.btnCautareCalculatorSalariu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCautareNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calculatorSalariiDataSet1 = new CalculatorSalarii.CalculatorSalariiDataSet1();
            this.platiSalariuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.platiSalariuTableAdapter = new CalculatorSalarii.CalculatorSalariiDataSet1TableAdapters.PlatiSalariuTableAdapter();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCautarePlataSalariu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiSalariuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(737, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 426);
            this.panel4.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCautarePlataSalariu);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(45, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 190);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Căutare salariu";
            // 
            // dgvCautarePlataSalariu
            // 
            this.dgvCautarePlataSalariu.AutoGenerateColumns = false;
            this.dgvCautarePlataSalariu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCautarePlataSalariu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvCautarePlataSalariu.DataSource = this.platiSalariuBindingSource;
            this.dgvCautarePlataSalariu.Location = new System.Drawing.Point(30, 19);
            this.dgvCautarePlataSalariu.Name = "dgvCautarePlataSalariu";
            this.dgvCautarePlataSalariu.Size = new System.Drawing.Size(641, 150);
            this.dgvCautarePlataSalariu.TabIndex = 32;
            // 
            // btnCautarePlataSalariu
            // 
            this.btnCautarePlataSalariu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautarePlataSalariu.ForeColor = System.Drawing.Color.White;
            this.btnCautarePlataSalariu.Location = new System.Drawing.Point(574, 156);
            this.btnCautarePlataSalariu.Name = "btnCautarePlataSalariu";
            this.btnCautarePlataSalariu.Size = new System.Drawing.Size(142, 28);
            this.btnCautarePlataSalariu.TabIndex = 52;
            this.btnCautarePlataSalariu.Text = "Căutare";
            this.btnCautarePlataSalariu.UseVisualStyleBackColor = true;
            this.btnCautarePlataSalariu.Click += new System.EventHandler(this.btnCautarePlataSalariu_Click);
            // 
            // btnCautareCalculatorSalariu
            // 
            this.btnCautareCalculatorSalariu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautareCalculatorSalariu.ForeColor = System.Drawing.Color.White;
            this.btnCautareCalculatorSalariu.Location = new System.Drawing.Point(574, 50);
            this.btnCautareCalculatorSalariu.Name = "btnCautareCalculatorSalariu";
            this.btnCautareCalculatorSalariu.Size = new System.Drawing.Size(142, 28);
            this.btnCautareCalculatorSalariu.TabIndex = 51;
            this.btnCautareCalculatorSalariu.Text = "Calculator salariu";
            this.btnCautareCalculatorSalariu.UseVisualStyleBackColor = true;
            this.btnCautareCalculatorSalariu.Click += new System.EventHandler(this.btnCautareCalculatorSalariu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 31);
            this.label2.TabIndex = 50;
            this.label2.Text = "Căutare plată salariu";
            // 
            // txtCautareNume
            // 
            this.txtCautareNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautareNume.Location = new System.Drawing.Point(259, 156);
            this.txtCautareNume.Name = "txtCautareNume";
            this.txtCautareNume.Size = new System.Drawing.Size(200, 26);
            this.txtCautareNume.TabIndex = 48;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(71, 159);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 49;
            this.lblNume.Text = "Nume";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 426);
            this.panel3.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 13);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(15, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 13);
            this.panel2.TabIndex = 45;
            // 
            // calculatorSalariiDataSet1
            // 
            this.calculatorSalariiDataSet1.DataSetName = "CalculatorSalariiDataSet1";
            this.calculatorSalariiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // platiSalariuBindingSource
            // 
            this.platiSalariuBindingSource.DataMember = "PlatiSalariu";
            this.platiSalariuBindingSource.DataSource = this.calculatorSalariiDataSet1;
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
            // FrmCautarePlataSalariu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCautarePlataSalariu);
            this.Controls.Add(this.btnCautareCalculatorSalariu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCautareNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCautarePlataSalariu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CautarePlataSalariu";
            this.Load += new System.EventHandler(this.FrmCautarePlataSalariu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCautarePlataSalariu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiSalariuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCautarePlataSalariu;
        private System.Windows.Forms.Button btnCautarePlataSalariu;
        private System.Windows.Forms.Button btnCautareCalculatorSalariu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCautareNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CalculatorSalariiDataSet1 calculatorSalariiDataSet1;
        private System.Windows.Forms.BindingSource platiSalariuBindingSource;
        private CalculatorSalariiDataSet1TableAdapters.PlatiSalariuTableAdapter platiSalariuTableAdapter;
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