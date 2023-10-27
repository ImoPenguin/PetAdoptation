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
    public partial class frmPetDetails : Form
    {
        public frmPetDetails()
        {
            InitializeComponent();
        }

        private void microchipped_Picbx_Click(object sender, EventArgs e)
        {

        }

        private void frmPetDetails_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdoptionSearch adoptionSearchForm = new frmAdoptionSearch();
            adoptionSearchForm.Show();
        }

        private void bAdopt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdoption adoptionForm = new frmAdoption();
            adoptionForm.Show();
        }
    }
}
