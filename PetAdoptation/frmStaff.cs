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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void customerButton_MouseHover(object sender, EventArgs e)
        {
            customerButton.BackColor = Color.FromArgb(255, 246, 229);
        }
        private void customerButton_MouseLeave(object sender, EventArgs e)
        {
            customerButton.BackColor = Color.FromArgb(229, 215, 200);
        }
        private void customerButton_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = true;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            staff_tabControl.Visible = false;
            customer_tabControl.SelectedTab = viewCustomers_tabPage;
        }
        private void customerLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = true;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            staff_tabControl.Visible = false;
            customer_tabControl.SelectedTab = viewCustomers_tabPage;
        }

        private void animalButton_MouseHover(object sender, EventArgs e)
        {
            animalButton.BackColor = Color.FromArgb(255, 246, 229);
        }

        private void animalButton_MouseLeave(object sender, EventArgs e)
        {
            animalButton.BackColor = Color.FromArgb(229, 215, 200);
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = true;
            viewDetails_tabControl.Visible = false;
            staff_tabControl.Visible = false;
            animal_tabControl.SelectedTab = viewAnimals_tabPage;
        }

        private void animalLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = true;
            viewDetails_tabControl.Visible = false;
            staff_tabControl.Visible = false;
            animal_tabControl.SelectedTab = viewAnimals_tabPage;
        }

        private void checkIDButton_MouseHover(object sender, EventArgs e)
        {
            checkIDButton.BackColor = Color.FromArgb(255, 246, 229);
        }
        private void checkIDButton_MouseLeave(object sender, EventArgs e)
        {
            checkIDButton.BackColor = Color.FromArgb(229, 215, 200);
        }

        private void checkIDButton_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = true;
            staff_tabControl.Visible = false;
            viewDetails_tabControl.SelectedTab = checkID_tabPage;
        }

        private void checkIDLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = true;
            staff_tabControl.Visible = false;
            viewDetails_tabControl.SelectedTab = checkID_tabPage;
        }

        private void staffButton_MouseHover(object sender, EventArgs e)
        {
            staffButton.BackColor = Color.FromArgb(255, 246, 229);
        }
        private void staffButton_MouseLeave(Object sender, EventArgs e)
        {
            staffButton.BackColor = Color.FromArgb(229, 215, 200);
        }
        private void staffButton_Click(Object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            staff_tabControl.Visible = true;
            staff_tabControl.SelectedTab = viewStaffs_tabPage;
        }
        private void staffLabel_Click(Object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            staff_tabControl.Visible = true;
            staff_tabControl.SelectedTab = viewStaffs_tabPage;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (txtPhone_view.Enabled)
            {
                bEdit.Text = "EDIT";
                txtName_view.Enabled = false;
                txtPhone_view.Enabled = false;
                txtEmail_view.Enabled = false;
                txtAddress_view.Enabled = false;
                txtPwdUp_view.Enabled = false;
                txtWorkingStore_view.Enabled = false;
                txtManagerName_view.Enabled = false;
            }
            else
            {
                bEdit.Text = "SAVED";
                txtName_view.Enabled = true;
                txtPhone_view.Enabled = true;
                txtEmail_view.Enabled = true;
                txtAddress_view.Enabled = true;
                txtPwdUp_view.Enabled = true;
                txtWorkingStore_view.Enabled = true;
                txtManagerName_view.Enabled = true;
            }
        }
    }
}
