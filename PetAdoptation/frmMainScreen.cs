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
            this.Hide();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserProfile profileForm = new frmUserProfile();
            profileForm.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserProfile profileForm = new frmUserProfile();
            profileForm.Show();
        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserProfile profileForm = new frmUserProfile();
            profileForm.Show();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void showAll_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAllPets allPetsForm = new frmAllPets();
            allPetsForm.Show();
        }

        private void cat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCats catForm = new frmCats();
            catForm.Show();
        }

        private void dog_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDogs dogForm = new frmDogs();
            dogForm.Show();
        }

        private void other_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOtherPets otherPetsForm = new frmOtherPets();
            otherPetsForm.Show();
        }

        //  Nhớ làm lại function này
        private void staffLabel_Click(object sender, EventArgs e)
        {
            frmAdmin staffForm = new frmAdmin();
            staffForm.Show();
        }
    }
}
