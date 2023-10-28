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
    public partial class frmCats : Form
    {
        public frmCats()
        {
            InitializeComponent();
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

        private void petButton_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPetDetails petDetailsForm = new frmPetDetails();
            petDetailsForm.Show(); 
        }
    }
}
