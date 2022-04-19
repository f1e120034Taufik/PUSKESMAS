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
            
        }

        private void pictureBoxPasien_Click(object sender, EventArgs e)
        {
            formPasien frmPasien = new formPasien();
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
    }
}
