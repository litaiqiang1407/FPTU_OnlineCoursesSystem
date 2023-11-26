namespace FPTU_OnlineCoursesSystem
{
    partial class RatingsManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingsManagementForm));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            valueCourseID = new Label();
            valueStudentID = new Label();
            inputSearchValue = new TextBox();
            label23 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClearAll = new Button();
            valueRatingID = new Label();
            inputCourseName = new TextBox();
            label18 = new Label();
            label19 = new Label();
            inputStudentName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label16 = new Label();
            label17 = new Label();
            label14 = new Label();
            lblStudent = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelCourses = new Panel();
            DGVRating = new DataGridView();
            inputReview = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnCreate = new Button();
            panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRating).BeginInit();
            SuspendLayout();
            // 
            // valueCourseID
            // 
            valueCourseID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueCourseID.ForeColor = Color.FromArgb(255, 109, 0);
            valueCourseID.Location = new Point(371, 91);
            valueCourseID.Name = "valueCourseID";
            valueCourseID.Size = new Size(133, 30);
            valueCourseID.TabIndex = 73;
            valueCourseID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // valueStudentID
            // 
            valueStudentID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueStudentID.ForeColor = Color.FromArgb(255, 109, 0);
            valueStudentID.Location = new Point(206, 91);
            valueStudentID.Name = "valueStudentID";
            valueStudentID.Size = new Size(133, 30);
            valueStudentID.TabIndex = 72;
            valueStudentID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputSearchValue
            // 
            inputSearchValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputSearchValue.Location = new Point(21, 241);
            inputSearchValue.Name = "inputSearchValue";
            inputSearchValue.PlaceholderText = "Search for anything....";
            inputSearchValue.Size = new Size(838, 30);
            inputSearchValue.TabIndex = 55;
            // 
            // label23
            // 
            label23.BackColor = Color.FromArgb(255, 109, 0);
            label23.Enabled = false;
            label23.FlatStyle = FlatStyle.Flat;
            label23.Location = new Point(20, 240);
            label23.Name = "label23";
            label23.Size = new Size(840, 32);
            label23.TabIndex = 58;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 109, 0);
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnRefresh.FlatAppearance.BorderSize = 2;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(950, 240);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(70, 30);
            btnRefresh.TabIndex = 57;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 109, 0);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Center;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(870, 240);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 30);
            btnSearch.TabIndex = 56;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 109, 0);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1040, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 40);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 109, 0);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1040, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 40);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(255, 109, 0);
            btnClearAll.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnClearAll.FlatAppearance.BorderSize = 2;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(864, 165);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(135, 32);
            btnClearAll.TabIndex = 51;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            // 
            // valueRatingID
            // 
            valueRatingID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueRatingID.ForeColor = Color.FromArgb(255, 109, 0);
            valueRatingID.Location = new Point(41, 91);
            valueRatingID.Name = "valueRatingID";
            valueRatingID.Size = new Size(133, 30);
            valueRatingID.TabIndex = 42;
            valueRatingID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputCourseName
            // 
            inputCourseName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputCourseName.ForeColor = Color.Black;
            inputCourseName.Location = new Point(371, 166);
            inputCourseName.Name = "inputCourseName";
            inputCourseName.PlaceholderText = "Enter course";
            inputCourseName.Size = new Size(133, 30);
            inputCourseName.TabIndex = 39;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(255, 109, 0);
            label18.FlatStyle = FlatStyle.Flat;
            label18.Location = new Point(370, 165);
            label18.Name = "label18";
            label18.Size = new Size(135, 32);
            label18.TabIndex = 40;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(255, 109, 0);
            label19.Location = new Point(370, 145);
            label19.Name = "label19";
            label19.Size = new Size(105, 20);
            label19.TabIndex = 38;
            label19.Text = "Course Name";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputStudentName
            // 
            inputStudentName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputStudentName.ForeColor = Color.Black;
            inputStudentName.Location = new Point(206, 166);
            inputStudentName.Name = "inputStudentName";
            inputStudentName.PlaceholderText = "Enter student";
            inputStudentName.Size = new Size(133, 30);
            inputStudentName.TabIndex = 30;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(255, 109, 0);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(205, 165);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 109, 0);
            label7.Location = new Point(205, 145);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 29;
            label7.Text = "Student Name";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 109, 0);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(370, 90);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 109, 0);
            label5.Location = new Point(370, 70);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 26;
            label5.Text = "Course ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.BackColor = Color.FromArgb(255, 109, 0);
            label16.FlatStyle = FlatStyle.Flat;
            label16.Location = new Point(40, 165);
            label16.Name = "label16";
            label16.Size = new Size(135, 32);
            label16.TabIndex = 25;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(255, 109, 0);
            label17.Location = new Point(40, 145);
            label17.Name = "label17";
            label17.Size = new Size(102, 20);
            label17.TabIndex = 23;
            label17.Text = "Rating Value";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(255, 109, 0);
            label14.FlatStyle = FlatStyle.Flat;
            label14.Location = new Point(205, 90);
            label14.Name = "label14";
            label14.Size = new Size(135, 32);
            label14.TabIndex = 22;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblStudent.ForeColor = Color.FromArgb(255, 109, 0);
            lblStudent.Location = new Point(205, 70);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(84, 20);
            lblStudent.TabIndex = 20;
            lblStudent.Text = "Student ID";
            lblStudent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 109, 0);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(40, 90);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 109, 0);
            label2.Location = new Point(40, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Rating ID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 109, 0);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(1000, 40);
            label1.TabIndex = 1;
            label1.Text = "Rating Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(20, 20);
            button1.Name = "button1";
            button1.Size = new Size(1000, 200);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // panelCourses
            // 
            panelCourses.BackColor = Color.White;
            panelCourses.Controls.Add(btnCreate);
            panelCourses.Controls.Add(label10);
            panelCourses.Controls.Add(DGVRating);
            panelCourses.Controls.Add(inputReview);
            panelCourses.Controls.Add(label8);
            panelCourses.Controls.Add(label9);
            panelCourses.Controls.Add(valueCourseID);
            panelCourses.Controls.Add(valueStudentID);
            panelCourses.Controls.Add(inputSearchValue);
            panelCourses.Controls.Add(label23);
            panelCourses.Controls.Add(btnRefresh);
            panelCourses.Controls.Add(btnSearch);
            panelCourses.Controls.Add(btnDelete);
            panelCourses.Controls.Add(btnUpdate);
            panelCourses.Controls.Add(btnClearAll);
            panelCourses.Controls.Add(valueRatingID);
            panelCourses.Controls.Add(inputCourseName);
            panelCourses.Controls.Add(label18);
            panelCourses.Controls.Add(label19);
            panelCourses.Controls.Add(inputStudentName);
            panelCourses.Controls.Add(label6);
            panelCourses.Controls.Add(label7);
            panelCourses.Controls.Add(label4);
            panelCourses.Controls.Add(label5);
            panelCourses.Controls.Add(label16);
            panelCourses.Controls.Add(label17);
            panelCourses.Controls.Add(label14);
            panelCourses.Controls.Add(lblStudent);
            panelCourses.Controls.Add(label3);
            panelCourses.Controls.Add(label2);
            panelCourses.Controls.Add(label1);
            panelCourses.Controls.Add(button1);
            panelCourses.Dock = DockStyle.Fill;
            panelCourses.Location = new Point(0, 0);
            panelCourses.Name = "panelCourses";
            panelCourses.Size = new Size(1260, 800);
            panelCourses.TabIndex = 3;
            // 
            // DGVRating
            // 
            DGVRating.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVRating.BackgroundColor = Color.White;
            DGVRating.BorderStyle = BorderStyle.None;
            DGVRating.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGVRating.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGVRating.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRating.EnableHeadersVisualStyles = false;
            DGVRating.GridColor = Color.FromArgb(255, 72, 0);
            DGVRating.Location = new Point(20, 340);
            DGVRating.Name = "DGVRating";
            DGVRating.ReadOnly = true;
            DGVRating.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVRating.RowHeadersVisible = false;
            DGVRating.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 138, 51);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            DGVRating.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DGVRating.RowTemplate.Height = 29;
            DGVRating.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVRating.Size = new Size(1220, 450);
            DGVRating.TabIndex = 77;
            DGVRating.CellClick += DGVRating_CellClick;
            // 
            // inputReview
            // 
            inputReview.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputReview.ForeColor = Color.Black;
            inputReview.Location = new Point(536, 91);
            inputReview.Multiline = true;
            inputReview.Name = "inputReview";
            inputReview.PlaceholderText = "Enter review";
            inputReview.Size = new Size(298, 105);
            inputReview.TabIndex = 75;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(255, 109, 0);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(535, 90);
            label8.Name = "label8";
            label8.Size = new Size(300, 107);
            label8.TabIndex = 76;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(255, 109, 0);
            label9.Location = new Point(535, 70);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 74;
            label9.Text = "Review";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(255, 109, 0);
            label10.Location = new Point(41, 166);
            label10.Name = "label10";
            label10.Size = new Size(133, 30);
            label10.TabIndex = 78;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 109, 0);
            btnCreate.Enabled = false;
            btnCreate.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnCreate.FlatAppearance.BorderSize = 2;
            btnCreate.FlatAppearance.MouseDownBackColor = Color.White;
            btnCreate.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1040, 60);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 40);
            btnCreate.TabIndex = 79;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // RatingsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 800);
            Controls.Add(panelCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RatingsManagementForm";
            Text = "RatingsManagementForm";
            panelCourses.ResumeLayout(false);
            panelCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRating).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label valueCourseID;
        private Label valueStudentID;
        private TextBox inputSearchValue;
        private Label label23;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearAll;
        private Label valueRatingID;
        private TextBox inputCourseName;
        private Label label18;
        private Label label19;
        private TextBox inputStudentName;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label16;
        private Label label17;
        private Label label14;
        private Label lblStudent;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel panelCourses;
        private TextBox inputReview;
        private Label label8;
        private Label label9;
        private DataGridView DGVRating;
        private Label label10;
        private Button btnCreate;
    }
}