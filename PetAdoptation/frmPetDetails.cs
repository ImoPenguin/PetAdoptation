using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAdoptation
{
    public partial class frmPetDetails : Form
    {
        public frmPetDetails()
        {
            InitializeComponent();

            //  GET Pet ID if Pet is not null
            if (Cart.chosenPet != null)
            {
                ID_label.Text = Cart.chosenPet.ID;
                txtName.Text = Cart.chosenPet.Name;
                txtPetLocation.Text = Cart.chosenPet.StoreID;
                txtBreed.Text = Cart.chosenPet.Breed;
                txtPetAge.Text = Cart.chosenPet.Age;
                txtPetSex.Text = Cart.chosenPet.Sex;
                txtPetSize.Text = Cart.chosenPet.Size;
                txtPetType.Text = Cart.chosenPet.Type;
                txtPetColour.Text = Cart.chosenPet.Color;
                desexed_Panel.Visible = Cart.chosenPet.Desexed;
                microchipped_panel.Visible = Cart.chosenPet.Microchip;
                wormed_Panel.Visible = Cart.chosenPet.Wormed;
                vaccinated_panel.Visible = Cart.chosenPet.Vaccinated;

                //  GET Image of PET
                string filePath = String.Format("Image\\Pet Image\\{0}.png", Cart.chosenPet.ID);
                filePath = Path.Combine(XML_Handler.getSolutionFolder(), filePath);

                //  CHECK if image existed, else, GET placeholder image
                try
                {
                    petPicture.BackgroundImage = new System.Drawing.Bitmap(filePath);
                }
                catch (Exception ex)
                {
                    petPicture.BackgroundImage = new System.Drawing.Bitmap(XML_Handler.getSolutionFolder() + "Image\\Pet Image\\placeholder.jpg");
                }

                //  

            }
        }

        private void microchipped_Picbx_Click(object sender, EventArgs e)
        {

        }

        private void frmPetDetails_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Cart.chosenPet = null;
            this.Close();
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
        }

        private void bAdopt_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdoption adoptionForm = new frmAdoption();
            adoptionForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
