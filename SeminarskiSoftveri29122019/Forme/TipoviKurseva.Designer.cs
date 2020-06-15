namespace Forme
{
    partial class TipoviKurseva
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
            this.dgvTipovi = new System.Windows.Forms.DataGridView();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipovi
            // 
            this.dgvTipovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipovi.Location = new System.Drawing.Point(12, 12);
            this.dgvTipovi.Name = "dgvTipovi";
            this.dgvTipovi.ReadOnly = true;
            this.dgvTipovi.Size = new System.Drawing.Size(341, 241);
            this.dgvTipovi.TabIndex = 0;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(12, 274);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(109, 23);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(243, 274);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(110, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // TipoviKurseva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 319);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvTipovi);
            this.Name = "TipoviKurseva";
            this.Text = "Tipovi";
            this.Load += new System.EventHandler(this.TipoviKurseva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipovi;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnIzlaz;
    }
}