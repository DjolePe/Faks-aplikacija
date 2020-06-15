namespace Forme
{
    partial class RadSaPosetamaForma
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPosete = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnPretragaClanova = new System.Windows.Forms.Button();
            this.btnPretragaTipova = new System.Windows.Forms.Button();
            this.btnPretragaKurseva = new System.Windows.Forms.Button();
            this.txtClanovi = new System.Windows.Forms.TextBox();
            this.txtTipovi = new System.Windows.Forms.TextBox();
            this.txtKursevi = new System.Windows.Forms.TextBox();
            this.btnVratiPosete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.dtpDatum = new Forme.MyDateTimePicker();
            this.btnOcistiClan = new System.Windows.Forms.Button();
            this.btnOcistiTip = new System.Windows.Forms.Button();
            this.btnOcistiKurs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(499, 116);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(90, 23);
            this.btnObrisi.TabIndex = 25;
            this.btnObrisi.Text = "Obriši prisustvo";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tip kursa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Član";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Datum";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(499, 68);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 23);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj prisustvo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Izmeni prisustvo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPosete
            // 
            this.dgvPosete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPosete.Location = new System.Drawing.Point(132, 214);
            this.dgvPosete.Name = "dgvPosete";
            this.dgvPosete.Size = new System.Drawing.Size(530, 150);
            this.dgvPosete.TabIndex = 14;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(132, 394);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(221, 23);
            this.btnSacuvaj.TabIndex = 26;
            this.btnSacuvaj.Text = "Sačuvaj prisustva";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnPretragaClanova
            // 
            this.btnPretragaClanova.Location = new System.Drawing.Point(342, 69);
            this.btnPretragaClanova.Name = "btnPretragaClanova";
            this.btnPretragaClanova.Size = new System.Drawing.Size(56, 23);
            this.btnPretragaClanova.TabIndex = 28;
            this.btnPretragaClanova.Text = "Izaberi";
            this.btnPretragaClanova.UseVisualStyleBackColor = true;
            this.btnPretragaClanova.Click += new System.EventHandler(this.btnPretragaClanova_Click);
            // 
            // btnPretragaTipova
            // 
            this.btnPretragaTipova.Location = new System.Drawing.Point(342, 117);
            this.btnPretragaTipova.Name = "btnPretragaTipova";
            this.btnPretragaTipova.Size = new System.Drawing.Size(56, 23);
            this.btnPretragaTipova.TabIndex = 29;
            this.btnPretragaTipova.Text = "Izaberi";
            this.btnPretragaTipova.UseVisualStyleBackColor = true;
            this.btnPretragaTipova.Click += new System.EventHandler(this.btnPretragaTipova_Click);
            // 
            // btnPretragaKurseva
            // 
            this.btnPretragaKurseva.Location = new System.Drawing.Point(342, 164);
            this.btnPretragaKurseva.Name = "btnPretragaKurseva";
            this.btnPretragaKurseva.Size = new System.Drawing.Size(56, 23);
            this.btnPretragaKurseva.TabIndex = 30;
            this.btnPretragaKurseva.Text = "Izaberi";
            this.btnPretragaKurseva.UseVisualStyleBackColor = true;
            this.btnPretragaKurseva.Click += new System.EventHandler(this.btnPretragaKurseva_Click);
            // 
            // txtClanovi
            // 
            this.txtClanovi.Location = new System.Drawing.Point(205, 71);
            this.txtClanovi.Name = "txtClanovi";
            this.txtClanovi.ReadOnly = true;
            this.txtClanovi.Size = new System.Drawing.Size(120, 20);
            this.txtClanovi.TabIndex = 31;
            // 
            // txtTipovi
            // 
            this.txtTipovi.Location = new System.Drawing.Point(204, 119);
            this.txtTipovi.Name = "txtTipovi";
            this.txtTipovi.ReadOnly = true;
            this.txtTipovi.Size = new System.Drawing.Size(121, 20);
            this.txtTipovi.TabIndex = 32;
            // 
            // txtKursevi
            // 
            this.txtKursevi.Location = new System.Drawing.Point(205, 167);
            this.txtKursevi.Name = "txtKursevi";
            this.txtKursevi.ReadOnly = true;
            this.txtKursevi.Size = new System.Drawing.Size(120, 20);
            this.txtKursevi.TabIndex = 33;
            // 
            // btnVratiPosete
            // 
            this.btnVratiPosete.Location = new System.Drawing.Point(499, 29);
            this.btnVratiPosete.Name = "btnVratiPosete";
            this.btnVratiPosete.Size = new System.Drawing.Size(112, 23);
            this.btnVratiPosete.TabIndex = 34;
            this.btnVratiPosete.Text = "Pronadji prisustva";
            this.btnVratiPosete.UseVisualStyleBackColor = true;
            this.btnVratiPosete.Click += new System.EventHandler(this.btnVratiPosete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(674, 26);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(99, 23);
            this.btnStampaj.TabIndex = 38;
            this.btnStampaj.Text = "Izveštaj";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "yyyy-dd-MM";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(205, 29);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(120, 20);
            this.dtpDatum.TabIndex = 35;
            // 
            // btnOcistiClan
            // 
            this.btnOcistiClan.Location = new System.Drawing.Point(417, 69);
            this.btnOcistiClan.Name = "btnOcistiClan";
            this.btnOcistiClan.Size = new System.Drawing.Size(44, 23);
            this.btnOcistiClan.TabIndex = 39;
            this.btnOcistiClan.Text = "Očisti";
            this.btnOcistiClan.UseVisualStyleBackColor = true;
            this.btnOcistiClan.Click += new System.EventHandler(this.btnOcistiClan_Click);
            // 
            // btnOcistiTip
            // 
            this.btnOcistiTip.Location = new System.Drawing.Point(417, 116);
            this.btnOcistiTip.Name = "btnOcistiTip";
            this.btnOcistiTip.Size = new System.Drawing.Size(44, 23);
            this.btnOcistiTip.TabIndex = 40;
            this.btnOcistiTip.Text = "Očisti";
            this.btnOcistiTip.UseVisualStyleBackColor = true;
            this.btnOcistiTip.Click += new System.EventHandler(this.btnOcistiTip_Click);
            // 
            // btnOcistiKurs
            // 
            this.btnOcistiKurs.Location = new System.Drawing.Point(417, 164);
            this.btnOcistiKurs.Name = "btnOcistiKurs";
            this.btnOcistiKurs.Size = new System.Drawing.Size(44, 23);
            this.btnOcistiKurs.TabIndex = 41;
            this.btnOcistiKurs.Text = "Očisti";
            this.btnOcistiKurs.UseVisualStyleBackColor = true;
            this.btnOcistiKurs.Click += new System.EventHandler(this.btnOcistiKurs_Click);
            // 
            // RadSaPosetamaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOcistiKurs);
            this.Controls.Add(this.btnOcistiTip);
            this.Controls.Add(this.btnOcistiClan);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnVratiPosete);
            this.Controls.Add(this.txtKursevi);
            this.Controls.Add(this.txtTipovi);
            this.Controls.Add(this.txtClanovi);
            this.Controls.Add(this.btnPretragaKurseva);
            this.Controls.Add(this.btnPretragaTipova);
            this.Controls.Add(this.btnPretragaClanova);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPosete);
            this.Name = "RadSaPosetamaForma";
            this.Text = "Prisustva";
            this.Load += new System.EventHandler(this.RadSaPosetamaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnPretragaClanova;
        private System.Windows.Forms.Button btnPretragaTipova;
        private System.Windows.Forms.Button btnPretragaKurseva;
        public System.Windows.Forms.TextBox txtClanovi;
        public System.Windows.Forms.TextBox txtTipovi;
        public System.Windows.Forms.TextBox txtKursevi;
        private System.Windows.Forms.Button btnVratiPosete;
        private MyDateTimePicker dtpDatum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStampaj;
        public System.Windows.Forms.DataGridView dgvPosete;
        private System.Windows.Forms.Button btnOcistiClan;
        private System.Windows.Forms.Button btnOcistiTip;
        private System.Windows.Forms.Button btnOcistiKurs;
    }
}