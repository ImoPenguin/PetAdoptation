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
            Main_panel = new Panel();
            panel1 = new Panel();
            Location_panel = new Panel();
            txtLocation = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            PetType_Combobx = new ComboBox();
            pictureBox2 = new PictureBox();
            Adopt_lb = new Label();
            bSearch_For_A_Pet = new Button();
            advanceSearch_Btn = new Button();
            backButton = new Button();
            Main_panel.SuspendLayout();
            panel1.SuspendLayout();
            Location_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Main_panel
            // 
            Main_panel.BackColor = Color.FromArgb(229, 215, 200);
            Main_panel.Controls.Add(panel1);
            Main_panel.Controls.Add(Adopt_lb);
            Main_panel.Location = new Point(44, 163);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(1285, 255);
            Main_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Location_panel);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(22, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 135);
            panel1.TabIndex = 2;
            // 
            // Location_panel
            // 
            Location_panel.Controls.Add(txtLocation);
            Location_panel.Controls.Add(pictureBox1);
            Location_panel.Location = new Point(639, 26);
            Location_panel.Name = "Location_panel";
            Location_panel.Size = new Size(491, 87);
            Location_panel.TabIndex = 4;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(253, 252, 245);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocation.ForeColor = Color.FromArgb(203, 199, 183);
            txtLocation.Location = new Point(88, 21);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Location";
            txtLocation.RightToLeft = RightToLeft.No;
            txtLocation.Size = new Size(373, 45);
            txtLocation.TabIndex = 3;
            txtLocation.TextChanged += txtLocation_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(18, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 66);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(PetType_Combobx);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(86, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1141, 87);
            panel2.TabIndex = 3;
            // 
            // PetType_Combobx
            // 
            PetType_Combobx.BackColor = Color.FromArgb(253, 252, 245);
            PetType_Combobx.FlatStyle = FlatStyle.Flat;
            PetType_Combobx.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PetType_Combobx.ForeColor = Color.FromArgb(203, 199, 183);
            PetType_Combobx.FormattingEnabled = true;
            PetType_Combobx.Items.AddRange(new object[] { "Cat ", "Dog ", "Other " });
            PetType_Combobx.Location = new Point(104, 21);
            PetType_Combobx.Name = "PetType_Combobx";
            PetType_Combobx.Size = new Size(354, 45);
            PetType_Combobx.TabIndex = 3;
            PetType_Combobx.Text = "Choose an animal type ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(18, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(463, 66);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Adopt_lb
            // 
            Adopt_lb.AutoSize = true;
            Adopt_lb.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            Adopt_lb.ForeColor = Color.FromArgb(81, 60, 41);
            Adopt_lb.Location = new Point(140, 20);
            Adopt_lb.Name = "Adopt_lb";
            Adopt_lb.Size = new Size(997, 62);
            Adopt_lb.TabIndex = 1;
            Adopt_lb.Text = "Adopt and shine with your Rescuoodle today!";
            // 
            // bSearch_For_A_Pet
            // 
            bSearch_For_A_Pet.BackColor = Color.FromArgb(111, 138, 129);
            bSearch_For_A_Pet.Cursor = Cursors.Hand;
            bSearch_For_A_Pet.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 138, 129);
            bSearch_For_A_Pet.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            bSearch_For_A_Pet.FlatStyle = FlatStyle.Flat;
            bSearch_For_A_Pet.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bSearch_For_A_Pet.ForeColor = Color.FromArgb(255, 246, 229);
            bSearch_For_A_Pet.Location = new Point(516, 444);
            bSearch_For_A_Pet.Name = "bSearch_For_A_Pet";
            bSearch_For_A_Pet.Size = new Size(331, 56);
            bSearch_For_A_Pet.TabIndex = 6;
            bSearch_For_A_Pet.Text = "SEARCH FOR A PET";
            bSearch_For_A_Pet.UseVisualStyleBackColor = false;
            // 
            // advanceSearch_Btn
            // 
            advanceSearch_Btn.BackColor = Color.Transparent;
            advanceSearch_Btn.FlatAppearance.BorderSize = 0;
            advanceSearch_Btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            advanceSearch_Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            advanceSearch_Btn.FlatStyle = FlatStyle.Flat;
            advanceSearch_Btn.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            advanceSearch_Btn.ForeColor = Color.FromArgb(81, 60, 41);
            advanceSearch_Btn.Location = new Point(553, 506);
            advanceSearch_Btn.Name = "advanceSearch_Btn";
            advanceSearch_Btn.Size = new Size(269, 67);
            advanceSearch_Btn.TabIndex = 7;
            advanceSearch_Btn.Text = "Advance search  ▼";
            advanceSearch_Btn.UseVisualStyleBackColor = false;
            advanceSearch_Btn.Click += advanceSearch_Btn_Click;
            advanceSearch_Btn.MouseLeave += advanceSearch_Btn_MouseLeave;
            advanceSearch_Btn.MouseHover += advanceSearch_Btn_MouseHover;
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
            backButton.TabIndex = 23;
            backButton.Text = "❮ BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseHover += backButton_MouseHover;
            backButton.MouseLeave += backButton_MouseLeave; 
            // 
            // frmAdoption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1371, 800);
            Controls.Add(backButton);
            Controls.Add(advanceSearch_Btn);
            Controls.Add(bSearch_For_A_Pet);
            Controls.Add(Main_panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdoption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdoption";
            Main_panel.ResumeLayout(false);
            Main_panel.PerformLayout();
            panel1.ResumeLayout(false);
            Location_panel.ResumeLayout(false);
            Location_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Main_panel;
        private Label Adopt_lb;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private ComboBox PetType_Combobx;
        private Panel Location_panel;
        private PictureBox pictureBox1;
        private Button bSearch_For_A_Pet;
        private Button advanceSearch_Btn;
        private TextBox txtLocation;
        private Button backButton;
    }
}