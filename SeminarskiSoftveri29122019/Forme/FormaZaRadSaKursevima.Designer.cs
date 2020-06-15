namespace Forme
{
    partial class FormaZaRadSaKursevima
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.txtTipKursa = new System.Windows.Forms.TextBox();
            this.btnTipovi = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(142, 373);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(479, 23);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši kurs";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tip kursa";
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.Location = new System.Drawing.Point(81, 147);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.Size = new System.Drawing.Size(600, 150);
            this.dgvKursevi.TabIndex = 6;
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(142, 319);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(479, 23);
            this.btnPrikaziDetalje.TabIndex = 5;
            this.btnPrikaziDetalje.Text = "Prikaži detalje kursa";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click_1);
            // 
            // txtTipKursa
            // 
            this.txtTipKursa.Location = new System.Drawing.Point(285, 59);
            this.txtTipKursa.Name = "txtTipKursa";
            this.txtTipKursa.ReadOnly = true;
            this.txtTipKursa.Size = new System.Drawing.Size(277, 20);
            this.txtTipKursa.TabIndex = 10;
            // 
            // btnTipovi
            // 
            this.btnTipovi.Location = new System.Drawing.Point(588, 59);
            this.btnTipovi.Name = "btnTipovi";
            this.btnTipovi.Size = new System.Drawing.Size(44, 23);
            this.btnTipovi.TabIndex = 11;
            this.btnTipovi.Text = "S";
            this.btnTipovi.UseVisualStyleBackColor = true;
            this.btnTipovi.Click += new System.EventHandler(this.btnTipovi_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(285, 102);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(111, 23);
            this.btnPretraga.TabIndex = 12;
            this.btnPretraga.Text = "Pretraži kurseve";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormaZaRadSaKursevima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.btnTipovi);
            this.Controls.Add(this.txtTipKursa);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKursevi);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Name = "FormaZaRadSaKursevima";
            this.Text = "Kursevi";
            this.Load += new System.EventHandler(this.FormaZaRadSaKursevima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.Button btnTipovi;
        public System.Windows.Forms.TextBox txtTipKursa;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvKursevi;
    }
}