namespace PUSKESMAS
{
    partial class Menu
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
            this.pasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRuanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasienToolStripMenuItem,
            this.dokterToolStripMenuItem,
            this.obatToolStripMenuItem,
            this.ruanganToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pasienToolStripMenuItem
            // 
            this.pasienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPasienToolStripMenuItem});
            this.pasienToolStripMenuItem.Name = "pasienToolStripMenuItem";
            this.pasienToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.pasienToolStripMenuItem.Text = "Pasien";
            // 
            // dataPasienToolStripMenuItem
            // 
            this.dataPasienToolStripMenuItem.Name = "dataPasienToolStripMenuItem";
            this.dataPasienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPasienToolStripMenuItem.Text = "Data pasien";
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataDokterToolStripMenuItem});
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dokterToolStripMenuItem.Text = "Dokter";
            // 
            // dataDokterToolStripMenuItem
            // 
            this.dataDokterToolStripMenuItem.Name = "dataDokterToolStripMenuItem";
            this.dataDokterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataDokterToolStripMenuItem.Text = "Data dokter";
            // 
            // obatToolStripMenuItem
            // 
            this.obatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataObatToolStripMenuItem});
            this.obatToolStripMenuItem.Name = "obatToolStripMenuItem";
            this.obatToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.obatToolStripMenuItem.Text = "Obat";
            // 
            // dataObatToolStripMenuItem
            // 
            this.dataObatToolStripMenuItem.Name = "dataObatToolStripMenuItem";
            this.dataObatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataObatToolStripMenuItem.Text = "Data obat";
            // 
            // ruanganToolStripMenuItem
            // 
            this.ruanganToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataRuanganToolStripMenuItem});
            this.ruanganToolStripMenuItem.Name = "ruanganToolStripMenuItem";
            this.ruanganToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ruanganToolStripMenuItem.Text = "Ruangan";
            // 
            // dataRuanganToolStripMenuItem
            // 
            this.dataRuanganToolStripMenuItem.Name = "dataRuanganToolStripMenuItem";
            this.dataRuanganToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataRuanganToolStripMenuItem.Text = "Data ruangan";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRuanganToolStripMenuItem;
    }
}