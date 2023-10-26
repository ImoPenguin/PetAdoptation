namespace PetAdoptation
{
    partial class frmAdoption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdoption));
            Main_panel = new Panel();
            panel1 = new Panel();
            Location_panel = new Panel();
            txtLocation = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            PetType_Combobx = new ComboBox();
            pictureBox2 = new PictureBox();
            Adopt_lb = new Label();
            bSearch_For_A_Pet = new Button();
            searchMode_Btn = new Button();
            backButton = new Button();
            SearchPet_Panel = new Panel();
            advancedPanel = new Panel();
            panel5 = new Panel();
            panel9 = new Panel();
            txtPetId = new TextBox();
            pictureBox6 = new PictureBox();
            panel8 = new Panel();
            vaccinated_Combobx = new ComboBox();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            sex_Combobx = new ComboBox();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            age_Combobx = new ComboBox();
            pictureBox4 = new PictureBox();
            Main_panel.SuspendLayout();
            panel1.SuspendLayout();
            Location_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SearchPet_Panel.SuspendLayout();
            advancedPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Main_panel
            // 
            Main_panel.BackColor = Color.FromArgb(229, 215, 200);
            Main_panel.Controls.Add(panel1);
            Main_panel.Controls.Add(Adopt_lb);
            Main_panel.Location = new Point(44, 163);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(1285, 255);
            Main_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Location_panel);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(22, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 135);
            panel1.TabIndex = 2;
            // 
            // Location_panel
            // 
            Location_panel.Controls.Add(txtLocation);
            Location_panel.Controls.Add(pictureBox1);
            Location_panel.Location = new Point(639, 26);
            Location_panel.Name = "Location_panel";
            Location_panel.Size = new Size(491, 87);
            Location_panel.TabIndex = 4;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(253, 252, 245);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocation.ForeColor = Color.FromArgb(203, 199, 183);
            txtLocation.Location = new Point(91, 26);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Location";
            txtLocation.RightToLeft = RightToLeft.No;
            txtLocation.Size = new Size(373, 45);
            txtLocation.TabIndex = 3;
            txtLocation.TextChanged += txtLocation_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(18, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 75);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(PetType_Combobx);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(86, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1141, 87);
            panel2.TabIndex = 3;
            // 
            // PetType_Combobx
            // 
            PetType_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            PetType_Combobx.FlatStyle = FlatStyle.Flat;
            PetType_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PetType_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            PetType_Combobx.FormattingEnabled = true;
            PetType_Combobx.Items.AddRange(new object[] { "Cat ", "Dog ", "Other " });
            PetType_Combobx.Location = new Point(105, 26);
            PetType_Combobx.Name = "PetType_Combobx";
            PetType_Combobx.Size = new Size(373, 45);
            PetType_Combobx.TabIndex = 3;
            PetType_Combobx.Text = "Choose an animal type ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(18, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(480, 75);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Adopt_lb
            // 
            Adopt_lb.AutoSize = true;
            Adopt_lb.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            Adopt_lb.ForeColor = Color.FromArgb(81, 60, 41);
            Adopt_lb.Location = new Point(140, 20);
            Adopt_lb.Name = "Adopt_lb";
            Adopt_lb.Size = new Size(997, 62);
            Adopt_lb.TabIndex = 1;
            Adopt_lb.Text = "Adopt and shine with your Rescuoodle today!";
            // 
            // bSearch_For_A_Pet
            // 
            bSearch_For_A_Pet.BackColor = Color.FromArgb(111, 138, 129);
            bSearch_For_A_Pet.Cursor = Cursors.Hand;
            bSearch_For_A_Pet.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 138, 129);
            bSearch_For_A_Pet.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            bSearch_For_A_Pet.FlatStyle = FlatStyle.Flat;
            bSearch_For_A_Pet.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bSearch_For_A_Pet.ForeColor = Color.FromArgb(255, 246, 229);
            bSearch_For_A_Pet.Location = new Point(36, 24);
            bSearch_For_A_Pet.Name = "bSearch_For_A_Pet";
            bSearch_For_A_Pet.Size = new Size(331, 56);
            bSearch_For_A_Pet.TabIndex = 6;
            bSearch_For_A_Pet.Text = "SEARCH FOR A PET";
            bSearch_For_A_Pet.UseVisualStyleBackColor = false;
            // 
            // searchMode_Btn
            // 
            searchMode_Btn.BackColor = Color.Transparent;
            searchMode_Btn.FlatAppearance.BorderSize = 0;
            searchMode_Btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            searchMode_Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            searchMode_Btn.FlatStyle = FlatStyle.Flat;
            searchMode_Btn.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchMode_Btn.ForeColor = Color.FromArgb(81, 60, 41);
            searchMode_Btn.Location = new Point(36, 86);
            searchMode_Btn.Name = "searchMode_Btn";
            searchMode_Btn.Size = new Size(331, 59);
            searchMode_Btn.TabIndex = 7;
            searchMode_Btn.Text = "Advanced search ▼";
            searchMode_Btn.UseVisualStyleBackColor = false;
            searchMode_Btn.Click += advanceSearch_Btn_Click;
            searchMode_Btn.MouseLeave += advanceSearch_Btn_MouseLeave;
            searchMode_Btn.MouseHover += advanceSearch_Btn_MouseHover;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Honeydew;
            backButton.Location = new Point(44, 40);
            backButton.Margin = new Padding(0);
            backButton.Name = "backButton";
            backButton.Size = new Size(145, 62);
            backButton.TabIndex = 23;
            backButton.Text = "❮ BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseLeave += backButton_MouseLeave;
            backButton.MouseHover += backButton_MouseHover;
            // 
            // SearchPet_Panel
            // 
            SearchPet_Panel.BackColor = Color.Transparent;
            SearchPet_Panel.Controls.Add(bSearch_For_A_Pet);
            SearchPet_Panel.Controls.Add(searchMode_Btn);
            SearchPet_Panel.Location = new Point(477, 420);
            SearchPet_Panel.Name = "SearchPet_Panel";
            SearchPet_Panel.Size = new Size(399, 152);
            SearchPet_Panel.TabIndex = 3;
            SearchPet_Panel.Paint += SearchPet_Panel_Paint;
            // 
            // advancedPanel
            // 
            advancedPanel.BackColor = Color.FromArgb(229, 215, 200);
            advancedPanel.Controls.Add(panel5);
            advancedPanel.Location = new Point(44, 414);
            advancedPanel.Name = "advancedPanel";
            advancedPanel.Size = new Size(1285, 216);
            advancedPanel.TabIndex = 3;
            advancedPanel.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(22, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1500, 135);
            panel5.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtPetId);
            panel9.Controls.Add(pictureBox6);
            panel9.Location = new Point(927, 26);
            panel9.Name = "panel9";
            panel9.Size = new Size(203, 87);
            panel9.TabIndex = 6;
            // 
            // txtPetId
            // 
            txtPetId.BackColor = Color.FromArgb(253, 252, 245);
            txtPetId.BorderStyle = BorderStyle.None;
            txtPetId.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPetId.ForeColor = Color.FromArgb(203, 199, 183);
            txtPetId.Location = new Point(28, 21);
            txtPetId.Multiline = true;
            txtPetId.Name = "txtPetId";
            txtPetId.PlaceholderText = "Pet ID";
            txtPetId.RightToLeft = RightToLeft.No;
            txtPetId.Size = new Size(148, 45);
            txtPetId.TabIndex = 4;
            txtPetId.TextAlign = HorizontalAlignment.Center;
            txtPetId.TextChanged += txtPetId_TextChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(12, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(186, 66);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(vaccinated_Combobx);
            panel8.Controls.Add(pictureBox5);
            panel8.Location = new Point(639, 26);
            panel8.Name = "panel8";
            panel8.Size = new Size(280, 87);
            panel8.TabIndex = 5;
            // 
            // vaccinated_Combobx
            // 
            vaccinated_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            vaccinated_Combobx.FlatStyle = FlatStyle.Flat;
            vaccinated_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            vaccinated_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            vaccinated_Combobx.FormattingEnabled = true;
            vaccinated_Combobx.Items.AddRange(new object[] { "Yes", "No" });
            vaccinated_Combobx.Location = new Point(87, 21);
            vaccinated_Combobx.Name = "vaccinated_Combobx";
            vaccinated_Combobx.RightToLeft = RightToLeft.No;
            vaccinated_Combobx.Size = new Size(164, 45);
            vaccinated_Combobx.TabIndex = 3;
            vaccinated_Combobx.Text = "Vaccinated";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(18, 9);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(250, 66);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(sex_Combobx);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(324, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(260, 87);
            panel6.TabIndex = 4;
            // 
            // sex_Combobx
            // 
            sex_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            sex_Combobx.FlatStyle = FlatStyle.Flat;
            sex_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            sex_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            sex_Combobx.FormattingEnabled = true;
            sex_Combobx.Items.AddRange(new object[] { "Male ", "Female " });
            sex_Combobx.Location = new Point(100, 21);
            sex_Combobx.Name = "sex_Combobx";
            sex_Combobx.RightToLeft = RightToLeft.No;
            sex_Combobx.Size = new Size(140, 45);
            sex_Combobx.TabIndex = 3;
            sex_Combobx.Text = "Sex";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(17, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(240, 66);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(age_Combobx);
            panel7.Controls.Add(pictureBox4);
            panel7.Location = new Point(86, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(257, 87);
            panel7.TabIndex = 3;
            // 
            // age_Combobx
            // 
            age_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            age_Combobx.FlatStyle = FlatStyle.Flat;
            age_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            age_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            age_Combobx.FormattingEnabled = true;
            age_Combobx.Items.AddRange(new object[] { "Young ", "Adult ", "Senior " });
            age_Combobx.Location = new Point(94, 21);
            age_Combobx.Name = "age_Combobx";
            age_Combobx.RightToLeft = RightToLeft.No;
            age_Combobx.Size = new Size(122, 45);
            age_Combobx.TabIndex = 3;
            age_Combobx.Text = "Age";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(18, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(214, 66);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // frmAdoption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1371, 800);
            Controls.Add(advancedPanel);
            Controls.Add(SearchPet_Panel);
            Controls.Add(backButton);
            Controls.Add(Main_panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdoption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdoption";
            Main_panel.ResumeLayout(false);
            Main_panel.PerformLayout();
            panel1.ResumeLayout(false);
            Location_panel.ResumeLayout(false);
            Location_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            SearchPet_Panel.ResumeLayout(false);
            advancedPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Main_panel;
        private Label Adopt_lb;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private ComboBox PetType_Combobx;
        private Panel Location_panel;
        private PictureBox pictureBox1;
        private Button bSearch_For_A_Pet;
        private Button searchMode_Btn;
        private TextBox txtLocation;
        private Button backButton;
        private Panel SearchPet_Panel;
        private Panel advancedPanel;
        private Panel panel5;
        private TextBox textBox1;
        private Panel panel7;
        private ComboBox age_Combobx;
        private PictureBox pictureBox4;
        private Panel panel6;
        private ComboBox sex_Combobx;
        private PictureBox pictureBox3;
        private Panel panel9;
        private TextBox txtPetId;
        private PictureBox pictureBox6;
        private Panel panel8;
        private ComboBox vaccinated_Combobx;
        private PictureBox pictureBox5;
    }
}