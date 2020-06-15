namespace Forme
{
    partial class ProstorForma
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
            this.dgvProstori = new System.Windows.Forms.DataGridView();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProstori
            // 
            this.dgvProstori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProstori.Location = new System.Drawing.Point(12, 12);
            this.dgvProstori.Name = "dgvProstori";
            this.dgvProstori.ReadOnly = true;
            this.dgvProstori.Size = new System.Drawing.Size(260, 238);
            this.dgvProstori.TabIndex = 0;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(12, 272);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(75, 23);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(196, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProstorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvProstori);
            this.Name = "ProstorForma";
            this.Text = "Prostori";
            this.Load += new System.EventHandler(this.ProstorForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProstori;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnExit;
    }
}