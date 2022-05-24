using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSKESMAS
{
    public partial class FormPasien : Form
    {
        public FormPasien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataComboBoxDokterPerawat()
        {
            DataTable dt = new DataTable();
            DataDokter dataDokter = new DataDokter();
            dt = dataDokter.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                string Id_dokter = row["Id_dokter"].ToString();
                string Nama_dokter = row["Nama_dokter"].ToString();
                comboBoxDokterPerawat.Items.Add(Id_dokter + " - " + Nama_dokter);
            }
            //comboBoxDokterPerawat.SelectedIndex = 0;
        }

        private void LoadDataComboBoxObat()
        {
            DataTable dt = new DataTable();
            DataObat dataObat = new DataObat();
            dt = dataObat.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                string Id_obat = row["Id_obat"].ToString();
                string Nama_obat = row["Nama_obat"].ToString();
                comboBoxObat.Items.Add(Id_obat + " - " + Nama_obat);
            }
            //comboBoxObat.SelectedIndex = 0;
        }

        private void FormPasien_Load(object sender, EventArgs e)
        {
            LoadDataComboBoxDokterPerawat();
            LoadDataComboBoxObat();
            LoadDataPasien();
        }
        private void LoadDataPasien()
        {
            DataPasien dataPasien = new DataPasien();
            DataTable dt = new DataTable();
            dt = dataPasien.SelectAll();
            dataGridViewPasien.AutoGenerateColumns = false;
            dataGridViewPasien.DataSource = dt;
            dataGridViewPasien.Columns["Id_pasien"].Visible = false;
            dataGridViewPasien.RowHeadersVisible = false;
            dataGridViewPasien.RowTemplate.MinimumHeight = 60;
            dataGridViewPasien.Show();
        }

        private void dataGridViewPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataPasien dataPasien = new DataPasien();
            DataDokter dataDokter = new DataDokter();
            int selectedrowindex = dataGridViewPasien.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPasien.Rows[selectedrowindex];
            textBoxIDPasien.Text = Convert.ToString(selectedRow.Cells["Id_pasien"].Value);
            textBoxNamaPasien.Text = Convert.ToString(selectedRow.Cells["Nama_pasien"].Value);
            textBoxAlamatPasien.Text = Convert.ToString(selectedRow.Cells["Alamat_pasien"].Value);
            textBoxHPPasien.Text = Convert.ToString(selectedRow.Cells["Hp_pasien"].Value);
            dateTimePickerTanggalLahirPasien.Value = Convert.ToDateTime(selectedRow.Cells["Tgl_lahir_pasien"].Value);
            textBoxRiwayatPenyakit.Text = Convert.ToString(selectedRow.Cells["R_penyakit_sebelumnya"].Value);
            dataPasien.Jenis_kelamin_pasien = Convert.ToString(selectedRow.Cells["Jenis_kelamin_pasien"].Value);
            if (dataPasien.Jenis_kelamin_pasien == "Laki-laki")
            {
                radioButtonPasienLakiLaki.Checked = true;
            }
            else if (dataPasien.Jenis_kelamin_pasien == "Perempuan")
            {
                radioButtonPasienPerempuan.Checked = true;
            }
            comboBoxObat.Text = Convert.ToString(selectedRow.Cells["Obat"].Value);
            comboBoxDokterPerawat.Text = Convert.ToString(selectedRow.Cells["Dr_perawat"].Value);
        }

        private void buttonSImpanDataPasien_Click(object sender, EventArgs e)
        {
            DataPasien dataPasien = new DataPasien();
            dataPasien.Nama_pasien = textBoxNamaPasien.Text;
            dataPasien.Alamat_pasien = textBoxAlamatPasien.Text;
            dataPasien.Hp_pasien = textBoxHPPasien.Text;
            dataPasien.Tgl_lahir_pasien = dateTimePickerTanggalLahirPasien.Value.ToString("yyyyMMdd");
            dataPasien.Obat = comboBoxObat.Text;
            if (radioButtonPasienLakiLaki.Checked)
            {
                dataPasien.Jenis_kelamin_pasien = radioButtonPasienLakiLaki.Text;
            }
            else if (radioButtonPasienPerempuan.Checked)
            {
                dataPasien.Jenis_kelamin_pasien = radioButtonPasienPerempuan.Text;
            }

            dataPasien.Dr_perawat = comboBoxDokterPerawat.Text;
            dataPasien.R_penyakit_sebelumnya = textBoxRiwayatPenyakit.Text;
            String response = dataPasien.insert();
            if (response == null)
            {


                MessageBox.Show("Tambah Data Pasien berhasil");
                LoadDataPasien();
            }
            else
            {
                MessageBox.Show("Tambah Data Pasien gagal. Error: " + response);
            }
        }

        private void buttonUbahDataPasien_Click(object sender, EventArgs e)
        {
            DataPasien dataPasien = new DataPasien();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataPasien.Nama_pasien = textBoxNamaPasien.Text;
            DialogResult result = MessageBox.Show("Ubah Data Pasien " + dataPasien.Nama_pasien + " ?", "Ubah Data Pasien", buttons);
            if (result == DialogResult.Yes)
            {
                dataPasien.Id_pasien = Convert.ToInt32(textBoxIDPasien.Text);
                dataPasien.Nama_pasien = textBoxNamaPasien.Text;
                dataPasien.Alamat_pasien = textBoxAlamatPasien.Text;
                dataPasien.Hp_pasien = textBoxHPPasien.Text;
                dataPasien.Tgl_lahir_pasien = dateTimePickerTanggalLahirPasien.Value.ToString("yyyyMMdd");
                dataPasien.Obat = comboBoxObat.Text;
                if (radioButtonPasienLakiLaki.Checked)
                {
                    dataPasien.Jenis_kelamin_pasien = radioButtonPasienLakiLaki.Text;
                }
                else if (radioButtonPasienPerempuan.Checked)
                {
                    dataPasien.Jenis_kelamin_pasien = radioButtonPasienPerempuan.Text;
                }

                dataPasien.Dr_perawat = comboBoxDokterPerawat.Text;
                dataPasien.R_penyakit_sebelumnya = textBoxRiwayatPenyakit.Text;
                String response = dataPasien.update();
                if (response == null)
                {


                    MessageBox.Show("Tambah Data Pasien berhasil");
                    LoadDataPasien();
                }
                else
                {
                    MessageBox.Show("Tambah Data Pasien gagal. Error: " + response);
                }
            } else
            {

            }
        }

        private void buttonCariIDPasien_Click(object sender, EventArgs e)
        {
            DataPasien dataPasien = new DataPasien();
            DataTable dt = new DataTable();
            dt = dataPasien.select(textBoxCariIDPasien.Text);
            dataGridViewPasien.AutoGenerateColumns = false;
            dataGridViewPasien.DataSource = dt;
            dataGridViewPasien.Columns["Id_pasien"].Visible = false;
            dataGridViewPasien.RowHeadersVisible = false;
            dataGridViewPasien.RowTemplate.MinimumHeight = 60;
            dataGridViewPasien.Show();
        }

        private void buttonHapusDataPasien_Click(object sender, EventArgs e)
        {
            DataPasien dataPasien = new DataPasien();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataPasien.Nama_pasien = textBoxNamaPasien.Text;
            DialogResult result = MessageBox.Show("Yakin menghapus data Pasien " + dataPasien.Nama_pasien + " ?", "Hapus Data Pasien", buttons);
            if (result == DialogResult.Yes)
            {
                string response;
                dataPasien.Id_pasien = Convert.ToInt32(textBoxIDPasien.Text);
                response = dataPasien.delete();
                if (response == null) MessageBox.Show("Sukses Hapus Data Pasien" + dataPasien.Nama_pasien);
                else MessageBox.Show(response);
                LoadDataPasien();
            }
            else
            {

            }
        }
    }
}
