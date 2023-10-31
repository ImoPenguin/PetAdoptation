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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void homeButton_MouseHover(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.FromArgb(255, 246, 229);
        }

        private void homeButton_MouseOff(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.FromArgb(203, 199, 183);
        }

        private void profileButton_MouseHover(Object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(255, 246, 229);
        }

        private void profileButton_MouseOff(Object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(203, 199, 183);
        }

        private void staffButton_MouseHover(Object sender, EventArgs e)
        {
            staffButton.BackColor = Color.FromArgb(255, 246, 229);
        }

        private void staffButton_MouseOff(Object sender, EventArgs e)
        {
            staffButton.BackColor = Color.FromArgb(203, 199, 183);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            sideMenuPanel.Visible = false;
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.FromArgb(81, 60, 41);
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.White;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void adoptBtn_Click(object sender, EventArgs e)
        {
            frmAdoptionSearch adoptionForm = new frmAdoptionSearch();
            adoptionForm.Show();
            this.Close();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            frmUserProfile profileForm = new frmUserProfile();
            profileForm.Show();
            this.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            frmUserProfile profileForm = new frmUserProfile();
            profileForm.Show();
            this.Close();
        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            frmUserProfile profileForm = new frmUserProfile();
            profileForm.Show();
            this.Close();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void showAll_Btn_Click(object sender, EventArgs e)
        {
            frmAllPets allPetsForm = new frmAllPets();
            allPetsForm.Show();
            this.Close();
        }

        private void cat_Btn_Click(object sender, EventArgs e)
        {
            frmCats catForm = new frmCats();
            catForm.Show();
            this.Close();
        }

        private void dog_Btn_Click(object sender, EventArgs e)
        {
            frmDogs dogForm = new frmDogs();
            dogForm.Show();
            this.Close();
        }

        private void other_Btn_Click(object sender, EventArgs e)
        {
            frmOtherPets otherPetsForm = new frmOtherPets();
            otherPetsForm.Show();
            this.Close();
        }

        private void staffLabel_Click(object sender, EventArgs e)
        {
            frmAssignedStaff assignedStaffForm = new frmAssignedStaff();
            assignedStaffForm.Show();
            this.Close();
        }

        private void returnPet_Btn_Click(object sender, EventArgs e)
        {
            frmReturnPets returnPetsForm = new frmReturnPets();
            returnPetsForm.Show();
            this.Close();
        }

        //  Nhớ làm lại function này
        private void searchID_Btn_Click(object sender, EventArgs e)
        {
            frmAdmin staffForm = new frmAdmin();
            staffForm.Show();
            this.Close();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            frmAssignedStaff assignedStaffForm = new frmAssignedStaff();
            assignedStaffForm.Show();
            this.Close();
        }
    }
}
