namespace Forme
{
    partial class KurseviZaPoseteForma
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(12, 271);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(75, 23);
            this.btnIzaberi.TabIndex = 7;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.Location = new System.Drawing.Point(12, 37);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.Size = new System.Drawing.Size(522, 216);
            this.dgvKursevi.TabIndex = 6;
            // 
            // KurseviZaPoseteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvKursevi);
            this.Name = "KurseviZaPoseteForma";
            this.Text = "Kursevi";
            this.Load += new System.EventHandler(this.KurseviZaPoseteForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgvKursevi;
    }
}