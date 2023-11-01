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
            panel8 = new Panel();
            txtPetName = new TextBox();
            pictureBox5 = new PictureBox();
            vaccinated_checkBox = new CheckBox();
            worming_checkBox = new CheckBox();
            Location_panel = new Panel();
            txtLocation = new TextBox();
            pictureBox1 = new PictureBox();
            panel12 = new Panel();
            txtBreed = new TextBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            panel4 = new Panel();
            PetType_Label = new TextBox();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            notFound_Warn = new Label();
            seacrhButton = new Button();
            microchipped_checkBox = new CheckBox();
            panel9 = new Panel();
            txtPetId = new TextBox();
            pictureBox6 = new PictureBox();
            desexed_checkBox = new CheckBox();
            panel10 = new Panel();
            txtReturnReason = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel6 = new Panel();
            genderLabel = new TextBox();
            pictureBox3 = new PictureBox();
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
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            Location_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel11.Controls.Add(panel8);
            panel11.Controls.Add(vaccinated_checkBox);
            panel11.Controls.Add(worming_checkBox);
            panel11.Controls.Add(Location_panel);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel4);
            panel11.Location = new Point(585, 7);
            panel11.Margin = new Padding(2, 1, 2, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(480, 267);
            panel11.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtPetName);
            panel8.Controls.Add(pictureBox5);
            panel8.Location = new Point(231, 75);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(235, 65);
            panel8.TabIndex = 11;
            // 
            // txtPetName
            // 
            txtPetName.BackColor = Color.FromArgb(253, 252, 245);
            txtPetName.BorderStyle = BorderStyle.None;
            txtPetName.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPetName.ForeColor = Color.FromArgb(132, 109, 97);
            txtPetName.Location = new Point(36, 15);
            txtPetName.Margin = new Padding(3, 2, 3, 2);
            txtPetName.Multiline = true;
            txtPetName.Name = "txtPetName";
            txtPetName.PlaceholderText = "Pet Name";
            txtPetName.RightToLeft = RightToLeft.No;
            txtPetName.Size = new Size(168, 34);
            txtPetName.TabIndex = 4;
            txtPetName.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(12, 7);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(214, 50);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // vaccinated_checkBox
            // 
            vaccinated_checkBox.Anchor = AnchorStyles.Right;
            vaccinated_checkBox.AutoSize = true;
            vaccinated_checkBox.BackColor = Color.Transparent;
            vaccinated_checkBox.Cursor = Cursors.Hand;
            vaccinated_checkBox.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            vaccinated_checkBox.ForeColor = Color.FromArgb(132, 109, 97);
            vaccinated_checkBox.ImageAlign = ContentAlignment.TopCenter;
            vaccinated_checkBox.Location = new Point(310, 226);
            vaccinated_checkBox.Margin = new Padding(1);
            vaccinated_checkBox.Name = "vaccinated_checkBox";
            vaccinated_checkBox.Padding = new Padding(5, 0, 3, 0);
            vaccinated_checkBox.Size = new Size(147, 34);
            vaccinated_checkBox.TabIndex = 10;
            vaccinated_checkBox.Text = "Vaccinated";
            vaccinated_checkBox.TextAlign = ContentAlignment.MiddleCenter;
            vaccinated_checkBox.UseVisualStyleBackColor = false;
            // 
            // worming_checkBox
            // 
            worming_checkBox.Anchor = AnchorStyles.Right;
            worming_checkBox.AutoSize = true;
            worming_checkBox.BackColor = Color.Transparent;
            worming_checkBox.Cursor = Cursors.Hand;
            worming_checkBox.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            worming_checkBox.ForeColor = Color.FromArgb(132, 109, 97);
            worming_checkBox.ImageAlign = ContentAlignment.TopCenter;
            worming_checkBox.Location = new Point(18, 226);
            worming_checkBox.Margin = new Padding(1);
            worming_checkBox.Name = "worming_checkBox";
            worming_checkBox.Padding = new Padding(5, 0, 3, 0);
            worming_checkBox.Size = new Size(132, 34);
            worming_checkBox.TabIndex = 9;
            worming_checkBox.Text = "Worming";
            worming_checkBox.TextAlign = ContentAlignment.MiddleCenter;
            worming_checkBox.UseVisualStyleBackColor = false;
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
            txtLocation.Enabled = false;
            txtLocation.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocation.ForeColor = Color.FromArgb(203, 199, 183);
            txtLocation.Location = new Point(80, 19);
            txtLocation.Margin = new Padding(3, 2, 3, 2);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Location";
            txtLocation.RightToLeft = RightToLeft.No;
            txtLocation.Size = new Size(352, 34);
            txtLocation.TabIndex = 3;
            txtLocation.TextAlign = HorizontalAlignment.Center;
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
            txtBreed.Enabled = false;
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
            txtBreed.TextAlign = HorizontalAlignment.Center;
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
            pictureBox10.Size = new Size(445, 56);
            pictureBox10.TabIndex = 6;
            pictureBox10.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(PetType_Label);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(0, 75);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 65);
            panel4.TabIndex = 5;
            // 
            // PetType_Label
            // 
            PetType_Label.BackColor = Color.FromArgb(253, 252, 245);
            PetType_Label.BorderStyle = BorderStyle.None;
            PetType_Label.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PetType_Label.ForeColor = Color.FromArgb(132, 109, 97);
            PetType_Label.Location = new Point(57, 16);
            PetType_Label.Name = "PetType_Label";
            PetType_Label.PlaceholderText = "Animal Type";
            PetType_Label.Size = new Size(149, 29);
            PetType_Label.TabIndex = 6;
            PetType_Label.TextAlign = HorizontalAlignment.Center;
            PetType_Label.Click += PetType_Label_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 5);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 56);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(notFound_Warn);
            panel5.Controls.Add(seacrhButton);
            panel5.Controls.Add(microchipped_checkBox);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(desexed_checkBox);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(29, 7);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(466, 267);
            panel5.TabIndex = 6;
            // 
            // notFound_Warn
            // 
            notFound_Warn.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            notFound_Warn.ForeColor = Color.Red;
            notFound_Warn.Location = new Point(321, 21);
            notFound_Warn.Name = "notFound_Warn";
            notFound_Warn.Size = new Size(133, 42);
            notFound_Warn.TabIndex = 10;
            notFound_Warn.Text = "No Pet Found";
            notFound_Warn.TextAlign = ContentAlignment.MiddleCenter;
            notFound_Warn.Visible = false;
            // 
            // seacrhButton
            // 
            seacrhButton.BackColor = Color.FromArgb(111, 138, 129);
            seacrhButton.Cursor = Cursors.Hand;
            seacrhButton.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            seacrhButton.FlatStyle = FlatStyle.Flat;
            seacrhButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            seacrhButton.ForeColor = SystemColors.ButtonHighlight;
            seacrhButton.Location = new Point(242, 21);
            seacrhButton.Name = "seacrhButton";
            seacrhButton.Size = new Size(73, 42);
            seacrhButton.TabIndex = 30;
            seacrhButton.Text = "Search";
            seacrhButton.UseVisualStyleBackColor = false;
            seacrhButton.Click += button1_Click;
            // 
            // microchipped_checkBox
            // 
            microchipped_checkBox.Anchor = AnchorStyles.Right;
            microchipped_checkBox.AutoSize = true;
            microchipped_checkBox.BackColor = Color.Transparent;
            microchipped_checkBox.Cursor = Cursors.Hand;
            microchipped_checkBox.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            microchipped_checkBox.ForeColor = Color.FromArgb(132, 109, 97);
            microchipped_checkBox.ImageAlign = ContentAlignment.TopCenter;
            microchipped_checkBox.Location = new Point(277, 226);
            microchipped_checkBox.Margin = new Padding(1);
            microchipped_checkBox.Name = "microchipped_checkBox";
            microchipped_checkBox.Padding = new Padding(5, 0, 3, 0);
            microchipped_checkBox.Size = new Size(177, 34);
            microchipped_checkBox.TabIndex = 8;
            microchipped_checkBox.Text = "Microchipped";
            microchipped_checkBox.TextAlign = ContentAlignment.MiddleCenter;
            microchipped_checkBox.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtPetId);
            panel9.Controls.Add(pictureBox6);
            panel9.Location = new Point(0, 10);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(228, 65);
            panel9.TabIndex = 6;
            // 
            // txtPetId
            // 
            txtPetId.BackColor = Color.FromArgb(253, 252, 245);
            txtPetId.BorderStyle = BorderStyle.None;
            txtPetId.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPetId.ForeColor = Color.FromArgb(203, 199, 183);
            txtPetId.Location = new Point(36, 15);
            txtPetId.Margin = new Padding(3, 2, 3, 2);
            txtPetId.MaxLength = 4;
            txtPetId.Multiline = true;
            txtPetId.Name = "txtPetId";
            txtPetId.PlaceholderText = "Pet ID";
            txtPetId.RightToLeft = RightToLeft.No;
            txtPetId.Size = new Size(153, 34);
            txtPetId.TabIndex = 4;
            txtPetId.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(12, 7);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(198, 50);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // desexed_checkBox
            // 
            desexed_checkBox.Anchor = AnchorStyles.Right;
            desexed_checkBox.AutoSize = true;
            desexed_checkBox.BackColor = Color.Transparent;
            desexed_checkBox.Cursor = Cursors.Hand;
            desexed_checkBox.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            desexed_checkBox.ForeColor = Color.FromArgb(132, 109, 97);
            desexed_checkBox.ImageAlign = ContentAlignment.TopCenter;
            desexed_checkBox.Location = new Point(16, 226);
            desexed_checkBox.Margin = new Padding(1);
            desexed_checkBox.Name = "desexed_checkBox";
            desexed_checkBox.Padding = new Padding(5, 0, 3, 0);
            desexed_checkBox.Size = new Size(132, 34);
            desexed_checkBox.TabIndex = 7;
            desexed_checkBox.Text = "Desexing";
            desexed_checkBox.TextAlign = ContentAlignment.MiddleCenter;
            desexed_checkBox.UseVisualStyleBackColor = false;
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
            txtReturnReason.TextAlign = HorizontalAlignment.Center;
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
            panel6.Controls.Add(genderLabel);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(227, 75);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(239, 65);
            panel6.TabIndex = 4;
            // 
            // genderLabel
            // 
            genderLabel.BackColor = Color.FromArgb(253, 252, 245);
            genderLabel.BorderStyle = BorderStyle.None;
            genderLabel.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            genderLabel.ForeColor = Color.FromArgb(132, 109, 97);
            genderLabel.Location = new Point(94, 16);
            genderLabel.Name = "genderLabel";
            genderLabel.PlaceholderText = "Gender";
            genderLabel.Size = new Size(112, 29);
            genderLabel.TabIndex = 10;
            genderLabel.TextAlign = HorizontalAlignment.Center;
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
            age_Combobx.Items.AddRange(new object[] { "Young", "Adult", "Senior" });
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
            pictureBox4.Size = new Size(198, 50);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // Adopt_lb
            // 
            Adopt_lb.Font = new Font("Segoe UI", 31.875F, FontStyle.Bold, GraphicsUnit.Point);
            Adopt_lb.ForeColor = Color.FromArgb(81, 60, 41);
            Adopt_lb.Location = new Point(27, 6);
            Adopt_lb.Name = "Adopt_lb";
            Adopt_lb.Size = new Size(1094, 59);
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
            submit_Btn.Location = new Point(27, 367);
            submit_Btn.Margin = new Padding(3, 2, 3, 2);
            submit_Btn.Name = "submit_Btn";
            submit_Btn.Size = new Size(1094, 53);
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
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            Location_panel.ResumeLayout(false);
            Location_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
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
        private PictureBox pictureBox3;
        private Panel panel7;
        private ComboBox age_Combobx;
        private PictureBox pictureBox4;
        private Panel panel4;
        private TextBox PetType_Label;
        private PictureBox pictureBox2;
        private Panel panel9;
        private TextBox txtPetId;
        private PictureBox pictureBox6;
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
        private CheckBox microchipped_checkBox;
        private CheckBox desexed_checkBox;
        private CheckBox worming_checkBox;
        private Button submit_Btn;
        private Button backButton;
        private Button closeButton;
        private CheckBox vaccinated_checkBox;
        private Button seacrhButton;
        private Label notFound_Warn;
        private TextBox genderLabel;
        private Label label1;
        private Panel panel8;
        private TextBox txtPetName;
        private PictureBox pictureBox5;
    }
}