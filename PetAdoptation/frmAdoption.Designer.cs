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
            panel1 = new Panel();
            submit_Btn = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            petType_label = new Label();
            pictureBox12 = new PictureBox();
            label3 = new Label();
            pictureBox13 = new PictureBox();
            panel8 = new Panel();
            txtpetID = new TextBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel10 = new Panel();
            txtState = new TextBox();
            txtPostalCode = new TextBox();
            pictureBox11 = new PictureBox();
            pictureBox8 = new PictureBox();
            txtCity = new TextBox();
            pictureBox7 = new PictureBox();
            txtUserAddress = new TextBox();
            label4 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            panel4 = new Panel();
            panel6 = new Panel();
            txtPhoneNum = new TextBox();
            label1 = new Label();
            phoneNum_pic = new PictureBox();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            txtEmail = new TextBox();
            emailAddr_label = new Label();
            emailAddr_Pic = new PictureBox();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            userName_label = new Label();
            userName_Pic = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Adopt_lb = new Label();
            backButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phoneNum_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emailAddr_Pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userName_Pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 215, 200);
            panel1.Controls.Add(submit_Btn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Adopt_lb);
            panel1.Location = new Point(23, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 624);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            submit_Btn.Location = new Point(19, 540);
            submit_Btn.Name = "submit_Btn";
            submit_Btn.Size = new Size(1276, 58);
            submit_Btn.TabIndex = 6;
            submit_Btn.Text = "SUBMIT";
            submit_Btn.UseVisualStyleBackColor = false;
            submit_Btn.Click += submit_Btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(19, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1276, 505);
            panel2.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel10);
            panel7.Location = new Point(664, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(587, 477);
            panel7.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.Controls.Add(petType_label);
            panel9.Controls.Add(pictureBox12);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(pictureBox13);
            panel9.Location = new Point(302, 325);
            panel9.Name = "panel9";
            panel9.Size = new Size(281, 135);
            panel9.TabIndex = 13;
            // 
            // petType_label
            // 
            petType_label.AutoSize = true;
            petType_label.BackColor = Color.FromArgb(253, 252, 245);
            petType_label.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            petType_label.ForeColor = Color.FromArgb(132, 109, 97);
            petType_label.Location = new Point(76, 65);
            petType_label.Name = "petType_label";
            petType_label.Size = new Size(102, 31);
            petType_label.TabIndex = 11;
            petType_label.Text = "Pet Type";
            petType_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = (Image)resources.GetObject("pictureBox12.BackgroundImage");
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.Location = new Point(0, 53);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(255, 56);
            pictureBox12.TabIndex = 10;
            pictureBox12.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(91, 66, 18);
            label3.Location = new Point(62, 9);
            label3.Name = "label3";
            label3.Size = new Size(162, 38);
            label3.TabIndex = 2;
            label3.Text = "Type Of Pet";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = (Image)resources.GetObject("pictureBox13.BackgroundImage");
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.Location = new Point(28, 15);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 32);
            pictureBox13.TabIndex = 2;
            pictureBox13.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtpetID);
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(pictureBox3);
            panel8.Location = new Point(9, 325);
            panel8.Name = "panel8";
            panel8.Size = new Size(281, 135);
            panel8.TabIndex = 7;
            // 
            // txtpetID
            // 
            txtpetID.BackColor = Color.FromArgb(253, 252, 245);
            txtpetID.BorderStyle = BorderStyle.None;
            txtpetID.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtpetID.ForeColor = Color.FromArgb(132, 109, 97);
            txtpetID.Location = new Point(35, 65);
            txtpetID.Name = "txtpetID";
            txtpetID.PlaceholderText = "Pet ID";
            txtpetID.Size = new Size(218, 31);
            txtpetID.TabIndex = 12;
            txtpetID.TextAlign = HorizontalAlignment.Center;
            txtpetID.TextChanged += txtpetID_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(14, 53);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(255, 56);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(91, 66, 18);
            label2.Location = new Point(69, 8);
            label2.Name = "label2";
            label2.Size = new Size(93, 38);
            label2.TabIndex = 2;
            label2.Text = "Pet ID";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(35, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 28);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtState);
            panel10.Controls.Add(txtPostalCode);
            panel10.Controls.Add(pictureBox11);
            panel10.Controls.Add(pictureBox8);
            panel10.Controls.Add(txtCity);
            panel10.Controls.Add(pictureBox7);
            panel10.Controls.Add(txtUserAddress);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(pictureBox9);
            panel10.Controls.Add(pictureBox10);
            panel10.Location = new Point(9, 13);
            panel10.Name = "panel10";
            panel10.Size = new Size(564, 293);
            panel10.TabIndex = 1;
            // 
            // txtState
            // 
            txtState.BackColor = Color.FromArgb(253, 252, 245);
            txtState.BorderStyle = BorderStyle.None;
            txtState.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtState.ForeColor = Color.FromArgb(132, 109, 97);
            txtState.Location = new Point(315, 221);
            txtState.Name = "txtState";
            txtState.PlaceholderText = "State";
            txtState.Size = new Size(218, 31);
            txtState.TabIndex = 12;
            txtState.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.FromArgb(253, 252, 245);
            txtPostalCode.BorderStyle = BorderStyle.None;
            txtPostalCode.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPostalCode.ForeColor = Color.FromArgb(132, 109, 97);
            txtPostalCode.Location = new Point(35, 220);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.PlaceholderText = "Postal code";
            txtPostalCode.Size = new Size(218, 31);
            txtPostalCode.TabIndex = 11;
            txtPostalCode.TextAlign = HorizontalAlignment.Center;
            txtPostalCode.TextChanged += txtPostalCode_TextChanged;
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImage = (Image)resources.GetObject("pictureBox11.BackgroundImage");
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(293, 208);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(255, 56);
            pictureBox11.TabIndex = 10;
            pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(14, 208);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(255, 56);
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(253, 252, 245);
            txtCity.BorderStyle = BorderStyle.None;
            txtCity.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtCity.ForeColor = Color.FromArgb(132, 109, 97);
            txtCity.Location = new Point(35, 142);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(498, 31);
            txtCity.TabIndex = 8;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(14, 131);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(534, 56);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // txtUserAddress
            // 
            txtUserAddress.BackColor = Color.FromArgb(253, 252, 245);
            txtUserAddress.BorderStyle = BorderStyle.None;
            txtUserAddress.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserAddress.ForeColor = Color.FromArgb(132, 109, 97);
            txtUserAddress.Location = new Point(35, 64);
            txtUserAddress.Name = "txtUserAddress";
            txtUserAddress.PlaceholderText = "Street address";
            txtUserAddress.Size = new Size(498, 31);
            txtUserAddress.TabIndex = 5;
            txtUserAddress.TextChanged += txtUserAddress_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(91, 66, 18);
            label4.Location = new Point(69, 9);
            label4.Name = "label4";
            label4.Size = new Size(191, 38);
            label4.TabIndex = 2;
            label4.Text = "Address Line*";
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(35, 15);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(28, 32);
            pictureBox9.TabIndex = 2;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(14, 53);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(534, 56);
            pictureBox10.TabIndex = 6;
            pictureBox10.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(587, 477);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtPhoneNum);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(phoneNum_pic);
            panel6.Controls.Add(pictureBox4);
            panel6.Location = new Point(9, 325);
            panel6.Name = "panel6";
            panel6.Size = new Size(564, 135);
            panel6.TabIndex = 7;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.BackColor = Color.FromArgb(253, 252, 245);
            txtPhoneNum.BorderStyle = BorderStyle.None;
            txtPhoneNum.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNum.ForeColor = Color.FromArgb(132, 109, 97);
            txtPhoneNum.Location = new Point(35, 65);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.PlaceholderText = "Your phone number";
            txtPhoneNum.Size = new Size(498, 31);
            txtPhoneNum.TabIndex = 5;
            txtPhoneNum.TextChanged += txtPhoneNum_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(91, 66, 18);
            label1.Location = new Point(69, 8);
            label1.Name = "label1";
            label1.Size = new Size(221, 38);
            label1.TabIndex = 2;
            label1.Text = "Phone Number*";
            // 
            // phoneNum_pic
            // 
            phoneNum_pic.BackgroundImage = (Image)resources.GetObject("phoneNum_pic.BackgroundImage");
            phoneNum_pic.BackgroundImageLayout = ImageLayout.Stretch;
            phoneNum_pic.Location = new Point(35, 15);
            phoneNum_pic.Name = "phoneNum_pic";
            phoneNum_pic.Size = new Size(28, 28);
            phoneNum_pic.TabIndex = 2;
            phoneNum_pic.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(14, 53);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(534, 56);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtEmail);
            panel5.Controls.Add(emailAddr_label);
            panel5.Controls.Add(emailAddr_Pic);
            panel5.Controls.Add(pictureBox6);
            panel5.Location = new Point(9, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(564, 138);
            panel5.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(253, 252, 245);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(132, 109, 97);
            txtEmail.Location = new Point(35, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Your email";
            txtEmail.Size = new Size(498, 31);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // emailAddr_label
            // 
            emailAddr_label.AutoSize = true;
            emailAddr_label.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            emailAddr_label.ForeColor = Color.FromArgb(91, 66, 18);
            emailAddr_label.Location = new Point(69, 5);
            emailAddr_label.Name = "emailAddr_label";
            emailAddr_label.Size = new Size(208, 38);
            emailAddr_label.TabIndex = 2;
            emailAddr_label.Text = "Email Address*";
            // 
            // emailAddr_Pic
            // 
            emailAddr_Pic.BackgroundImage = (Image)resources.GetObject("emailAddr_Pic.BackgroundImage");
            emailAddr_Pic.BackgroundImageLayout = ImageLayout.Stretch;
            emailAddr_Pic.Location = new Point(35, 17);
            emailAddr_Pic.Name = "emailAddr_Pic";
            emailAddr_Pic.Size = new Size(28, 21);
            emailAddr_Pic.TabIndex = 2;
            emailAddr_Pic.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(14, 53);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(534, 56);
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(userName_label);
            panel3.Controls.Add(userName_Pic);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(9, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 133);
            panel3.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(253, 252, 245);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.ForeColor = Color.FromArgb(132, 109, 97);
            txtFirstName.Location = new Point(35, 65);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(221, 31);
            txtFirstName.TabIndex = 5;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(253, 252, 245);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.ForeColor = Color.FromArgb(132, 109, 97);
            txtLastName.Location = new Point(312, 65);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(221, 31);
            txtLastName.TabIndex = 4;
            // 
            // userName_label
            // 
            userName_label.AutoSize = true;
            userName_label.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            userName_label.ForeColor = Color.FromArgb(91, 66, 18);
            userName_label.Location = new Point(66, 12);
            userName_label.Name = "userName_label";
            userName_label.Size = new Size(93, 38);
            userName_label.TabIndex = 2;
            userName_label.Text = "Name";
            // 
            // userName_Pic
            // 
            userName_Pic.BackgroundImage = (Image)resources.GetObject("userName_Pic.BackgroundImage");
            userName_Pic.BackgroundImageLayout = ImageLayout.Stretch;
            userName_Pic.Location = new Point(32, 15);
            userName_Pic.Name = "userName_Pic";
            userName_Pic.Size = new Size(28, 32);
            userName_Pic.TabIndex = 2;
            userName_Pic.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(293, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(255, 56);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(14, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Adopt_lb
            // 
            Adopt_lb.AutoSize = true;
            Adopt_lb.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            Adopt_lb.ForeColor = Color.FromArgb(81, 60, 41);
            Adopt_lb.Location = new Point(486, 1);
            Adopt_lb.Name = "Adopt_lb";
            Adopt_lb.Size = new Size(349, 62);
            Adopt_lb.TabIndex = 2;
            Adopt_lb.Text = "Adoption Form";
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
            backButton.TabIndex = 24;
            backButton.Text = "❮ BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // frmAdoption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1371, 800);
            Controls.Add(backButton);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdoption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdoption";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phoneNum_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emailAddr_Pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userName_Pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox userName_Pic;
        private Panel panel4;
        private Label userName_label;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Panel panel5;
        private TextBox txtEmail;
        private Label emailAddr_label;
        private PictureBox emailAddr_Pic;
        private PictureBox pictureBox6;
        private Panel panel6;
        private TextBox txtPhoneNum;
        private Label label1;
        private PictureBox phoneNum_pic;
        private PictureBox pictureBox4;
        private Panel panel7;
        private Panel panel8;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel panel10;
        private TextBox txtUserAddress;
        private Label label4;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private TextBox txtCity;
        private PictureBox pictureBox7;
        private TextBox txtState;
        private TextBox txtPostalCode;
        private PictureBox pictureBox11;
        private PictureBox pictureBox8;
        private TextBox txtpetID;
        private PictureBox pictureBox5;
        private Panel panel9;
        private Label petType_label;
        private PictureBox pictureBox12;
        private Label label3;
        private PictureBox pictureBox13;
        private Button submit_Btn;
        private Button backButton;
        private Label Adopt_lb;
    }
}