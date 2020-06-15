namespace Forme
{
    partial class PregledImportovanihClanovaForma
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
            this.dgvClanoviImport = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClanoviImport
            // 
            this.dgvClanoviImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanoviImport.Location = new System.Drawing.Point(12, 56);
            this.dgvClanoviImport.Name = "dgvClanoviImport";
            this.dgvClanoviImport.Size = new System.Drawing.Size(502, 271);
            this.dgvClanoviImport.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(13, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Importuj";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(439, 13);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // PregledImportovanihClanovaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 339);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvClanoviImport);
            this.Name = "PregledImportovanihClanovaForma";
            this.Text = "PregledImportovanihClanovaForma";
            this.Load += new System.EventHandler(this.PregledImportovanihClanovaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClanoviImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnIzlaz;
    }
}