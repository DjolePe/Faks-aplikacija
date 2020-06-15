namespace Forme
{
    partial class TipKursaZaPoseteForma
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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipovi
            // 
            this.dgvTipovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipovi.Location = new System.Drawing.Point(12, 21);
            this.dgvTipovi.Name = "dgvTipovi";
            this.dgvTipovi.Size = new System.Drawing.Size(285, 150);
            this.dgvTipovi.TabIndex = 0;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(13, 178);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(75, 23);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TipKursaZaPoseteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 213);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvTipovi);
            this.Name = "TipKursaZaPoseteForma";
            this.Text = "TipKursaZaPoseteForma";
            this.Load += new System.EventHandler(this.TipKursaZaPoseteForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipovi;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button button2;
    }
}