namespace PetAdoptation
{
    partial class frmAdoptionSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdoptionSearch));
            Main_panel = new Panel();
            panel1 = new Panel();
            Location_panel = new Panel();
            txtLocation = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            PetType_Combobx = new ComboBox();
            pictureBox2 = new PictureBox();
            titleLabel = new Label();
            searchPet_Btn = new Button();
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
            Main_panel.Controls.Add(titleLabel);
            Main_panel.Location = new Point(38, 122);
            Main_panel.Margin = new Padding(3, 2, 3, 2);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(1124, 191);
            Main_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Location_panel);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(19, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 101);
            panel1.TabIndex = 2;
            // 
            // Location_panel
            // 
            Location_panel.Controls.Add(txtLocation);
            Location_panel.Controls.Add(pictureBox1);
            Location_panel.Location = new Point(559, 20);
            Location_panel.Margin = new Padding(3, 2, 3, 2);
            Location_panel.Name = "Location_panel";
            Location_panel.Size = new Size(430, 65);
            Location_panel.TabIndex = 4;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(253, 252, 245);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocation.ForeColor = Color.FromArgb(203, 199, 183);
            txtLocation.Location = new Point(80, 20);
            txtLocation.Margin = new Padding(3, 2, 3, 2);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Location";
            txtLocation.RightToLeft = RightToLeft.No;
            txtLocation.Size = new Size(326, 34);
            txtLocation.TabIndex = 3;
            txtLocation.TextAlign = HorizontalAlignment.Center;
            txtLocation.TextChanged += txtLocation_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(16, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 56);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(PetType_Combobx);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(75, 20);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 65);
            panel2.TabIndex = 3;
            // 
            // PetType_Combobx
            // 
            PetType_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            PetType_Combobx.FlatStyle = FlatStyle.Flat;
            PetType_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PetType_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            PetType_Combobx.FormattingEnabled = true;
            PetType_Combobx.Items.AddRange(new object[] { "Choose an animal type", "Cat", "Dog", "Other" });
            PetType_Combobx.Location = new Point(92, 18);
            PetType_Combobx.Margin = new Padding(3, 2, 3, 2);
            PetType_Combobx.Name = "PetType_Combobx";
            PetType_Combobx.Size = new Size(327, 38);
            PetType_Combobx.TabIndex = 3;
            PetType_Combobx.Text = "Choose an animal type";
            PetType_Combobx.SelectedIndexChanged += PetType_Combobx_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(16, 7);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 56);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(81, 60, 41);
            titleLabel.Location = new Point(0, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1124, 51);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Adopt and shine with your Rescuoodle today!";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchPet_Btn
            // 
            searchPet_Btn.BackColor = Color.FromArgb(111, 138, 129);
            searchPet_Btn.Cursor = Cursors.Hand;
            searchPet_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 138, 129);
            searchPet_Btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            searchPet_Btn.FlatStyle = FlatStyle.Flat;
            searchPet_Btn.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            searchPet_Btn.ForeColor = Color.FromArgb(255, 246, 229);
            searchPet_Btn.Location = new Point(32, 18);
            searchPet_Btn.Margin = new Padding(3, 2, 3, 2);
            searchPet_Btn.Name = "searchPet_Btn";
            searchPet_Btn.Size = new Size(290, 42);
            searchPet_Btn.TabIndex = 6;
            searchPet_Btn.Text = "SEARCH FOR A PET";
            searchPet_Btn.UseVisualStyleBackColor = false;
            searchPet_Btn.Click += searchPet_Btn_Click;
            // 
            // searchMode_Btn
            // 
            searchMode_Btn.BackColor = Color.Transparent;
            searchMode_Btn.Cursor = Cursors.Hand;
            searchMode_Btn.FlatAppearance.BorderSize = 0;
            searchMode_Btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            searchMode_Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            searchMode_Btn.FlatStyle = FlatStyle.Flat;
            searchMode_Btn.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchMode_Btn.ForeColor = Color.FromArgb(81, 60, 41);
            searchMode_Btn.Location = new Point(32, 64);
            searchMode_Btn.Margin = new Padding(3, 2, 3, 2);
            searchMode_Btn.Name = "searchMode_Btn";
            searchMode_Btn.Size = new Size(290, 44);
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
            backButton.Location = new Point(38, 30);
            backButton.Margin = new Padding(0);
            backButton.Name = "backButton";
            backButton.Size = new Size(127, 46);
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
            SearchPet_Panel.Controls.Add(searchPet_Btn);
            SearchPet_Panel.Controls.Add(searchMode_Btn);
            SearchPet_Panel.Location = new Point(417, 315);
            SearchPet_Panel.Margin = new Padding(3, 2, 3, 2);
            SearchPet_Panel.Name = "SearchPet_Panel";
            SearchPet_Panel.Size = new Size(349, 114);
            SearchPet_Panel.TabIndex = 3;
            SearchPet_Panel.Paint += SearchPet_Panel_Paint;
            // 
            // advancedPanel
            // 
            advancedPanel.BackColor = Color.FromArgb(229, 215, 200);
            advancedPanel.Controls.Add(panel5);
            advancedPanel.Location = new Point(38, 313);
            advancedPanel.Margin = new Padding(3, 2, 3, 2);
            advancedPanel.Name = "advancedPanel";
            advancedPanel.Size = new Size(1124, 162);
            advancedPanel.TabIndex = 3;
            advancedPanel.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(19, 8);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1094, 101);
            panel5.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtPetId);
            panel9.Controls.Add(pictureBox6);
            panel9.Location = new Point(811, 20);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(178, 65);
            panel9.TabIndex = 6;
            // 
            // txtPetId
            // 
            txtPetId.BackColor = Color.FromArgb(253, 252, 245);
            txtPetId.BorderStyle = BorderStyle.None;
            txtPetId.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPetId.ForeColor = Color.FromArgb(203, 199, 183);
            txtPetId.Location = new Point(24, 16);
            txtPetId.Margin = new Padding(3, 2, 3, 2);
            txtPetId.MaxLength = 5;
            txtPetId.Multiline = true;
            txtPetId.Name = "txtPetId";
            txtPetId.PlaceholderText = "Pet ID";
            txtPetId.RightToLeft = RightToLeft.No;
            txtPetId.Size = new Size(130, 34);
            txtPetId.TabIndex = 4;
            txtPetId.TextAlign = HorizontalAlignment.Center;
            txtPetId.TextChanged += txtPetId_TextChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(10, 7);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(163, 50);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(vaccinated_Combobx);
            panel8.Controls.Add(pictureBox5);
            panel8.Location = new Point(559, 20);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(245, 65);
            panel8.TabIndex = 5;
            // 
            // vaccinated_Combobx
            // 
            vaccinated_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            vaccinated_Combobx.FlatStyle = FlatStyle.Flat;
            vaccinated_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            vaccinated_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            vaccinated_Combobx.FormattingEnabled = true;
            vaccinated_Combobx.Items.AddRange(new object[] { "Vaccinated", "Yes", "No" });
            vaccinated_Combobx.Location = new Point(76, 14);
            vaccinated_Combobx.Margin = new Padding(3, 2, 3, 2);
            vaccinated_Combobx.Name = "vaccinated_Combobx";
            vaccinated_Combobx.RightToLeft = RightToLeft.No;
            vaccinated_Combobx.Size = new Size(144, 38);
            vaccinated_Combobx.TabIndex = 3;
            vaccinated_Combobx.Text = "Vaccinated";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(16, 7);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(219, 50);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(sex_Combobx);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(284, 20);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(228, 65);
            panel6.TabIndex = 4;
            // 
            // sex_Combobx
            // 
            sex_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            sex_Combobx.FlatStyle = FlatStyle.Flat;
            sex_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            sex_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            sex_Combobx.FormattingEnabled = true;
            sex_Combobx.Items.AddRange(new object[] { "Sex", "Male", "Female" });
            sex_Combobx.Location = new Point(88, 14);
            sex_Combobx.Margin = new Padding(3, 2, 3, 2);
            sex_Combobx.Name = "sex_Combobx";
            sex_Combobx.RightToLeft = RightToLeft.No;
            sex_Combobx.Size = new Size(123, 38);
            sex_Combobx.TabIndex = 3;
            sex_Combobx.Text = "Sex";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(15, 7);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(210, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(age_Combobx);
            panel7.Controls.Add(pictureBox4);
            panel7.Location = new Point(75, 20);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 65);
            panel7.TabIndex = 3;
            // 
            // age_Combobx
            // 
            age_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            age_Combobx.FlatStyle = FlatStyle.Flat;
            age_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            age_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            age_Combobx.FormattingEnabled = true;
            age_Combobx.Items.AddRange(new object[] { "Age", "Young", "Adult", "Senior" });
            age_Combobx.Location = new Point(82, 14);
            age_Combobx.Margin = new Padding(3, 2, 3, 2);
            age_Combobx.Name = "age_Combobx";
            age_Combobx.RightToLeft = RightToLeft.No;
            age_Combobx.Size = new Size(107, 38);
            age_Combobx.TabIndex = 3;
            age_Combobx.Text = "Age";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(16, 7);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(187, 50);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // frmAdoptionSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 600);
            Controls.Add(advancedPanel);
            Controls.Add(SearchPet_Panel);
            Controls.Add(backButton);
            Controls.Add(Main_panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdoptionSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdoption";
            Main_panel.ResumeLayout(false);
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
        private Label titleLabel;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private ComboBox PetType_Combobx;
        private Panel Location_panel;
        private PictureBox pictureBox1;
        private Button searchPet_Btn;
        private Button searchMode_Btn;
        private TextBox txtLocation;
        private Button backButton;
        private Panel SearchPet_Panel;
        private Panel advancedPanel;
        private Panel panel5;
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