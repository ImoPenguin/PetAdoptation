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
    public partial class frmReturnPets : Form
    {
        private Pet returnedPet = null;
        public frmReturnPets()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtReturnReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBreed_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            //  IF Pet found by ID
            if (returnedPet != null)
            {
                //  UPDATE Data of Pet then EDIT Data
                returnedPet.Desexed = desexed_checkBox.Checked;
                returnedPet.Microchip = microchipped_checkBox.Checked;
                returnedPet.Wormed = worming_checkBox.Checked;
                returnedPet.Vaccinated = vaccinated_checkBox.Checked;
                returnedPet.OwnerID = "";
                XML_Handler.editPetData(returnedPet);
            }

            //  CLOSE Form
            frmPetReturnConfirm petReturnConfirmScreen = new frmPetReturnConfirm();
            petReturnConfirmScreen.Show();
            this.Close();
        }

        //  SEARCH Button click event
        private void button1_Click(object sender, EventArgs e)
        {
            List<Pet> petList = XML_Handler.readPetData();
            returnedPet = null;

            foreach (Pet p in petList)
            {
                if ((p.OwnerID == LoginAccount.currentCustomer.ID) && (p.ID == txtPetId.Text))
                {
                    returnedPet = p;
                    break;
                }
            }

            //  IF Pet found by ID
            if (returnedPet != null)
            {
                //  LABEL Data Pulling
                notFound_Warn.Visible = false;
                age_Combobx.Text = returnedPet.Age;
                genderLabel.Text = returnedPet.Sex;
                txtLocation.Text = XML_Handler.findShelterByID(returnedPet.StoreID).Address;
                PetType_Label.Text = returnedPet.Type;
                txtPetName.Text = returnedPet.Name;
                txtBreed.Text = returnedPet.Breed;

                //  CHECKBOX Data Pulling
                desexed_checkBox.Checked = returnedPet.Desexed;
                microchipped_checkBox.Checked = returnedPet.Microchip;
                worming_checkBox.Checked = returnedPet.Wormed;
                vaccinated_checkBox.Checked = returnedPet.Vaccinated;

                //  UPDATE Data of Pet then EDIT Data
                returnedPet.Desexed = desexed_checkBox.Checked;
                returnedPet.Microchip = microchipped_checkBox.Checked;
                returnedPet.Wormed = worming_checkBox.Checked;
                returnedPet.Vaccinated = vaccinated_checkBox.Checked;
                returnedPet.OwnerID = "";
                XML_Handler.editPetData(returnedPet);

            }
            else
            {
                //  LABEL Data Pulling
                notFound_Warn.Visible = true;
                age_Combobx.Text = "Age";
                genderLabel.Text = "";
                txtLocation.Text = "";
                PetType_Label.Text = "";
                txtBreed.Text = "";

                //  CHECKBOX Data Pulling
                desexed_checkBox.Checked = false;
                microchipped_checkBox.Checked = false;
                worming_checkBox.Checked = false;
                vaccinated_checkBox.Checked = false;
            }
        }

        private void PetType_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
