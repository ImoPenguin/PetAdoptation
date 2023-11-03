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
            staff_tabControl.Visible = false;
            animal_tabControl.SelectedTab = viewAnimals_tabPage;
        }

        private void animalLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = true;
            viewDetails_tabControl.Visible = false;
            admin_tabControl.Visible = false;
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
            admin_tabControl.Visible = false;
            staff_tabControl.Visible = false;
            viewDetails_tabControl.SelectedTab = checkID_tabPage;
        }

        private void checkIDLabel_Click(object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = true;
            admin_tabControl.Visible = false;
            staff_tabControl.Visible = false;
            viewDetails_tabControl.SelectedTab = checkID_tabPage;
        }
        private void adminButton_MouseHover(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(255, 246, 229);
        }
        private void adminButton_MouseLeave(Object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(229, 215, 200);
        }
        private void adminButton_Click(Object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            admin_tabControl.Visible = true;
            staff_tabControl.Visible = false;
            admin_tabControl.SelectedTab = viewAdmin_tabPage;
        }
        private void adminLabel_Click(Object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            admin_tabControl.Visible = true;
            staff_tabControl.Visible = false;
            admin_tabControl.SelectedTab = viewAdmin_tabPage;
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
            admin_tabControl.Visible = false;
            staff_tabControl.Visible = true;
            staff_tabControl.SelectedTab = viewStaff_tabPage;
        }
        private void staffLabel_Click(Object sender, EventArgs e)
        {
            customer_tabControl.Visible = false;
            animal_tabControl.Visible = false;
            viewDetails_tabControl.Visible = false;
            admin_tabControl.Visible = false;
            staff_tabControl.Visible = true;
            staff_tabControl.SelectedTab = viewStaff_tabPage;
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
                txtAdminStore.Enabled = false;
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

        //LIST all Pet data 
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
                                textLabel.Text = p.Type.ToString();
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

        private void addPet_btn_Click(object sender, EventArgs e)
        {
            //  CALCULATE Pet ID
            int ID_num = 101 + XML_Handler.readPetData().Count;
            string ID_No = "P" + ID_num.ToString();

            if (addPetValidate())
            {
                Pet newPet = new Pet(
                                LoginAccount.currentManager.WorkingStoreID,
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
                txtLocation.Text = XML_Handler.findShelterByID(LoginAccount.currentManager.WorkingStoreID).Address;
            }
        }

        //  UPDATE PETLIST after ADD new pet
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

        //  LIST all Customers 
        private void Customer_tabControl_VisibleChanged(object sender, EventArgs e)
        {
            if (customer_tabControl.Visible)
            {
                List<Customer> cusList = XML_Handler.readCustomerData();


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
                customerList_table.Controls.Clear();
            }

        }

        private void Customer_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer_tabControl.SelectedIndex == 0)
            {
                Customer_tabControl_VisibleChanged(sender, e);
            }
            else
            {
                customerList_table.Controls.Clear();
            }
        }

        private async void add_Btn_ClickAsyncCust(object sender, EventArgs e)
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

        private void Staff_tabControl_VisibleChanged(object sender, EventArgs e)
        {
            if (staff_tabControl.Visible)
            {
                List<Staff> staffList = XML_Handler.readStaffData();

                staffList = staffList.FindAll(s => s.ManagerID == LoginAccount.currentManager.ID);


                foreach (Staff s in staffList)
                {
                    staffList_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));

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
                                textLabel.Text = s.ID;
                                break;

                            case 1:
                                textLabel.Text = s.Name;
                                break;

                            case 2:
                                textLabel.Text = s.PhoneNo;
                                break;

                            case 3:
                                textLabel.Text = s.Email;
                                break;

                            case 4:
                                string address = String.Join(", ", s.Address.Split(';'));
                                textLabel.Text = address;
                                break;

                            case 5:
                                textLabel.Text = s.ManagerID; //AssignedManager_ID
                                break;

                            default:
                                break;
                        }

                        staffList_table.Controls.Add(textLabel);
                    }
                }
            }
            else
            {
                staffList_table.Controls.Clear();
            }

        }


        private void Staff_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (staff_tabControl.SelectedIndex == 0)
            {
                Staff_tabControl_VisibleChanged(sender, e);
            }
            else
            {
                staffList_table.Controls.Clear();
            }
        }

        private async void addStaff_Btn_ClickAsyncStaff(object sender, EventArgs e)
        {
            //  CHECK if all fields are not empty
            if (validateNewStaff())
            {
                //  Validate Mail
                MailCheckResponse validEmail = await Mail_Handler.Mail_Check(txtStaffEmail.Text);

                if (validEmail != null)
                {
                    if (validEmail.FormatValid && validEmail.MxFound)
                    {
                        string address = String.Join(';', new[] { txtStaffAddress.Text, txtStaffCity.Text, txtStaffState.Text, txtStaffPostalCode.Text });

                        //  CALCULATE ID
                        List<Customer> cusList = XML_Handler.readCustomerData();
                        List<Staff> staffList = XML_Handler.readStaffData();
                        List<Manager> mngrList = XML_Handler.readManagerData();
                        int staffOrder = 1001 + cusList.Count + staffList.Count + mngrList.Count;
                        string newStaff_ID = "U" + staffOrder.ToString();

                        //  ADD new Staff to System
                        Staff newStaff = new Staff(newStaff_ID, "password", txtStaffName.Text, txtStaffPhoneNum.Text, txtStaffEmail.Text, address, LoginAccount.currentManager.WorkingStoreID, LoginAccount.currentManager.ID);

                        XML_Handler.addStaffData(newStaff);

                        MessageBox.Show("New Staff Added Successfully!", "Successful!", MessageBoxButtons.OK);
                        staff_tabControl.SelectedIndex = 0;
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

        private bool validateNewStaff()
        {
            if (txtStaffName.Text == "")
            {
                return false;
            }

            if (txtStaffEmail.Text == "")
            {
                return false;
            }

            if (txtStaffPhoneNum.Text == "")
            {
                return false;
            }

            if (txtStaffAddress.Text == "")
            {
                return false;
            }

            if (txtStaffCity.Text == "")
            {
                return false;
            }

            if (txtStaffPostalCode.Text == "")
            {
                return false;
            }

            if (txtStaffState.Text == "")
            {
                return false;
            }

            return true;
        }
    }
}
