namespace Forme
{
    partial class DetaljiKursaForma
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
            this.txtProstor = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTipKursa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Izmeni kurs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtProstor
            // 
            this.txtProstor.Enabled = false;
            this.txtProstor.Location = new System.Drawing.Point(152, 219);
            this.txtProstor.Name = "txtProstor";
            this.txtProstor.Size = new System.Drawing.Size(147, 20);
            this.txtProstor.TabIndex = 20;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(152, 158);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(147, 20);
            this.txtCena.TabIndex = 19;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(152, 100);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(147, 20);
            this.txtTrajanje.TabIndex = 18;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Enabled = false;
            this.txtNaziv.Location = new System.Drawing.Point(152, 46);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(147, 20);
            this.txtNaziv.TabIndex = 17;
            // 
            // txtTipKursa
            // 
            this.txtTipKursa.Enabled = false;
            this.txtTipKursa.Location = new System.Drawing.Point(152, 284);
            this.txtTipKursa.Name = "txtTipKursa";
            this.txtTipKursa.Size = new System.Drawing.Size(147, 20);
            this.txtTipKursa.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tip kursa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Učionica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trajanje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naziv kursa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DetaljiKursaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProstor);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtTipKursa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetaljiKursaForma";
            this.Text = "Detalji forma";
            this.Load += new System.EventHandler(this.DetaljiKursaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProstor;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTipKursa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}