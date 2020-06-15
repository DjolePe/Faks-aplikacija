namespace Forme
{
    partial class ManipulacijaSaClanovima
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobilni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email:";
            // 
            // txtMobilni
            // 
            this.txtMobilni.Location = new System.Drawing.Point(118, 60);
            this.txtMobilni.Name = "txtMobilni";
            this.txtMobilni.Size = new System.Drawing.Size(135, 20);
            this.txtMobilni.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mobilni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(382, 23);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(184, 20);
            this.txtPrezime.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(79, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(174, 20);
            this.txtIme.TabIndex = 16;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(45, 141);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(104, 23);
            this.btnPretraga.TabIndex = 15;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(45, 179);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.Size = new System.Drawing.Size(520, 208);
            this.dgvClanovi.TabIndex = 12;
            // 
            // btnIzmena
            // 
            this.btnIzmena.Location = new System.Drawing.Point(203, 141);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(95, 23);
            this.btnIzmena.TabIndex = 24;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(357, 141);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(99, 23);
            this.btnBrisanje.TabIndex = 25;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(490, 141);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 26;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // ManipulacijaSaClanovima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 486);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMobilni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvClanovi);
            this.Name = "ManipulacijaSaClanovima";
            this.Text = "Manipulacija sa clanovima";
            this.Load += new System.EventHandler(this.ManipulacijaSaClanovima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMobilni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnExcel;
        public System.Windows.Forms.DataGridView dgvClanovi;
    }
}