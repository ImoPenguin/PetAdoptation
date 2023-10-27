namespace PetAdoptation
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            pictureBox1 = new PictureBox();
            catPanel = new Panel();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            categoriesLabel = new Label();
            dogPanel = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            otherPanel = new Panel();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            adoptBtn = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            sideMenuButton = new Button();
            closeButton = new Button();
            sideMenuPanel = new Panel();
            panel1 = new Panel();
            logOut_btn = new Button();
            staffButton = new Panel();
            staffLabel = new Label();
            staffIcon = new PictureBox();
            profileButton = new Panel();
            profileLabel = new Label();
            profileIcon = new PictureBox();
            homeButton = new Panel();
            homeLabel = new Label();
            homeIcon = new PictureBox();
            backButton = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            catPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            dogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            otherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            sideMenuPanel.SuspendLayout();
            panel1.SuspendLayout();
            staffButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffIcon).BeginInit();
            profileButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIcon).BeginInit();
            homeButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // catPanel
            // 
            catPanel.BackColor = Color.BlanchedAlmond;
            catPanel.Controls.Add(button1);
            catPanel.Controls.Add(pictureBox3);
            catPanel.Location = new Point(270, 398);
            catPanel.Margin = new Padding(3, 2, 3, 2);
            catPanel.Name = "catPanel";
            catPanel.Size = new Size(170, 148);
            catPanel.TabIndex = 0;
            catPanel.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.LightYellow;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 109);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(120, 31);
            button1.TabIndex = 3;
            button1.Text = "Cat";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(35, -8);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 110);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // categoriesLabel
            // 
            categoriesLabel.Anchor = AnchorStyles.Right;
            categoriesLabel.AutoSize = true;
            categoriesLabel.BackColor = Color.Transparent;
            categoriesLabel.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoriesLabel.ForeColor = Color.SaddleBrown;
            categoriesLabel.Location = new Point(11, 340);
            categoriesLabel.Margin = new Padding(2, 0, 2, 0);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(119, 30);
            categoriesLabel.TabIndex = 2;
            categoriesLabel.Text = "Categories";
            categoriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dogPanel
            // 
            dogPanel.BackColor = Color.BlanchedAlmond;
            dogPanel.Controls.Add(button2);
            dogPanel.Controls.Add(pictureBox2);
            dogPanel.Location = new Point(520, 398);
            dogPanel.Margin = new Padding(3, 2, 3, 2);
            dogPanel.Name = "dogPanel";
            dogPanel.Size = new Size(170, 148);
            dogPanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.LightYellow;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(25, 109);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(120, 31);
            button2.TabIndex = 4;
            button2.Text = "Dog";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(35, -10);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 110);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // otherPanel
            // 
            otherPanel.BackColor = Color.BlanchedAlmond;
            otherPanel.Controls.Add(button3);
            otherPanel.Controls.Add(pictureBox4);
            otherPanel.Location = new Point(770, 398);
            otherPanel.Margin = new Padding(3, 2, 3, 2);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new Size(170, 148);
            otherPanel.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.LightYellow;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(25, 109);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(120, 31);
            button3.TabIndex = 5;
            button3.Text = "Other";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(35, -10);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 110);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // adoptBtn
            // 
            adoptBtn.BackColor = Color.LightYellow;
            adoptBtn.Cursor = Cursors.Hand;
            adoptBtn.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            adoptBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            adoptBtn.FlatStyle = FlatStyle.Flat;
            adoptBtn.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            adoptBtn.ForeColor = SystemColors.ControlText;
            adoptBtn.Location = new Point(760, 147);
            adoptBtn.Margin = new Padding(3, 2, 3, 2);
            adoptBtn.Name = "adoptBtn";
            adoptBtn.Size = new Size(180, 54);
            adoptBtn.TabIndex = 5;
            adoptBtn.Text = "ADOPT NOW";
            adoptBtn.UseVisualStyleBackColor = false;
            adoptBtn.Click += adoptBtn_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.BackColor = Color.LightYellow;
            button5.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(1052, 398);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(136, 40);
            button5.TabIndex = 5;
            button5.Text = "Show All";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.BackColor = Color.LightYellow;
            button6.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(1052, 507);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(136, 40);
            button6.TabIndex = 6;
            button6.Text = "Search ID";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Right;
            button7.BackColor = Color.LightYellow;
            button7.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(1052, 452);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(136, 40);
            button7.TabIndex = 7;
            button7.Text = "Return Pet";
            button7.UseVisualStyleBackColor = false;
            // 
            // sideMenuButton
            // 
            sideMenuButton.BackColor = Color.LightYellow;
            sideMenuButton.BackgroundImage = (Image)resources.GetObject("sideMenuButton.BackgroundImage");
            sideMenuButton.BackgroundImageLayout = ImageLayout.Zoom;
            sideMenuButton.Cursor = Cursors.Hand;
            sideMenuButton.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            sideMenuButton.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            sideMenuButton.FlatStyle = FlatStyle.Flat;
            sideMenuButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sideMenuButton.Location = new Point(11, 34);
            sideMenuButton.Margin = new Padding(3, 2, 3, 2);
            sideMenuButton.Name = "sideMenuButton";
            sideMenuButton.Size = new Size(67, 35);
            sideMenuButton.TabIndex = 8;
            sideMenuButton.UseVisualStyleBackColor = false;
            sideMenuButton.Click += SideMenuButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.IndianRed;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1161, 9);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(31, 26);
            closeButton.TabIndex = 22;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sideMenuPanel.BackColor = Color.FromArgb(203, 199, 183);
            sideMenuPanel.Controls.Add(panel1);
            sideMenuPanel.Controls.Add(staffButton);
            sideMenuPanel.Controls.Add(profileButton);
            sideMenuPanel.Controls.Add(homeButton);
            sideMenuPanel.Controls.Add(backButton);
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Margin = new Padding(3, 2, 3, 2);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(275, 600);
            sideMenuPanel.TabIndex = 23;
            sideMenuPanel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(logOut_btn);
            panel1.Location = new Point(0, 532);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 68);
            panel1.TabIndex = 10;
            // 
            // logOut_btn
            // 
            logOut_btn.BackColor = Color.FromArgb(248, 123, 110);
            logOut_btn.FlatAppearance.BorderSize = 0;
            logOut_btn.FlatStyle = FlatStyle.Flat;
            logOut_btn.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            logOut_btn.ForeColor = Color.Cornsilk;
            logOut_btn.Location = new Point(0, 19);
            logOut_btn.Margin = new Padding(3, 2, 3, 2);
            logOut_btn.Name = "logOut_btn";
            logOut_btn.Size = new Size(275, 50);
            logOut_btn.TabIndex = 0;
            logOut_btn.Text = "Log Out";
            logOut_btn.UseVisualStyleBackColor = false;
            logOut_btn.Click += logOut_btn_Click;
            // 
            // staffButton
            // 
            staffButton.Controls.Add(staffLabel);
            staffButton.Controls.Add(staffIcon);
            staffButton.Cursor = Cursors.Hand;
            staffButton.Location = new Point(0, 255);
            staffButton.Margin = new Padding(3, 2, 3, 2);
            staffButton.Name = "staffButton";
            staffButton.Size = new Size(275, 74);
            staffButton.TabIndex = 7;
            staffButton.MouseLeave += staffButton_MouseOff;
            staffButton.MouseHover += staffButton_MouseHover;
            // 
            // staffLabel
            // 
            staffLabel.BackColor = Color.Transparent;
            staffLabel.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            staffLabel.Location = new Point(98, 22);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(177, 33);
            staffLabel.TabIndex = 7;
            staffLabel.Text = "STAFF";
            staffLabel.TextAlign = ContentAlignment.MiddleLeft;
            staffLabel.MouseLeave += staffButton_MouseOff;
            staffLabel.MouseHover += staffButton_MouseHover;
            // 
            // staffIcon
            // 
            staffIcon.BackColor = Color.Transparent;
            staffIcon.BackgroundImage = (Image)resources.GetObject("staffIcon.BackgroundImage");
            staffIcon.BackgroundImageLayout = ImageLayout.Stretch;
            staffIcon.Location = new Point(35, 22);
            staffIcon.Margin = new Padding(3, 2, 3, 2);
            staffIcon.Name = "staffIcon";
            staffIcon.Size = new Size(48, 33);
            staffIcon.TabIndex = 6;
            staffIcon.TabStop = false;
            staffIcon.MouseLeave += staffButton_MouseOff;
            staffIcon.MouseHover += staffButton_MouseHover;
            // 
            // profileButton
            // 
            profileButton.Controls.Add(profileLabel);
            profileButton.Controls.Add(profileIcon);
            profileButton.Cursor = Cursors.Hand;
            profileButton.Location = new Point(0, 181);
            profileButton.Margin = new Padding(3, 2, 3, 2);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(275, 74);
            profileButton.TabIndex = 6;
            profileButton.Click += profileButton_Click;
            profileButton.MouseLeave += profileButton_MouseOff;
            profileButton.MouseHover += profileButton_MouseHover;
            // 
            // profileLabel
            // 
            profileLabel.BackColor = Color.Transparent;
            profileLabel.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            profileLabel.Location = new Point(98, 23);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(177, 33);
            profileLabel.TabIndex = 6;
            profileLabel.Text = "PROFILE";
            profileLabel.TextAlign = ContentAlignment.MiddleLeft;
            profileLabel.Click += profileLabel_Click;
            profileLabel.MouseLeave += profileButton_MouseOff;
            profileLabel.MouseHover += profileButton_MouseHover;
            // 
            // profileIcon
            // 
            profileIcon.BackColor = Color.Transparent;
            profileIcon.BackgroundImage = (Image)resources.GetObject("profileIcon.BackgroundImage");
            profileIcon.BackgroundImageLayout = ImageLayout.Stretch;
            profileIcon.Location = new Point(35, 23);
            profileIcon.Margin = new Padding(3, 2, 3, 2);
            profileIcon.Name = "profileIcon";
            profileIcon.Size = new Size(48, 33);
            profileIcon.TabIndex = 5;
            profileIcon.TabStop = false;
            profileIcon.Click += profileIcon_Click;
            profileIcon.MouseLeave += profileButton_MouseOff;
            profileIcon.MouseHover += profileButton_MouseHover;
            // 
            // homeButton
            // 
            homeButton.Controls.Add(homeLabel);
            homeButton.Controls.Add(homeIcon);
            homeButton.Cursor = Cursors.Hand;
            homeButton.Location = new Point(0, 106);
            homeButton.Margin = new Padding(3, 2, 3, 2);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(275, 74);
            homeButton.TabIndex = 7;
            homeButton.MouseLeave += homeButton_MouseOff;
            homeButton.MouseHover += homeButton_MouseHover;
            // 
            // homeLabel
            // 
            homeLabel.BackColor = Color.Transparent;
            homeLabel.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            homeLabel.Location = new Point(98, 21);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(177, 33);
            homeLabel.TabIndex = 5;
            homeLabel.Text = "HOME";
            homeLabel.TextAlign = ContentAlignment.MiddleLeft;
            homeLabel.MouseLeave += homeButton_MouseOff;
            homeLabel.MouseHover += homeButton_MouseHover;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.BackgroundImage = (Image)resources.GetObject("homeIcon.BackgroundImage");
            homeIcon.BackgroundImageLayout = ImageLayout.Stretch;
            homeIcon.Location = new Point(35, 21);
            homeIcon.Margin = new Padding(3, 2, 3, 2);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(48, 33);
            homeIcon.TabIndex = 4;
            homeIcon.TabStop = false;
            homeIcon.MouseLeave += homeButton_MouseOff;
            homeIcon.MouseHover += homeButton_MouseHover;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.BackColor = Color.Transparent;
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(18, 15);
            backButton.Name = "backButton";
            backButton.Size = new Size(32, 37);
            backButton.TabIndex = 0;
            backButton.Text = "❮";
            backButton.Click += backButton_Click;
            backButton.MouseLeave += backButton_MouseLeave;
            backButton.MouseHover += backButton_MouseHover;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 600);
            Controls.Add(sideMenuPanel);
            Controls.Add(closeButton);
            Controls.Add(sideMenuButton);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(adoptBtn);
            Controls.Add(otherPanel);
            Controls.Add(dogPanel);
            Controls.Add(categoriesLabel);
            Controls.Add(catPanel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMainScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            catPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            dogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            otherPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            sideMenuPanel.ResumeLayout(false);
            sideMenuPanel.PerformLayout();
            panel1.ResumeLayout(false);
            staffButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)staffIcon).EndInit();
            profileButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileIcon).EndInit();
            homeButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            sideMenuPanel.Visible = true;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BackButton_MouseHover(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StaffButton_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProfileButton_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StaffButton_MouseHover(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProfileButton_MouseHover(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel catPanel;
        private Label categoriesLabel;
        private Panel dogPanel;
        private Panel otherPanel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button adoptBtn;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button sideMenuButton;
        private Button closeButton;
        private Panel sideMenuPanel;
        private Label backButton;
        private PictureBox homeIcon;
        private PictureBox profileIcon;
        private PictureBox staffIcon;
        private Panel homeButton;
        private Label homeLabel;
        private Panel profileButton;
        private Panel staffButton;
        private Label staffLabel;
        private Label profileLabel;
        private Panel panel1;
        private Button logOut_btn;
    }
}