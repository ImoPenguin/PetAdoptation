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

        private async void createAccount_Btn_Click(object sender, EventArgs e)
        {
            //  CHECK if Policy Checkbox is CHECKED
            if (!PolicyCheckBox.Checked)
            {
                PolicyCheckBox.ForeColor = Color.Red;
                return;
            }

            //  CHECK if any of the fields are empty and show warnings accordingly
            txtName_Warn.Visible = string.IsNullOrWhiteSpace(txtUserName.Text);
            txtEmail_Warn.Visible = string.IsNullOrWhiteSpace(txtUserEmail.Text);
            txtPwd_Warn.Visible = string.IsNullOrWhiteSpace(txtUserPwd.Text);

            //  If any field is empty, EXIT the method
            if (txtName_Warn.Visible || txtEmail_Warn.Visible || txtPwd_Warn.Visible)
            {
                txtEmail_Warn.Text = "!";
                return;
            }

            MailCheckResponse mailCheckResponse = await Mail_Handler.Mail_Check(txtUserEmail.Text);

            if (mailCheckResponse != null)
            {
                if (mailCheckResponse.FormatValid && mailCheckResponse.MxFound)
                {
                    // Both checks passed, proceed with registration
                    txtEmail_Warn.Visible = false;

                    List<Customer> cusList = XML_Handler.readCustomerData();
                    List<Staff> staffList = XML_Handler.readStaffData();
                    List<Manager> mngrList = XML_Handler.readManagerData();
                    int cusOrder = 1001 + cusList.Count + staffList.Count + mngrList.Count;

                    string newCus_ID = "U" + cusOrder.ToString();

                    Customer newCus = new Customer(newCus_ID, txtUserPwd.Text, txtUserName.Text, "", txtUserEmail.Text, "", "");
                    XML_Handler.addCustomerData(newCus);
                }
                else
                {
                    // Either format_valid or mx_found check failed
                    txtEmail_Warn.Text = "Invalid email format";
                    txtEmail_Warn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    txtEmail_Warn.Visible = true;
                }
            }
            else
            {
                // API call failed or some other error
                txtEmail_Warn.Text = "Error checking the email. Please try again.";
                txtEmail_Warn.Visible = true;
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