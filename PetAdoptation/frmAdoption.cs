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

        private void frmAdoption_Load(object sender, EventArgs e)
        {
            if (Cart.chosenPet != null)
            {
                txtpetID.Text = Cart.chosenPet.ID;
                petType_label.Text = Cart.chosenPet.Type;
            }

            if (LoginAccount.currentCustomer != null)
            {
                txtFullName.Text = LoginAccount.currentCustomer.Name;
                txtEmail.Text = LoginAccount.currentCustomer.Email;
                txtPhoneNum.Text = LoginAccount.currentCustomer.PhoneNo;

                //  Separate Address data to string array
                /*
                 * [0]: Street addres
                 * [1]: City
                 * [2]: State
                 * [3]: Postcode
                 */
                string[] addressData = LoginAccount.currentCustomer.Address.Split(';');

                txtStreetAddress.Text = addressData[0];
                txtCity.Text = addressData[1];
                txtState.Text = addressData[2];
                txtPostalCode.Text = addressData[3];
            }
        }
    }
}