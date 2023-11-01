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

        }

        private void staffButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void staffButton_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void viewStaffs_tabPage_Paint(object sender, EventArgs e)
        {
            ID_lbl.Text = LoginAccount.currentStaff.ID;
            txtStaffName.Text = LoginAccount.currentStaff.Name;
            txtStaffPhone.Text = LoginAccount.currentStaff.PhoneNo;
            txtStaffEmail.Text = LoginAccount.currentStaff.Email;
            txtStaffAddress.Text = LoginAccount.currentStaff.Address;
            txtStaffStore.Text = XML_Handler.findShelterByID(LoginAccount.currentStaff.WorkingStoreID).Address;
            txtStaffManager.Text = XML_Handler.findManagerByID(LoginAccount.currentStaff.ManagerID).Name;
            txtPwdUp.Text = LoginAccount.currentStaff.Password;
        }

        private void bEdit_Click_1(object sender, EventArgs e)
        {
            if (txtStaffPhone.Enabled)
            {
                bEdit.Text = "EDIT";
                txtStaffName.Enabled = false;
                txtStaffPhone.Enabled = false;
                txtStaffEmail.Enabled = false;
                txtStaffAddress.Enabled = false;
                txtPwdUp.Enabled = false;

                //  UPDATE Staff DATA
                LoginAccount.currentStaff.Name = txtStaffName.Text;
                LoginAccount.currentStaff.PhoneNo = txtStaffPhone.Text;
                LoginAccount.currentStaff.Email = txtStaffEmail.Text;
                LoginAccount.currentStaff.Address = txtStaffAddress.Text;
                LoginAccount.currentStaff.Password = txtPwdUp.Text;
                XML_Handler.editStaffData(LoginAccount.currentStaff);
            }
            else
            {
                bEdit.Text = "SAVE";
                txtStaffName.Enabled = true;
                txtStaffPhone.Enabled = true;
                txtStaffEmail.Enabled = true;
                txtStaffAddress.Enabled = true;
                txtPwdUp.Enabled = true;
            }
        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            string typeToCheck = checkList_comboBox.Text;
            string findingID = txtID.Text;

            //  FIND in User List
            if (typeToCheck == "Customer")
            {
                List<Customer> cusList = XML_Handler.readCustomerData();
                Customer findingObject = null;

                foreach (Customer cus in cusList)
                {
                    if (cus.ID == findingID)
                    {
                        findingObject = cus;
                        break;
                    }
                }

                if (findingObject != null)
                {
                    findStaff_panel.Visible = true;

                    //  CHANGE Tab Name
                    viewDetails_tabPage.Text = typeToCheck;

                    findCustomer_panel.Visible = true;
                    findStaff_panel.Visible = false;

                    //  CHANGE Tab Name
                    viewDetails_tabPage.Text = typeToCheck;

                    //  PULL Data from Object
                    findCustomerID_lbl.Text = findingObject.ID;
                    findCustomerName_lbl.Text = findingObject.Name;
                    findCustomerPhone_lbl.Text = findingObject.PhoneNo;
                    findCustomerEmail_lbl.Text = findingObject.Email;
                    findCustomerAddress_lbl.Text = String.Join(", ", findingObject.Address.Split(';'));

                    Staff assignedStaff = XML_Handler.findStaffByID(findingObject.AssignedStaff_ID);

                    if (assignedStaff != null)
                    {
                        findCustomerStaff_lbl.Text = assignedStaff.Name;
                    }
                    else
                    {
                        findCustomerStaff_lbl.Text = "";
                    }
                }
            }
            //  FIND in Staff List
            else if (typeToCheck == "Staff")
            {
                List<Staff> staffList = XML_Handler.readStaffData();
                Staff findingObject = null;

                foreach (Staff staff in staffList)
                {
                    if (staff.ID == findingID)
                    {
                        findingObject = staff;
                        break;
                    }
                }

                //  CHECK if finding Object is existed
                if (findingObject != null)
                {
                    findStaff_panel.Visible = true;
                    findCustomer_panel.Visible = false;

                    //  CHANGE Tab Name
                    viewDetails_tabPage.Text = typeToCheck;

                    //  PULL Data from Object
                    findStaffID_lbl.Text = findingObject.ID;
                    findStaffName_lbl.Text = findingObject.Name;
                    findStaffPhone_lbl.Text = findingObject.PhoneNo;
                    findStaffEmail_lbl.Text = findingObject.Email;
                    findStaffAddress_lbl.Text = String.Join(", ", findingObject.Address.Split(';'));
                    findStaffStore_lbl.Text = XML_Handler.findShelterByID(findingObject.WorkingStoreID).Address;
                    findStaffMng_lbl.Text = XML_Handler.findManagerByID(findingObject.ManagerID).Name;
                }
            }
            //  FIND in Animal List
            else if (typeToCheck == "Animal")
            {
                List<Pet> petList = XML_Handler.readPetData();
                Pet findingObject = null;

                foreach (Pet p in petList)
                {
                    if (p.ID == findingID)
                    {
                        findingObject = p;
                        break;
                    }
                }

                if (findingObject != null)
                {
                    findStaff_panel.Visible = true;

                    //  CHANGE Tab Name
                    viewDetails_tabPage.Text = typeToCheck;
                }
            }
            //  FIND in all LISTs
            else
            {

            }

        }

        private void findStaffAddress_lbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}