namespace Forme
{
    partial class TipoviKursevaZaRad
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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvTipovi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(269, 261);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(113, 23);
            this.btnIzlaz.TabIndex = 5;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(38, 261);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(112, 23);
            this.btnIzaberi.TabIndex = 4;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgvTipovi
            // 
            this.dgvTipovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipovi.Location = new System.Drawing.Point(38, 32);
            this.dgvTipovi.Name = "dgvTipovi";
            this.dgvTipovi.ReadOnly = true;
            this.dgvTipovi.Size = new System.Drawing.Size(344, 223);
            this.dgvTipovi.TabIndex = 3;
            // 
            // TipoviKursevaZaRad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 328);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvTipovi);
            this.Name = "TipoviKursevaZaRad";
            this.Text = "Tipovi";
            this.Load += new System.EventHandler(this.TipoviKursevaZaRad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgvTipovi;
    }
}