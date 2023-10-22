using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAdoptation
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PolicyCheckBox.Checked)
            {
                PolicyCheckBox.BackColor = Color.DarkSeaGreen;
                PolicyCheckBox.ForeColor = Color.White;
            }
            else
            {
                PolicyCheckBox.BackColor = Color.FloralWhite;
                PolicyCheckBox.ForeColor = Color.DarkGray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpwd4_Click(object sender, EventArgs e)
        {

        }

        private void createAccount_Btn_MouseHover(object sender, MouseEventArgs e)
        {
            createAccount_Btn.BackColor = Color.DarkSeaGreen;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
