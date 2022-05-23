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
    public partial class FormDokter : Form
    {
        public FormDokter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataDokter dataDokter = new DataDokter();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataDokter.Nama_dokter = textBoxNamaDokter.Text;
            DialogResult result = MessageBox.Show("Ubah Data Dokter " + dataDokter.Nama_dokter + " ?", "Ubah Data Dokter", buttons);
            if (result == DialogResult.Yes)
            {
                dataDokter.Id_dokter = Convert.ToInt16(textBoxIDDokter.Text);
                dataDokter.Nama_dokter = textBoxNamaDokter.Text;
                dataDokter.Alamat_dokter = textBoxAlamatDokter.Text;
                dataDokter.Hp_dokter = textBoxHPDokter.Text;
                dataDokter.Tgl_lahir_dokter = dateTimePickerTanggalLahirDokter.Value.ToString("yyyyMMdd");
                dataDokter.Email_dokter = textBoxEmailDokter.Text;
                if (radioButtonLakiLaki.Checked)
                {
                    dataDokter.Jenis_kelamin_dokter = radioButtonLakiLaki.Text;
                }
                else if (radioButtonPerempuan.Checked)
                {
                    dataDokter.Jenis_kelamin_dokter = radioButtonPerempuan.Text;
                }
                dataDokter.Spesialis = textBoxSpesialis.Text;
                dataDokter.Jam_kerja = comboBoxJamKerja.Text;
                string response = dataDokter.update();
                if (response == null)
                {

                    MessageBox.Show("Update Data Dokter berhasil");
                    LoadDataDokter();
                }
                else
                {
                    MessageBox.Show("Update Data Dokter gagal. Error: " + response);
                }
            } else
            {

            }
           

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSimpanDataDokter_Click(object sender, EventArgs e)
        {
            DataDokter dataDokter = new DataDokter();
            dataDokter.Nama_dokter = textBoxNamaDokter.Text;
            dataDokter.Alamat_dokter = textBoxAlamatDokter.Text;
            dataDokter.Hp_dokter = textBoxHPDokter.Text;
            dataDokter.Tgl_lahir_dokter = dateTimePickerTanggalLahirDokter.Value.ToString("yyyyMMdd");
            dataDokter.Email_dokter = textBoxEmailDokter.Text;
            if (radioButtonLakiLaki.Checked)
            {
                dataDokter.Jenis_kelamin_dokter = radioButtonLakiLaki.Text;
            } else if (radioButtonPerempuan.Checked)
            {
                dataDokter.Jenis_kelamin_dokter = radioButtonPerempuan.Text;
            }
            dataDokter.Spesialis = textBoxSpesialis.Text;
            dataDokter.Jam_kerja = comboBoxJamKerja.Text;
            String response = dataDokter.insert();
            if (response == null)
            {


                MessageBox.Show("Tambah Data Dokter berhasil");
                LoadDataDokter();
            }
            else
            {
                MessageBox.Show("Tambah Data Dokter gagal. Error: " + response);
            }
        }
        private void LoadDataDokter()
        {
            DataDokter dataDokter = new DataDokter();
            DataTable dt = new DataTable();
            dt = dataDokter.SelectAll();
            dataGridViewDokter.AutoGenerateColumns = false;
            dataGridViewDokter.DataSource = dt;
            dataGridViewDokter.Columns["Id_dokter"].Visible = false;
            dataGridViewDokter.RowHeadersVisible = false;
            dataGridViewDokter.RowTemplate.MinimumHeight = 60;
            dataGridViewDokter.Show();
        }

        private void FormDokter_Load(object sender, EventArgs e)
        {
            LoadDataDokter();
        }

        private void buttonCariIDDokter_Click(object sender, EventArgs e)
        {
            DataDokter dataDokter = new DataDokter();
            DataTable dt = new DataTable();
            dt = dataDokter.select(textBoxCariIDDokter.Text);
            dataGridViewDokter.AutoGenerateColumns = false;
            dataGridViewDokter.DataSource = dt;
            dataGridViewDokter.Columns["Id_dokter"].Visible = false;
            dataGridViewDokter.RowHeadersVisible = false;
            dataGridViewDokter.RowTemplate.MinimumHeight = 60;
            dataGridViewDokter.Show();
        }

        private void dataGridViewDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataDokter dataDokter = new DataDokter();
            int selectedrowindex = dataGridViewDokter.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewDokter.Rows[selectedrowindex];
            /*dataDokter.Id_dokter = Convert.ToInt32(selectedRow.Cells["Id_dokter"].Value);
            dataDokter.Nama_dokter = Convert.ToString(selectedRow.Cells["Nama_dokter"].Value);
            dataDokter.Alamat_dokter = Convert.ToString(selectedRow.Cells["Alamat_dokter"].Value);
            dataDokter.Hp_dokter = Convert.ToString(selectedRow.Cells["Hp_Dokter"].Value);
            dataDokter.Tgl_lahir_dokter = Convert.ToString(selectedRow.Cells["Tgl_lahir_dokter"].Value);
            dataDokter.Email_dokter = Convert.ToString(selectedRow.Cells["Email_dokter"].Value);
            dataDokter.Jenis_kelamin_dokter = Convert.ToString(selectedRow.Cells["Jenis_kelamin_dokter"].Value);
            dataDokter.Spesialis = Convert.ToString(selectedRow.Cells["Spesialis"].Value);
            dataDokter.Jam_kerja = Convert.ToString(selectedRow.Cells["Jam_kerja"].Value); */
            textBoxIDDokter.Text = Convert.ToString(selectedRow.Cells["Id_dokter"].Value);
            textBoxNamaDokter.Text = Convert.ToString(selectedRow.Cells["Nama_dokter"].Value);
            textBoxAlamatDokter.Text = Convert.ToString(selectedRow.Cells["Alamat_dokter"].Value);
            textBoxHPDokter.Text = Convert.ToString(selectedRow.Cells["Hp_Dokter"].Value);
            dateTimePickerTanggalLahirDokter.Value = Convert.ToDateTime(selectedRow.Cells["Tgl_lahir_dokter"].Value);
            dataDokter.Jenis_kelamin_dokter = Convert.ToString(selectedRow.Cells["Jenis_kelamin_dokter"].Value);
            if (dataDokter.Jenis_kelamin_dokter == "Laki-laki")
            {
                radioButtonLakiLaki.Checked = true;
            } else if (dataDokter.Jenis_kelamin_dokter == "Perempuan")
            {
                radioButtonPerempuan.Checked = true;
            }
            textBoxEmailDokter.Text = Convert.ToString(selectedRow.Cells["Email_dokter"].Value);
            textBoxSpesialis.Text = Convert.ToString(selectedRow.Cells["Spesialis"].Value);
            comboBoxJamKerja.Text = Convert.ToString(selectedRow.Cells["Jam_kerja"].Value);
        }

        private void buttonHapusDataDokter_Click(object sender, EventArgs e)
        {
            DataDokter dataDokter = new DataDokter();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataDokter.Nama_dokter = textBoxNamaDokter.Text;
            DialogResult result = MessageBox.Show("Yakin menghapus data Dokter " + dataDokter.Nama_dokter + " ?", "Hapus Data Dokter", buttons);
            if (result == DialogResult.Yes)
            {
                string response;
                dataDokter.Id_dokter = Convert.ToInt32(textBoxIDDokter.Text);
                response = dataDokter.delete();
                if (response == null) MessageBox.Show("Sukses");
                else MessageBox.Show(response);
                LoadDataDokter();
            } else
            {

            }


        }

        private void radioButtonLakiLaki_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButtonLakiLaki.Checked)
            {
                value = radioButtonLakiLaki.Text;
            } else
            {
                value = radioButtonPerempuan.Text;
            }
        }

        private void radioButtonPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButtonPerempuan.Checked)
            {
                value = radioButtonPerempuan.Text;
            }
            else
            {
                value = radioButtonLakiLaki.Text;
            }
        }
    }
}
