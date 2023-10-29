namespace PetAdoptation
{
    partial class frmCats
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
            backButton = new Button();
            closeButton = new Button();
            titleLabel = new Label();
            SuspendLayout();
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
            backButton.TabIndex = 25;
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
            closeButton.Location = new Point(1161, 7);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(31, 26);
            closeButton.TabIndex = 26;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Yu Gothic UI", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(91, 66, 18);
            titleLabel.Location = new Point(26, 103);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1147, 92);
            titleLabel.TabIndex = 27;
            titleLabel.Text = "Cats";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch6;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 600);
            Controls.Add(titleLabel);
            Controls.Add(closeButton);
            Controls.Add(backButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCat";
            Load += frmCats_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button backButton;
        private Button closeButton;
        private Label titleLabel;
    }
}