
namespace CalculatorSalarii.Formulare
{
    partial class FrmInregistrareUtilizatori
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
            this.btnStergereUtilizator = new System.Windows.Forms.Button();
            this.btnActualizareUtilizator = new System.Windows.Forms.Button();
            this.btnInregistrareUtilizator = new System.Windows.Forms.Button();
            this.dgvUtilizatoriInregistrati = new System.Windows.Forms.DataGridView();
            this.utilizatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeUtilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculatorSalariiDataSet3 = new CalculatorSalarii.CalculatorSalariiDataSet3();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUtilizatorConfirmaParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeUtilizator = new System.Windows.Forms.TextBox();
            this.txtPozitie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUtilizatoriParola = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnResetareUtilizator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUtilizatoriInchide = new System.Windows.Forms.Button();
            this.utilizatorTableAdapter = new CalculatorSalarii.CalculatorSalariiDataSet3TableAdapters.UtilizatorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatoriInregistrati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStergereUtilizator
            // 
            this.btnStergereUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergereUtilizator.Location = new System.Drawing.Point(904, 488);
            this.btnStergereUtilizator.Name = "btnStergereUtilizator";
            this.btnStergereUtilizator.Size = new System.Drawing.Size(201, 39);
            this.btnStergereUtilizator.TabIndex = 58;
            this.btnStergereUtilizator.Text = "Ștergere";
            this.btnStergereUtilizator.UseVisualStyleBackColor = true;
            this.btnStergereUtilizator.Click += new System.EventHandler(this.btnStergereUtilizator_Click);
            // 
            // btnActualizareUtilizator
            // 
            this.btnActualizareUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizareUtilizator.Location = new System.Drawing.Point(480, 488);
            this.btnActualizareUtilizator.Name = "btnActualizareUtilizator";
            this.btnActualizareUtilizator.Size = new System.Drawing.Size(201, 39);
            this.btnActualizareUtilizator.TabIndex = 56;
            this.btnActualizareUtilizator.Text = "Actualizare";
            this.btnActualizareUtilizator.UseVisualStyleBackColor = true;
            this.btnActualizareUtilizator.Click += new System.EventHandler(this.btnActualizareUtilizator_Click);
            // 
            // btnInregistrareUtilizator
            // 
            this.btnInregistrareUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInregistrareUtilizator.Location = new System.Drawing.Point(269, 488);
            this.btnInregistrareUtilizator.Name = "btnInregistrareUtilizator";
            this.btnInregistrareUtilizator.Size = new System.Drawing.Size(201, 39);
            this.btnInregistrareUtilizator.TabIndex = 55;
            this.btnInregistrareUtilizator.Text = "Înregistrare";
            this.btnInregistrareUtilizator.UseVisualStyleBackColor = true;
            this.btnInregistrareUtilizator.Click += new System.EventHandler(this.btnInregistrareUtilizator_Click);
            // 
            // dgvUtilizatoriInregistrati
            // 
            this.dgvUtilizatoriInregistrati.AutoGenerateColumns = false;
            this.dgvUtilizatoriInregistrati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatoriInregistrati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorIDDataGridViewTextBoxColumn,
            this.numeUtilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.pozitieDataGridViewTextBoxColumn});
            this.dgvUtilizatoriInregistrati.DataSource = this.utilizatorBindingSource;
            this.dgvUtilizatoriInregistrati.Location = new System.Drawing.Point(20, 30);
            this.dgvUtilizatoriInregistrati.Name = "dgvUtilizatoriInregistrati";
            this.dgvUtilizatoriInregistrati.RowHeadersWidth = 51;
            this.dgvUtilizatoriInregistrati.RowTemplate.Height = 24;
            this.dgvUtilizatoriInregistrati.Size = new System.Drawing.Size(451, 241);
            this.dgvUtilizatoriInregistrati.TabIndex = 15;
            this.dgvUtilizatoriInregistrati.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtilizatoriInregistrati_CellEnter);
            // 
            // utilizatorIDDataGridViewTextBoxColumn
            // 
            this.utilizatorIDDataGridViewTextBoxColumn.DataPropertyName = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.HeaderText = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.Name = "utilizatorIDDataGridViewTextBoxColumn";
            this.utilizatorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeUtilizatorDataGridViewTextBoxColumn
            // 
            this.numeUtilizatorDataGridViewTextBoxColumn.DataPropertyName = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.HeaderText = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.Name = "numeUtilizatorDataGridViewTextBoxColumn";
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            // 
            // pozitieDataGridViewTextBoxColumn
            // 
            this.pozitieDataGridViewTextBoxColumn.DataPropertyName = "Pozitie";
            this.pozitieDataGridViewTextBoxColumn.HeaderText = "Pozitie";
            this.pozitieDataGridViewTextBoxColumn.Name = "pozitieDataGridViewTextBoxColumn";
            // 
            // utilizatorBindingSource
            // 
            this.utilizatorBindingSource.DataMember = "Utilizator";
            this.utilizatorBindingSource.DataSource = this.calculatorSalariiDataSet3;
            // 
            // calculatorSalariiDataSet3
            // 
            this.calculatorSalariiDataSet3.DataSetName = "CalculatorSalariiDataSet3";
            this.calculatorSalariiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUtilizatoriInregistrati);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(609, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 297);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilizatori Înregistrați";
            // 
            // txtUtilizatorConfirmaParola
            // 
            this.txtUtilizatorConfirmaParola.Location = new System.Drawing.Point(207, 166);
            this.txtUtilizatorConfirmaParola.Name = "txtUtilizatorConfirmaParola";
            this.txtUtilizatorConfirmaParola.Size = new System.Drawing.Size(283, 20);
            this.txtUtilizatorConfirmaParola.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nume";
            // 
            // txtNumeUtilizator
            // 
            this.txtNumeUtilizator.Location = new System.Drawing.Point(207, 43);
            this.txtNumeUtilizator.Name = "txtNumeUtilizator";
            this.txtNumeUtilizator.Size = new System.Drawing.Size(283, 20);
            this.txtNumeUtilizator.TabIndex = 7;
            // 
            // txtPozitie
            // 
            this.txtPozitie.Location = new System.Drawing.Point(207, 228);
            this.txtPozitie.Name = "txtPozitie";
            this.txtPozitie.Size = new System.Drawing.Size(283, 20);
            this.txtPozitie.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Poziție";
            // 
            // txtUtilizatoriParola
            // 
            this.txtUtilizatoriParola.Location = new System.Drawing.Point(207, 104);
            this.txtUtilizatoriParola.Name = "txtUtilizatoriParola";
            this.txtUtilizatoriParola.Size = new System.Drawing.Size(283, 20);
            this.txtUtilizatoriParola.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(1131, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 543);
            this.panel4.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 13);
            this.panel2.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 540);
            this.panel3.TabIndex = 60;
            // 
            // btnResetareUtilizator
            // 
            this.btnResetareUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetareUtilizator.Location = new System.Drawing.Point(693, 488);
            this.btnResetareUtilizator.Name = "btnResetareUtilizator";
            this.btnResetareUtilizator.Size = new System.Drawing.Size(201, 39);
            this.btnResetareUtilizator.TabIndex = 57;
            this.btnResetareUtilizator.Text = "Resetare";
            this.btnResetareUtilizator.UseVisualStyleBackColor = true;
            this.btnResetareUtilizator.Click += new System.EventHandler(this.btnResetareUtilizator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUtilizatorConfirmaParola);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumeUtilizator);
            this.groupBox1.Controls.Add(this.txtPozitie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUtilizatoriParola);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(53, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 297);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Înregistrare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirmă Parola";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(353, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(324, 36);
            this.label13.TabIndex = 52;
            this.label13.Text = "Înregistrare Utilizatori";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 15);
            this.panel1.TabIndex = 61;
            // 
            // btnUtilizatoriInchide
            // 
            this.btnUtilizatoriInchide.FlatAppearance.BorderSize = 0;
            this.btnUtilizatoriInchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilizatoriInchide.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizatoriInchide.Image = global::CalculatorSalarii.Properties.Resources.turn_off;
            this.btnUtilizatoriInchide.Location = new System.Drawing.Point(1019, 64);
            this.btnUtilizatoriInchide.Name = "btnUtilizatoriInchide";
            this.btnUtilizatoriInchide.Size = new System.Drawing.Size(82, 74);
            this.btnUtilizatoriInchide.TabIndex = 59;
            this.btnUtilizatoriInchide.UseVisualStyleBackColor = true;
            this.btnUtilizatoriInchide.Click += new System.EventHandler(this.btnUtilizatoriInchide_Click);
            // 
            // utilizatorTableAdapter
            // 
            this.utilizatorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInregistrareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1162, 582);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnStergereUtilizator);
            this.Controls.Add(this.btnActualizareUtilizator);
            this.Controls.Add(this.btnInregistrareUtilizator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnResetareUtilizator);
            this.Controls.Add(this.btnUtilizatoriInchide);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInregistrareUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InregistrareUtilizatori";
            this.Load += new System.EventHandler(this.FrmInregistrareUtilizatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatoriInregistrati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStergereUtilizator;
        private System.Windows.Forms.Button btnActualizareUtilizator;
        private System.Windows.Forms.Button btnInregistrareUtilizator;
        private System.Windows.Forms.DataGridView dgvUtilizatoriInregistrati;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtUtilizatorConfirmaParola;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNumeUtilizator;
        public System.Windows.Forms.TextBox txtPozitie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUtilizatoriParola;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnResetareUtilizator;
        private System.Windows.Forms.Button btnUtilizatoriInchide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private CalculatorSalariiDataSet3 calculatorSalariiDataSet3;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private CalculatorSalariiDataSet3TableAdapters.UtilizatorTableAdapter utilizatorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeUtilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozitieDataGridViewTextBoxColumn;
    }
}