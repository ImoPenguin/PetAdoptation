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
            button8 = new Button();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            catPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            dogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            otherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
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
            catPanel.Location = new Point(309, 531);
            catPanel.Name = "catPanel";
            catPanel.Size = new Size(194, 197);
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
            button1.Location = new Point(29, 145);
            button1.Name = "button1";
            button1.Size = new Size(137, 41);
            button1.TabIndex = 3;
            button1.Text = "Cat";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(40, -11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 147);
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
            categoriesLabel.Location = new Point(13, 453);
            categoriesLabel.Margin = new Padding(2, 0, 2, 0);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(152, 38);
            categoriesLabel.TabIndex = 2;
            categoriesLabel.Text = "Categories";
            categoriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dogPanel
            // 
            dogPanel.BackColor = Color.BlanchedAlmond;
            dogPanel.Controls.Add(button2);
            dogPanel.Controls.Add(pictureBox2);
            dogPanel.Location = new Point(594, 531);
            dogPanel.Name = "dogPanel";
            dogPanel.Size = new Size(194, 197);
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
            button2.Location = new Point(29, 145);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 4;
            button2.Text = "Dog";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(40, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 147);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // otherPanel
            // 
            otherPanel.BackColor = Color.BlanchedAlmond;
            otherPanel.Controls.Add(button3);
            otherPanel.Controls.Add(pictureBox4);
            otherPanel.Location = new Point(880, 531);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new Size(194, 197);
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
            button3.Location = new Point(29, 145);
            button3.Name = "button3";
            button3.Size = new Size(137, 41);
            button3.TabIndex = 5;
            button3.Text = "Other";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(40, -13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 147);
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
            adoptBtn.Location = new Point(869, 196);
            adoptBtn.Name = "adoptBtn";
            adoptBtn.Size = new Size(206, 72);
            adoptBtn.TabIndex = 5;
            adoptBtn.Text = "ADOPT NOW";
            adoptBtn.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.BackColor = Color.LightYellow;
            button5.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(1202, 531);
            button5.Name = "button5";
            button5.Size = new Size(155, 53);
            button5.TabIndex = 5;
            button5.Text = "Show All";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.BackColor = Color.LightYellow;
            button6.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(1202, 676);
            button6.Name = "button6";
            button6.Size = new Size(155, 53);
            button6.TabIndex = 6;
            button6.Text = "Search ID";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Right;
            button7.BackColor = Color.LightYellow;
            button7.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(1202, 603);
            button7.Name = "button7";
            button7.Size = new Size(155, 53);
            button7.TabIndex = 7;
            button7.Text = "Return Pet";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightYellow;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.MouseDownBackColor = Color.LightYellow;
            button8.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(13, 45);
            button8.Name = "button8";
            button8.Size = new Size(77, 47);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.IndianRed;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1327, 12);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(35, 35);
            closeButton.TabIndex = 22;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1371, 800);
            Controls.Add(closeButton);
            Controls.Add(button8);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Button button8;
        private Button closeButton;
    }
}