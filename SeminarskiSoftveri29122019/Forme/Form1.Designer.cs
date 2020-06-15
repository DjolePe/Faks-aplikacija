namespace Forme
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radSaClanovimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogKursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radSaPostojecimKursevimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radSaPosetamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKrajRada = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clanToolStripMenuItem,
            this.kursToolStripMenuItem,
            this.posetaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clanToolStripMenuItem
            // 
            this.clanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosClanaToolStripMenuItem,
            this.radSaClanovimaToolStripMenuItem});
            this.clanToolStripMenuItem.Name = "clanToolStripMenuItem";
            this.clanToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.clanToolStripMenuItem.Text = "Član";
            // 
            // unosClanaToolStripMenuItem
            // 
            this.unosClanaToolStripMenuItem.Name = "unosClanaToolStripMenuItem";
            this.unosClanaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.unosClanaToolStripMenuItem.Text = "Unos člana";
            this.unosClanaToolStripMenuItem.Click += new System.EventHandler(this.unosClanaToolStripMenuItem_Click_1);
            // 
            // radSaClanovimaToolStripMenuItem
            // 
            this.radSaClanovimaToolStripMenuItem.Name = "radSaClanovimaToolStripMenuItem";
            this.radSaClanovimaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.radSaClanovimaToolStripMenuItem.Text = "Rad sa članovima";
            this.radSaClanovimaToolStripMenuItem.Click += new System.EventHandler(this.radSaClanovimaToolStripMenuItem_Click);
            // 
            // kursToolStripMenuItem
            // 
            this.kursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogKursaToolStripMenuItem,
            this.radSaPostojecimKursevimaToolStripMenuItem});
            this.kursToolStripMenuItem.Name = "kursToolStripMenuItem";
            this.kursToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.kursToolStripMenuItem.Text = "Kurs";
            // 
            // unosNovogKursaToolStripMenuItem
            // 
            this.unosNovogKursaToolStripMenuItem.Name = "unosNovogKursaToolStripMenuItem";
            this.unosNovogKursaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.unosNovogKursaToolStripMenuItem.Text = "Unos novog kursa";
            this.unosNovogKursaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogKursaToolStripMenuItem_Click_1);
            // 
            // radSaPostojecimKursevimaToolStripMenuItem
            // 
            this.radSaPostojecimKursevimaToolStripMenuItem.Name = "radSaPostojecimKursevimaToolStripMenuItem";
            this.radSaPostojecimKursevimaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.radSaPostojecimKursevimaToolStripMenuItem.Text = "Rad sa postojećim kursevima";
            this.radSaPostojecimKursevimaToolStripMenuItem.Click += new System.EventHandler(this.radSaPostojecimKursevimaToolStripMenuItem_Click_1);
            // 
            // posetaToolStripMenuItem
            // 
            this.posetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radSaPosetamaToolStripMenuItem});
            this.posetaToolStripMenuItem.Name = "posetaToolStripMenuItem";
            this.posetaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.posetaToolStripMenuItem.Text = "Prisustva";
            this.posetaToolStripMenuItem.Click += new System.EventHandler(this.posetaToolStripMenuItem_Click);
            // 
            // radSaPosetamaToolStripMenuItem
            // 
            this.radSaPosetamaToolStripMenuItem.Name = "radSaPosetamaToolStripMenuItem";
            this.radSaPosetamaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.radSaPosetamaToolStripMenuItem.Text = "Rad sa prisustvima";
            this.radSaPosetamaToolStripMenuItem.Click += new System.EventHandler(this.radSaPosetamaToolStripMenuItem_Click_1);
            // 
            // btnKrajRada
            // 
            this.btnKrajRada.Location = new System.Drawing.Point(247, 323);
            this.btnKrajRada.Name = "btnKrajRada";
            this.btnKrajRada.Size = new System.Drawing.Size(278, 23);
            this.btnKrajRada.TabIndex = 4;
            this.btnKrajRada.Text = "Kraj rada";
            this.btnKrajRada.UseVisualStyleBackColor = true;
            this.btnKrajRada.Click += new System.EventHandler(this.btnKrajRada_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKrajRada);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Glavna forma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogKursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radSaPostojecimKursevimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radSaPosetamaToolStripMenuItem;
        private System.Windows.Forms.Button btnKrajRada;
        private System.Windows.Forms.ToolStripMenuItem radSaClanovimaToolStripMenuItem;
    }
}

