namespace FPTU_OnlineCoursesSystem
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            panel1 = new Panel();
            btnClose = new Button();
            panel2 = new Panel();
            labelCopyright = new Label();
            panel3 = new Panel();
            btnLogout = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panelNavigation = new Panel();
            btnReports = new Button();
            btnRatings = new Button();
            btnEnrollments = new Button();
            btnCourses = new Button();
            btnStudents = new Button();
            btnCategories = new Button();
            btnInstructors = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 72, 0);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1380, 30);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 72, 0);
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 96, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 96, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1316, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(64, 24);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 72, 0);
            panel2.Controls.Add(labelCopyright);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 900);
            panel2.Name = "panel2";
            panel2.Size = new Size(1380, 30);
            panel2.TabIndex = 1;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCopyright.ForeColor = Color.White;
            labelCopyright.Location = new Point(634, 5);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(113, 20);
            labelCopyright.TabIndex = 1;
            labelCopyright.Text = "© CuongLT <3";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1380, 66);
            panel3.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 2;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(1324, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(36, 36);
            btnLogout.TabIndex = 6;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1280, 15);
            button1.Name = "button1";
            button1.Size = new Size(36, 36);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 109, 0);
            label1.Location = new Point(510, 0);
            label1.Name = "label1";
            label1.Size = new Size(360, 66);
            label1.TabIndex = 2;
            label1.Text = "Online Courses System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(120, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 72, 0);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(1380, 4);
            panel4.TabIndex = 3;
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.FromArgb(255, 72, 0);
            panelNavigation.Controls.Add(btnReports);
            panelNavigation.Controls.Add(btnRatings);
            panelNavigation.Controls.Add(btnEnrollments);
            panelNavigation.Controls.Add(btnCourses);
            panelNavigation.Controls.Add(btnStudents);
            panelNavigation.Controls.Add(btnCategories);
            panelNavigation.Controls.Add(btnInstructors);
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 100);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(120, 800);
            panelNavigation.TabIndex = 4;
            // 
            // btnReports
            // 
            btnReports.AccessibleName = "Reports";
            btnReports.BackgroundImage = (Image)resources.GetObject("btnReports.BackgroundImage");
            btnReports.BackgroundImageLayout = ImageLayout.Center;
            btnReports.FlatAppearance.BorderColor = Color.FromArgb(255, 72, 0);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 72, 0);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 72, 0);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 460);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(120, 60);
            btnReports.TabIndex = 6;
            btnReports.UseVisualStyleBackColor = true;


            // 
            // btnRatings
            // 
            btnRatings.AccessibleName = "Ratings";
            btnRatings.BackgroundImage = (Image)resources.GetObject("btnRatings.BackgroundImage");
            btnRatings.BackgroundImageLayout = ImageLayout.Center;
            btnRatings.FlatAppearance.BorderColor = Color.FromArgb(255, 72, 0);
            btnRatings.FlatAppearance.BorderSize = 0;
            btnRatings.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 72, 0);
            btnRatings.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 72, 0);
            btnRatings.FlatStyle = FlatStyle.Flat;
            btnRatings.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRatings.ForeColor = Color.White;
            btnRatings.Location = new Point(0, 400);
            btnRatings.Name = "btnRatings";
            btnRatings.Size = new Size(120, 60);
            btnRatings.TabIndex = 5;
            btnRatings.UseVisualStyleBackColor = true;


            // 
            // btnEnrollments
            // 
            btnEnrollments.AccessibleName = "Enrollments";
            btnEnrollments.BackgroundImage = (Image)resources.GetObject("btnEnrollments.BackgroundImage");
            btnEnrollments.BackgroundImageLayout = ImageLayout.Center;
            btnEnrollments.FlatAppearance.BorderColor = Color.FromArgb(255, 72, 0);
            btnEnrollments.FlatAppearance.BorderSize = 0;
            btnEnrollments.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 72, 0);
            btnEnrollments.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 72, 0);
            btnEnrollments.FlatStyle = FlatStyle.Flat;
            btnEnrollments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnrollments.ForeColor = Color.White;
            btnEnrollments.Location = new Point(0, 340);
            btnEnrollments.Name = "btnEnrollments";
            btnEnrollments.Size = new Size(120, 60);
            btnEnrollments.TabIndex = 4;
            btnEnrollments.UseVisualStyleBackColor = true;


            // 
            // btnCourses
            // 
            btnCourses.AccessibleName = "Courses";
            btnCourses.BackgroundImage = (Image)resources.GetObject("btnCourses.BackgroundImage");
            btnCourses.BackgroundImageLayout = ImageLayout.Center;
            btnCourses.FlatAppearance.BorderColor = Color.FromArgb(255, 72, 0);
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 72, 0);
            btnCourses.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 72, 0);
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourses.ForeColor = Color.White;
            btnCourses.Location = new Point(0, 280);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(120, 60);
            btnCourses.TabIndex = 3;
            btnCourses.UseVisualStyleBackColor = true;


            // 
            // btnStudents
            // 
            btnStudents.AccessibleName = "Students";
            btnStudents.BackgroundImage = (Image)resources.GetObject("btnStudents.BackgroundImage");
            btnStudents.BackgroundImageLayout = ImageLayout.Center;
            btnStudents.FlatAppearance.BorderColor = Color.FromArgb(255, 72, 0);
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 72, 0);
            btnStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 72, 0);
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(0, 160);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(120, 60);
            btnStudents.TabIndex = 2;
            btnStudents.UseVisualStyleBackColor = true;
 

            // 
            // btnCategories
            // 
            btnCategories.AccessibleName = "Categories";
            btnCategories.BackgroundImage = (Image)resources.GetObject("btnCategories.BackgroundImage");
            btnCategories.BackgroundImageLayout = ImageLayout.Center;
            btnCategories.FlatAppearance.BorderColor = Color.FromArgb(255, 72, 0);
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 72, 0);
            btnCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 72, 0);
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 220);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(120, 60);
            btnCategories.TabIndex = 1;
            btnCategories.UseVisualStyleBackColor = true;
    

            // 
            // btnInstructors
            // 
            btnInstructors.AccessibleName = "Instructors";
            btnInstructors.BackgroundImage = (Image)resources.GetObject("btnInstructors.BackgroundImage");
            btnInstructors.BackgroundImageLayout = ImageLayout.Center;
            btnInstructors.FlatAppearance.BorderColor = Color.FromArgb(255, 72, 0);
            btnInstructors.FlatAppearance.BorderSize = 0;
            btnInstructors.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 72, 0);
            btnInstructors.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 72, 0);
            btnInstructors.FlatStyle = FlatStyle.Flat;
            btnInstructors.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInstructors.ForeColor = Color.White;
            btnInstructors.Location = new Point(0, 100);
            btnInstructors.Name = "btnInstructors";
            btnInstructors.Size = new Size(120, 60);
            btnInstructors.TabIndex = 0;
            btnInstructors.UseVisualStyleBackColor = true;
          
           
            // 
            // panelMain
            // 
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.BackgroundImageLayout = ImageLayout.Center;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(120, 100);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1260, 800);
            panelMain.TabIndex = 5;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1380, 930);
            Controls.Add(panelMain);
            Controls.Add(panelNavigation);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministratorForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelNavigation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelCopyright;
        private Button btnClose;
        private Panel panel3;
        private Panel panel4;
        private Panel panelNavigation;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnLogout;
        private Button button1;
        private Button btnEnrollments;
        private Button btnCourses;
        private Button btnStudents;
        private Button btnCategories;
        private Button btnInstructors;
        private Button btnReports;
        private Button btnRatings;
    }
}