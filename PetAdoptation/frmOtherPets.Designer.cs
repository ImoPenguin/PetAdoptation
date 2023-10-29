namespace PetAdoptation
{
    partial class frmOtherPets
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
            Adopt_lb = new Label();
            backButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // Adopt_lb
            // 
            Adopt_lb.BackColor = Color.Transparent;
            Adopt_lb.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Adopt_lb.ForeColor = Color.FromArgb(81, 60, 41);
            Adopt_lb.Location = new Point(26, 103);
            Adopt_lb.Name = "Adopt_lb";
            Adopt_lb.Size = new Size(1147, 92);
            Adopt_lb.TabIndex = 4;
            Adopt_lb.Text = "O T H E R _ P E T S";
            Adopt_lb.TextAlign = ContentAlignment.MiddleCenter;
            Adopt_lb.Click += Adopt_lb_Click;
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
            backButton.Location = new Point(26, 25);
            backButton.Margin = new Padding(0);
            backButton.Name = "backButton";
            backButton.Size = new Size(127, 46);
            backButton.TabIndex = 26;
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
            closeButton.Location = new Point(1164, 9);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(31, 26);
            closeButton.TabIndex = 27;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // frmOtherPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch10;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 600);
            Controls.Add(closeButton);
            Controls.Add(backButton);
            Controls.Add(Adopt_lb);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmOtherPets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOtherPets1";
            ResumeLayout(false);
        }

        #endregion
        private Label Adopt_lb;
        private Button backButton;
        private Button closeButton;
    }
}