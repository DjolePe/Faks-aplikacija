namespace Forme
{
    partial class UnosNovogKursa
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTipoviKursa = new System.Windows.Forms.TextBox();
            this.btnTipoviKursa = new System.Windows.Forms.Button();
            this.btnProstori = new System.Windows.Forms.Button();
            this.txtProstor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Unesite kurs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Učionica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tip kursa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Trajanje";
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(291, 60);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(34, 13);
            this.Naziv.TabIndex = 16;
            this.Naziv.Text = "Naziv";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(340, 169);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(201, 20);
            this.txtCena.TabIndex = 13;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(340, 117);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(201, 20);
            this.txtTrajanje.TabIndex = 12;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(340, 53);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(201, 20);
            this.txtNaziv.TabIndex = 11;
            // 
            // txtTipoviKursa
            // 
            this.txtTipoviKursa.Location = new System.Drawing.Point(340, 222);
            this.txtTipoviKursa.Name = "txtTipoviKursa";
            this.txtTipoviKursa.ReadOnly = true;
            this.txtTipoviKursa.Size = new System.Drawing.Size(201, 20);
            this.txtTipoviKursa.TabIndex = 22;
            this.txtTipoviKursa.TextChanged += new System.EventHandler(this.txtTipoviKursa_TextChanged);
            // 
            // btnTipoviKursa
            // 
            this.btnTipoviKursa.Location = new System.Drawing.Point(560, 222);
            this.btnTipoviKursa.Name = "btnTipoviKursa";
            this.btnTipoviKursa.Size = new System.Drawing.Size(31, 23);
            this.btnTipoviKursa.TabIndex = 23;
            this.btnTipoviKursa.Text = "S";
            this.btnTipoviKursa.UseVisualStyleBackColor = true;
            this.btnTipoviKursa.Click += new System.EventHandler(this.btnTipoviKursa_Click);
            // 
            // btnProstori
            // 
            this.btnProstori.Location = new System.Drawing.Point(560, 279);
            this.btnProstori.Name = "btnProstori";
            this.btnProstori.Size = new System.Drawing.Size(31, 23);
            this.btnProstori.TabIndex = 24;
            this.btnProstori.Text = "S";
            this.btnProstori.UseVisualStyleBackColor = true;
            this.btnProstori.Click += new System.EventHandler(this.btnProstori_Click);
            // 
            // txtProstor
            // 
            this.txtProstor.Location = new System.Drawing.Point(340, 282);
            this.txtProstor.Name = "txtProstor";
            this.txtProstor.ReadOnly = true;
            this.txtProstor.Size = new System.Drawing.Size(201, 20);
            this.txtProstor.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnosNovogKursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtProstor);
            this.Controls.Add(this.btnProstori);
            this.Controls.Add(this.btnTipoviKursa);
            this.Controls.Add(this.txtTipoviKursa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtNaziv);
            this.Name = "UnosNovogKursa";
            this.Text = "Unos kursa";
            this.Load += new System.EventHandler(this.UnosNovogKursa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnTipoviKursa;
        public System.Windows.Forms.TextBox txtTipoviKursa;
        private System.Windows.Forms.Button btnProstori;
        public System.Windows.Forms.TextBox txtProstor;
        private System.Windows.Forms.Button button2;
    }
}