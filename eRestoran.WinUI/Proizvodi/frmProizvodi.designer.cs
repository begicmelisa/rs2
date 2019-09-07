namespace eRestoran.WinUI.Proizvodi
{
    partial class frmProizvodi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.proizvodGrid = new System.Windows.Forms.DataGridView();
            this.cmbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.cmbJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrste proizvoda:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(151, 87);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(296, 22);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(151, 59);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(296, 22);
            this.txtSifra.TabIndex = 3;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(151, 115);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(98, 22);
            this.txtCijena.TabIndex = 4;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(151, 143);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(296, 22);
            this.txtSlikaInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sifra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Slika:";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(453, 143);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 30);
            this.btnDodajSliku.TabIndex = 11;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(662, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 56);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // proizvodGrid
            // 
            this.proizvodGrid.AllowUserToAddRows = false;
            this.proizvodGrid.AllowUserToDeleteRows = false;
            this.proizvodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.proizvodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodGrid.Location = new System.Drawing.Point(9, 240);
            this.proizvodGrid.Name = "proizvodGrid";
            this.proizvodGrid.ReadOnly = true;
            this.proizvodGrid.RowHeadersWidth = 51;
            this.proizvodGrid.RowTemplate.Height = 24;
            this.proizvodGrid.Size = new System.Drawing.Size(779, 198);
            this.proizvodGrid.TabIndex = 13;
            // 
            // cmbVrstaProizvoda
            // 
            this.cmbVrstaProizvoda.FormattingEnabled = true;
            this.cmbVrstaProizvoda.Location = new System.Drawing.Point(151, 29);
            this.cmbVrstaProizvoda.Name = "cmbVrstaProizvoda";
            this.cmbVrstaProizvoda.Size = new System.Drawing.Size(296, 24);
            this.cmbVrstaProizvoda.TabIndex = 14;
            // 
            // cmbJedinicaMjere
            // 
            this.cmbJedinicaMjere.FormattingEnabled = true;
            this.cmbJedinicaMjere.Location = new System.Drawing.Point(347, 113);
            this.cmbJedinicaMjere.Name = "cmbJedinicaMjere";
            this.cmbJedinicaMjere.Size = new System.Drawing.Size(100, 24);
            this.cmbJedinicaMjere.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jed. mjere:";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(639, 29);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbJedinicaMjere);
            this.Controls.Add(this.cmbVrstaProizvoda);
            this.Controls.Add(this.proizvodGrid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodi";
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.FrmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView proizvodGrid;
        private System.Windows.Forms.ComboBox cmbVrstaProizvoda;
        private System.Windows.Forms.ComboBox cmbJedinicaMjere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}