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
            cat_Btn = new Button();
            pictureBox3 = new PictureBox();
            categoriesLabel = new Label();
            dogPanel = new Panel();
            dog_Btn = new Button();
            pictureBox2 = new PictureBox();
            otherPanel = new Panel();
            other_Btn = new Button();
            pictureBox4 = new PictureBox();
            adoptBtn = new Button();
            showAll_Btn = new Button();
            searchID_Btn = new Button();
            returnPet_Btn = new Button();
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
            pictureBox1.Margin = new Padding(6, 4, 6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // catPanel
            // 
            catPanel.BackColor = Color.BlanchedAlmond;
            catPanel.Controls.Add(cat_Btn);
            catPanel.Controls.Add(pictureBox3);
            catPanel.Location = new Point(501, 849);
            catPanel.Margin = new Padding(6, 4, 6, 4);
            catPanel.Name = "catPanel";
            catPanel.Size = new Size(316, 316);
            catPanel.TabIndex = 0;
            catPanel.Paint += panel2_Paint;
            // 
            // cat_Btn
            // 
            cat_Btn.BackColor = Color.LightYellow;
            cat_Btn.Cursor = Cursors.Hand;
            cat_Btn.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            cat_Btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            cat_Btn.FlatStyle = FlatStyle.Flat;
            cat_Btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cat_Btn.Location = new Point(46, 233);
            cat_Btn.Margin = new Padding(6, 4, 6, 4);
            cat_Btn.Name = "cat_Btn";
            cat_Btn.Size = new Size(223, 66);
            cat_Btn.TabIndex = 3;
            cat_Btn.Text = "Cat";
            cat_Btn.UseVisualStyleBackColor = false;
            cat_Btn.Click += cat_Btn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(65, -17);
            pictureBox3.Margin = new Padding(6, 4, 6, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 235);
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
            categoriesLabel.Location = new Point(20, 725);
            categoriesLabel.Margin = new Padding(4, 0, 4, 0);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(237, 60);
            categoriesLabel.TabIndex = 2;
            categoriesLabel.Text = "Categories";
            categoriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dogPanel
            // 
            dogPanel.BackColor = Color.BlanchedAlmond;
            dogPanel.Controls.Add(dog_Btn);
            dogPanel.Controls.Add(pictureBox2);
            dogPanel.Location = new Point(966, 849);
            dogPanel.Margin = new Padding(6, 4, 6, 4);
            dogPanel.Name = "dogPanel";
            dogPanel.Size = new Size(316, 316);
            dogPanel.TabIndex = 1;
            // 
            // dog_Btn
            // 
            dog_Btn.BackColor = Color.LightYellow;
            dog_Btn.Cursor = Cursors.Hand;
            dog_Btn.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            dog_Btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            dog_Btn.FlatStyle = FlatStyle.Flat;
            dog_Btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dog_Btn.Location = new Point(46, 233);
            dog_Btn.Margin = new Padding(6, 4, 6, 4);
            dog_Btn.Name = "dog_Btn";
            dog_Btn.Size = new Size(223, 66);
            dog_Btn.TabIndex = 4;
            dog_Btn.Text = "Dog";
            dog_Btn.UseVisualStyleBackColor = false;
            dog_Btn.Click += dog_Btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(65, -21);
            pictureBox2.Margin = new Padding(6, 4, 6, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 235);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // otherPanel
            // 
            otherPanel.BackColor = Color.BlanchedAlmond;
            otherPanel.Controls.Add(other_Btn);
            otherPanel.Controls.Add(pictureBox4);
            otherPanel.Location = new Point(1430, 849);
            otherPanel.Margin = new Padding(6, 4, 6, 4);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new Size(316, 316);
            otherPanel.TabIndex = 1;
            // 
            // other_Btn
            // 
            other_Btn.BackColor = Color.LightYellow;
            other_Btn.Cursor = Cursors.Hand;
            other_Btn.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            other_Btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            other_Btn.FlatStyle = FlatStyle.Flat;
            other_Btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            other_Btn.Location = new Point(46, 233);
            other_Btn.Margin = new Padding(6, 4, 6, 4);
            other_Btn.Name = "other_Btn";
            other_Btn.Size = new Size(223, 66);
            other_Btn.TabIndex = 5;
            other_Btn.Text = "Other";
            other_Btn.UseVisualStyleBackColor = false;
            other_Btn.Click += other_Btn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(65, -21);
            pictureBox4.Margin = new Padding(6, 4, 6, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(186, 235);
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
            adoptBtn.Location = new Point(1411, 314);
            adoptBtn.Margin = new Padding(6, 4, 6, 4);
            adoptBtn.Name = "adoptBtn";
            adoptBtn.Size = new Size(334, 115);
            adoptBtn.TabIndex = 5;
            adoptBtn.Text = "ADOPT NOW";
            adoptBtn.UseVisualStyleBackColor = false;
            adoptBtn.Click += adoptBtn_Click;
            // 
            // showAll_Btn
            // 
            showAll_Btn.Anchor = AnchorStyles.Right;
            showAll_Btn.BackColor = Color.LightYellow;
            showAll_Btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            showAll_Btn.Location = new Point(1954, 849);
            showAll_Btn.Margin = new Padding(6, 4, 6, 4);
            showAll_Btn.Name = "showAll_Btn";
            showAll_Btn.Size = new Size(253, 85);
            showAll_Btn.TabIndex = 5;
            showAll_Btn.Text = "Show All";
            showAll_Btn.UseVisualStyleBackColor = false;
            showAll_Btn.Click += showAll_Btn_Click;
            // 
            // searchID_Btn
            // 
            searchID_Btn.Anchor = AnchorStyles.Right;
            searchID_Btn.BackColor = Color.LightYellow;
            searchID_Btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchID_Btn.Location = new Point(1954, 1082);
            searchID_Btn.Margin = new Padding(6, 4, 6, 4);
            searchID_Btn.Name = "searchID_Btn";
            searchID_Btn.Size = new Size(253, 85);
            searchID_Btn.TabIndex = 6;
            searchID_Btn.Text = "Search ID";
            searchID_Btn.UseVisualStyleBackColor = false;
            searchID_Btn.Click += searchID_Btn_Click;
            // 
            // returnPet_Btn
            // 
            returnPet_Btn.Anchor = AnchorStyles.Right;
            returnPet_Btn.BackColor = Color.LightYellow;
            returnPet_Btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            returnPet_Btn.Location = new Point(1954, 964);
            returnPet_Btn.Margin = new Padding(6, 4, 6, 4);
            returnPet_Btn.Name = "returnPet_Btn";
            returnPet_Btn.Size = new Size(253, 85);
            returnPet_Btn.TabIndex = 7;
            returnPet_Btn.Text = "Return Pet";
            returnPet_Btn.UseVisualStyleBackColor = false;
            returnPet_Btn.Click += returnPet_Btn_Click;
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
            sideMenuButton.Location = new Point(20, 73);
            sideMenuButton.Margin = new Padding(6, 4, 6, 4);
            sideMenuButton.Name = "sideMenuButton";
            sideMenuButton.Size = new Size(124, 75);
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
            closeButton.Location = new Point(2156, 19);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(58, 55);
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
            sideMenuPanel.Margin = new Padding(6, 4, 6, 4);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(511, 1280);
            sideMenuPanel.TabIndex = 23;
            sideMenuPanel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(logOut_btn);
            panel1.Location = new Point(0, 1135);
            panel1.Margin = new Padding(6, 4, 6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 145);
            panel1.TabIndex = 10;
            // 
            // logOut_btn
            // 
            logOut_btn.BackColor = Color.FromArgb(248, 123, 110);
            logOut_btn.FlatAppearance.BorderSize = 0;
            logOut_btn.FlatStyle = FlatStyle.Flat;
            logOut_btn.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            logOut_btn.ForeColor = Color.Cornsilk;
            logOut_btn.Location = new Point(0, 41);
            logOut_btn.Margin = new Padding(6, 4, 6, 4);
            logOut_btn.Name = "logOut_btn";
            logOut_btn.Size = new Size(511, 107);
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
            staffButton.Location = new Point(0, 546);
            staffButton.Margin = new Padding(6, 4, 6, 4);
            staffButton.Name = "staffButton";
            staffButton.Size = new Size(511, 158);
            staffButton.TabIndex = 7;
            staffButton.Paint += staffButton_Paint;
            staffButton.MouseLeave += staffButton_MouseOff;
            staffButton.MouseHover += staffButton_MouseHover;
            // 
            // staffLabel
            // 
            staffLabel.BackColor = Color.Transparent;
            staffLabel.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            staffLabel.ForeColor = Color.FromArgb(81, 60, 41);
            staffLabel.Location = new Point(182, 47);
            staffLabel.Margin = new Padding(6, 0, 6, 0);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(329, 70);
            staffLabel.TabIndex = 7;
            staffLabel.Text = "STAFF";
            staffLabel.TextAlign = ContentAlignment.MiddleLeft;
            staffLabel.Click += staffLabel_Click;
            staffLabel.MouseLeave += staffButton_MouseOff;
            staffLabel.MouseHover += staffButton_MouseHover;
            // 
            // staffIcon
            // 
            staffIcon.BackColor = Color.Transparent;
            staffIcon.BackgroundImage = (Image)resources.GetObject("staffIcon.BackgroundImage");
            staffIcon.BackgroundImageLayout = ImageLayout.Stretch;
            staffIcon.Location = new Point(65, 47);
            staffIcon.Margin = new Padding(6, 4, 6, 4);
            staffIcon.Name = "staffIcon";
            staffIcon.Size = new Size(89, 70);
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
            profileButton.Location = new Point(0, 386);
            profileButton.Margin = new Padding(6, 4, 6, 4);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(511, 158);
            profileButton.TabIndex = 6;
            profileButton.Click += profileButton_Click;
            profileButton.MouseLeave += profileButton_MouseOff;
            profileButton.MouseHover += profileButton_MouseHover;
            // 
            // profileLabel
            // 
            profileLabel.BackColor = Color.Transparent;
            profileLabel.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            profileLabel.ForeColor = Color.FromArgb(81, 60, 41);
            profileLabel.Location = new Point(182, 49);
            profileLabel.Margin = new Padding(6, 0, 6, 0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(329, 70);
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
            profileIcon.Location = new Point(65, 49);
            profileIcon.Margin = new Padding(6, 4, 6, 4);
            profileIcon.Name = "profileIcon";
            profileIcon.Size = new Size(89, 70);
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
            homeButton.Location = new Point(0, 226);
            homeButton.Margin = new Padding(6, 4, 6, 4);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(511, 158);
            homeButton.TabIndex = 7;
            homeButton.MouseLeave += homeButton_MouseOff;
            homeButton.MouseHover += homeButton_MouseHover;
            // 
            // homeLabel
            // 
            homeLabel.BackColor = Color.Transparent;
            homeLabel.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            homeLabel.ForeColor = Color.FromArgb(81, 60, 41);
            homeLabel.Location = new Point(182, 45);
            homeLabel.Margin = new Padding(6, 0, 6, 0);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(329, 70);
            homeLabel.TabIndex = 5;
            homeLabel.Text = "HOME";
            homeLabel.TextAlign = ContentAlignment.MiddleLeft;
            homeLabel.Click += backButton_Click;
            homeLabel.MouseLeave += homeButton_MouseOff;
            homeLabel.MouseHover += homeButton_MouseHover;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.BackgroundImage = (Image)resources.GetObject("homeIcon.BackgroundImage");
            homeIcon.BackgroundImageLayout = ImageLayout.Stretch;
            homeIcon.Location = new Point(65, 45);
            homeIcon.Margin = new Padding(6, 4, 6, 4);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(89, 70);
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
            backButton.Location = new Point(33, 32);
            backButton.Margin = new Padding(6, 0, 6, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(59, 72);
            backButton.TabIndex = 0;
            backButton.Text = "❮";
            backButton.Click += backButton_Click;
            backButton.MouseLeave += backButton_MouseLeave;
            backButton.MouseHover += backButton_MouseHover;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2229, 1280);
            Controls.Add(sideMenuPanel);
            Controls.Add(closeButton);
            Controls.Add(sideMenuButton);
            Controls.Add(returnPet_Btn);
            Controls.Add(searchID_Btn);
            Controls.Add(showAll_Btn);
            Controls.Add(adoptBtn);
            Controls.Add(otherPanel);
            Controls.Add(dogPanel);
            Controls.Add(categoriesLabel);
            Controls.Add(catPanel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
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
        private Button cat_Btn;
        private Button dog_Btn;
        private Button other_Btn;
        private Button adoptBtn;
        private Button showAll_Btn;
        private Button searchID_Btn;
        private Button returnPet_Btn;
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