using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSKESMAS
{
    public partial class FormRuangan : Form
    {
        public FormRuangan()
        {
            InitializeComponent();
        }

        private void dataGridViewRuangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRuang dataRuang = new DataRuang();
            int selectedrowindex = dataGridViewRuangan.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewRuangan.Rows[selectedrowindex];
            textBoxIDRuangan.Text = Convert.ToString(selectedRow.Cells["Id_ruang"].Value);
            textBoxNomorRuangan.Text = Convert.ToString(selectedRow.Cells["No_ruangan"].Value);
            comboBoxRuanganDokter.Text = Convert.ToString(selectedRow.Cells["Dokter"].Value);
            comboBoxRuanganPasien.Text = Convert.ToString(selectedRow.Cells["Pasien"].Value);
        }

        private void FormRuangan_Load(object sender, EventArgs e)
        {
            LoadDataComboBoxDokter();
            LoadDataComboBoxPasien();
            LoadDataRuang();

        }
        private void LoadDataComboBoxDokter()
        {
            DataTable dt = new DataTable();
            DataDokter dataDokter = new DataDokter();
            dt = dataDokter.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                string Id_dokter = row["Id_dokter"].ToString();
                string Nama_dokter = row["Nama_dokter"].ToString();
                comboBoxRuanganDokter.Items.Add(Id_dokter + " - " + Nama_dokter);
            }
        }

        private void LoadDataComboBoxPasien()
        {
            DataTable dt = new DataTable();
            DataPasien dataPasien = new DataPasien();
            dt = dataPasien.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                string Id_pasien = row["Id_pasien"].ToString();
                string Nama_pasien = row["Nama_pasien"].ToString();
                comboBoxRuanganPasien.Items.Add(Id_pasien + " - " + Nama_pasien);
            }
        }
        private void LoadDataRuang()
        {
            DataRuang dataRuang = new DataRuang();
            DataTable dt = new DataTable();
            dt = dataRuang.SelectAll();
            dataGridViewRuangan.AutoGenerateColumns = false;
            dataGridViewRuangan.DataSource = dt;
            dataGridViewRuangan.Columns["Id_ruang"].Visible = false;
            dataGridViewRuangan.RowHeadersVisible = false;
            dataGridViewRuangan.RowTemplate.MinimumHeight = 60;
            dataGridViewRuangan.Show();
        }

        private void buttonCariIDRuangan_Click(object sender, EventArgs e)
        {
            DataRuang dataRuang = new DataRuang();
            DataTable dt = new DataTable();
            dt = dataRuang.select(textBoxNomorRuangan.Text);
            dataGridViewRuangan.AutoGenerateColumns = false;
            dataGridViewRuangan.DataSource = dt;
            dataGridViewRuangan.Columns["Id_ruang"].Visible = false;
            dataGridViewRuangan.RowHeadersVisible = false;
            dataGridViewRuangan.RowTemplate.MinimumHeight = 60;
            dataGridViewRuangan.Show();
        }

        private void buttonSImpanDataRuangan_Click(object sender, EventArgs e)
        {
            DataRuang dataRuang = new DataRuang();
            dataRuang.No_ruangan = textBoxNomorRuangan.Text;
            dataRuang.Dokter = comboBoxRuanganDokter.Text;
            dataRuang.Pasien = comboBoxRuanganPasien.Text;
            String response = dataRuang.insert();
            if (response == null)
            {
                MessageBox.Show("Tambah Data Ruang berhasil");
                LoadDataRuang();
            }
            else
            {
                MessageBox.Show("Tambah Data Ruang gagal. Error: " + response);
            }
        }

        private void buttonUbahDataRuangan_Click(object sender, EventArgs e)
        {
            DataRuang dataRuang = new DataRuang();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataRuang.No_ruangan = textBoxNomorRuangan.Text;
            DialogResult result = MessageBox.Show("Ubah Data Ruangan " + dataRuang.No_ruangan + " ?", "Ubah Data Ruang", buttons);
            if (result == DialogResult.Yes)
            {
                dataRuang.Id_ruang = Convert.ToInt32(textBoxIDRuangan.Text);
                dataRuang.Dokter = comboBoxRuanganDokter.Text;
                dataRuang.Pasien = comboBoxRuanganPasien.Text;
                String response = dataRuang.update();
                if (response == null)
                {
                    MessageBox.Show("Ubah Data Ruang berhasil");
                    LoadDataRuang();
                }
                else
                {
                    MessageBox.Show("Ubah Data Ruang gagal. Error: " + response);
                }
            } else
            {

            }
        }

        private void buttonHapusDataRuangan_Click(object sender, EventArgs e)
        {
            DataRuang dataRuang = new DataRuang();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataRuang.No_ruangan = textBoxNomorRuangan.Text;
            DialogResult result = MessageBox.Show("Hapus Data Ruangan " + dataRuang.No_ruangan + " ?", "Hapus Data Ruang", buttons);
            if (result == DialogResult.Yes)
            {
                string response;
                dataRuang.Id_ruang = Convert.ToInt32(textBoxIDRuangan.Text);
                response = dataRuang.delete();
                if (response == null) MessageBox.Show("Sukses");
                else MessageBox.Show(response);
                LoadDataRuang();
            } else
            {

            }
        }
    }
}
