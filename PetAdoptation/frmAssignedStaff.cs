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
    public partial class frmAssignedStaff : Form
    {
        public frmAssignedStaff()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmAssignedStaff_Load(object sender, EventArgs e)
        {
            Staff assignedStaff = XML_Handler.findStaffByID(LoginAccount.currentCustomer.AssignedStaff_ID);

            //  PULL Data to Info Labels in FORMs
            if (assignedStaff != null)
            {
                infoPanel.Visible = true;
                noStaff_lbl.Visible = false;

                ID_lbl.Text = assignedStaff.ID;
                txtName.Text = assignedStaff.Name;
                txtPhone.Text = assignedStaff.PhoneNo;
                txtEmail.Text = assignedStaff.Email;
                txtWorkingStore.Text = XML_Handler.findShelterByID(assignedStaff.WorkingStoreID).Address;

                //  GET Manager of this STAFF
                Manager m = XML_Handler.findManagerByID(assignedStaff.ManagerID);

                if (m != null)
                {
                    managerName_lbl.Text = m.Name;
                }
            }
            else
            {
                infoPanel.Visible = false;
                noStaff_lbl.Visible = true;
            }

        }
    }
}
