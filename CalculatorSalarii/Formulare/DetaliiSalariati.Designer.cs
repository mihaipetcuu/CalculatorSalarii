
namespace CalculatorSalarii
{
    partial class frmDetaliiSalariati
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
            this.lblNumeFisier = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetaliiSalariati = new System.Windows.Forms.DataGridView();
            this.marcaSalariatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contBancarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeFisierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagineDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.salariatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculatorSalariiDataSet = new CalculatorSalarii.CalculatorSalariiDataSet();
            this.btnTablouBord = new System.Windows.Forms.Button();
            this.btnStergeSalariat = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnStergePoza = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.dtpDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.txtContBancar = new System.Windows.Forms.TextBox();
            this.lblContBancar = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblDataNasterii = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtMarcaSalariat = new System.Windows.Forms.TextBox();
            this.lblMarcaSalariat = new System.Windows.Forms.Label();
            this.btnPoza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPoza = new System.Windows.Forms.PictureBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.salariatiTableAdapter = new CalculatorSalarii.CalculatorSalariiDataSetTableAdapters.SalariatiTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaliiSalariati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeFisier
            // 
            this.lblNumeFisier.AutoSize = true;
            this.lblNumeFisier.Location = new System.Drawing.Point(141, 68);
            this.lblNumeFisier.Name = "lblNumeFisier";
            this.lblNumeFisier.Size = new System.Drawing.Size(0, 13);
            this.lblNumeFisier.TabIndex = 68;
            this.lblNumeFisier.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetaliiSalariati);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(87, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 190);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Salariați";
            // 
            // dgvDetaliiSalariati
            // 
            this.dgvDetaliiSalariati.AutoGenerateColumns = false;
            this.dgvDetaliiSalariati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaliiSalariati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaSalariatDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.cIDataGridViewTextBoxColumn,
            this.contBancarDataGridViewTextBoxColumn,
            this.numeFisierDataGridViewTextBoxColumn,
            this.imagineDataGridViewImageColumn});
            this.dgvDetaliiSalariati.DataSource = this.salariatiBindingSource;
            this.dgvDetaliiSalariati.Location = new System.Drawing.Point(21, 25);
            this.dgvDetaliiSalariati.Name = "dgvDetaliiSalariati";
            this.dgvDetaliiSalariati.Size = new System.Drawing.Size(1036, 150);
            this.dgvDetaliiSalariati.TabIndex = 32;
            this.dgvDetaliiSalariati.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetaliiSalariati_CellEnter);
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
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "Data Nasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "Data Nasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // cIDataGridViewTextBoxColumn
            // 
            this.cIDataGridViewTextBoxColumn.DataPropertyName = "CI";
            this.cIDataGridViewTextBoxColumn.HeaderText = "CI";
            this.cIDataGridViewTextBoxColumn.Name = "cIDataGridViewTextBoxColumn";
            // 
            // contBancarDataGridViewTextBoxColumn
            // 
            this.contBancarDataGridViewTextBoxColumn.DataPropertyName = "ContBancar";
            this.contBancarDataGridViewTextBoxColumn.HeaderText = "ContBancar";
            this.contBancarDataGridViewTextBoxColumn.Name = "contBancarDataGridViewTextBoxColumn";
            // 
            // numeFisierDataGridViewTextBoxColumn
            // 
            this.numeFisierDataGridViewTextBoxColumn.DataPropertyName = "NumeFisier";
            this.numeFisierDataGridViewTextBoxColumn.HeaderText = "NumeFisier";
            this.numeFisierDataGridViewTextBoxColumn.Name = "numeFisierDataGridViewTextBoxColumn";
            // 
            // imagineDataGridViewImageColumn
            // 
            this.imagineDataGridViewImageColumn.DataPropertyName = "Imagine";
            this.imagineDataGridViewImageColumn.HeaderText = "Imagine";
            this.imagineDataGridViewImageColumn.Name = "imagineDataGridViewImageColumn";
            // 
            // salariatiBindingSource
            // 
            this.salariatiBindingSource.DataMember = "Salariati";
            this.salariatiBindingSource.DataSource = this.calculatorSalariiDataSet;
            // 
            // calculatorSalariiDataSet
            // 
            this.calculatorSalariiDataSet.DataSetName = "CalculatorSalariiDataSet";
            this.calculatorSalariiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTablouBord
            // 
            this.btnTablouBord.FlatAppearance.BorderSize = 0;
            this.btnTablouBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablouBord.ForeColor = System.Drawing.Color.White;
            this.btnTablouBord.Image = global::CalculatorSalarii.Properties.Resources.turn_off;
            this.btnTablouBord.Location = new System.Drawing.Point(1002, 33);
            this.btnTablouBord.Name = "btnTablouBord";
            this.btnTablouBord.Size = new System.Drawing.Size(142, 75);
            this.btnTablouBord.TabIndex = 16;
            this.btnTablouBord.UseVisualStyleBackColor = true;
            this.btnTablouBord.Click += new System.EventHandler(this.btnTablouBord_Click);
            // 
            // btnStergeSalariat
            // 
            this.btnStergeSalariat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergeSalariat.ForeColor = System.Drawing.Color.White;
            this.btnStergeSalariat.Location = new System.Drawing.Point(1055, 363);
            this.btnStergeSalariat.Name = "btnStergeSalariat";
            this.btnStergeSalariat.Size = new System.Drawing.Size(89, 28);
            this.btnStergeSalariat.TabIndex = 13;
            this.btnStergeSalariat.Text = "Șterge";
            this.btnStergeSalariat.UseVisualStyleBackColor = true;
            this.btnStergeSalariat.Click += new System.EventHandler(this.btnStergeSalariat_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizare.ForeColor = System.Drawing.Color.White;
            this.btnActualizare.Location = new System.Drawing.Point(960, 363);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(89, 28);
            this.btnActualizare.TabIndex = 12;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.ForeColor = System.Drawing.Color.White;
            this.btnAdauga.Location = new System.Drawing.Point(865, 363);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(89, 28);
            this.btnAdauga.TabIndex = 11;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnStergePoza
            // 
            this.btnStergePoza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergePoza.ForeColor = System.Drawing.Color.White;
            this.btnStergePoza.Location = new System.Drawing.Point(213, 363);
            this.btnStergePoza.Name = "btnStergePoza";
            this.btnStergePoza.Size = new System.Drawing.Size(89, 28);
            this.btnStergePoza.TabIndex = 15;
            this.btnStergePoza.Text = "Șterge";
            this.btnStergePoza.UseVisualStyleBackColor = true;
            this.btnStergePoza.Click += new System.EventHandler(this.btnStergePoza_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare.ForeColor = System.Drawing.Color.White;
            this.btnSalvare.Location = new System.Drawing.Point(770, 363);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(89, 28);
            this.btnSalvare.TabIndex = 10;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSex.Location = new System.Drawing.Point(893, 226);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(200, 21);
            this.cmbSex.TabIndex = 7;
            // 
            // dtpDataNasterii
            // 
            this.dtpDataNasterii.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasterii.Location = new System.Drawing.Point(893, 179);
            this.dtpDataNasterii.Name = "dtpDataNasterii";
            this.dtpDataNasterii.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNasterii.TabIndex = 6;
            // 
            // txtContBancar
            // 
            this.txtContBancar.Location = new System.Drawing.Point(893, 312);
            this.txtContBancar.Name = "txtContBancar";
            this.txtContBancar.Size = new System.Drawing.Size(200, 20);
            this.txtContBancar.TabIndex = 9;
            // 
            // lblContBancar
            // 
            this.lblContBancar.AutoSize = true;
            this.lblContBancar.ForeColor = System.Drawing.Color.White;
            this.lblContBancar.Location = new System.Drawing.Point(802, 315);
            this.lblContBancar.Name = "lblContBancar";
            this.lblContBancar.Size = new System.Drawing.Size(63, 13);
            this.lblContBancar.TabIndex = 66;
            this.lblContBancar.Text = "ContBancar";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(893, 274);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(200, 20);
            this.txtCI.TabIndex = 8;
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.ForeColor = System.Drawing.Color.White;
            this.lblCI.Location = new System.Drawing.Point(802, 277);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(17, 13);
            this.lblCI.TabIndex = 65;
            this.lblCI.Text = "CI";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(802, 229);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 64;
            this.lblSex.Text = "Sex";
            // 
            // lblDataNasterii
            // 
            this.lblDataNasterii.AutoSize = true;
            this.lblDataNasterii.ForeColor = System.Drawing.Color.White;
            this.lblDataNasterii.Location = new System.Drawing.Point(802, 182);
            this.lblDataNasterii.Name = "lblDataNasterii";
            this.lblDataNasterii.Size = new System.Drawing.Size(65, 13);
            this.lblDataNasterii.TabIndex = 63;
            this.lblDataNasterii.Text = "DataNașterii";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(893, 134);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.ForeColor = System.Drawing.Color.White;
            this.lblTelefon.Location = new System.Drawing.Point(802, 137);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 61;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(491, 312);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(200, 20);
            this.txtAdresa.TabIndex = 4;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.ForeColor = System.Drawing.Color.White;
            this.lblAdresa.Location = new System.Drawing.Point(386, 315);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 58;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(491, 274);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(200, 20);
            this.txtCNP.TabIndex = 3;
            this.txtCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNP_KeyPress);
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.ForeColor = System.Drawing.Color.White;
            this.lblCNP.Location = new System.Drawing.Point(386, 277);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 56;
            this.lblCNP.Text = "CNP";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(491, 179);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 20);
            this.txtNume.TabIndex = 1;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(386, 182);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 53;
            this.lblNume.Text = "Nume";
            // 
            // txtMarcaSalariat
            // 
            this.txtMarcaSalariat.Location = new System.Drawing.Point(491, 134);
            this.txtMarcaSalariat.Name = "txtMarcaSalariat";
            this.txtMarcaSalariat.Size = new System.Drawing.Size(200, 20);
            this.txtMarcaSalariat.TabIndex = 0;
            this.txtMarcaSalariat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarcaSalariat_KeyPress);
            // 
            // lblMarcaSalariat
            // 
            this.lblMarcaSalariat.AutoSize = true;
            this.lblMarcaSalariat.ForeColor = System.Drawing.Color.White;
            this.lblMarcaSalariat.Location = new System.Drawing.Point(386, 137);
            this.lblMarcaSalariat.Name = "lblMarcaSalariat";
            this.lblMarcaSalariat.Size = new System.Drawing.Size(72, 13);
            this.lblMarcaSalariat.TabIndex = 50;
            this.lblMarcaSalariat.Text = "MarcaSalariat";
            // 
            // btnPoza
            // 
            this.btnPoza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoza.ForeColor = System.Drawing.Color.White;
            this.btnPoza.Location = new System.Drawing.Point(108, 363);
            this.btnPoza.Name = "btnPoza";
            this.btnPoza.Size = new System.Drawing.Size(89, 28);
            this.btnPoza.TabIndex = 14;
            this.btnPoza.Text = "Poza";
            this.btnPoza.UseVisualStyleBackColor = true;
            this.btnPoza.Click += new System.EventHandler(this.btnPoza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Detalii Salariați";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(1173, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 634);
            this.panel4.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(27, 636);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 10);
            this.panel3.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(18, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 634);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 13);
            this.panel1.TabIndex = 36;
            // 
            // picPoza
            // 
            this.picPoza.Location = new System.Drawing.Point(108, 134);
            this.picPoza.Name = "picPoza";
            this.picPoza.Size = new System.Drawing.Size(194, 204);
            this.picPoza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoza.TabIndex = 45;
            this.picPoza.TabStop = false;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(491, 226);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(200, 20);
            this.txtPrenume.TabIndex = 2;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.ForeColor = System.Drawing.Color.White;
            this.lblPrenume.Location = new System.Drawing.Point(386, 229);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 70;
            this.lblPrenume.Text = "Prenume";
            // 
            // salariatiTableAdapter
            // 
            this.salariatiTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetaliiSalariati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1195, 652);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNumeFisier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTablouBord);
            this.Controls.Add(this.btnStergeSalariat);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnStergePoza);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.dtpDataNasterii);
            this.Controls.Add(this.txtContBancar);
            this.Controls.Add(this.lblContBancar);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblDataNasterii);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtMarcaSalariat);
            this.Controls.Add(this.lblMarcaSalariat);
            this.Controls.Add(this.btnPoza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPoza);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetaliiSalariati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetaliiSalariati";
            this.Load += new System.EventHandler(this.frmDetaliiSalariati_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaliiSalariati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeFisier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetaliiSalariati;
        private System.Windows.Forms.Button btnTablouBord;
        private System.Windows.Forms.Button btnStergeSalariat;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnStergePoza;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.DateTimePicker dtpDataNasterii;
        private System.Windows.Forms.TextBox txtContBancar;
        private System.Windows.Forms.Label lblContBancar;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblDataNasterii;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtMarcaSalariat;
        private System.Windows.Forms.Label lblMarcaSalariat;
        private System.Windows.Forms.Button btnPoza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPoza;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private CalculatorSalariiDataSet calculatorSalariiDataSet;
        private System.Windows.Forms.BindingSource salariatiBindingSource;
        private CalculatorSalariiDataSetTableAdapters.SalariatiTableAdapter salariatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaSalariatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contBancarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeFisierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagineDataGridViewImageColumn;
    }
}