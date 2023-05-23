namespace prodavnicaElektroOpreme
{
    partial class frmProizvodi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtIdDobavljaca = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtBrojNaStanju = new System.Windows.Forms.TextBox();
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnMenjaj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime proizvoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj proizvoda na stanju:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID dobavljaca:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(279, 69);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(226, 23);
            this.txtIme.TabIndex = 5;
            // 
            // txtIdDobavljaca
            // 
            this.txtIdDobavljaca.Location = new System.Drawing.Point(279, 156);
            this.txtIdDobavljaca.Name = "txtIdDobavljaca";
            this.txtIdDobavljaca.Size = new System.Drawing.Size(226, 23);
            this.txtIdDobavljaca.TabIndex = 6;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(279, 98);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(226, 23);
            this.txtCena.TabIndex = 7;
            // 
            // txtBrojNaStanju
            // 
            this.txtBrojNaStanju.Location = new System.Drawing.Point(279, 127);
            this.txtBrojNaStanju.Name = "txtBrojNaStanju";
            this.txtBrojNaStanju.Size = new System.Drawing.Size(226, 23);
            this.txtBrojNaStanju.TabIndex = 8;
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Location = new System.Drawing.Point(25, 201);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.RowTemplate.Height = 25;
            this.dgProizvodi.Size = new System.Drawing.Size(693, 150);
            this.dgProizvodi.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(171, 357);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnMenjaj
            // 
            this.btnMenjaj.Location = new System.Drawing.Point(252, 357);
            this.btnMenjaj.Name = "btnMenjaj";
            this.btnMenjaj.Size = new System.Drawing.Size(75, 23);
            this.btnMenjaj.TabIndex = 11;
            this.btnMenjaj.Text = "Menjaj";
            this.btnMenjaj.UseVisualStyleBackColor = true;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(333, 357);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 12;
            this.btnBrisi.Text = "Brisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(414, 357);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 13;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(495, 357);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnMenjaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgProizvodi);
            this.Controls.Add(this.txtBrojNaStanju);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtIdDobavljaca);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodi";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIme;
        private TextBox txtIdDobavljaca;
        private TextBox txtCena;
        private TextBox txtBrojNaStanju;
        private DataGridView dgProizvodi;
        private Button btnDodaj;
        private Button btnMenjaj;
        private Button btnBrisi;
        private Button btnPotvrdi;
        private Button btnOdustani;
    }
}