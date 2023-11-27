namespace FPTU_OnlineCoursesSystem
{
    partial class EnrollmentsManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollmentsManagementForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            filterEnrollmentDate = new ComboBox();
            label26 = new Label();
            inputSearch = new TextBox();
            label23 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            valueEnrollmentID = new Label();
            inputCourseName = new TextBox();
            label18 = new Label();
            label19 = new Label();
            panelCourses = new Panel();
            labelEnrollmentDate = new Label();
            labelCourseName = new Label();
            labelStudentName = new Label();
            btnCreate = new Button();
            filterPaymentStatus = new ComboBox();
            label9 = new Label();
            filterEnrollmentStatus = new ComboBox();
            label8 = new Label();
            inputPaymentStatus = new ComboBox();
            inputEnrollmentStatus = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            DGVEnrollment = new DataGridView();
            valueCourseID = new Label();
            valueStudentID = new Label();
            inputStudentName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputEnrollmentDate = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label14 = new Label();
            lblStudent = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVEnrollment).BeginInit();
            SuspendLayout();
            // 
            // filterEnrollmentDate
            // 
            filterEnrollmentDate.AccessibleName = "Enrollment Date";
            filterEnrollmentDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterEnrollmentDate.ForeColor = Color.FromArgb(255, 109, 0);
            filterEnrollmentDate.FormattingEnabled = true;
            filterEnrollmentDate.Location = new Point(21, 291);
            filterEnrollmentDate.Name = "filterEnrollmentDate";
            filterEnrollmentDate.Size = new Size(198, 31);
            filterEnrollmentDate.TabIndex = 59;
            filterEnrollmentDate.Text = "Enrollment Date";
            // 
            // label26
            // 
            label26.BackColor = Color.FromArgb(255, 109, 0);
            label26.FlatStyle = FlatStyle.Flat;
            label26.Location = new Point(20, 290);
            label26.Name = "label26";
            label26.Size = new Size(200, 33);
            label26.TabIndex = 60;
            // 
            // inputSearch
            // 
            inputSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputSearch.Location = new Point(21, 241);
            inputSearch.Name = "inputSearch";
            inputSearch.PlaceholderText = "Search for anything....";
            inputSearch.Size = new Size(838, 30);
            inputSearch.TabIndex = 55;
            inputSearch.TextChanged += inputSearch_TextChanged;
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
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.White;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(950, 240);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(70, 30);
            btnRefresh.TabIndex = 57;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 109, 0);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Center;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.White;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(870, 240);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 30);
            btnSearch.TabIndex = 56;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 109, 0);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.White;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.White;
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
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.White;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1040, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 40);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 109, 0);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatAppearance.MouseDownBackColor = Color.White;
            btnClear.FlatAppearance.MouseOverBackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(700, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(300, 32);
            btnClear.TabIndex = 51;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // valueEnrollmentID
            // 
            valueEnrollmentID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueEnrollmentID.ForeColor = Color.FromArgb(255, 109, 0);
            valueEnrollmentID.Location = new Point(41, 91);
            valueEnrollmentID.Name = "valueEnrollmentID";
            valueEnrollmentID.Size = new Size(133, 30);
            valueEnrollmentID.TabIndex = 42;
            valueEnrollmentID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputCourseName
            // 
            inputCourseName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputCourseName.ForeColor = Color.Black;
            inputCourseName.Location = new Point(371, 166);
            inputCourseName.Name = "inputCourseName";
            inputCourseName.PlaceholderText = "Enter course's name";
            inputCourseName.Size = new Size(298, 30);
            inputCourseName.TabIndex = 39;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(255, 109, 0);
            label18.FlatStyle = FlatStyle.Flat;
            label18.Location = new Point(370, 165);
            label18.Name = "label18";
            label18.Size = new Size(300, 32);
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
            // panelCourses
            // 
            panelCourses.BackColor = Color.White;
            panelCourses.Controls.Add(labelEnrollmentDate);
            panelCourses.Controls.Add(labelCourseName);
            panelCourses.Controls.Add(labelStudentName);
            panelCourses.Controls.Add(btnCreate);
            panelCourses.Controls.Add(filterPaymentStatus);
            panelCourses.Controls.Add(label9);
            panelCourses.Controls.Add(filterEnrollmentStatus);
            panelCourses.Controls.Add(label8);
            panelCourses.Controls.Add(inputPaymentStatus);
            panelCourses.Controls.Add(inputEnrollmentStatus);
            panelCourses.Controls.Add(label10);
            panelCourses.Controls.Add(label11);
            panelCourses.Controls.Add(label12);
            panelCourses.Controls.Add(label13);
            panelCourses.Controls.Add(DGVEnrollment);
            panelCourses.Controls.Add(valueCourseID);
            panelCourses.Controls.Add(valueStudentID);
            panelCourses.Controls.Add(filterEnrollmentDate);
            panelCourses.Controls.Add(label26);
            panelCourses.Controls.Add(inputSearch);
            panelCourses.Controls.Add(label23);
            panelCourses.Controls.Add(btnRefresh);
            panelCourses.Controls.Add(btnSearch);
            panelCourses.Controls.Add(btnDelete);
            panelCourses.Controls.Add(btnUpdate);
            panelCourses.Controls.Add(btnClear);
            panelCourses.Controls.Add(valueEnrollmentID);
            panelCourses.Controls.Add(inputCourseName);
            panelCourses.Controls.Add(label18);
            panelCourses.Controls.Add(label19);
            panelCourses.Controls.Add(inputStudentName);
            panelCourses.Controls.Add(label6);
            panelCourses.Controls.Add(label7);
            panelCourses.Controls.Add(label4);
            panelCourses.Controls.Add(label5);
            panelCourses.Controls.Add(inputEnrollmentDate);
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
            panelCourses.TabIndex = 2;
            // 
            // labelEnrollmentDate
            // 
            labelEnrollmentDate.AutoSize = true;
            labelEnrollmentDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnrollmentDate.ForeColor = Color.Red;
            labelEnrollmentDate.Location = new Point(40, 197);
            labelEnrollmentDate.Name = "labelEnrollmentDate";
            labelEnrollmentDate.Size = new Size(125, 17);
            labelEnrollmentDate.TabIndex = 90;
            labelEnrollmentDate.Text = "labelEnrollmentDate";
            labelEnrollmentDate.Visible = false;
            // 
            // labelCourseName
            // 
            labelCourseName.AutoSize = true;
            labelCourseName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCourseName.ForeColor = Color.Red;
            labelCourseName.Location = new Point(369, 197);
            labelCourseName.Name = "labelCourseName";
            labelCourseName.Size = new Size(112, 17);
            labelCourseName.TabIndex = 89;
            labelCourseName.Text = "labelCourseName";
            labelCourseName.Visible = false;
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudentName.ForeColor = Color.Red;
            labelStudentName.Location = new Point(369, 122);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(115, 17);
            labelStudentName.TabIndex = 88;
            labelStudentName.Text = "labelStudentName";
            labelStudentName.Visible = false;
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
            btnCreate.TabIndex = 87;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // filterPaymentStatus
            // 
            filterPaymentStatus.AccessibleName = "Payment Status";
            filterPaymentStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterPaymentStatus.ForeColor = Color.FromArgb(255, 109, 0);
            filterPaymentStatus.FormattingEnabled = true;
            filterPaymentStatus.Location = new Point(661, 291);
            filterPaymentStatus.Name = "filterPaymentStatus";
            filterPaymentStatus.Size = new Size(198, 31);
            filterPaymentStatus.TabIndex = 85;
            filterPaymentStatus.Text = "Payment Status";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(255, 109, 0);
            label9.FlatStyle = FlatStyle.Flat;
            label9.Location = new Point(660, 290);
            label9.Name = "label9";
            label9.Size = new Size(200, 33);
            label9.TabIndex = 86;
            // 
            // filterEnrollmentStatus
            // 
            filterEnrollmentStatus.AccessibleName = "Enrollment Status";
            filterEnrollmentStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterEnrollmentStatus.ForeColor = Color.FromArgb(255, 109, 0);
            filterEnrollmentStatus.FormattingEnabled = true;
            filterEnrollmentStatus.Location = new Point(341, 291);
            filterEnrollmentStatus.Name = "filterEnrollmentStatus";
            filterEnrollmentStatus.Size = new Size(198, 31);
            filterEnrollmentStatus.TabIndex = 83;
            filterEnrollmentStatus.Text = "Enrollment Status";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(255, 109, 0);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(340, 290);
            label8.Name = "label8";
            label8.Size = new Size(200, 33);
            label8.TabIndex = 84;
            // 
            // inputPaymentStatus
            // 
            inputPaymentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputPaymentStatus.ForeColor = Color.Black;
            inputPaymentStatus.FormattingEnabled = true;
            inputPaymentStatus.Items.AddRange(new object[] { "Male", "Female", "Other" });
            inputPaymentStatus.Location = new Point(866, 92);
            inputPaymentStatus.Name = "inputPaymentStatus";
            inputPaymentStatus.Size = new Size(133, 28);
            inputPaymentStatus.TabIndex = 82;
            inputPaymentStatus.Text = "Select status";
            // 
            // inputEnrollmentStatus
            // 
            inputEnrollmentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputEnrollmentStatus.ForeColor = Color.Black;
            inputEnrollmentStatus.FormattingEnabled = true;
            inputEnrollmentStatus.Items.AddRange(new object[] { "Male", "Female", "Other" });
            inputEnrollmentStatus.Location = new Point(701, 92);
            inputEnrollmentStatus.Name = "inputEnrollmentStatus";
            inputEnrollmentStatus.Size = new Size(133, 28);
            inputEnrollmentStatus.TabIndex = 81;
            inputEnrollmentStatus.Text = "Select status";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 109, 0);
            label10.FlatStyle = FlatStyle.Flat;
            label10.Location = new Point(865, 90);
            label10.Name = "label10";
            label10.Size = new Size(135, 32);
            label10.TabIndex = 78;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(255, 109, 0);
            label11.Location = new Point(865, 70);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 77;
            label11.Text = "Payment Status";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(255, 109, 0);
            label12.FlatStyle = FlatStyle.Flat;
            label12.Location = new Point(700, 90);
            label12.Name = "label12";
            label12.Size = new Size(135, 32);
            label12.TabIndex = 76;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(255, 109, 0);
            label13.Location = new Point(700, 70);
            label13.Name = "label13";
            label13.Size = new Size(137, 20);
            label13.TabIndex = 75;
            label13.Text = "Enrollment Status";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DGVEnrollment
            // 
            DGVEnrollment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVEnrollment.BackgroundColor = Color.White;
            DGVEnrollment.BorderStyle = BorderStyle.None;
            DGVEnrollment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVEnrollment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVEnrollment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVEnrollment.EnableHeadersVisualStyles = false;
            DGVEnrollment.GridColor = Color.FromArgb(255, 72, 0);
            DGVEnrollment.Location = new Point(20, 340);
            DGVEnrollment.Name = "DGVEnrollment";
            DGVEnrollment.ReadOnly = true;
            DGVEnrollment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVEnrollment.RowHeadersVisible = false;
            DGVEnrollment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 138, 51);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DGVEnrollment.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGVEnrollment.RowTemplate.Height = 29;
            DGVEnrollment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVEnrollment.Size = new Size(1220, 450);
            DGVEnrollment.TabIndex = 74;
            DGVEnrollment.CellClick += DGVEnrollment_CellClick;
            // 
            // valueCourseID
            // 
            valueCourseID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueCourseID.ForeColor = Color.FromArgb(255, 109, 0);
            valueCourseID.Location = new Point(206, 166);
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
            // inputStudentName
            // 
            inputStudentName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputStudentName.ForeColor = Color.Black;
            inputStudentName.Location = new Point(371, 91);
            inputStudentName.Name = "inputStudentName";
            inputStudentName.PlaceholderText = "Enter student's name";
            inputStudentName.Size = new Size(298, 30);
            inputStudentName.TabIndex = 30;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(255, 109, 0);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(370, 90);
            label6.Name = "label6";
            label6.Size = new Size(300, 32);
            label6.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 109, 0);
            label7.Location = new Point(370, 70);
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
            label4.Location = new Point(205, 165);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 109, 0);
            label5.Location = new Point(205, 145);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 26;
            label5.Text = "Course ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputEnrollmentDate
            // 
            inputEnrollmentDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputEnrollmentDate.ForeColor = Color.Black;
            inputEnrollmentDate.Location = new Point(41, 166);
            inputEnrollmentDate.Name = "inputEnrollmentDate";
            inputEnrollmentDate.PlaceholderText = "dd/mm/yyyy";
            inputEnrollmentDate.Size = new Size(133, 30);
            inputEnrollmentDate.TabIndex = 24;
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
            label17.Size = new Size(126, 20);
            label17.TabIndex = 23;
            label17.Text = "Enrollment Date";
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
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Enrollment ID";
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
            label1.Text = "Enrollment Information";
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
            // EnrollmentsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 800);
            Controls.Add(panelCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnrollmentsManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnrollmentsManagementForm";
            panelCourses.ResumeLayout(false);
            panelCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVEnrollment).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox filterEnrollmentDate;
        private Label label26;
        private TextBox inputSearch;
        private Label label23;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Label valueEnrollmentID;
        private TextBox inputCourseName;
        private Label label18;
        private Label label19;
        private Panel panelCourses;
        private TextBox inputStudentName;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private TextBox inputEnrollmentDate;
        private Label label16;
        private Label label17;
        private Label label14;
        private Label lblStudent;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label valueStudentID;
        private Label valueCourseID;
        private DataGridView DGVEnrollment;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox inputPaymentStatus;
        private ComboBox inputEnrollmentStatus;
        private ComboBox filterPaymentStatus;
        private Label label9;
        private ComboBox filterEnrollmentStatus;
        private Label label8;
        private Button btnCreate;
        private Label labelStudentName;
        private Label labelCourseName;
        private Label labelEnrollmentDate;
    }
}