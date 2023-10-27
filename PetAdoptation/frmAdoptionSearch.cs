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
            InitializeComponenthttps://github.com/ImoPenguin/PetAdoptation/pull/36/conflict?name=PetAdoptation%252FfrmAdoptionSearch.Designer.cs&base_oid=1352383ada9efc70f630419c83f6dac9676e68dc&head_oid=d1e7f47c80e8f20d454b0e2535b847c254e633a5();
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
                searchMode_Btn.Text = "Standard search  ▲";
                SearchPet_Panel.Location = new Point(477, 636);
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
            this.Hide();
            frmPetDetails petDetailsForm = new frmPetDetails();
            petDetailsForm.Show(); 
        }


    }
}
