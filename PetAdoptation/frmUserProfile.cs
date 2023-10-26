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
    public partial class frmUserProfile : Form
    {
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.FromArgb(81, 60, 41);
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.Honeydew;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (txtPhone.Enabled)
            {
                bEdit.Text = "EDIT";
                txtName.Enabled = false;
                txtPhone.Enabled = false;
                txtEmail.Enabled = false;
                txtAddress.Enabled = false;
                txtPwdUp.Enabled = false;
            }
            else
            {
                bEdit.Text = "SAVE";
                txtName.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                txtAddress.Enabled = true;
                txtPwdUp.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
