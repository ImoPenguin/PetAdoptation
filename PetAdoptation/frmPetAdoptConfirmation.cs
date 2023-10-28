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
    public partial class frmPetAdoptConfirmation : Form
    {
        public frmPetAdoptConfirmation()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
        }
    }
}
