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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            LoginAccount.currentCustomer = XML_Handler.findCustomerAccount(txtUserID.Text, txtPwd.Text);
            LoginAccount.currentStaff = XML_Handler.findStaffAccount(txtUserID.Text, txtPwd.Text);
            LoginAccount.currentManager = XML_Handler.findManagerAccount(txtUserID.Text, txtPwd.Text);

            if (LoginAccount.currentCustomer != null)
            {
                frmMainScreen mainScreen = new frmMainScreen();
                mainScreen.Show();
            }
            //  DISPLAY Staff Screen
            else if (LoginAccount.currentStaff != null)
            {

            }
            //  DISPLAY Staff Screen
            else if (LoginAccount.currentManager != null)
            {

            }
            //  DISPLAY Error Warning
            else
            {
                txtUserID.Text = "";
                txtPwd.Text = "";
                wrongLoginLbl.Visible = true;
                Console.WriteLine("Error !");
            }

        }

        private void lbUserID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbPwd_Click(object sender, EventArgs e)
        {

        }

        private void bRegistered_Click_1(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
            this.Hide();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            wrongLoginLbl.Visible = false;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            wrongLoginLbl.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
