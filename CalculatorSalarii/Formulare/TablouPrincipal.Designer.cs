
namespace CalculatorSalarii
{
    partial class frmTablouPrincipal
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
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIesire = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRapoarte = new System.Windows.Forms.Button();
            this.btnSalarii = new System.Windows.Forms.Button();
            this.btnSalariati = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1073, 34);
            this.materialTabSelector2.TabIndex = 5;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.btnIesire);
            this.panel3.Location = new System.Drawing.Point(188, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 100);
            this.panel3.TabIndex = 6;
            // 
            // btnIesire
            // 
            this.btnIesire.FlatAppearance.BorderSize = 0;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.ForeColor = System.Drawing.Color.White;
            this.btnIesire.Image = global::CalculatorSalarii.Properties.Resources.turn_off;
            this.btnIesire.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIesire.Location = new System.Drawing.Point(759, 3);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(126, 91);
            this.btnIesire.TabIndex = 7;
            this.btnIesire.Text = "Ieșire";
            this.btnIesire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnRapoarte);
            this.panel1.Controls.Add(this.btnSalarii);
            this.panel1.Controls.Add(this.btnSalariati);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 612);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::CalculatorSalarii.Properties.Resources.user;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmin.Location = new System.Drawing.Point(33, 505);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(114, 95);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRapoarte
            // 
            this.btnRapoarte.FlatAppearance.BorderSize = 0;
            this.btnRapoarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapoarte.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapoarte.ForeColor = System.Drawing.Color.White;
            this.btnRapoarte.Image = global::CalculatorSalarii.Properties.Resources.report;
            this.btnRapoarte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRapoarte.Location = new System.Drawing.Point(33, 284);
            this.btnRapoarte.Name = "btnRapoarte";
            this.btnRapoarte.Size = new System.Drawing.Size(114, 95);
            this.btnRapoarte.TabIndex = 5;
            this.btnRapoarte.Text = "Rapoarte";
            this.btnRapoarte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRapoarte.UseVisualStyleBackColor = true;
            this.btnRapoarte.Click += new System.EventHandler(this.btnRapoarte_Click);
            // 
            // btnSalarii
            // 
            this.btnSalarii.FlatAppearance.BorderSize = 0;
            this.btnSalarii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalarii.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarii.ForeColor = System.Drawing.Color.White;
            this.btnSalarii.Image = global::CalculatorSalarii.Properties.Resources.wages;
            this.btnSalarii.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalarii.Location = new System.Drawing.Point(33, 152);
            this.btnSalarii.Name = "btnSalarii";
            this.btnSalarii.Size = new System.Drawing.Size(114, 95);
            this.btnSalarii.TabIndex = 4;
            this.btnSalarii.Text = "Salarii";
            this.btnSalarii.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalarii.UseVisualStyleBackColor = true;
            this.btnSalarii.Click += new System.EventHandler(this.btnSalarii_Click);
            // 
            // btnSalariati
            // 
            this.btnSalariati.FlatAppearance.BorderSize = 0;
            this.btnSalariati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalariati.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalariati.ForeColor = System.Drawing.Color.White;
            this.btnSalariati.Image = global::CalculatorSalarii.Properties.Resources.employee;
            this.btnSalariati.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalariati.Location = new System.Drawing.Point(33, 20);
            this.btnSalariati.Name = "btnSalariati";
            this.btnSalariati.Size = new System.Drawing.Size(114, 95);
            this.btnSalariati.TabIndex = 3;
            this.btnSalariati.Text = "Salariați";
            this.btnSalariati.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalariati.UseVisualStyleBackColor = true;
            this.btnSalariati.Click += new System.EventHandler(this.btnSalariati_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(245, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculatorSalarii.Properties.Resources.note_contabile_2019;
            this.pictureBox1.Location = new System.Drawing.Point(186, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 509);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmTablouPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 707);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmTablouPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Salarii";
            this.Load += new System.EventHandler(this.frmTablouPrincipal_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRapoarte;
        private System.Windows.Forms.Button btnSalarii;
        private System.Windows.Forms.Button btnSalariati;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

