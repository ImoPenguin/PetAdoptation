namespace PetAdoptation
{
    partial class frmReturnPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnPets));
            panel2 = new Panel();
            panel3 = new Panel();
            panel11 = new Panel();
            checkBox3 = new CheckBox();
            panel9 = new Panel();
            txtPetId = new TextBox();
            pictureBox6 = new PictureBox();
            Location_panel = new Panel();
            txtLocation = new TextBox();
            pictureBox1 = new PictureBox();
            panel12 = new Panel();
            txtBreed = new TextBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            panel8 = new Panel();
            vaccinated_Combobx = new ComboBox();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel10 = new Panel();
            txtReturnReason = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel6 = new Panel();
            sex_Combobx = new ComboBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            PetType_Combobx = new ComboBox();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            age_Combobx = new ComboBox();
            pictureBox4 = new PictureBox();
            Adopt_lb = new Label();
            panel1 = new Panel();
            submit_Btn = new Button();
            backButton = new Button();
            closeButton = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            Location_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(27, 45);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1094, 318);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(21, 21);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1073, 287);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Controls.Add(checkBox3);
            panel11.Controls.Add(panel9);
            panel11.Controls.Add(Location_panel);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel8);
            panel11.Location = new Point(585, 7);
            panel11.Margin = new Padding(2, 1, 2, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(480, 267);
            panel11.TabIndex = 7;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Cursor = Cursors.Hand;
            checkBox3.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.FromArgb(132, 109, 97);
            checkBox3.ImageAlign = ContentAlignment.TopCenter;
            checkBox3.Location = new Point(18, 226);
            checkBox3.Margin = new Padding(1, 1, 1, 1);
            checkBox3.Name = "checkBox3";
            checkBox3.Padding = new Padding(5, 0, 3, 0);
            checkBox3.Size = new Size(132, 34);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Worming";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtPetId);
            panel9.Controls.Add(pictureBox6);
            panel9.Location = new Point(247, 75);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(219, 65);
            panel9.TabIndex = 6;
            // 
            // txtPetId
            // 
            txtPetId.BackColor = Color.FromArgb(253, 252, 245);
            txtPetId.BorderStyle = BorderStyle.None;
            txtPetId.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPetId.ForeColor = Color.FromArgb(203, 199, 183);
            txtPetId.Location = new Point(60, 15);
            txtPetId.Margin = new Padding(3, 2, 3, 2);
            txtPetId.Multiline = true;
            txtPetId.Name = "txtPetId";
            txtPetId.PlaceholderText = "Pet ID";
            txtPetId.RightToLeft = RightToLeft.No;
            txtPetId.Size = new Size(138, 34);
            txtPetId.TabIndex = 4;
            txtPetId.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(45, 7);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(165, 50);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // Location_panel
            // 
            Location_panel.Controls.Add(txtLocation);
            Location_panel.Controls.Add(pictureBox1);
            Location_panel.Location = new Point(3, 2);
            Location_panel.Margin = new Padding(3, 2, 3, 2);
            Location_panel.Name = "Location_panel";
            Location_panel.Size = new Size(463, 73);
            Location_panel.TabIndex = 4;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(253, 252, 245);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocation.ForeColor = Color.FromArgb(203, 199, 183);
            txtLocation.Location = new Point(80, 19);
            txtLocation.Margin = new Padding(3, 2, 3, 2);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Location";
            txtLocation.RightToLeft = RightToLeft.No;
            txtLocation.Size = new Size(363, 34);
            txtLocation.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 56);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtBreed);
            panel12.Controls.Add(pictureBox9);
            panel12.Controls.Add(pictureBox10);
            panel12.Location = new Point(0, 139);
            panel12.Margin = new Padding(2, 1, 2, 1);
            panel12.Name = "panel12";
            panel12.Size = new Size(466, 76);
            panel12.TabIndex = 6;
            // 
            // txtBreed
            // 
            txtBreed.BackColor = Color.FromArgb(253, 252, 245);
            txtBreed.BorderStyle = BorderStyle.None;
            txtBreed.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtBreed.ForeColor = Color.FromArgb(203, 199, 183);
            txtBreed.Location = new Point(87, 22);
            txtBreed.Margin = new Padding(3, 2, 3, 2);
            txtBreed.Multiline = true;
            txtBreed.Name = "txtBreed";
            txtBreed.PlaceholderText = "Breed";
            txtBreed.RightToLeft = RightToLeft.No;
            txtBreed.Size = new Size(359, 34);
            txtBreed.TabIndex = 4;
            txtBreed.TextChanged += txtBreed_TextChanged;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(253, 252, 245);
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(33, 21);
            pictureBox9.Margin = new Padding(2, 1, 2, 1);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 36);
            pictureBox9.TabIndex = 7;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(12, 10);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(442, 56);
            pictureBox10.TabIndex = 6;
            pictureBox10.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(vaccinated_Combobx);
            panel8.Controls.Add(pictureBox5);
            panel8.Location = new Point(0, 75);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(248, 65);
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
            vaccinated_Combobx.Location = new Point(76, 13);
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
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(checkBox2);
            panel5.Controls.Add(checkBox1);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(29, 7);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(466, 267);
            panel5.TabIndex = 6;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.FromArgb(132, 109, 97);
            checkBox2.ImageAlign = ContentAlignment.TopCenter;
            checkBox2.Location = new Point(277, 226);
            checkBox2.Margin = new Padding(1, 1, 1, 1);
            checkBox2.Name = "checkBox2";
            checkBox2.Padding = new Padding(5, 0, 3, 0);
            checkBox2.Size = new Size(177, 34);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Microchipped";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(132, 109, 97);
            checkBox1.ImageAlign = ContentAlignment.TopCenter;
            checkBox1.Location = new Point(16, 226);
            checkBox1.Margin = new Padding(1, 1, 1, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(5, 0, 3, 0);
            checkBox1.Size = new Size(132, 34);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Desexing";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtReturnReason);
            panel10.Controls.Add(pictureBox8);
            panel10.Controls.Add(pictureBox7);
            panel10.Location = new Point(0, 139);
            panel10.Margin = new Padding(2, 1, 2, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(466, 76);
            panel10.TabIndex = 6;
            // 
            // txtReturnReason
            // 
            txtReturnReason.BackColor = Color.FromArgb(253, 252, 245);
            txtReturnReason.BorderStyle = BorderStyle.None;
            txtReturnReason.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtReturnReason.ForeColor = Color.FromArgb(203, 199, 183);
            txtReturnReason.Location = new Point(87, 21);
            txtReturnReason.Margin = new Padding(3, 2, 3, 2);
            txtReturnReason.Multiline = true;
            txtReturnReason.Name = "txtReturnReason";
            txtReturnReason.PlaceholderText = "Reason to return";
            txtReturnReason.RightToLeft = RightToLeft.No;
            txtReturnReason.Size = new Size(346, 34);
            txtReturnReason.TabIndex = 4;
            txtReturnReason.TextChanged += txtReturnReason_TextChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(253, 252, 245);
            pictureBox8.BackgroundImage = Properties.Resources.Reason_to_return_3;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(36, 21);
            pictureBox8.Margin = new Padding(2, 1, 2, 1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 36);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(12, 10);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(442, 56);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(sex_Combobx);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(227, 75);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(239, 65);
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
            sex_Combobx.Location = new Point(87, 13);
            sex_Combobx.Margin = new Padding(3, 2, 3, 2);
            sex_Combobx.Name = "sex_Combobx";
            sex_Combobx.RightToLeft = RightToLeft.No;
            sex_Combobx.Size = new Size(131, 38);
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
            pictureBox3.Size = new Size(212, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(PetType_Combobx);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(466, 75);
            panel4.TabIndex = 5;
            // 
            // PetType_Combobx
            // 
            PetType_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            PetType_Combobx.FlatStyle = FlatStyle.Flat;
            PetType_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PetType_Combobx.ForeColor = Color.FromArgb(132, 109, 97);
            PetType_Combobx.FormattingEnabled = true;
            PetType_Combobx.Items.AddRange(new object[] { "Cat ", "Dog ", "Other " });
            PetType_Combobx.Location = new Point(87, 19);
            PetType_Combobx.Margin = new Padding(3, 2, 3, 2);
            PetType_Combobx.Name = "PetType_Combobx";
            PetType_Combobx.Size = new Size(348, 38);
            PetType_Combobx.TabIndex = 5;
            PetType_Combobx.Text = "Choose an animal type ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(442, 56);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(age_Combobx);
            panel7.Controls.Add(pictureBox4);
            panel7.Location = new Point(0, 75);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(228, 65);
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
            age_Combobx.Location = new Point(82, 13);
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
            pictureBox4.Location = new Point(12, 7);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(191, 50);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // Adopt_lb
            // 
            Adopt_lb.AutoSize = true;
            Adopt_lb.Font = new Font("Segoe UI", 31.875F, FontStyle.Bold, GraphicsUnit.Point);
            Adopt_lb.ForeColor = Color.FromArgb(81, 60, 41);
            Adopt_lb.Location = new Point(304, 6);
            Adopt_lb.Name = "Adopt_lb";
            Adopt_lb.Size = new Size(506, 59);
            Adopt_lb.TabIndex = 8;
            Adopt_lb.Text = "Return Your Rescuoodle";
            Adopt_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 215, 200);
            panel1.Controls.Add(submit_Btn);
            panel1.Controls.Add(Adopt_lb);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(25, 130);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 436);
            panel1.TabIndex = 1;
            // 
            // submit_Btn
            // 
            submit_Btn.BackColor = Color.FromArgb(111, 138, 129);
            submit_Btn.Cursor = Cursors.Hand;
            submit_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 138, 129);
            submit_Btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            submit_Btn.FlatStyle = FlatStyle.Flat;
            submit_Btn.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            submit_Btn.ForeColor = Color.FromArgb(255, 246, 229);
            submit_Btn.Location = new Point(27, 376);
            submit_Btn.Margin = new Padding(3, 2, 3, 2);
            submit_Btn.Name = "submit_Btn";
            submit_Btn.Size = new Size(1094, 44);
            submit_Btn.TabIndex = 9;
            submit_Btn.Text = "SUBMIT";
            submit_Btn.UseVisualStyleBackColor = false;
            submit_Btn.Click += submit_Btn_Click;
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
            backButton.Location = new Point(39, 30);
            backButton.Margin = new Padding(0);
            backButton.Name = "backButton";
            backButton.Size = new Size(127, 46);
            backButton.TabIndex = 25;
            backButton.Text = "❮ BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackColor = Color.IndianRed;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1305, 4);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(31, 26);
            closeButton.TabIndex = 29;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // frmReturnPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch10;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 600);
            Controls.Add(closeButton);
            Controls.Add(backButton);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmReturnPets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReturnPets";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            Location_panel.ResumeLayout(false);
            Location_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel Location_panel;
        private TextBox txtLocation;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private ComboBox sex_Combobx;
        private PictureBox pictureBox3;
        private Panel panel7;
        private ComboBox age_Combobx;
        private PictureBox pictureBox4;
        private Panel panel4;
        private ComboBox PetType_Combobx;
        private PictureBox pictureBox2;
        private Panel panel9;
        private TextBox txtPetId;
        private PictureBox pictureBox6;
        private Panel panel8;
        private ComboBox vaccinated_Combobx;
        private PictureBox pictureBox5;
        private Label Adopt_lb;
        private Panel panel1;
        private Panel panel10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private TextBox txtReturnReason;
        private Panel panel11;
        private Panel panel12;
        private TextBox txtBreed;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private Button submit_Btn;
        private Button backButton;
        private Button closeButton;
    }
}