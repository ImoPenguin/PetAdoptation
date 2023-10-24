﻿namespace PetAdoptation
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtIcon2 = new PictureBox();
            checkBox1 = new CheckBox();
            loginButton1 = new Button();
            bRegistered = new Button();
            txtPwd = new TextBox();
            txtUserID = new TextBox();
            pictureBox2 = new PictureBox();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIcon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(837, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(610, 136);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 1;
            label1.Text = "Get Start";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtIcon2
            // 
            txtIcon2.Anchor = AnchorStyles.Right;
            txtIcon2.Image = Properties.Resources.Screenshot_2023_10_19_at_4_20_52_pm;
            txtIcon2.Location = new Point(537, 248);
            txtIcon2.Margin = new Padding(1);
            txtIcon2.Name = "txtIcon2";
            txtIcon2.Size = new Size(262, 45);
            txtIcon2.SizeMode = PictureBoxSizeMode.StretchImage;
            txtIcon2.TabIndex = 3;
            txtIcon2.TabStop = false;
            txtIcon2.Click += pictureBox3_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.DarkSeaGreen;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Yu Gothic UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ControlLight;
            checkBox1.ImageAlign = ContentAlignment.TopCenter;
            checkBox1.Location = new Point(598, 304);
            checkBox1.Margin = new Padding(1);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(5, 0, 3, 0);
            checkBox1.Size = new Size(138, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Keep Me Login";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginButton1
            // 
            loginButton1.Anchor = AnchorStyles.Right;
            loginButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton1.BackColor = Color.AntiqueWhite;
            loginButton1.Cursor = Cursors.Hand;
            loginButton1.Font = new Font("Yu Gothic UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton1.ForeColor = SystemColors.WindowFrame;
            loginButton1.Location = new Point(537, 353);
            loginButton1.Margin = new Padding(1);
            loginButton1.Name = "loginButton1";
            loginButton1.Size = new Size(108, 33);
            loginButton1.TabIndex = 7;
            loginButton1.Text = "LOGIN";
            loginButton1.UseVisualStyleBackColor = false;
            loginButton1.Click += bLogin_Click;
            // 
            // bRegistered
            // 
            bRegistered.Anchor = AnchorStyles.Right;
            bRegistered.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bRegistered.BackColor = Color.DarkSeaGreen;
            bRegistered.Cursor = Cursors.Hand;
            bRegistered.Font = new Font("Yu Gothic UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            bRegistered.ForeColor = Color.AntiqueWhite;
            bRegistered.Location = new Point(691, 353);
            bRegistered.Margin = new Padding(1);
            bRegistered.Name = "bRegistered";
            bRegistered.Size = new Size(108, 33);
            bRegistered.TabIndex = 10;
            bRegistered.Text = "Register";
            bRegistered.UseVisualStyleBackColor = false;
            bRegistered.Click += bRegistered_Click_1;
            // 
            // txtPwd
            // 
            txtPwd.Anchor = AnchorStyles.Right;
            txtPwd.BackColor = SystemColors.ButtonFace;
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPwd.ForeColor = Color.DimGray;
            txtPwd.Location = new Point(561, 260);
            txtPwd.Margin = new Padding(1);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '●';
            txtPwd.PlaceholderText = "Password";
            txtPwd.Size = new Size(215, 20);
            txtPwd.TabIndex = 12;
            txtPwd.TextChanged += txtPwd_TextChanged;
            // 
            // txtUserID
            // 
            txtUserID.Anchor = AnchorStyles.Right;
            txtUserID.BackColor = SystemColors.ButtonFace;
            txtUserID.BorderStyle = BorderStyle.None;
            txtUserID.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.ForeColor = Color.DimGray;
            txtUserID.Location = new Point(561, 203);
            txtUserID.Margin = new Padding(1);
            txtUserID.Name = "txtUserID";
            txtUserID.PlaceholderText = "User ID";
            txtUserID.Size = new Size(215, 20);
            txtUserID.TabIndex = 12;
            txtUserID.TextChanged += txtUserID_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2023_10_19_at_4_20_52_pm;
            pictureBox2.Location = new Point(537, 189);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(262, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
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
            closeButton.TabIndex = 14;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += button1_Click_1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 428);
            Controls.Add(closeButton);
            Controls.Add(txtUserID);
            Controls.Add(pictureBox2);
            Controls.Add(txtPwd);
            Controls.Add(bRegistered);
            Controls.Add(checkBox1);
            Controls.Add(loginButton1);
            Controls.Add(txtIcon2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIcon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox txtIcon2;
        private TextBox txtUserID;
        private CheckBox checkBox1;
        private Button loginButton1;
        private Button bRegistered;
        private TextBox txtPwd;
        private PictureBox pictureBox2;
        private Button closeButton;
    }
}