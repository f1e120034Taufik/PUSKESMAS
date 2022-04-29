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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void pictureBoxDokter_Click(object sender, EventArgs e)
        {
            FormDokter frmDokter = new FormDokter();
            frmDokter.TopLevel = false;
            frmDokter.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmDokter);
            frmDokter.Show();
        }

        private void pictureBoxPasien_Click(object sender, EventArgs e)
        {
            FormPasien frmPasien = new FormPasien();
            frmPasien.TopLevel = false;
            frmPasien.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmPasien);
            frmPasien.Show();
        }

        private void pictureBoxTutup_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Yakin Ingin Keluar?", "Application Form" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBoxObat_Click(object sender, EventArgs e)
        {
            FormObat frmObat = new FormObat();
            frmObat.TopLevel = false;
            frmObat.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmObat);
            frmObat.Show();
        }

        private void pictureBoxRuangan_Click(object sender, EventArgs e)
        {
            FormRuangan frmRuangan = new FormRuangan();
            frmRuangan.TopLevel = false;
            frmRuangan.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmRuangan);
            frmRuangan.Show();
        }
    }
}
