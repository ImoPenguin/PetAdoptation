namespace PetAdoptation
{
    partial class frmPetAdoptConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetAdoptConfirmation));
            panel1 = new Panel();
            bDone = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            Adopt_lb = new Label();
            closeButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 215, 200);
            panel1.Controls.Add(bDone);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(30, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 606);
            panel1.TabIndex = 0;
            // 
            // bDone
            // 
            bDone.BackColor = Color.FromArgb(111, 138, 129);
            bDone.Cursor = Cursors.Hand;
            bDone.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 138, 129);
            bDone.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            bDone.FlatStyle = FlatStyle.Flat;
            bDone.Font = new Font("Yu Gothic UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            bDone.ForeColor = Color.FromArgb(255, 246, 229);
            bDone.Location = new Point(550, 508);
            bDone.Name = "bDone";
            bDone.Size = new Size(195, 67);
            bDone.TabIndex = 6;
            bDone.Text = "DONE";
            bDone.UseVisualStyleBackColor = false;
            bDone.Click += bDone_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(Adopt_lb);
            panel2.Location = new Point(30, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1269, 474);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(229, 215, 200);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(81, 60, 41);
            textBox1.Location = new Point(69, 131);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1152, 305);
            textBox1.TabIndex = 4;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Adopt_lb
            // 
            Adopt_lb.AutoSize = true;
            Adopt_lb.Font = new Font("Yu Gothic UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Adopt_lb.ForeColor = Color.FromArgb(81, 60, 41);
            Adopt_lb.Location = new Point(288, 23);
            Adopt_lb.Name = "Adopt_lb";
            Adopt_lb.Size = new Size(694, 72);
            Adopt_lb.TabIndex = 3;
            Adopt_lb.Text = "Thank you for choosing us!";
            Adopt_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.IndianRed;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1327, 9);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(35, 35);
            closeButton.TabIndex = 23;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // frmPetAdoptConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PetMatch4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1371, 800);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPetAdoptConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPetAdoptConfirmation";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Adopt_lb;
        private Panel panel2;
        private TextBox textBox1;
        private Button closeButton;
        private Button bDone;
    }
}