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

        private void advanceSearch_Btn_Click(object sender, EventArgs e)
        {

        }

        private void advanceSearch_Btn_MouseHover(object sender, EventArgs e)
        {
            advanceSearch_Btn.ForeColor = Color.FromArgb(132, 109, 97);
        }

        private void advanceSearch_Btn_MouseLeave(object sender, EventArgs e)
        {
            advanceSearch_Btn.ForeColor = Color.FromArgb(81, 60, 41);
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
    }
}
