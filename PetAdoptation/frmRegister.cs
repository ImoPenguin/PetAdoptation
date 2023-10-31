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
                PolicyCheckBox.BackColor = Color.Transparent;
                PolicyCheckBox.ForeColor = Color.Gray;
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccount_Btn_Click(object sender, EventArgs e)
        {
            bool validated = false;

            //  VALIDATE user input
            //  CHECK if All Textboxes are not empty
            if ((txtUserName.Text != "") && (txtUserEmail.Text != "") && (txtUserPwd.Text != ""))
            {
                txtName_Warn.Visible = false;
                txtEmail_Warn.Visible = false;
                txtPwd_Warn.Visible = false;

                Task<bool> mailValid = Mail_Handler.Mail_Check(txtUserEmail.Text);
                if (mailValid.Result)
                {
                    txtEmail_Warn.Visible = false;

                    List<Customer> cusList = XML_Handler.readCustomerData();
                    int cusOrder = 1001 + cusList.Count;

                    string newCus_ID = "U" + cusOrder.ToString();

                    Customer newCus = new Customer(newCus_ID, txtUserPwd.Text, txtUserName.Text, "", txtUserEmail.Text, "", "");

                    XML_Handler.addCustomerData(newCus);
                }
                else
                {
                    txtEmail_Warn.Visible = true;
                }
            }
            else
            {
                if(txtUserName.Text == "")
                {
                    txtName_Warn.Visible = true;
                }
                else
                {
                    txtName_Warn.Visible = false;
                }
                
                if(txtUserEmail.Text == "")
                {
                    txtEmail_Warn.Visible = true;
                }
                else
                {
                    txtEmail_Warn.Visible = false;
                }
                
                if(txtUserPwd.Text == "")
                {
                    txtPwd_Warn.Visible = true;
                }
                else
                {
                    txtPwd_Warn.Visible = false;
                }

            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void psw_pic_MouseDown(object sender, MouseEventArgs e)
        {
            txtUserPwd.UseSystemPasswordChar = false;
        }

        private void psw_pic_MouseUp(object sender, MouseEventArgs e)
        {
            txtUserPwd.UseSystemPasswordChar = true;
        }
    }
}
