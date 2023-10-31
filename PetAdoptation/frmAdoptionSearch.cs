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
    public partial class frmAdoptionSearch : Form
    {
        public frmAdoptionSearch()
        {
            InitializeComponent();
        }

        private void advanceSearch_Btn_Click(object sender, EventArgs e)
        {
            if (advancedPanel.Visible)
            {
                advancedPanel.Visible = false;
                SearchPet_Panel.Location = new Point(SearchPet_Panel.Location.X, SearchPet_Panel.Location.Y - advancedPanel.Height);
                searchMode_Btn.Text = "Advanced search ▼";

            }
            else
            {
                advancedPanel.Visible = true;
                searchMode_Btn.Text = "Standard search ▲";
                SearchPet_Panel.Location = new Point(SearchPet_Panel.Location.X, SearchPet_Panel.Location.Y + advancedPanel.Height);
            }


        }

        private void advanceSearch_Btn_MouseHover(object sender, EventArgs e)
        {
            searchMode_Btn.ForeColor = Color.FromArgb(132, 109, 97);
        }

        private void advanceSearch_Btn_MouseLeave(object sender, EventArgs e)
        {
            searchMode_Btn.ForeColor = Color.FromArgb(81, 60, 41);
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //  RESET Search Data
            SearchData.resetSearchData();

            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
            this.Close();
        }
        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.FromArgb(81, 60, 41);
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.Honeydew;
        }

        private void txtPetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdoption_Load(object sender, EventArgs e)
        {

        }

        private void SearchPet_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PetType_Combobx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchPet_Btn_Click(object sender, EventArgs e)
        {
            //  GET Search Data
            //  Pet Type Data
            if (PetType_Combobx.SelectedIndex <= 0)
            {
                SearchData.animalType = String.Empty;
            }
            else
            {
                SearchData.animalType = PetType_Combobx.Text;
            }

            //  Pet Age Data
            if (age_Combobx.SelectedIndex <= 0)
            {
                SearchData.animalAge = String.Empty;
            }
            else
            {
                SearchData.animalAge = age_Combobx.Text;
            }

            //  Pet Gender Data
            if (sex_Combobx.SelectedIndex <= 0)
            {
                SearchData.animalGender = String.Empty;
            }
            else
            {
                SearchData.animalGender = sex_Combobx.Text;
            }

            //  Pet Vaccinated Data
            if (vaccinated_Combobx.SelectedIndex <= 0)
            {
                SearchData.vaccinated = String.Empty;
            }
            else
            {
                SearchData.vaccinated = vaccinated_Combobx.Text;
            }

            //  GET Data from Text Box
            SearchData.animalLocation = txtLocation.Text;
            SearchData.petID = txtPetId.Text;

            //titleLabel.Text = SearchData.animalType + SearchData.animalAge + SearchData.animalGender + SearchData.animalLocation + SearchData.vaccinated + SearchData.petID;

            this.Close();
            frmSearchResult searchResultscreen = new frmSearchResult();
            searchResultscreen.Show();

        }


    }
}