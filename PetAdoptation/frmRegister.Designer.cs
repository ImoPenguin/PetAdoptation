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
            lbUserID = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUserID = new TextBox();
            textBox1 = new TextBox();
            newPwd_TextBox = new TextBox();
            pictureBox5 = new PictureBox();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtpwd4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            createAccount_Btn.FlatAppearance.MouseOverBackColor = Color.Yellow;
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
            // lbUserID
            // 
            lbUserID.Anchor = AnchorStyles.Top;
            lbUserID.AutoSize = true;
            lbUserID.BackColor = SystemColors.ButtonFace;
            lbUserID.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserID.ForeColor = Color.DarkGray;
            lbUserID.Location = new Point(226, 137);
            lbUserID.Margin = new Padding(2, 0, 2, 0);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(43, 17);
            lbUserID.TabIndex = 14;
            lbUserID.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(226, 272);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 15;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(226, 204);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 16;
            label2.Text = "Email";
            label2.Click += label2_Click_1;
            // 
            // txtUserID
            // 
            txtUserID.Anchor = AnchorStyles.Top;
            txtUserID.BackColor = SystemColors.ButtonFace;
            txtUserID.BorderStyle = BorderStyle.None;
            txtUserID.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.ForeColor = Color.Gray;
            txtUserID.Location = new Point(307, 134);
            txtUserID.Margin = new Padding(2, 1, 2, 1);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(288, 21);
            txtUserID.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(307, 204);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 21);
            textBox1.TabIndex = 18;
            // 
            // newPwd_TextBox
            // 
            newPwd_TextBox.Anchor = AnchorStyles.Top;
            newPwd_TextBox.BackColor = SystemColors.ButtonFace;
            newPwd_TextBox.BorderStyle = BorderStyle.None;
            newPwd_TextBox.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPwd_TextBox.ForeColor = Color.Gray;
            newPwd_TextBox.Location = new Point(307, 271);
            newPwd_TextBox.Margin = new Padding(2, 1, 2, 1);
            newPwd_TextBox.Multiline = true;
            newPwd_TextBox.Name = "newPwd_TextBox";
            newPwd_TextBox.Size = new Size(288, 20);
            newPwd_TextBox.TabIndex = 19;
            newPwd_TextBox.TextChanged += textBox2_TextChanged;
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
            closeButton.BackColor = Color.IndianRed;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(803, 9);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 25);
            closeButton.TabIndex = 21;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 428);
            Controls.Add(closeButton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox5);
            Controls.Add(newPwd_TextBox);
            Controls.Add(txtUserID);
            Controls.Add(label1);
            Controls.Add(lbUserID);
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
        private Label lbUserID;
        private Label label1;
        private Label label2;
        private TextBox txtUserID;
        private TextBox textBox1;
        private TextBox newPwd_TextBox;
        private PictureBox pictureBox5;
        private PictureBox txtpwd4;
        private CheckBox PolicyCheckBox;
        private Button closeButton;
    }
}