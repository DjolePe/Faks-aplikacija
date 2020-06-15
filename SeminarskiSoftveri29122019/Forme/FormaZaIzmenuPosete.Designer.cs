namespace Forme
{
    partial class FormaZaIzmenuPosete
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.txtKurs = new System.Windows.Forms.TextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(174, 40);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // txtClan
            // 
            this.txtClan.Enabled = false;
            this.txtClan.Location = new System.Drawing.Point(174, 113);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(200, 20);
            this.txtClan.TabIndex = 1;
            // 
            // txtKurs
            // 
            this.txtKurs.Enabled = false;
            this.txtKurs.Location = new System.Drawing.Point(174, 190);
            this.txtKurs.Name = "txtKurs";
            this.txtKurs.Size = new System.Drawing.Size(200, 20);
            this.txtKurs.TabIndex = 2;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(174, 267);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(200, 23);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Sačuvaj izmene";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormaZaIzmenuPosete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.txtKurs);
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.dtpDatum);
            this.Name = "FormaZaIzmenuPosete";
            this.Text = "Izmena prisustva";
            this.Load += new System.EventHandler(this.FormaZaIzmenuPosete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.TextBox txtKurs;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button button1;
    }
}