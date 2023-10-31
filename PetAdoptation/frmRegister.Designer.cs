namespace PetAdoptation
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            pictureBox2 = new PictureBox();
            createAccount_Btn = new Button();
            PolicyCheckBox = new CheckBox();
            txtpwd4 = new PictureBox();
            txtUserEmail = new TextBox();
            pictureBox5 = new PictureBox();
            closeButton = new Button();
            txtUserName = new TextBox();
            psw_pic = new PictureBox();
            txtUserPwd = new TextBox();
            txtEmail_Warn = new Label();
            txtName_Warn = new Label();
            txtPwd_Warn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtpwd4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)psw_pic).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.meow;
            pictureBox2.Location = new Point(206, 122);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(414, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // createAccount_Btn
            // 
            createAccount_Btn.Anchor = AnchorStyles.Top;
            createAccount_Btn.BackColor = Color.Honeydew;
            createAccount_Btn.Cursor = Cursors.Hand;
            createAccount_Btn.FlatAppearance.MouseDownBackColor = Color.Honeydew;
            createAccount_Btn.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            createAccount_Btn.FlatStyle = FlatStyle.Flat;
            createAccount_Btn.Font = new Font("Yu Gothic UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            createAccount_Btn.ForeColor = SystemColors.ControlText;
            createAccount_Btn.Location = new Point(329, 363);
            createAccount_Btn.Margin = new Padding(2, 1, 2, 1);
            createAccount_Btn.Name = "createAccount_Btn";
            createAccount_Btn.Size = new Size(168, 38);
            createAccount_Btn.TabIndex = 8;
            createAccount_Btn.Text = "CREATE ACCOUNT";
            createAccount_Btn.UseVisualStyleBackColor = false;
            createAccount_Btn.Click += createAccount_Btn_Click;
            // 
            // PolicyCheckBox
            // 
            PolicyCheckBox.Anchor = AnchorStyles.Top;
            PolicyCheckBox.AutoSize = true;
            PolicyCheckBox.BackColor = Color.Transparent;
            PolicyCheckBox.Cursor = Cursors.Hand;
            PolicyCheckBox.Font = new Font("Yu Gothic UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            PolicyCheckBox.ForeColor = Color.Gray;
            PolicyCheckBox.ImageAlign = ContentAlignment.TopCenter;
            PolicyCheckBox.Location = new Point(261, 320);
            PolicyCheckBox.Margin = new Padding(2, 1, 2, 1);
            PolicyCheckBox.Name = "PolicyCheckBox";
            PolicyCheckBox.Padding = new Padding(5, 0, 3, 0);
            PolicyCheckBox.Size = new Size(284, 24);
            PolicyCheckBox.TabIndex = 9;
            PolicyCheckBox.Text = "I have read and agree Privacy Policy";
            PolicyCheckBox.UseVisualStyleBackColor = false;
            PolicyCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtpwd4
            // 
            txtpwd4.Anchor = AnchorStyles.Top;
            txtpwd4.Image = Properties.Resources.meow;
            txtpwd4.Location = new Point(206, 259);
            txtpwd4.Margin = new Padding(2, 1, 2, 1);
            txtpwd4.Name = "txtpwd4";
            txtpwd4.Size = new Size(415, 45);
            txtpwd4.SizeMode = PictureBoxSizeMode.StretchImage;
            txtpwd4.TabIndex = 11;
            txtpwd4.TabStop = false;
            txtpwd4.Click += txtpwd4_Click;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Anchor = AnchorStyles.Top;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BorderStyle = BorderStyle.None;
            txtUserEmail.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserEmail.ForeColor = Color.Gray;
            txtUserEmail.Location = new Point(226, 202);
            txtUserEmail.Margin = new Padding(2, 1, 2, 1);
            txtUserEmail.Multiline = true;
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.PlaceholderText = "Email";
            txtUserEmail.Size = new Size(369, 23);
            txtUserEmail.TabIndex = 18;
            txtUserEmail.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top;
            pictureBox5.Image = Properties.Resources.meow;
            pictureBox5.Location = new Point(206, 190);
            pictureBox5.Margin = new Padding(2, 1, 2, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(414, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.LightYellow;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.DarkSlateGray;
            closeButton.Location = new Point(22, 19);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(90, 33);
            closeButton.TabIndex = 21;
            closeButton.Text = "❮ BACK ";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Right;
            txtUserName.BackColor = SystemColors.ButtonFace;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.DimGray;
            txtUserName.Location = new Point(226, 134);
            txtUserName.Margin = new Padding(1);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Name";
            txtUserName.Size = new Size(369, 22);
            txtUserName.TabIndex = 22;
            // 
            // psw_pic
            // 
            psw_pic.BackgroundImage = Properties.Resources.pswIcon;
            psw_pic.BackgroundImageLayout = ImageLayout.Stretch;
            psw_pic.Cursor = Cursors.Hand;
            psw_pic.Location = new Point(578, 273);
            psw_pic.Margin = new Padding(2, 1, 2, 1);
            psw_pic.Name = "psw_pic";
            psw_pic.Size = new Size(25, 19);
            psw_pic.TabIndex = 24;
            psw_pic.TabStop = false;
            psw_pic.MouseDown += psw_pic_MouseDown;
            psw_pic.MouseUp += psw_pic_MouseUp;
            // 
            // txtUserPwd
            // 
            txtUserPwd.Anchor = AnchorStyles.Right;
            txtUserPwd.BackColor = SystemColors.ButtonFace;
            txtUserPwd.BorderStyle = BorderStyle.None;
            txtUserPwd.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPwd.ForeColor = Color.DimGray;
            txtUserPwd.Location = new Point(226, 272);
            txtUserPwd.Margin = new Padding(1);
            txtUserPwd.Name = "txtUserPwd";
            txtUserPwd.PlaceholderText = "Password";
            txtUserPwd.Size = new Size(350, 20);
            txtUserPwd.TabIndex = 25;
            txtUserPwd.UseSystemPasswordChar = true;
            // 
            // txtEmail_Warn
            // 
            txtEmail_Warn.AutoSize = true;
            txtEmail_Warn.BackColor = Color.Transparent;
            txtEmail_Warn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail_Warn.ForeColor = Color.OrangeRed;
            txtEmail_Warn.Location = new Point(625, 195);
            txtEmail_Warn.Name = "txtEmail_Warn";
            txtEmail_Warn.Size = new Size(20, 30);
            txtEmail_Warn.TabIndex = 26;
            txtEmail_Warn.Text = "!";
            txtEmail_Warn.Visible = false;
            // 
            // txtName_Warn
            // 
            txtName_Warn.AutoSize = true;
            txtName_Warn.BackColor = Color.Transparent;
            txtName_Warn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtName_Warn.ForeColor = Color.OrangeRed;
            txtName_Warn.Location = new Point(625, 126);
            txtName_Warn.Name = "txtName_Warn";
            txtName_Warn.Size = new Size(20, 30);
            txtName_Warn.TabIndex = 27;
            txtName_Warn.Text = "!";
            txtName_Warn.Visible = false;
            // 
            // txtPwd_Warn
            // 
            txtPwd_Warn.AutoSize = true;
            txtPwd_Warn.BackColor = Color.Transparent;
            txtPwd_Warn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPwd_Warn.ForeColor = Color.OrangeRed;
            txtPwd_Warn.Location = new Point(625, 264);
            txtPwd_Warn.Name = "txtPwd_Warn";
            txtPwd_Warn.Size = new Size(20, 30);
            txtPwd_Warn.TabIndex = 28;
            txtPwd_Warn.Text = "!";
            txtPwd_Warn.Visible = false;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 428);
            Controls.Add(txtPwd_Warn);
            Controls.Add(txtName_Warn);
            Controls.Add(txtEmail_Warn);
            Controls.Add(txtUserPwd);
            Controls.Add(psw_pic);
            Controls.Add(txtUserName);
            Controls.Add(closeButton);
            Controls.Add(txtUserEmail);
            Controls.Add(pictureBox5);
            Controls.Add(txtpwd4);
            Controls.Add(PolicyCheckBox);
            Controls.Add(createAccount_Btn);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtpwd4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)psw_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button createAccount_Btn;
        private TextBox txtUserEmail;
        private PictureBox pictureBox5;
        private PictureBox txtpwd4;
        private CheckBox PolicyCheckBox;
        private Button closeButton;
        private TextBox txtUserName;
        private PictureBox psw_pic;
        private TextBox txtUserPwd;
        private Label txtEmail_Warn;
        private Label txtName_Warn;
        private Label txtPwd_Warn;
    }
}