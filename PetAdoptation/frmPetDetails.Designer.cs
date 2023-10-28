namespace PetAdoptation
{
    partial class frmPetDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetDetails));
            panel1 = new Panel();
            bAdopt = new Button();
            label4 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            petHealth_panel = new Panel();
            panel12 = new Panel();
            wormed_Label = new Label();
            pictureBox4 = new PictureBox();
            microchipped_panel = new Panel();
            microchipped_label = new Label();
            microchipped_Picbx = new PictureBox();
            vaccinated_panel = new Panel();
            Vaccinated_label = new Label();
            vaccinated_Picbx = new PictureBox();
            desexed_Panel = new Panel();
            desexed_Label = new Label();
            desexed_Picbox = new PictureBox();
            petDetails_panel = new Panel();
            panel10 = new Panel();
            textBox2 = new TextBox();
            Colour_label = new Label();
            panel8 = new Panel();
            txtBreed = new TextBox();
            breed_Label = new Label();
            panel9 = new Panel();
            textBox1 = new TextBox();
            Type_label = new Label();
            panel5 = new Panel();
            txtPetAge = new TextBox();
            age_Label = new Label();
            panel7 = new Panel();
            txtPetSize = new TextBox();
            size_label = new Label();
            panel6 = new Panel();
            txtPetSex = new TextBox();
            sex_Label = new Label();
            panel2 = new Panel();
            panel11 = new Panel();
            txtPetLocation = new TextBox();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            txtName = new TextBox();
            Name_label = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            backButton = new Button();
            closeButton = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            petHealth_panel.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            microchipped_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)microchipped_Picbx).BeginInit();
            vaccinated_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vaccinated_Picbx).BeginInit();
            desexed_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)desexed_Picbox).BeginInit();
            petDetails_panel.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 215, 200);
            panel1.Controls.Add(bAdopt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(46, 254);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2140, 979);
            panel1.TabIndex = 0;
            // 
            // bAdopt
            // 
            bAdopt.BackColor = Color.FromArgb(111, 138, 129);
            bAdopt.Cursor = Cursors.Hand;
            bAdopt.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 138, 129);
            bAdopt.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            bAdopt.FlatStyle = FlatStyle.Flat;
            bAdopt.Font = new Font("Yu Gothic UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            bAdopt.ForeColor = Color.FromArgb(255, 246, 229);
            bAdopt.Location = new Point(125, 789);
            bAdopt.Margin = new Padding(5);
            bAdopt.Name = "bAdopt";
            bAdopt.Size = new Size(317, 107);
            bAdopt.TabIndex = 11;
            bAdopt.Text = "ADOPT";
            bAdopt.UseVisualStyleBackColor = false;
            bAdopt.Click += bAdopt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 246, 229);
            label4.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(81, 60, 41);
            label4.Location = new Point(262, 35);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 86);
            label4.TabIndex = 6;
            label4.Text = "P001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 246, 229);
            label2.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(81, 60, 41);
            label2.Location = new Point(125, 35);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 86);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // panel4
            // 
            panel4.Controls.Add(petHealth_panel);
            panel4.Controls.Add(petDetails_panel);
            panel4.Location = new Point(570, 192);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1550, 742);
            panel4.TabIndex = 4;
            // 
            // petHealth_panel
            // 
            petHealth_panel.BackColor = Color.Transparent;
            petHealth_panel.Controls.Add(panel12);
            petHealth_panel.Controls.Add(microchipped_panel);
            petHealth_panel.Controls.Add(vaccinated_panel);
            petHealth_panel.Controls.Add(desexed_Panel);
            petHealth_panel.Location = new Point(20, 46);
            petHealth_panel.Margin = new Padding(5);
            petHealth_panel.Name = "petHealth_panel";
            petHealth_panel.Size = new Size(665, 613);
            petHealth_panel.TabIndex = 10;
            // 
            // panel12
            // 
            panel12.Controls.Add(wormed_Label);
            panel12.Controls.Add(pictureBox4);
            panel12.Location = new Point(6, 310);
            panel12.Margin = new Padding(5);
            panel12.Name = "panel12";
            panel12.Size = new Size(257, 234);
            panel12.TabIndex = 13;
            // 
            // wormed_Label
            // 
            wormed_Label.AutoSize = true;
            wormed_Label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            wormed_Label.ForeColor = Color.FromArgb(81, 60, 41);
            wormed_Label.Location = new Point(8, 152);
            wormed_Label.Margin = new Padding(5, 0, 5, 0);
            wormed_Label.Name = "wormed_Label";
            wormed_Label.Size = new Size(238, 65);
            wormed_Label.TabIndex = 5;
            wormed_Label.Text = "WORMED";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(68, 22);
            pictureBox4.Margin = new Padding(5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(124, 125);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // microchipped_panel
            // 
            microchipped_panel.Controls.Add(microchipped_label);
            microchipped_panel.Controls.Add(microchipped_Picbx);
            microchipped_panel.Location = new Point(273, 21);
            microchipped_panel.Margin = new Padding(5);
            microchipped_panel.Name = "microchipped_panel";
            microchipped_panel.Size = new Size(387, 234);
            microchipped_panel.TabIndex = 13;
            // 
            // microchipped_label
            // 
            microchipped_label.AutoSize = true;
            microchipped_label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            microchipped_label.ForeColor = Color.FromArgb(81, 60, 41);
            microchipped_label.Location = new Point(5, 152);
            microchipped_label.Margin = new Padding(5, 0, 5, 0);
            microchipped_label.Name = "microchipped_label";
            microchipped_label.Size = new Size(368, 65);
            microchipped_label.TabIndex = 5;
            microchipped_label.Text = "MICROCHIPPED";
            // 
            // microchipped_Picbx
            // 
            microchipped_Picbx.BackColor = Color.Transparent;
            microchipped_Picbx.BackgroundImage = (Image)resources.GetObject("microchipped_Picbx.BackgroundImage");
            microchipped_Picbx.BackgroundImageLayout = ImageLayout.Stretch;
            microchipped_Picbx.Location = new Point(130, 22);
            microchipped_Picbx.Margin = new Padding(5);
            microchipped_Picbx.Name = "microchipped_Picbx";
            microchipped_Picbx.Size = new Size(124, 125);
            microchipped_Picbx.TabIndex = 8;
            microchipped_Picbx.TabStop = false;
            microchipped_Picbx.Click += microchipped_Picbx_Click;
            // 
            // vaccinated_panel
            // 
            vaccinated_panel.Controls.Add(Vaccinated_label);
            vaccinated_panel.Controls.Add(vaccinated_Picbx);
            vaccinated_panel.Location = new Point(280, 310);
            vaccinated_panel.Margin = new Padding(5);
            vaccinated_panel.Name = "vaccinated_panel";
            vaccinated_panel.Size = new Size(374, 234);
            vaccinated_panel.TabIndex = 12;
            // 
            // Vaccinated_label
            // 
            Vaccinated_label.AutoSize = true;
            Vaccinated_label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Vaccinated_label.ForeColor = Color.FromArgb(81, 60, 41);
            Vaccinated_label.Location = new Point(34, 152);
            Vaccinated_label.Margin = new Padding(5, 0, 5, 0);
            Vaccinated_label.Name = "Vaccinated_label";
            Vaccinated_label.Size = new Size(307, 65);
            Vaccinated_label.TabIndex = 5;
            Vaccinated_label.Text = "VACCINATED";
            // 
            // vaccinated_Picbx
            // 
            vaccinated_Picbx.BackColor = Color.Transparent;
            vaccinated_Picbx.BackgroundImage = (Image)resources.GetObject("vaccinated_Picbx.BackgroundImage");
            vaccinated_Picbx.BackgroundImageLayout = ImageLayout.Stretch;
            vaccinated_Picbx.Location = new Point(124, 22);
            vaccinated_Picbx.Margin = new Padding(5);
            vaccinated_Picbx.Name = "vaccinated_Picbx";
            vaccinated_Picbx.Size = new Size(124, 125);
            vaccinated_Picbx.TabIndex = 9;
            vaccinated_Picbx.TabStop = false;
            // 
            // desexed_Panel
            // 
            desexed_Panel.Controls.Add(desexed_Label);
            desexed_Panel.Controls.Add(desexed_Picbox);
            desexed_Panel.Location = new Point(5, 21);
            desexed_Panel.Margin = new Padding(5);
            desexed_Panel.Name = "desexed_Panel";
            desexed_Panel.Size = new Size(258, 234);
            desexed_Panel.TabIndex = 11;
            // 
            // desexed_Label
            // 
            desexed_Label.AutoSize = true;
            desexed_Label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            desexed_Label.ForeColor = Color.FromArgb(81, 60, 41);
            desexed_Label.Location = new Point(28, 152);
            desexed_Label.Margin = new Padding(5, 0, 5, 0);
            desexed_Label.Name = "desexed_Label";
            desexed_Label.Size = new Size(222, 65);
            desexed_Label.TabIndex = 5;
            desexed_Label.Text = "DESEXED";
            // 
            // desexed_Picbox
            // 
            desexed_Picbox.BackColor = Color.Transparent;
            desexed_Picbox.BackgroundImage = (Image)resources.GetObject("desexed_Picbox.BackgroundImage");
            desexed_Picbox.BackgroundImageLayout = ImageLayout.Stretch;
            desexed_Picbox.Location = new Point(70, 19);
            desexed_Picbox.Margin = new Padding(5);
            desexed_Picbox.Name = "desexed_Picbox";
            desexed_Picbox.Size = new Size(124, 125);
            desexed_Picbox.TabIndex = 7;
            desexed_Picbox.TabStop = false;
            // 
            // petDetails_panel
            // 
            petDetails_panel.BackColor = Color.Transparent;
            petDetails_panel.Controls.Add(panel10);
            petDetails_panel.Controls.Add(panel8);
            petDetails_panel.Controls.Add(panel9);
            petDetails_panel.Controls.Add(panel5);
            petDetails_panel.Controls.Add(panel7);
            petDetails_panel.Controls.Add(panel6);
            petDetails_panel.Location = new Point(694, 46);
            petDetails_panel.Margin = new Padding(5);
            petDetails_panel.Name = "petDetails_panel";
            petDetails_panel.Size = new Size(852, 613);
            petDetails_panel.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(textBox2);
            panel10.Controls.Add(Colour_label);
            panel10.Location = new Point(37, 491);
            panel10.Margin = new Padding(5);
            panel10.Name = "panel10";
            panel10.Size = new Size(774, 85);
            panel10.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(229, 215, 200);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Yu Gothic UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(81, 60, 41);
            textBox2.Location = new Point(398, 8);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 64);
            textBox2.TabIndex = 7;
            textBox2.Text = "Black/White";
            // 
            // Colour_label
            // 
            Colour_label.AutoSize = true;
            Colour_label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Colour_label.ForeColor = Color.FromArgb(81, 60, 41);
            Colour_label.Location = new Point(26, 6);
            Colour_label.Margin = new Padding(5, 0, 5, 0);
            Colour_label.Name = "Colour_label";
            Colour_label.Size = new Size(193, 65);
            Colour_label.TabIndex = 0;
            Colour_label.Text = "Colour :";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(txtBreed);
            panel8.Controls.Add(breed_Label);
            panel8.Location = new Point(37, 21);
            panel8.Margin = new Padding(5);
            panel8.Name = "panel8";
            panel8.Size = new Size(774, 83);
            panel8.TabIndex = 4;
            // 
            // txtBreed
            // 
            txtBreed.BackColor = Color.FromArgb(229, 215, 200);
            txtBreed.BorderStyle = BorderStyle.None;
            txtBreed.Font = new Font("Yu Gothic UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBreed.ForeColor = Color.FromArgb(81, 60, 41);
            txtBreed.Location = new Point(398, 8);
            txtBreed.Margin = new Padding(5);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(362, 64);
            txtBreed.TabIndex = 4;
            txtBreed.Text = "Siamese ";
            // 
            // breed_Label
            // 
            breed_Label.AutoSize = true;
            breed_Label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            breed_Label.ForeColor = Color.FromArgb(81, 60, 41);
            breed_Label.Location = new Point(26, 8);
            breed_Label.Margin = new Padding(5, 0, 5, 0);
            breed_Label.Name = "breed_Label";
            breed_Label.Size = new Size(174, 65);
            breed_Label.TabIndex = 3;
            breed_Label.Text = "Breed :";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(textBox1);
            panel9.Controls.Add(Type_label);
            panel9.Location = new Point(37, 397);
            panel9.Margin = new Padding(5);
            panel9.Name = "panel9";
            panel9.Size = new Size(774, 85);
            panel9.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(229, 215, 200);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(81, 60, 41);
            textBox1.Location = new Point(398, 8);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 64);
            textBox1.TabIndex = 7;
            textBox1.Text = "Cat";
            // 
            // Type_label
            // 
            Type_label.AutoSize = true;
            Type_label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Type_label.ForeColor = Color.FromArgb(81, 60, 41);
            Type_label.Location = new Point(26, 6);
            Type_label.Margin = new Padding(5, 0, 5, 0);
            Type_label.Name = "Type_label";
            Type_label.Size = new Size(148, 65);
            Type_label.TabIndex = 0;
            Type_label.Text = "Type :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(txtPetAge);
            panel5.Controls.Add(age_Label);
            panel5.Location = new Point(37, 114);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(774, 85);
            panel5.TabIndex = 5;
            // 
            // txtPetAge
            // 
            txtPetAge.BackColor = Color.FromArgb(229, 215, 200);
            txtPetAge.BorderStyle = BorderStyle.None;
            txtPetAge.Font = new Font("Yu Gothic UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPetAge.ForeColor = Color.FromArgb(81, 60, 41);
            txtPetAge.Location = new Point(398, 8);
            txtPetAge.Margin = new Padding(5);
            txtPetAge.Name = "txtPetAge";
            txtPetAge.Size = new Size(362, 64);
            txtPetAge.TabIndex = 5;
            txtPetAge.Text = "3 Years 8 Months ";
            // 
            // age_Label
            // 
            age_Label.AutoSize = true;
            age_Label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            age_Label.ForeColor = Color.FromArgb(81, 60, 41);
            age_Label.Location = new Point(26, 6);
            age_Label.Margin = new Padding(5, 0, 5, 0);
            age_Label.Name = "age_Label";
            age_Label.Size = new Size(135, 65);
            age_Label.TabIndex = 0;
            age_Label.Text = "Age :";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(txtPetSize);
            panel7.Controls.Add(size_label);
            panel7.Location = new Point(37, 302);
            panel7.Margin = new Padding(5);
            panel7.Name = "panel7";
            panel7.Size = new Size(774, 85);
            panel7.TabIndex = 6;
            // 
            // txtPetSize
            // 
            txtPetSize.BackColor = Color.FromArgb(229, 215, 200);
            txtPetSize.BorderStyle = BorderStyle.None;
            txtPetSize.Font = new Font("Yu Gothic UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPetSize.ForeColor = Color.FromArgb(81, 60, 41);
            txtPetSize.Location = new Point(398, 8);
            txtPetSize.Margin = new Padding(5);
            txtPetSize.Name = "txtPetSize";
            txtPetSize.Size = new Size(362, 64);
            txtPetSize.TabIndex = 7;
            txtPetSize.Text = "Medium";
            // 
            // size_label
            // 
            size_label.AutoSize = true;
            size_label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            size_label.ForeColor = Color.FromArgb(81, 60, 41);
            size_label.Location = new Point(26, 6);
            size_label.Margin = new Padding(5, 0, 5, 0);
            size_label.Name = "size_label";
            size_label.Size = new Size(136, 65);
            size_label.TabIndex = 0;
            size_label.Text = "Size :";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(txtPetSex);
            panel6.Controls.Add(sex_Label);
            panel6.Location = new Point(37, 208);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(774, 85);
            panel6.TabIndex = 6;
            // 
            // txtPetSex
            // 
            txtPetSex.BackColor = Color.FromArgb(229, 215, 200);
            txtPetSex.BorderStyle = BorderStyle.None;
            txtPetSex.Font = new Font("Yu Gothic UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPetSex.ForeColor = Color.FromArgb(81, 60, 41);
            txtPetSex.Location = new Point(398, 8);
            txtPetSex.Margin = new Padding(5);
            txtPetSex.Name = "txtPetSex";
            txtPetSex.Size = new Size(362, 64);
            txtPetSex.TabIndex = 6;
            txtPetSex.Text = "Male ";
            // 
            // sex_Label
            // 
            sex_Label.AutoSize = true;
            sex_Label.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sex_Label.ForeColor = Color.FromArgb(81, 60, 41);
            sex_Label.Location = new Point(26, 6);
            sex_Label.Margin = new Padding(5, 0, 5, 0);
            sex_Label.Name = "sex_Label";
            sex_Label.Size = new Size(137, 65);
            sex_Label.TabIndex = 0;
            sex_Label.Text = "Sex : ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(570, 5);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1550, 178);
            panel2.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(255, 246, 229);
            panel11.Controls.Add(txtPetLocation);
            panel11.Controls.Add(pictureBox5);
            panel11.Location = new Point(731, 42);
            panel11.Margin = new Padding(5);
            panel11.Name = "panel11";
            panel11.Size = new Size(760, 93);
            panel11.TabIndex = 8;
            // 
            // txtPetLocation
            // 
            txtPetLocation.BackColor = Color.FromArgb(255, 246, 229);
            txtPetLocation.BorderStyle = BorderStyle.None;
            txtPetLocation.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtPetLocation.ForeColor = Color.FromArgb(81, 60, 41);
            txtPetLocation.Location = new Point(114, 14);
            txtPetLocation.Margin = new Padding(5);
            txtPetLocation.Name = "txtPetLocation";
            txtPetLocation.Size = new Size(642, 64);
            txtPetLocation.TabIndex = 5;
            txtPetLocation.Text = "Coffs Shelter, Vic";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.Location;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(26, 14);
            pictureBox5.Margin = new Padding(5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 64);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 246, 229);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(Name_label);
            panel3.Location = new Point(73, 34);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 110);
            panel3.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 246, 229);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Yu Gothic UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(81, 60, 41);
            txtName.Location = new Point(301, 14);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 86);
            txtName.TabIndex = 3;
            txtName.Text = "Blah Blah";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Name_label.ForeColor = Color.FromArgb(81, 60, 41);
            Name_label.Location = new Point(28, 14);
            Name_label.Margin = new Padding(5, 0, 5, 0);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(261, 86);
            Name_label.TabIndex = 0;
            Name_label.Text = "Name : ";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.bOptionMainScreen;
            pictureBox3.Location = new Point(20, 5);
            pictureBox3.Margin = new Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1526, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.SiameseCat;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(32, 149);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(528, 786);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ID3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(88, 14);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 125);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            backButton.Location = new Point(72, 64);
            backButton.Margin = new Padding(0);
            backButton.Name = "backButton";
            backButton.Size = new Size(236, 99);
            backButton.TabIndex = 23;
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
            closeButton.Location = new Point(2162, 9);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(57, 56);
            closeButton.TabIndex = 28;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // frmPetDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2228, 1280);
            Controls.Add(closeButton);
            Controls.Add(backButton);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "frmPetDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPetDetails";
            Load += frmPetDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            petHealth_panel.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            microchipped_panel.ResumeLayout(false);
            microchipped_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)microchipped_Picbx).EndInit();
            vaccinated_panel.ResumeLayout(false);
            vaccinated_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vaccinated_Picbx).EndInit();
            desexed_Panel.ResumeLayout(false);
            desexed_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)desexed_Picbox).EndInit();
            petDetails_panel.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private TextBox txtName;
        private Label Name_label;
        private Panel panel4;
        private Panel panel7;
        private Label size_label;
        private Panel panel6;
        private Label sex_Label;
        private Panel panel5;
        private Label age_Label;
        private Panel panel8;
        private Label label4;
        private Label label2;
        private Label breed_Label;
        private TextBox txtBreed;
        private TextBox txtPetSex;
        private TextBox txtPetAge;
        private TextBox txtPetSize;
        private Panel petHealth_panel;
        private Panel petDetails_panel;
        private Panel panel10;
        private TextBox textBox2;
        private Label Colour_label;
        private Panel panel9;
        private TextBox textBox1;
        private Label Type_label;
        private Panel desexed_Panel;
        private Label desexed_Label;
        private PictureBox desexed_Picbox;
        private PictureBox pictureBox4;
        private PictureBox vaccinated_Picbx;
        private PictureBox microchipped_Picbx;
        private Panel microchipped_panel;
        private Label microchipped_label;
        private Panel vaccinated_panel;
        private Label Vaccinated_label;
        private Panel panel12;
        private Label wormed_Label;
        private Button bAdopt;
        private Panel panel11;
        private TextBox txtPetLocation;
        private PictureBox pictureBox5;
        private Button backButton;
        private Button closeButton;
    }
}