namespace prodavnicaElektroOpreme
{
    partial class Dobavljaci
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnMenjaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgDobavljaci = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(524, 358);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(443, 358);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 27;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(362, 358);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 26;
            this.btnBrisi.Text = "Brisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            // 
            // btnMenjaj
            // 
            this.btnMenjaj.Location = new System.Drawing.Point(281, 358);
            this.btnMenjaj.Name = "btnMenjaj";
            this.btnMenjaj.Size = new System.Drawing.Size(75, 23);
            this.btnMenjaj.TabIndex = 25;
            this.btnMenjaj.Text = "Menjaj";
            this.btnMenjaj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(200, 358);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dgDobavljaci
            // 
            this.dgDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDobavljaci.Location = new System.Drawing.Point(54, 202);
            this.dgDobavljaci.Name = "dgDobavljaci";
            this.dgDobavljaci.RowTemplate.Height = 25;
            this.dgDobavljaci.Size = new System.Drawing.Size(693, 150);
            this.dgDobavljaci.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(308, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 23);
            this.txtEmail.TabIndex = 21;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(308, 70);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(226, 23);
            this.txtIme.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email dobavljaca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ime dobavljaca:";
            // 
            // Dobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnMenjaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgDobavljaci);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dobavljaci";
            this.Text = "Dobavljaci";
            this.Load += new System.EventHandler(this.Dobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDobavljaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOdustani;
        private Button btnPotvrdi;
        private Button btnBrisi;
        private Button btnMenjaj;
        private Button btnDodaj;
        private DataGridView dgDobavljaci;
        private TextBox txtEmail;
        private TextBox txtIme;
        private Label label2;
        private Label label1;
    }
}