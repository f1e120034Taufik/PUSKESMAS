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
    public partial class FormObat : Form
    {
        public FormObat()
        {
            InitializeComponent();
        }

        private void dataGridViewObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataObat dataObat = new DataObat();
            int selectedrowindex = dataGridViewObat.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewObat.Rows[selectedrowindex];
            textBoxIDObat.Text = Convert.ToString(selectedRow.Cells["Id_obat"].Value);
            textBoxNamaObat.Text = Convert.ToString(selectedRow.Cells["Nama_obat"].Value);
            textBoxJenisObat.Text = Convert.ToString(selectedRow.Cells["Jenis_obat"].Value);
            textBoxKandunganObat.Text = Convert.ToString(selectedRow.Cells["Kandungan"].Value);
            textBoxKuantitas.Text = Convert.ToString(selectedRow.Cells["Kuantitas"].Value);
        }

        private void FormObat_Load(object sender, EventArgs e)
        {
            LoadDataObat();
        }
        private void LoadDataObat()
        {
            DataObat dataObat = new DataObat();
            DataTable dt = new DataTable();
            dt = dataObat.SelectAll();
            dataGridViewObat.AutoGenerateColumns = false;
            dataGridViewObat.DataSource = dt;
            dataGridViewObat.Columns["Id_obat"].Visible = false;
            dataGridViewObat.RowHeadersVisible = false;
            dataGridViewObat.RowTemplate.MinimumHeight = 60;
            dataGridViewObat.Show();
        }

        private void buttonCariIDObat_Click(object sender, EventArgs e)
        {
            DataObat dataObat = new DataObat();
            DataTable dt = new DataTable();
            dt = dataObat.select(textBoxCariIDObat.Text);
            dataGridViewObat.AutoGenerateColumns = false;
            dataGridViewObat.DataSource = dt;
            dataGridViewObat.Columns["Id_obat"].Visible = false;
            dataGridViewObat.RowHeadersVisible = false;
            dataGridViewObat.RowTemplate.MinimumHeight = 60;
            dataGridViewObat.Show();
        }

        private void buttonSImpanDataObat_Click(object sender, EventArgs e)
        {
            DataObat dataObat = new DataObat();
            dataObat.Nama_obat = textBoxNamaObat.Text;
            dataObat.Jenis_obat = textBoxJenisObat.Text;
            dataObat.Kandungan = textBoxKandunganObat.Text;
            dataObat.Kuantitas = textBoxKuantitas.Text;
            String response = dataObat.insert();
            if (response == null)
            {
                MessageBox.Show("Tambah Data Obat berhasil");
                LoadDataObat();
            }
            else
            {
                MessageBox.Show("Tambah Data Obat gagal. Error: " + response);
            }
        }

        private void buttonUbahDataObat_Click(object sender, EventArgs e)
        {
            DataObat dataObat = new DataObat();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataObat.Nama_obat = textBoxNamaObat.Text;
            DialogResult result = MessageBox.Show("Ubah Data Obat " + dataObat.Nama_obat + " ?", "Ubah Data Obat", buttons);
            if (result == DialogResult.Yes)
            {
                dataObat.Id_obat = Convert.ToInt16(textBoxIDObat.Text);
                dataObat.Nama_obat = textBoxNamaObat.Text;
                dataObat.Jenis_obat = textBoxJenisObat.Text;
                dataObat.Kandungan = textBoxKandunganObat.Text;
                dataObat.Kuantitas = textBoxKuantitas.Text;
                String response = dataObat.update();
                if (response == null)
                {
                    MessageBox.Show("Ubah Data Obat berhasil");
                    LoadDataObat();
                }
                else
                {
                    MessageBox.Show("Ubah Data Obat gagal. Error: " + response);
                }
            } else
            {

            }
        }

        private void buttonHapusDataObat_Click(object sender, EventArgs e)
        {
            DataObat dataObat = new DataObat();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            dataObat.Nama_obat = textBoxNamaObat.Text;
            DialogResult result = MessageBox.Show("Yakin Menhapus Data Obat " + dataObat.Nama_obat + " ?", "Habus Data Obat", buttons);
            if (result == DialogResult.Yes)
            {
                string response;
                dataObat.Id_obat = Convert.ToInt32(textBoxIDObat.Text);
                response = dataObat.delete();
                if (response == null) MessageBox.Show("Sukses");
                else MessageBox.Show(response);
                LoadDataObat();
            }
            else
            {

            }


        }
    }
}
