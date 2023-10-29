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
            this.Hide();
            frmPetReturnConfirm petReturnConfirmScreen = new frmPetReturnConfirm();
            petReturnConfirmScreen.Show();
        }
    }
}
