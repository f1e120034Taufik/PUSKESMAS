namespace PUSKESMAS
{
    partial class FormRuangan
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
            this.buttonCariIDRuangan = new System.Windows.Forms.Button();
            this.buttonHapusDataRuangan = new System.Windows.Forms.Button();
            this.buttonUbahDataRuangan = new System.Windows.Forms.Button();
            this.buttonSImpanDataRuangan = new System.Windows.Forms.Button();
            this.textBoxCariIDRuangan = new System.Windows.Forms.TextBox();
            this.labelCariIDRuangan = new System.Windows.Forms.Label();
            this.dataGridViewRuangan = new System.Windows.Forms.DataGridView();
            this.groupBoxDataPasien = new System.Windows.Forms.GroupBox();
            this.textBoxIDRuangan = new System.Windows.Forms.TextBox();
            this.labelNamaRuanganPasien = new System.Windows.Forms.Label();
            this.labelNamaRuanganDokter = new System.Windows.Forms.Label();
            this.labelIDRuangan = new System.Windows.Forms.Label();
            this.labelDataObat = new System.Windows.Forms.Label();
            this.comboBoxRuanganDokter = new System.Windows.Forms.ComboBox();
            this.comboBoxRuanganPasien = new System.Windows.Forms.ComboBox();
            this.textBoxNomorRuangan = new System.Windows.Forms.TextBox();
            this.labelNomorRuangan = new System.Windows.Forms.Label();
            this.Id_ruang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_ruangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuangan)).BeginInit();
            this.groupBoxDataPasien.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCariIDRuangan
            // 
            this.buttonCariIDRuangan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCariIDRuangan.Location = new System.Drawing.Point(1128, 88);
            this.buttonCariIDRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCariIDRuangan.Name = "buttonCariIDRuangan";
            this.buttonCariIDRuangan.Size = new System.Drawing.Size(100, 28);
            this.buttonCariIDRuangan.TabIndex = 27;
            this.buttonCariIDRuangan.Text = "Cari";
            this.buttonCariIDRuangan.UseVisualStyleBackColor = true;
            this.buttonCariIDRuangan.Click += new System.EventHandler(this.buttonCariIDRuangan_Click);
            // 
            // buttonHapusDataRuangan
            // 
            this.buttonHapusDataRuangan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusDataRuangan.Location = new System.Drawing.Point(1010, 489);
            this.buttonHapusDataRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHapusDataRuangan.Name = "buttonHapusDataRuangan";
            this.buttonHapusDataRuangan.Size = new System.Drawing.Size(100, 28);
            this.buttonHapusDataRuangan.TabIndex = 26;
            this.buttonHapusDataRuangan.Text = "Hapus";
            this.buttonHapusDataRuangan.UseVisualStyleBackColor = true;
            this.buttonHapusDataRuangan.Click += new System.EventHandler(this.buttonHapusDataRuangan_Click);
            // 
            // buttonUbahDataRuangan
            // 
            this.buttonUbahDataRuangan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbahDataRuangan.Location = new System.Drawing.Point(886, 489);
            this.buttonUbahDataRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUbahDataRuangan.Name = "buttonUbahDataRuangan";
            this.buttonUbahDataRuangan.Size = new System.Drawing.Size(100, 28);
            this.buttonUbahDataRuangan.TabIndex = 25;
            this.buttonUbahDataRuangan.Text = "Ubah";
            this.buttonUbahDataRuangan.UseVisualStyleBackColor = true;
            this.buttonUbahDataRuangan.Click += new System.EventHandler(this.buttonUbahDataRuangan_Click);
            // 
            // buttonSImpanDataRuangan
            // 
            this.buttonSImpanDataRuangan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSImpanDataRuangan.Location = new System.Drawing.Point(756, 489);
            this.buttonSImpanDataRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSImpanDataRuangan.Name = "buttonSImpanDataRuangan";
            this.buttonSImpanDataRuangan.Size = new System.Drawing.Size(100, 28);
            this.buttonSImpanDataRuangan.TabIndex = 24;
            this.buttonSImpanDataRuangan.Text = "Simpan";
            this.buttonSImpanDataRuangan.UseVisualStyleBackColor = true;
            this.buttonSImpanDataRuangan.Click += new System.EventHandler(this.buttonSImpanDataRuangan_Click);
            // 
            // textBoxCariIDRuangan
            // 
            this.textBoxCariIDRuangan.Location = new System.Drawing.Point(870, 92);
            this.textBoxCariIDRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCariIDRuangan.Name = "textBoxCariIDRuangan";
            this.textBoxCariIDRuangan.Size = new System.Drawing.Size(250, 22);
            this.textBoxCariIDRuangan.TabIndex = 23;
            // 
            // labelCariIDRuangan
            // 
            this.labelCariIDRuangan.AutoSize = true;
            this.labelCariIDRuangan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariIDRuangan.Location = new System.Drawing.Point(623, 92);
            this.labelCariIDRuangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCariIDRuangan.Name = "labelCariIDRuangan";
            this.labelCariIDRuangan.Size = new System.Drawing.Size(239, 19);
            this.labelCariIDRuangan.TabIndex = 22;
            this.labelCariIDRuangan.Text = "Cari Berdasarkan Nomor Ruangan";
            // 
            // dataGridViewRuangan
            // 
            this.dataGridViewRuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRuangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ruang,
            this.No_ruangan,
            this.Dokter,
            this.Pasien});
            this.dataGridViewRuangan.Location = new System.Drawing.Point(690, 138);
            this.dataGridViewRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRuangan.Name = "dataGridViewRuangan";
            this.dataGridViewRuangan.RowHeadersWidth = 51;
            this.dataGridViewRuangan.Size = new System.Drawing.Size(494, 310);
            this.dataGridViewRuangan.TabIndex = 21;
            this.dataGridViewRuangan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRuangan_CellContentClick);
            // 
            // groupBoxDataPasien
            // 
            this.groupBoxDataPasien.Controls.Add(this.labelNomorRuangan);
            this.groupBoxDataPasien.Controls.Add(this.textBoxNomorRuangan);
            this.groupBoxDataPasien.Controls.Add(this.comboBoxRuanganPasien);
            this.groupBoxDataPasien.Controls.Add(this.comboBoxRuanganDokter);
            this.groupBoxDataPasien.Controls.Add(this.textBoxIDRuangan);
            this.groupBoxDataPasien.Controls.Add(this.labelNamaRuanganPasien);
            this.groupBoxDataPasien.Controls.Add(this.labelNamaRuanganDokter);
            this.groupBoxDataPasien.Controls.Add(this.labelIDRuangan);
            this.groupBoxDataPasien.Location = new System.Drawing.Point(13, 196);
            this.groupBoxDataPasien.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDataPasien.Name = "groupBoxDataPasien";
            this.groupBoxDataPasien.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDataPasien.Size = new System.Drawing.Size(579, 252);
            this.groupBoxDataPasien.TabIndex = 20;
            this.groupBoxDataPasien.TabStop = false;
            // 
            // textBoxIDRuangan
            // 
            this.textBoxIDRuangan.Enabled = false;
            this.textBoxIDRuangan.Location = new System.Drawing.Point(193, 26);
            this.textBoxIDRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDRuangan.Name = "textBoxIDRuangan";
            this.textBoxIDRuangan.Size = new System.Drawing.Size(376, 22);
            this.textBoxIDRuangan.TabIndex = 2;
            // 
            // labelNamaRuanganPasien
            // 
            this.labelNamaRuanganPasien.AutoSize = true;
            this.labelNamaRuanganPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaRuanganPasien.Location = new System.Drawing.Point(27, 174);
            this.labelNamaRuanganPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaRuanganPasien.Name = "labelNamaRuanganPasien";
            this.labelNamaRuanganPasien.Size = new System.Drawing.Size(54, 19);
            this.labelNamaRuanganPasien.TabIndex = 2;
            this.labelNamaRuanganPasien.Text = "Pasien";
            // 
            // labelNamaRuanganDokter
            // 
            this.labelNamaRuanganDokter.AutoSize = true;
            this.labelNamaRuanganDokter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaRuanganDokter.Location = new System.Drawing.Point(27, 116);
            this.labelNamaRuanganDokter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaRuanganDokter.Name = "labelNamaRuanganDokter";
            this.labelNamaRuanganDokter.Size = new System.Drawing.Size(57, 19);
            this.labelNamaRuanganDokter.TabIndex = 1;
            this.labelNamaRuanganDokter.Text = "Dokter";
            // 
            // labelIDRuangan
            // 
            this.labelIDRuangan.AutoSize = true;
            this.labelIDRuangan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDRuangan.Location = new System.Drawing.Point(27, 26);
            this.labelIDRuangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDRuangan.Name = "labelIDRuangan";
            this.labelIDRuangan.Size = new System.Drawing.Size(87, 19);
            this.labelIDRuangan.TabIndex = 0;
            this.labelIDRuangan.Text = "ID Ruangan";
            // 
            // labelDataObat
            // 
            this.labelDataObat.AutoSize = true;
            this.labelDataObat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataObat.Location = new System.Drawing.Point(621, 39);
            this.labelDataObat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataObat.Name = "labelDataObat";
            this.labelDataObat.Size = new System.Drawing.Size(231, 31);
            this.labelDataObat.TabIndex = 19;
            this.labelDataObat.Text = "DATA RUANGAN";
            // 
            // comboBoxRuanganDokter
            // 
            this.comboBoxRuanganDokter.FormattingEnabled = true;
            this.comboBoxRuanganDokter.Location = new System.Drawing.Point(193, 115);
            this.comboBoxRuanganDokter.Name = "comboBoxRuanganDokter";
            this.comboBoxRuanganDokter.Size = new System.Drawing.Size(376, 24);
            this.comboBoxRuanganDokter.TabIndex = 3;
            // 
            // comboBoxRuanganPasien
            // 
            this.comboBoxRuanganPasien.FormattingEnabled = true;
            this.comboBoxRuanganPasien.Location = new System.Drawing.Point(193, 168);
            this.comboBoxRuanganPasien.Name = "comboBoxRuanganPasien";
            this.comboBoxRuanganPasien.Size = new System.Drawing.Size(376, 24);
            this.comboBoxRuanganPasien.TabIndex = 4;
            // 
            // textBoxNomorRuangan
            // 
            this.textBoxNomorRuangan.Location = new System.Drawing.Point(193, 72);
            this.textBoxNomorRuangan.Name = "textBoxNomorRuangan";
            this.textBoxNomorRuangan.Size = new System.Drawing.Size(376, 22);
            this.textBoxNomorRuangan.TabIndex = 5;
            // 
            // labelNomorRuangan
            // 
            this.labelNomorRuangan.AutoSize = true;
            this.labelNomorRuangan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorRuangan.Location = new System.Drawing.Point(27, 75);
            this.labelNomorRuangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomorRuangan.Name = "labelNomorRuangan";
            this.labelNomorRuangan.Size = new System.Drawing.Size(119, 19);
            this.labelNomorRuangan.TabIndex = 6;
            this.labelNomorRuangan.Text = "Nomor Ruangan";
            // 
            // Id_ruang
            // 
            this.Id_ruang.DataPropertyName = "Id_ruang";
            this.Id_ruang.HeaderText = "ID Ruangan";
            this.Id_ruang.MinimumWidth = 6;
            this.Id_ruang.Name = "Id_ruang";
            this.Id_ruang.Width = 125;
            // 
            // No_ruangan
            // 
            this.No_ruangan.DataPropertyName = "No_ruangan";
            this.No_ruangan.HeaderText = "Nomor Ruangan";
            this.No_ruangan.MinimumWidth = 6;
            this.No_ruangan.Name = "No_ruangan";
            this.No_ruangan.Width = 125;
            // 
            // Dokter
            // 
            this.Dokter.DataPropertyName = "Dokter";
            this.Dokter.HeaderText = "Dokter";
            this.Dokter.MinimumWidth = 6;
            this.Dokter.Name = "Dokter";
            this.Dokter.Width = 125;
            // 
            // Pasien
            // 
            this.Pasien.DataPropertyName = "Pasien";
            this.Pasien.HeaderText = "Pasien";
            this.Pasien.MinimumWidth = 6;
            this.Pasien.Name = "Pasien";
            this.Pasien.Width = 125;
            // 
            // FormRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 558);
            this.Controls.Add(this.buttonCariIDRuangan);
            this.Controls.Add(this.buttonHapusDataRuangan);
            this.Controls.Add(this.buttonUbahDataRuangan);
            this.Controls.Add(this.buttonSImpanDataRuangan);
            this.Controls.Add(this.textBoxCariIDRuangan);
            this.Controls.Add(this.labelCariIDRuangan);
            this.Controls.Add(this.dataGridViewRuangan);
            this.Controls.Add(this.groupBoxDataPasien);
            this.Controls.Add(this.labelDataObat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRuangan";
            this.Text = "Ruangan";
            this.Load += new System.EventHandler(this.FormRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuangan)).EndInit();
            this.groupBoxDataPasien.ResumeLayout(false);
            this.groupBoxDataPasien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCariIDRuangan;
        private System.Windows.Forms.Button buttonHapusDataRuangan;
        private System.Windows.Forms.Button buttonUbahDataRuangan;
        private System.Windows.Forms.Button buttonSImpanDataRuangan;
        private System.Windows.Forms.TextBox textBoxCariIDRuangan;
        private System.Windows.Forms.Label labelCariIDRuangan;
        private System.Windows.Forms.DataGridView dataGridViewRuangan;
        private System.Windows.Forms.GroupBox groupBoxDataPasien;
        private System.Windows.Forms.TextBox textBoxIDRuangan;
        private System.Windows.Forms.Label labelNamaRuanganPasien;
        private System.Windows.Forms.Label labelNamaRuanganDokter;
        private System.Windows.Forms.Label labelIDRuangan;
        private System.Windows.Forms.Label labelDataObat;
        private System.Windows.Forms.ComboBox comboBoxRuanganPasien;
        private System.Windows.Forms.ComboBox comboBoxRuanganDokter;
        private System.Windows.Forms.Label labelNomorRuangan;
        private System.Windows.Forms.TextBox textBoxNomorRuangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ruang;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_ruangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasien;
    }
}