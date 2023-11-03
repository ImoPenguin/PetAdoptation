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
            this.Close();
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
                    findStaff_panel.Visible = false;
                    findCustomer_panel.Visible = true;
                    findAnimal_panel.Visible = false;

                    //  CHANGE Tab Name
                    viewDetails_findStaff.Text = typeToCheck;

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

                    //  CHANGE Tabs
                    viewDetails_tabControl.SelectedIndex = 2;
                }

                else
                {
                    warningLabel.Visible = true;
                    warningLabel.Text = "! Customer not found !";
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
                    findAnimal_panel.Visible = false;

                    //  PULL Data from Object
                    findStaffID_lbl.Text = findingObject.ID;
                    findStaffName_lbl.Text = findingObject.Name;
                    findStaffPhone_lbl.Text = findingObject.PhoneNo;
                    findStaffEmail_lbl.Text = findingObject.Email;
                    findStaffAddress_lbl.Text = String.Join(", ", findingObject.Address.Split(';'));
                    findStaffStore_lbl.Text = XML_Handler.findShelterByID(findingObject.WorkingStoreID).Address;
                    findStaffMng_lbl.Text = XML_Handler.findManagerByID(findingObject.ManagerID).Name;

                    //  CHANGE Tab
                    viewDetails_tabControl.SelectedIndex = 1;
                }
                else
                {
                    warningLabel.Visible = true;
                    warningLabel.Text = "! Staff not found !";
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
                    findStaff_panel.Visible = false;
                    findCustomer_panel.Visible = false;
                    findAnimal_panel.Visible = true;

                    //  PULL Data from object
                    findAnimalID_lbl.Text = findingObject.ID;
                    findAnimalName_lbl.Text = findingObject.Name;
                    findAnimalAddress_lbl.Text = XML_Handler.findShelterByID(findingObject.StoreID).Address;
                    findAnimalBreed_lbl.Text = findingObject.Breed;
                    findAnimalAge_lbl.Text = findingObject.Age;
                    findAnimalGender_lbl.Text = findingObject.Sex;
                    findAnimalSize_lbl.Text = findingObject.Size;
                    findAnimalType_lbl.Text = findingObject.Type;
                    findAnimalColor_lbl.Text = findingObject.Color;
                    findAnimalOwner_lbl.Text = findingObject.OwnerID;

                    findAnimalVaccinated_checkBox.Checked = findingObject.Vaccinated;
                    findAnimalDesexed_checkBox.Checked = findingObject.Desexed;
                    findAnimalWorming_checkBox.Checked = findingObject.Wormed;
                    findAnimalMicrochipped_checkBox.Checked = findingObject.Microchip;

                    //  GET Image of PET
                    string filePath = String.Format("Image\\Pet Image\\{0}.png", findingObject.ID);
                    filePath = Path.Combine(XML_Handler.getSolutionFolder(), filePath);

                    //  CHECK if image existed, else, GET placeholder image
                    try
                    {
                        petPicture.BackgroundImage = new System.Drawing.Bitmap(filePath);
                    }
                    catch (Exception ex)
                    {
                        petPicture.BackgroundImage = new System.Drawing.Bitmap(XML_Handler.getSolutionFolder() + "Image\\Pet Image\\placeholder.jpg");
                    }

                    //  CHANGE Tab
                    viewDetails_tabControl.SelectedIndex = 3;
                }
                else
                {
                    warningLabel.Visible = true;
                    warningLabel.Text = "! Pet not found !";
                }
            }
            //  FIND in all LISTs
            else
            {
                warningLabel.Visible = true;
                warningLabel.Text = "Please choose a valid category";
            }

        }

        private void ViewDetails_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  HIDE all Info Panels if tab index = 0
            if (viewDetails_tabControl.SelectedIndex == 0)
            {
                findCustomer_panel.Visible = false;
                findStaff_panel.Visible = false;
                findAnimal_panel.Visible = false;
            }
        }

        private void findStaffAddress_lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }

        private void Animal_tabControl_VisibleChanged(object sender, EventArgs e)
        {
            if (animal_tabControl.Visible)
            {
                List<Pet> petList = XML_Handler.readPetData();

                foreach (Pet p in petList)
                {
                    for (int i = 0; i < petList_table.ColumnCount; i++)
                    {
                        Label textLabel = new Label();
                        textLabel.Dock = DockStyle.Fill;
                        textLabel.Location = new Point(3, 0);
                        textLabel.Name = "InfoLabel";
                        textLabel.Size = new Size(136, 32);
                        textLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                        textLabel.TabIndex = 0;
                        textLabel.TextAlign = ContentAlignment.MiddleCenter;

                        switch (i)
                        {
                            case 0:
                                textLabel.Text = p.ID;
                                break;

                            case 1:
                                textLabel.Text = p.Name;
                                break;

                            case 2:
                                textLabel.Text = p.Sex;
                                break;

                            case 3:
                                textLabel.Text = p.Breed;
                                break;

                            case 4:
                                textLabel.Text = p.Vaccinated.ToString();
                                break;

                            case 5:
                                textLabel.Text = p.Microchip.ToString();
                                break;

                            default:
                                break;
                        }

                        petList_table.Controls.Add(textLabel);
                    }
                }
            }
            else
            {
                petList_table.Controls.Clear();
                petList_table.RowCount = 1;
            }
        }

        private void PetList_panel_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void addPet_btn_Click(object sender, EventArgs e)
        {
            //  CALCULATE Pet ID
            int ID_num = 101 + XML_Handler.readPetData().Count;
            string ID_No = "P" + ID_num.ToString();

            if (addPetValidate())
            {
                Pet newPet = new Pet(
                                LoginAccount.currentStaff.WorkingStoreID,
                                ID_No,
                                PetType_Combobx.Text,
                                txtName.Text,
                                txtPetColor.Text,
                                sex_Combobx.Text,
                                txtBreed.Text,
                                size_comboBox.Text,
                                vaccinated_checkBox.Checked,
                                microchipped_checkBox.Checked,
                                desexed_checkBox.Checked,
                                worming_checkBox.Checked,
                                txtDescription.Text,
                                age_Combobx.Text,
                                ""
                                );

                XML_Handler.addPetData(newPet);

                MessageBox.Show("New Pet added to system", "Successful!", MessageBoxButtons.OK);

                //  RESET Text Boxes
                PetType_Combobx.Text = "Choose an animal type";
                txtName.Text = "";
                txtPetColor.Text = "";
                sex_Combobx.Text = "Sex";
                txtBreed.Text = "";
                size_comboBox.Text = "Size";
                vaccinated_checkBox.Checked = false;
                microchipped_checkBox.Checked = false;
                desexed_checkBox.Checked = false;
                worming_checkBox.Checked = false;
                txtDescription.Text = "";
                age_Combobx.Text = "Age";

                //  JUMP back to View Tab
                animal_tabControl.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("One or more field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool addPetValidate()
        {
            if ((PetType_Combobx.Text != "Cat") && (PetType_Combobx.Text != "Dog") && (PetType_Combobx.Text != "Other"))
            {
                return false;
            }

            if (txtName.Text == "")
            {
                return false;
            }

            if (txtPetColor.Text == "")
            {
                return false;
            }

            if ((sex_Combobx.Text != "Male") && (sex_Combobx.Text != "Female"))
            {
                return false;
            }

            if (txtBreed.Text == "")
            {
                return false;
            }

            if ((size_comboBox.Text != "Small") && (size_comboBox.Text != "Medium") && (size_comboBox.Text != "Large"))
            {
                return false;
            }

            if (txtBreed.Text == "")
            {
                return false;
            }

            if (txtName.Text == "")
            {
                return false;
            }


            return true;
        }

        private void addPet_VisibleChanged(object sender, EventArgs e)
        {
            if (addPet_panel.Visible)
            {
                //  CALCULATE Pet ID
                int ID_num = 101 + XML_Handler.readPetData().Count;
                string ID_No = "P" + ID_num.ToString();

                //  SET Fixed ID of PET
                txtPetID.Text = ID_No;
                txtLocation.Text = XML_Handler.findShelterByID(LoginAccount.currentStaff.WorkingStoreID).Address;
            }
        }

        //UPDATE PETLIST after ADD new pet
        private void Animal_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animal_tabControl.SelectedIndex == 0)
            {
                petList_panel.Visible = true;
                addPet_panel.Visible = false;

                petList_table.Controls.Clear();
                petList_table.RowCount = 1;

                List<Pet> petList = XML_Handler.readPetData();

                foreach (Pet p in petList)
                {
                    for (int i = 0; i < petList_table.ColumnCount; i++)
                    {
                        Label textLabel = new Label();
                        textLabel.Dock = DockStyle.Fill;
                        textLabel.Location = new Point(3, 0);
                        textLabel.Name = "InfoLabel";
                        textLabel.Size = new Size(136, 32);
                        textLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                        textLabel.TabIndex = 0;
                        textLabel.TextAlign = ContentAlignment.MiddleCenter;

                        switch (i)
                        {
                            case 0:
                                textLabel.Text = p.ID;
                                break;

                            case 1:
                                textLabel.Text = p.Name;
                                break;

                            case 2:
                                textLabel.Text = p.Sex;
                                break;

                            case 3:
                                textLabel.Text = p.Breed;
                                break;

                            case 4:
                                textLabel.Text = p.Vaccinated.ToString();
                                break;

                            case 5:
                                textLabel.Text = p.Microchip.ToString();
                                break;

                            default:
                                break;
                        }

                        petList_table.Controls.Add(textLabel);
                    }
                }
            }
            else
            {
                petList_panel.Visible = false;
                addPet_panel.Visible = true;
            }
        }

        private void Customer_tabControl_VisibleChanged(object sender, EventArgs e)
        {
            if (customer_tabControl.Visible)
            {
                List<Customer> cusList = XML_Handler.readCustomerData();

                cusList = cusList.FindAll(c => c.AssignedStaff_ID == LoginAccount.currentStaff.ID);


                foreach (Customer c in cusList)
                {
                    customerList_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));

                    for (int i = 0; i < petList_table.ColumnCount; i++)
                    {
                        Label textLabel = new Label();
                        textLabel.Dock = DockStyle.Fill;
                        textLabel.Name = "customerInfoLabel";
                        textLabel.TabIndex = 0;
                        textLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                        textLabel.TabIndex = 0;
                        textLabel.TextAlign = ContentAlignment.MiddleCenter;
                        textLabel.BackColor = Color.FromArgb(229, 215, 200);
                        textLabel.ForeColor = Color.Black;
                        textLabel.BorderStyle = BorderStyle.None;

                        switch (i)
                        {
                            case 0:
                                textLabel.Text = c.ID;
                                break;

                            case 1:
                                textLabel.Text = c.Name;
                                break;

                            case 2:
                                textLabel.Text = c.PhoneNo;
                                break;

                            case 3:
                                textLabel.Text = c.Email;
                                break;

                            case 4:
                                string address = String.Join(", ", c.Address.Split(';'));
                                textLabel.Text = address;
                                break;

                            case 5:
                                textLabel.Text = c.AssignedStaff_ID;
                                break;

                            default:
                                break;
                        }

                        customerList_table.Controls.Add(textLabel);
                    }
                }
            }
            else
            {

            }

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private async void add_Btn_ClickAsync(object sender, EventArgs e)
        {
            //  CHECK if all fields are not empty
            if (validateNewCustomer())
            {
                //  Validate Mail
                MailCheckResponse validEmail = await Mail_Handler.Mail_Check(txtCustomerEmail.Text);

                if (validEmail != null)
                {
                    if (validEmail.FormatValid && validEmail.MxFound)
                    {
                        string address = String.Join(';', new[] { txtCustomerAddress.Text, txtCustomerCity.Text, txtCustomerState.Text, txtCustomerPostalCode.Text });

                        //  CALCULATE ID
                        List<Customer> cusList = XML_Handler.readCustomerData();
                        List<Staff> staffList = XML_Handler.readStaffData();
                        List<Manager> mngrList = XML_Handler.readManagerData();
                        int cusOrder = 1001 + cusList.Count + staffList.Count + mngrList.Count;
                        string newCus_ID = "U" + cusOrder.ToString();

                        //  ADD new Cutomer to System
                        Customer newCus = new Customer(newCus_ID, "password", txtCustomerName.Text, txtCustomerPhoneNum.Text, txtCustomerEmail.Text, address, LoginAccount.currentStaff.ID);

                        XML_Handler.addCustomerData(newCus);
                    }
                    else
                    {
                        MessageBox.Show("Email is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("One or more field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validateNewCustomer()
        {
            if (txtCustomerName.Text == "")
            {
                return false;
            }

            if (txtCustomerEmail.Text == "")
            {
                return false;
            }

            if (txtCustomerPhoneNum.Text == "")
            {
                return false;
            }

            if (txtCustomerAddress.Text == "")
            {
                return false;
            }

            if (txtCustomerCity.Text == "")
            {
                return false;
            }

            if (txtCustomerPostalCode.Text == "")
            {
                return false;
            }

            if (txtCustomerState.Text == "")
            {
                return false;
            }

            return true;
        }
    }
}