namespace Server
{
    partial class PokretanjeServera
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
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Location = new System.Drawing.Point(87, 119);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(216, 23);
            this.btnZaustavi.TabIndex = 3;
            this.btnZaustavi.Text = "Zaustavi server";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(87, 45);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(216, 23);
            this.btnPokreni.TabIndex = 2;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // PokretanjeServera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 179);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Name = "PokretanjeServera";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.PokretanjeServera_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Button btnPokreni;
    }
}

