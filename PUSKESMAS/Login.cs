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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = textBoxUsername.Text;
            user.password = textBoxPassword.Text;
            if (user.validasi())
            {
                MessageBox.Show("User Berhasil Login");
                formMenu frmMenu = new formMenu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User gagal login");
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.PasswordChar == '*')
            {
                buttonHidePassword.BringToFront();
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '\0')
            {
                buttonShowPassword.BringToFront();
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
 