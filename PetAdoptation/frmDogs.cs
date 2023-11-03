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
    public partial class frmDogs : Form
    {
        public frmDogs()
        {
            InitializeComponent();

            TableLayoutPanel allPets_Panel = new TableLayoutPanel();
            allPets_Panel.Size = new Size(1130, 380);
            allPets_Panel.Location = new Point(0, 0);
            allPets_Panel.ColumnCount = 3;
            allPets_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            allPets_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            allPets_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));

            allPets_Panel.AutoScroll = false;
            allPets_Panel.AutoSize = true;
            allPets_Panel.BackColor = Color.FromArgb(229, 215, 200);
            allPets_Panel.AutoSizeMode = AutoSizeMode.GrowOnly;

            //  GET Pet List
            List<Pet> petList = XML_Handler.readAvailablePetData();

            //  GET Cat List
            List<Pet> dogList = petList.Where(pet => pet.Type == "Dog").ToList();

            //  LIST all Pet in Pet list
            foreach (Pet p in dogList)
            {
                Console.WriteLine(p.Type);

                // Create a Panel for each cell
                Panel petPanel = new Panel();
                petPanel.Dock = DockStyle.Top;
                petPanel.BackColor = Color.Transparent;
                petPanel.AutoSize = true;

                //  GET Corresponding Images
                PictureBox petPicture = new PictureBox();
                string filePath = String.Format("Image\\Pet Image\\{0}.png", p.ID);
                filePath = Path.Combine(XML_Handler.getSolutionFolder(), filePath);
                //  CHECK if image existed, else, GET placeholder image
                try
                {
                    petPicture.Image = new System.Drawing.Bitmap(filePath);
                }
                catch (Exception ex)
                {
                    petPicture.Image = new System.Drawing.Bitmap(Path.Combine(XML_Handler.getSolutionFolder(), "Image\\Pet Image\\placeholder.jpg"));
                }

                petPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                petPicture.Size = new Size(274, 305);
                petPicture.Location = new Point(26, 0);

                //  CREATE Adopt Button
                Button petButton = new Button();
                petButton.Text = p.Name;
                petButton.Size = new Size(162, 38);
                petButton.Location = new Point(80, 306);
                petButton.BackColor = Color.FromArgb(111, 138, 129);
                petButton.Cursor = Cursors.Hand;
                petButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 138, 129);
                petButton.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
                petButton.FlatStyle = FlatStyle.Flat;
                petButton.Font = new Font("Yu Gothic UI", 15.2F, FontStyle.Bold, GraphicsUnit.Point);
                petButton.ForeColor = Color.FromArgb(255, 246, 229);
                petButton.Margin = new Padding(5);
                petButton.TabIndex = 7;
                petButton.Name = p.ID;
                petButton.Click += (s, ea) => petButton_Click(petButton.Name);

                // Add controls to the Panel
                petPanel.Controls.Add(petPicture);
                petPanel.Controls.Add(petButton);

                // Add the Panel to the TableLayoutPanel
                allPets_Panel.Controls.Add(petPanel);
            }

            // Create a Panel to contain the TableLayoutPanel

            // Add the Panel to the form
            var scrollablePanel = new Panel();
            scrollablePanel.Size = new Size(1147, 380);
            scrollablePanel.Location = new Point(26, 198);
            scrollablePanel.AutoScroll = true;
            scrollablePanel.AutoSize = false;
            scrollablePanel.Controls.Add(allPets_Panel);

            this.Controls.Add(scrollablePanel);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void petButton_Click(string ID)
        {
            Cart.chosenPet = XML_Handler.findPetData(ID);
            Console.WriteLine(ID);
            this.Close();
            frmPetDetails petDetailScreen = new frmPetDetails();
            petDetailScreen.Show();
        }
    }
}
