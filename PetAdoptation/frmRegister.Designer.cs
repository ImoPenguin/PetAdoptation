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
            textBox1 = new TextBox();
            pictureBox5 = new PictureBox();
            closeButton = new Button();
            txtUserID = new TextBox();
            txtPwd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtpwd4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.meow;
            pictureBox2.Location = new Point(235, 163);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(473, 60);
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
            createAccount_Btn.Location = new Point(376, 484);
            createAccount_Btn.Margin = new Padding(2, 1, 2, 1);
            createAccount_Btn.Name = "createAccount_Btn";
            createAccount_Btn.Size = new Size(192, 51);
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
            PolicyCheckBox.Location = new Point(298, 427);
            PolicyCheckBox.Margin = new Padding(2, 1, 2, 1);
            PolicyCheckBox.Name = "PolicyCheckBox";
            PolicyCheckBox.Padding = new Padding(6, 0, 3, 0);
            PolicyCheckBox.Size = new Size(351, 29);
            PolicyCheckBox.TabIndex = 9;
            PolicyCheckBox.Text = "I have read and agree Privacy Policy";
            PolicyCheckBox.UseVisualStyleBackColor = false;
            PolicyCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtpwd4
            // 
            txtpwd4.Anchor = AnchorStyles.Top;
            txtpwd4.Image = Properties.Resources.meow;
            txtpwd4.Location = new Point(235, 345);
            txtpwd4.Margin = new Padding(2, 1, 2, 1);
            txtpwd4.Name = "txtpwd4";
            txtpwd4.Size = new Size(474, 60);
            txtpwd4.SizeMode = PictureBoxSizeMode.StretchImage;
            txtpwd4.TabIndex = 11;
            txtpwd4.TabStop = false;
            txtpwd4.Click += txtpwd4_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(258, 269);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email";
            textBox1.Size = new Size(422, 31);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top;
            pictureBox5.Image = Properties.Resources.meow;
            pictureBox5.Location = new Point(235, 253);
            pictureBox5.Margin = new Padding(2, 1, 2, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(473, 64);
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
            closeButton.Location = new Point(25, 25);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(103, 44);
            closeButton.TabIndex = 21;
            closeButton.Text = "❮ BACK ";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // txtUserID
            // 
            txtUserID.Anchor = AnchorStyles.Right;
            txtUserID.BackColor = SystemColors.ButtonFace;
            txtUserID.BorderStyle = BorderStyle.None;
            txtUserID.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.ForeColor = Color.DimGray;
            txtUserID.Location = new Point(258, 178);
            txtUserID.Margin = new Padding(1);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.PlaceholderText = "Name";
            txtUserID.Size = new Size(422, 29);
            txtUserID.TabIndex = 22;
            // 
            // txtPwd
            // 
            txtPwd.Anchor = AnchorStyles.Right;
            txtPwd.BackColor = SystemColors.ButtonFace;
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPwd.ForeColor = Color.DimGray;
            txtPwd.Location = new Point(258, 361);
            txtPwd.Margin = new Padding(1);
            txtPwd.Multiline = true;
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '●';
            txtPwd.PlaceholderText = "Password";
            txtPwd.Size = new Size(422, 30);
            txtPwd.TabIndex = 23;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(957, 571);
            Controls.Add(txtPwd);
            Controls.Add(txtUserID);
            Controls.Add(closeButton);
            Controls.Add(textBox1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button createAccount_Btn;
        private TextBox textBox1;
        private PictureBox pictureBox5;
        private PictureBox txtpwd4;
        private CheckBox PolicyCheckBox;
        private Button closeButton;
        private TextBox txtUserID;
        private TextBox txtPwd;
    }
}