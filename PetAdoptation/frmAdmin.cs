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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
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
            admin_tabControl.Visible = false;
            customer_tabControl.SelectedTab = viewCustomers_tabPage;
        }

        private void customerLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = true;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            admin_tabControl.Visible = false;
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
            admin_tabControl.Visible = false;
            animal_tabControl.SelectedTab = viewAnimals_tabPage;
        }

        private void animalLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = true;
            viewDetails_tabControl.Visible = false;
            admin_tabControl.Visible = false;
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
            admin_tabControl.Visible = false;
            viewDetails_tabControl.SelectedTab = checkID_tabPage;
        }

        private void checkIDLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = true;
            admin_tabControl.Visible = false;
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
            admin_tabControl.Visible = true;
            admin_tabControl.SelectedTab = viewAdmin_tabPage;
        }
        private void staffLabel_Click(Object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            admin_tabControl.Visible = true;
            admin_tabControl.SelectedTab = viewAdmin_tabPage;
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewAdmin_tabPage_Paint(object sender, EventArgs e)
        {
            ID_lbl.Text = LoginAccount.currentManager.ID;
            txtAdminName.Text = LoginAccount.currentManager.Name;
            txtAdminPhone.Text = LoginAccount.currentManager.PhoneNo;
            txtAdminEmail.Text = LoginAccount.currentManager.Email;
            txtAdminAddress.Text = LoginAccount.currentManager.Address;
            txtAdminStore.Text = XML_Handler.findShelterByID(LoginAccount.currentManager.WorkingStoreID).Address;
            txtPwdUp.Text = LoginAccount.currentManager.Password;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (txtAdminPhone.Enabled)
            {
                bEdit.Text = "EDIT";
                txtAdminName.Enabled = false;
                txtAdminPhone.Enabled = false;
                txtAdminEmail.Enabled = false;
                txtAdminAddress.Enabled = false;
                txtAdminStore.Enabled = false;
                txtPwdUp.Enabled = false;

                //  UPDATE Staff DATA
                LoginAccount.currentManager.Name = txtAdminName.Text;
                LoginAccount.currentManager.PhoneNo = txtAdminPhone.Text;
                LoginAccount.currentManager.Email = txtAdminEmail.Text;
                LoginAccount.currentManager.Address = txtAdminAddress.Text;
                LoginAccount.currentManager.Password = txtPwdUp.Text;
                XML_Handler.editManagerData(LoginAccount.currentManager);
            }
            else
            {
                bEdit.Text = "SAVE";
                txtAdminName.Enabled = true;
                txtAdminPhone.Enabled = true;
                txtAdminEmail.Enabled = true;
                txtAdminAddress.Enabled = true;
                txtAdminStore.Enabled = true;
                txtPwdUp.Enabled = true;
            }
        }
    }
}
