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
    public partial class frmAdoption : Form
    {
        public frmAdoption()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPetDetails petDetailsForm = new frmPetDetails();
            petDetailsForm.Show();
        }

        private void txtpetID_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            frmPetAdoptConfirmation petAdoptConfirmation_form = new frmPetAdoptConfirmation();
            petAdoptConfirmation_form.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
