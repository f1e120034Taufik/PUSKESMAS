namespace PUSKESMAS
{
    partial class FormPasien
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
            this.labelDataPasien = new System.Windows.Forms.Label();
            this.groupBoxDataPasien = new System.Windows.Forms.GroupBox();
            this.groupBoxJenisKelamin = new System.Windows.Forms.GroupBox();
            this.radioButtonPasienPerempuan = new System.Windows.Forms.RadioButton();
            this.radioButtonPasienLakiLaki = new System.Windows.Forms.RadioButton();
            this.comboBoxDokterPerawat = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTanggalLahirPasien = new System.Windows.Forms.DateTimePicker();
            this.labelJenisKelaminPasien = new System.Windows.Forms.Label();
            this.textBoxAlamatPasien = new System.Windows.Forms.TextBox();
            this.textBoxNamaPasien = new System.Windows.Forms.TextBox();
            this.textBoxHPPasien = new System.Windows.Forms.TextBox();
            this.textBoxRiwayatPenyakit = new System.Windows.Forms.TextBox();
            this.textBoxIDPasien = new System.Windows.Forms.TextBox();
            this.labelObat = new System.Windows.Forms.Label();
            this.labelDokter = new System.Windows.Forms.Label();
            this.labelHPPasien = new System.Windows.Forms.Label();
            this.labelTanggalLahirPasien = new System.Windows.Forms.Label();
            this.labelRiwayatPenyakit = new System.Windows.Forms.Label();
            this.labelAlamatPasien = new System.Windows.Forms.Label();
            this.labelNamaPasien = new System.Windows.Forms.Label();
            this.labelIDPasien = new System.Windows.Forms.Label();
            this.dataGridViewPasien = new System.Windows.Forms.DataGridView();
            this.Id_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hp_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tgl_lahir_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_kelamin_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_penyakit_sebelumnya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dr_perawat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCariIDPasien = new System.Windows.Forms.Label();
            this.textBoxCariIDPasien = new System.Windows.Forms.TextBox();
            this.buttonSImpanDataPasien = new System.Windows.Forms.Button();
            this.buttonUbahDataPasien = new System.Windows.Forms.Button();
            this.buttonCariIDPasien = new System.Windows.Forms.Button();
            this.buttonHapusDataPasien = new System.Windows.Forms.Button();
            this.comboBoxObat = new System.Windows.Forms.ComboBox();
            this.groupBoxDataPasien.SuspendLayout();
            this.groupBoxJenisKelamin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasien)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataPasien
            // 
            this.labelDataPasien.AutoSize = true;
            this.labelDataPasien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataPasien.Location = new System.Drawing.Point(623, 39);
            this.labelDataPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataPasien.Name = "labelDataPasien";
            this.labelDataPasien.Size = new System.Drawing.Size(189, 31);
            this.labelDataPasien.TabIndex = 0;
            this.labelDataPasien.Text = "DATA PASIEN";
            // 
            // groupBoxDataPasien
            // 
            this.groupBoxDataPasien.Controls.Add(this.comboBoxObat);
            this.groupBoxDataPasien.Controls.Add(this.groupBoxJenisKelamin);
            this.groupBoxDataPasien.Controls.Add(this.comboBoxDokterPerawat);
            this.groupBoxDataPasien.Controls.Add(this.dateTimePickerTanggalLahirPasien);
            this.groupBoxDataPasien.Controls.Add(this.labelJenisKelaminPasien);
            this.groupBoxDataPasien.Controls.Add(this.textBoxAlamatPasien);
            this.groupBoxDataPasien.Controls.Add(this.textBoxNamaPasien);
            this.groupBoxDataPasien.Controls.Add(this.textBoxHPPasien);
            this.groupBoxDataPasien.Controls.Add(this.textBoxRiwayatPenyakit);
            this.groupBoxDataPasien.Controls.Add(this.textBoxIDPasien);
            this.groupBoxDataPasien.Controls.Add(this.labelObat);
            this.groupBoxDataPasien.Controls.Add(this.labelDokter);
            this.groupBoxDataPasien.Controls.Add(this.labelHPPasien);
            this.groupBoxDataPasien.Controls.Add(this.labelTanggalLahirPasien);
            this.groupBoxDataPasien.Controls.Add(this.labelRiwayatPenyakit);
            this.groupBoxDataPasien.Controls.Add(this.labelAlamatPasien);
            this.groupBoxDataPasien.Controls.Add(this.labelNamaPasien);
            this.groupBoxDataPasien.Controls.Add(this.labelIDPasien);
            this.groupBoxDataPasien.Location = new System.Drawing.Point(9, 6);
            this.groupBoxDataPasien.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDataPasien.Name = "groupBoxDataPasien";
            this.groupBoxDataPasien.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDataPasien.Size = new System.Drawing.Size(579, 545);
            this.groupBoxDataPasien.TabIndex = 1;
            this.groupBoxDataPasien.TabStop = false;
            // 
            // groupBoxJenisKelamin
            // 
            this.groupBoxJenisKelamin.Controls.Add(this.radioButtonPasienPerempuan);
            this.groupBoxJenisKelamin.Controls.Add(this.radioButtonPasienLakiLaki);
            this.groupBoxJenisKelamin.Location = new System.Drawing.Point(197, 168);
            this.groupBoxJenisKelamin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxJenisKelamin.Name = "groupBoxJenisKelamin";
            this.groupBoxJenisKelamin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxJenisKelamin.Size = new System.Drawing.Size(377, 57);
            this.groupBoxJenisKelamin.TabIndex = 19;
            this.groupBoxJenisKelamin.TabStop = false;
            // 
            // radioButtonPasienPerempuan
            // 
            this.radioButtonPasienPerempuan.AutoSize = true;
            this.radioButtonPasienPerempuan.Location = new System.Drawing.Point(115, 23);
            this.radioButtonPasienPerempuan.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPasienPerempuan.Name = "radioButtonPasienPerempuan";
            this.radioButtonPasienPerempuan.Size = new System.Drawing.Size(98, 20);
            this.radioButtonPasienPerempuan.TabIndex = 1;
            this.radioButtonPasienPerempuan.Text = "Perempuan";
            this.radioButtonPasienPerempuan.UseVisualStyleBackColor = true;
            // 
            // radioButtonPasienLakiLaki
            // 
            this.radioButtonPasienLakiLaki.AutoSize = true;
            this.radioButtonPasienLakiLaki.Location = new System.Drawing.Point(0, 23);
            this.radioButtonPasienLakiLaki.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPasienLakiLaki.Name = "radioButtonPasienLakiLaki";
            this.radioButtonPasienLakiLaki.Size = new System.Drawing.Size(78, 20);
            this.radioButtonPasienLakiLaki.TabIndex = 0;
            this.radioButtonPasienLakiLaki.Text = "Laki-laki";
            this.radioButtonPasienLakiLaki.UseVisualStyleBackColor = true;
            // 
            // comboBoxDokterPerawat
            // 
            this.comboBoxDokterPerawat.DisplayMember = "Nama_dokter";
            this.comboBoxDokterPerawat.FormattingEnabled = true;
            this.comboBoxDokterPerawat.Location = new System.Drawing.Point(193, 419);
            this.comboBoxDokterPerawat.Name = "comboBoxDokterPerawat";
            this.comboBoxDokterPerawat.Size = new System.Drawing.Size(376, 24);
            this.comboBoxDokterPerawat.TabIndex = 17;
            this.comboBoxDokterPerawat.ValueMember = "Nama_dokter";
            // 
            // dateTimePickerTanggalLahirPasien
            // 
            this.dateTimePickerTanggalLahirPasien.Location = new System.Drawing.Point(193, 293);
            this.dateTimePickerTanggalLahirPasien.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTanggalLahirPasien.Name = "dateTimePickerTanggalLahirPasien";
            this.dateTimePickerTanggalLahirPasien.Size = new System.Drawing.Size(376, 22);
            this.dateTimePickerTanggalLahirPasien.TabIndex = 16;
            this.dateTimePickerTanggalLahirPasien.Value = new System.DateTime(2022, 4, 19, 0, 0, 0, 0);
            // 
            // labelJenisKelaminPasien
            // 
            this.labelJenisKelaminPasien.AutoSize = true;
            this.labelJenisKelaminPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJenisKelaminPasien.Location = new System.Drawing.Point(27, 192);
            this.labelJenisKelaminPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJenisKelaminPasien.Name = "labelJenisKelaminPasien";
            this.labelJenisKelaminPasien.Size = new System.Drawing.Size(106, 19);
            this.labelJenisKelaminPasien.TabIndex = 18;
            this.labelJenisKelaminPasien.Text = "Jenis Kelamin";
            // 
            // textBoxAlamatPasien
            // 
            this.textBoxAlamatPasien.Location = new System.Drawing.Point(193, 140);
            this.textBoxAlamatPasien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlamatPasien.Name = "textBoxAlamatPasien";
            this.textBoxAlamatPasien.Size = new System.Drawing.Size(376, 22);
            this.textBoxAlamatPasien.TabIndex = 15;
            // 
            // textBoxNamaPasien
            // 
            this.textBoxNamaPasien.Location = new System.Drawing.Point(193, 84);
            this.textBoxNamaPasien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaPasien.Name = "textBoxNamaPasien";
            this.textBoxNamaPasien.Size = new System.Drawing.Size(376, 22);
            this.textBoxNamaPasien.TabIndex = 14;
            // 
            // textBoxHPPasien
            // 
            this.textBoxHPPasien.Location = new System.Drawing.Point(193, 240);
            this.textBoxHPPasien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHPPasien.Name = "textBoxHPPasien";
            this.textBoxHPPasien.Size = new System.Drawing.Size(376, 22);
            this.textBoxHPPasien.TabIndex = 13;
            // 
            // textBoxRiwayatPenyakit
            // 
            this.textBoxRiwayatPenyakit.Location = new System.Drawing.Point(193, 336);
            this.textBoxRiwayatPenyakit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRiwayatPenyakit.Multiline = true;
            this.textBoxRiwayatPenyakit.Name = "textBoxRiwayatPenyakit";
            this.textBoxRiwayatPenyakit.Size = new System.Drawing.Size(376, 70);
            this.textBoxRiwayatPenyakit.TabIndex = 12;
            // 
            // textBoxIDPasien
            // 
            this.textBoxIDPasien.Enabled = false;
            this.textBoxIDPasien.Location = new System.Drawing.Point(193, 30);
            this.textBoxIDPasien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDPasien.Name = "textBoxIDPasien";
            this.textBoxIDPasien.Size = new System.Drawing.Size(82, 22);
            this.textBoxIDPasien.TabIndex = 2;
            // 
            // labelObat
            // 
            this.labelObat.AutoSize = true;
            this.labelObat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObat.Location = new System.Drawing.Point(27, 470);
            this.labelObat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObat.Name = "labelObat";
            this.labelObat.Size = new System.Drawing.Size(41, 19);
            this.labelObat.TabIndex = 8;
            this.labelObat.Text = "Obat";
            this.labelObat.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelDokter
            // 
            this.labelDokter.AutoSize = true;
            this.labelDokter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDokter.Location = new System.Drawing.Point(23, 419);
            this.labelDokter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDokter.Name = "labelDokter";
            this.labelDokter.Size = new System.Drawing.Size(116, 19);
            this.labelDokter.TabIndex = 7;
            this.labelDokter.Text = "Dokter/Perawat";
            // 
            // labelHPPasien
            // 
            this.labelHPPasien.AutoSize = true;
            this.labelHPPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPPasien.Location = new System.Drawing.Point(27, 240);
            this.labelHPPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHPPasien.Name = "labelHPPasien";
            this.labelHPPasien.Size = new System.Drawing.Size(79, 19);
            this.labelHPPasien.TabIndex = 5;
            this.labelHPPasien.Text = "HP Pasien";
            this.labelHPPasien.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelTanggalLahirPasien
            // 
            this.labelTanggalLahirPasien.AutoSize = true;
            this.labelTanggalLahirPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalLahirPasien.Location = new System.Drawing.Point(23, 293);
            this.labelTanggalLahirPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanggalLahirPasien.Name = "labelTanggalLahirPasien";
            this.labelTanggalLahirPasien.Size = new System.Drawing.Size(144, 19);
            this.labelTanggalLahirPasien.TabIndex = 4;
            this.labelTanggalLahirPasien.Text = "Tanggal lahir Pasien";
            // 
            // labelRiwayatPenyakit
            // 
            this.labelRiwayatPenyakit.AutoSize = true;
            this.labelRiwayatPenyakit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRiwayatPenyakit.Location = new System.Drawing.Point(23, 361);
            this.labelRiwayatPenyakit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRiwayatPenyakit.Name = "labelRiwayatPenyakit";
            this.labelRiwayatPenyakit.Size = new System.Drawing.Size(126, 19);
            this.labelRiwayatPenyakit.TabIndex = 3;
            this.labelRiwayatPenyakit.Text = "Riwayat Penyakit";
            // 
            // labelAlamatPasien
            // 
            this.labelAlamatPasien.AutoSize = true;
            this.labelAlamatPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamatPasien.Location = new System.Drawing.Point(27, 146);
            this.labelAlamatPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlamatPasien.Name = "labelAlamatPasien";
            this.labelAlamatPasien.Size = new System.Drawing.Size(106, 19);
            this.labelAlamatPasien.TabIndex = 2;
            this.labelAlamatPasien.Text = "Alamat Pasien";
            // 
            // labelNamaPasien
            // 
            this.labelNamaPasien.AutoSize = true;
            this.labelNamaPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPasien.Location = new System.Drawing.Point(27, 86);
            this.labelNamaPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaPasien.Name = "labelNamaPasien";
            this.labelNamaPasien.Size = new System.Drawing.Size(97, 19);
            this.labelNamaPasien.TabIndex = 1;
            this.labelNamaPasien.Text = "Nama Pasien";
            // 
            // labelIDPasien
            // 
            this.labelIDPasien.AutoSize = true;
            this.labelIDPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPasien.Location = new System.Drawing.Point(27, 33);
            this.labelIDPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDPasien.Name = "labelIDPasien";
            this.labelIDPasien.Size = new System.Drawing.Size(75, 19);
            this.labelIDPasien.TabIndex = 0;
            this.labelIDPasien.Text = "ID Pasien";
            this.labelIDPasien.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewPasien
            // 
            this.dataGridViewPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_pasien,
            this.Nama_pasien,
            this.Alamat_pasien,
            this.Hp_pasien,
            this.Tgl_lahir_pasien,
            this.Jenis_kelamin_pasien,
            this.R_penyakit_sebelumnya,
            this.Dr_perawat,
            this.Obat});
            this.dataGridViewPasien.Location = new System.Drawing.Point(629, 146);
            this.dataGridViewPasien.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPasien.Name = "dataGridViewPasien";
            this.dataGridViewPasien.RowHeadersWidth = 51;
            this.dataGridViewPasien.Size = new System.Drawing.Size(601, 310);
            this.dataGridViewPasien.TabIndex = 2;
            this.dataGridViewPasien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPasien_CellContentClick);
            // 
            // Id_pasien
            // 
            this.Id_pasien.DataPropertyName = "Id_pasien";
            this.Id_pasien.HeaderText = "ID Pasien";
            this.Id_pasien.MinimumWidth = 6;
            this.Id_pasien.Name = "Id_pasien";
            this.Id_pasien.Width = 125;
            // 
            // Nama_pasien
            // 
            this.Nama_pasien.DataPropertyName = "Nama_pasien";
            this.Nama_pasien.HeaderText = "Nama Pasien";
            this.Nama_pasien.MinimumWidth = 6;
            this.Nama_pasien.Name = "Nama_pasien";
            this.Nama_pasien.Width = 125;
            // 
            // Alamat_pasien
            // 
            this.Alamat_pasien.DataPropertyName = "Alamat_pasien";
            this.Alamat_pasien.HeaderText = "Alamat Pasien";
            this.Alamat_pasien.MinimumWidth = 6;
            this.Alamat_pasien.Name = "Alamat_pasien";
            this.Alamat_pasien.Width = 125;
            // 
            // Hp_pasien
            // 
            this.Hp_pasien.DataPropertyName = "Hp_pasien";
            this.Hp_pasien.HeaderText = "HP Pasien";
            this.Hp_pasien.MinimumWidth = 6;
            this.Hp_pasien.Name = "Hp_pasien";
            this.Hp_pasien.Width = 125;
            // 
            // Tgl_lahir_pasien
            // 
            this.Tgl_lahir_pasien.DataPropertyName = "Tgl_lahir_pasien";
            this.Tgl_lahir_pasien.HeaderText = "Tanggal Lahir Pasien";
            this.Tgl_lahir_pasien.MinimumWidth = 6;
            this.Tgl_lahir_pasien.Name = "Tgl_lahir_pasien";
            this.Tgl_lahir_pasien.Width = 125;
            // 
            // Jenis_kelamin_pasien
            // 
            this.Jenis_kelamin_pasien.DataPropertyName = "Jenis_kelamin_pasien";
            this.Jenis_kelamin_pasien.HeaderText = "Jenis Kelamin Pasien";
            this.Jenis_kelamin_pasien.MinimumWidth = 6;
            this.Jenis_kelamin_pasien.Name = "Jenis_kelamin_pasien";
            this.Jenis_kelamin_pasien.Width = 125;
            // 
            // R_penyakit_sebelumnya
            // 
            this.R_penyakit_sebelumnya.DataPropertyName = "R_penyakit_sebelumnya";
            this.R_penyakit_sebelumnya.HeaderText = "Riwayat Penyakit Sebelumnya";
            this.R_penyakit_sebelumnya.MinimumWidth = 6;
            this.R_penyakit_sebelumnya.Name = "R_penyakit_sebelumnya";
            this.R_penyakit_sebelumnya.Width = 125;
            // 
            // Dr_perawat
            // 
            this.Dr_perawat.DataPropertyName = "Dr_perawat";
            this.Dr_perawat.HeaderText = "Dokter/Perawat";
            this.Dr_perawat.MinimumWidth = 6;
            this.Dr_perawat.Name = "Dr_perawat";
            this.Dr_perawat.Width = 125;
            // 
            // Obat
            // 
            this.Obat.DataPropertyName = "Obat";
            this.Obat.HeaderText = "Obat";
            this.Obat.MinimumWidth = 6;
            this.Obat.Name = "Obat";
            this.Obat.Width = 125;
            // 
            // labelCariIDPasien
            // 
            this.labelCariIDPasien.AutoSize = true;
            this.labelCariIDPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariIDPasien.Location = new System.Drawing.Point(625, 92);
            this.labelCariIDPasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCariIDPasien.Name = "labelCariIDPasien";
            this.labelCariIDPasien.Size = new System.Drawing.Size(168, 19);
            this.labelCariIDPasien.TabIndex = 3;
            this.labelCariIDPasien.Text = "Cari Berdasarkan Nama";
            // 
            // textBoxCariIDPasien
            // 
            this.textBoxCariIDPasien.Location = new System.Drawing.Point(801, 92);
            this.textBoxCariIDPasien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCariIDPasien.Name = "textBoxCariIDPasien";
            this.textBoxCariIDPasien.Size = new System.Drawing.Size(225, 22);
            this.textBoxCariIDPasien.TabIndex = 4;
            // 
            // buttonSImpanDataPasien
            // 
            this.buttonSImpanDataPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSImpanDataPasien.Location = new System.Drawing.Point(758, 489);
            this.buttonSImpanDataPasien.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSImpanDataPasien.Name = "buttonSImpanDataPasien";
            this.buttonSImpanDataPasien.Size = new System.Drawing.Size(100, 28);
            this.buttonSImpanDataPasien.TabIndex = 5;
            this.buttonSImpanDataPasien.Text = "Simpan";
            this.buttonSImpanDataPasien.UseVisualStyleBackColor = true;
            this.buttonSImpanDataPasien.Click += new System.EventHandler(this.buttonSImpanDataPasien_Click);
            // 
            // buttonUbahDataPasien
            // 
            this.buttonUbahDataPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbahDataPasien.Location = new System.Drawing.Point(888, 489);
            this.buttonUbahDataPasien.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUbahDataPasien.Name = "buttonUbahDataPasien";
            this.buttonUbahDataPasien.Size = new System.Drawing.Size(100, 28);
            this.buttonUbahDataPasien.TabIndex = 6;
            this.buttonUbahDataPasien.Text = "Ubah";
            this.buttonUbahDataPasien.UseVisualStyleBackColor = true;
            this.buttonUbahDataPasien.Click += new System.EventHandler(this.buttonUbahDataPasien_Click);
            // 
            // buttonCariIDPasien
            // 
            this.buttonCariIDPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCariIDPasien.Location = new System.Drawing.Point(1034, 88);
            this.buttonCariIDPasien.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCariIDPasien.Name = "buttonCariIDPasien";
            this.buttonCariIDPasien.Size = new System.Drawing.Size(100, 28);
            this.buttonCariIDPasien.TabIndex = 9;
            this.buttonCariIDPasien.Text = "Cari";
            this.buttonCariIDPasien.UseVisualStyleBackColor = true;
            this.buttonCariIDPasien.Click += new System.EventHandler(this.buttonCariIDPasien_Click);
            // 
            // buttonHapusDataPasien
            // 
            this.buttonHapusDataPasien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusDataPasien.Location = new System.Drawing.Point(1012, 489);
            this.buttonHapusDataPasien.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHapusDataPasien.Name = "buttonHapusDataPasien";
            this.buttonHapusDataPasien.Size = new System.Drawing.Size(100, 28);
            this.buttonHapusDataPasien.TabIndex = 7;
            this.buttonHapusDataPasien.Text = "Hapus";
            this.buttonHapusDataPasien.UseVisualStyleBackColor = true;
            this.buttonHapusDataPasien.Click += new System.EventHandler(this.buttonHapusDataPasien_Click);
            // 
            // comboBoxObat
            // 
            this.comboBoxObat.FormattingEnabled = true;
            this.comboBoxObat.Location = new System.Drawing.Point(193, 464);
            this.comboBoxObat.Name = "comboBoxObat";
            this.comboBoxObat.Size = new System.Drawing.Size(376, 24);
            this.comboBoxObat.TabIndex = 20;
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 558);
            this.Controls.Add(this.buttonCariIDPasien);
            this.Controls.Add(this.buttonHapusDataPasien);
            this.Controls.Add(this.buttonUbahDataPasien);
            this.Controls.Add(this.buttonSImpanDataPasien);
            this.Controls.Add(this.textBoxCariIDPasien);
            this.Controls.Add(this.labelCariIDPasien);
            this.Controls.Add(this.dataGridViewPasien);
            this.Controls.Add(this.groupBoxDataPasien);
            this.Controls.Add(this.labelDataPasien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPasien";
            this.Text = "Pasien";
            this.Load += new System.EventHandler(this.FormPasien_Load);
            this.groupBoxDataPasien.ResumeLayout(false);
            this.groupBoxDataPasien.PerformLayout();
            this.groupBoxJenisKelamin.ResumeLayout(false);
            this.groupBoxJenisKelamin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataPasien;
        private System.Windows.Forms.GroupBox groupBoxDataPasien;
        private System.Windows.Forms.Label labelHPPasien;
        private System.Windows.Forms.Label labelTanggalLahirPasien;
        private System.Windows.Forms.Label labelRiwayatPenyakit;
        private System.Windows.Forms.Label labelAlamatPasien;
        private System.Windows.Forms.Label labelNamaPasien;
        private System.Windows.Forms.Label labelIDPasien;
        private System.Windows.Forms.Label labelObat;
        private System.Windows.Forms.Label labelDokter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalLahirPasien;
        private System.Windows.Forms.TextBox textBoxAlamatPasien;
        private System.Windows.Forms.TextBox textBoxNamaPasien;
        private System.Windows.Forms.TextBox textBoxHPPasien;
        private System.Windows.Forms.TextBox textBoxRiwayatPenyakit;
        private System.Windows.Forms.TextBox textBoxIDPasien;
        private System.Windows.Forms.Label labelCariIDPasien;
        private System.Windows.Forms.TextBox textBoxCariIDPasien;
        private System.Windows.Forms.Button buttonSImpanDataPasien;
        private System.Windows.Forms.Button buttonUbahDataPasien;
        private System.Windows.Forms.Button buttonCariIDPasien;
        private System.Windows.Forms.Button buttonHapusDataPasien;
        private System.Windows.Forms.ComboBox comboBoxDokterPerawat;
        private System.Windows.Forms.GroupBox groupBoxJenisKelamin;
        private System.Windows.Forms.RadioButton radioButtonPasienPerempuan;
        private System.Windows.Forms.RadioButton radioButtonPasienLakiLaki;
        private System.Windows.Forms.Label labelJenisKelaminPasien;
        private System.Windows.Forms.DataGridView dataGridViewPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hp_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tgl_lahir_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_kelamin_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_penyakit_sebelumnya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dr_perawat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obat;
        private System.Windows.Forms.ComboBox comboBoxObat;
    }
}