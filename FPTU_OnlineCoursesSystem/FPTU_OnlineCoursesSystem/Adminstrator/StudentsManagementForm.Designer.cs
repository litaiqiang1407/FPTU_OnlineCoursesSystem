namespace FPTU_OnlineCoursesSystem
{
    partial class StudentsManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsManagementForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            filterEnrollments = new ComboBox();
            label27 = new Label();
            filterGender = new ComboBox();
            label26 = new Label();
            inputSearchValue = new TextBox();
            label23 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            btnClearAll = new Button();
            requiredName = new Label();
            requiredEmail = new Label();
            requiredBirthDate = new Label();
            requiredGender = new Label();
            valueID = new Label();
            inputGender = new ComboBox();
            inputBirthDate = new TextBox();
            label18 = new Label();
            label19 = new Label();
            inputEmailAddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            inputPhoneNumber = new TextBox();
            label4 = new Label();
            label5 = new Label();
            inputName = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label14 = new Label();
            label15 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelStudents = new Panel();
            DGVStudent = new DataGridView();
            valueEnrollments = new Label();
            label9 = new Label();
            label10 = new Label();
            panelStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVStudent).BeginInit();
            SuspendLayout();
            // 
            // filterEnrollments
            // 
            filterEnrollments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterEnrollments.ForeColor = Color.FromArgb(255, 109, 0);
            filterEnrollments.FormattingEnabled = true;
            filterEnrollments.Location = new Point(341, 291);
            filterEnrollments.Name = "filterEnrollments";
            filterEnrollments.Size = new Size(198, 31);
            filterEnrollments.TabIndex = 61;
            filterEnrollments.Text = "Enrollments";
            // 
            // label27
            // 
            label27.BackColor = Color.FromArgb(255, 109, 0);
            label27.FlatStyle = FlatStyle.Flat;
            label27.Location = new Point(340, 290);
            label27.Name = "label27";
            label27.Size = new Size(200, 33);
            label27.TabIndex = 62;
            // 
            // filterGender
            // 
            filterGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterGender.ForeColor = Color.FromArgb(255, 109, 0);
            filterGender.FormattingEnabled = true;
            filterGender.Location = new Point(21, 291);
            filterGender.Name = "filterGender";
            filterGender.Size = new Size(198, 31);
            filterGender.TabIndex = 59;
            filterGender.Text = "Gender";
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
            // inputSearchValue
            // 
            inputSearchValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputSearchValue.Location = new Point(21, 241);
            inputSearchValue.Name = "inputSearchValue";
            inputSearchValue.PlaceholderText = "Search for anything....";
            inputSearchValue.Size = new Size(840, 30);
            inputSearchValue.TabIndex = 55;
            // 
            // label23
            // 
            label23.BackColor = Color.FromArgb(255, 109, 0);
            label23.Enabled = false;
            label23.FlatStyle = FlatStyle.Flat;
            label23.Location = new Point(20, 240);
            label23.Name = "label23";
            label23.Size = new Size(842, 32);
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
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 109, 0);
            btnCreate.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnCreate.FlatAppearance.BorderSize = 2;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1040, 60);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 40);
            btnCreate.TabIndex = 52;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(255, 109, 0);
            btnClearAll.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnClearAll.FlatAppearance.BorderSize = 2;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(699, 165);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(300, 32);
            btnClearAll.TabIndex = 51;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            // 
            // requiredName
            // 
            requiredName.AutoSize = true;
            requiredName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            requiredName.ForeColor = Color.Red;
            requiredName.Location = new Point(40, 197);
            requiredName.Name = "requiredName";
            requiredName.Size = new Size(171, 17);
            requiredName.TabIndex = 47;
            requiredName.Text = "Please enter student's name";
            requiredName.Visible = false;
            // 
            // requiredEmail
            // 
            requiredEmail.AutoSize = true;
            requiredEmail.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            requiredEmail.ForeColor = Color.Red;
            requiredEmail.Location = new Point(369, 197);
            requiredEmail.Name = "requiredEmail";
            requiredEmail.Size = new Size(89, 17);
            requiredEmail.TabIndex = 46;
            requiredEmail.Text = "labelRequired";
            requiredEmail.Visible = false;
            // 
            // requiredBirthDate
            // 
            requiredBirthDate.AutoSize = true;
            requiredBirthDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            requiredBirthDate.ForeColor = Color.Red;
            requiredBirthDate.Location = new Point(699, 122);
            requiredBirthDate.Name = "requiredBirthDate";
            requiredBirthDate.Size = new Size(89, 17);
            requiredBirthDate.TabIndex = 45;
            requiredBirthDate.Text = "labelRequired";
            requiredBirthDate.Visible = false;
            // 
            // requiredGender
            // 
            requiredGender.AutoSize = true;
            requiredGender.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            requiredGender.ForeColor = Color.Red;
            requiredGender.Location = new Point(205, 122);
            requiredGender.Name = "requiredGender";
            requiredGender.Size = new Size(135, 17);
            requiredGender.TabIndex = 44;
            requiredGender.Text = "Please select this field";
            requiredGender.Visible = false;
            // 
            // valueID
            // 
            valueID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueID.ForeColor = Color.FromArgb(255, 109, 0);
            valueID.Location = new Point(41, 91);
            valueID.Name = "valueID";
            valueID.Size = new Size(133, 30);
            valueID.TabIndex = 42;
            valueID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputGender
            // 
            inputGender.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputGender.ForeColor = Color.Black;
            inputGender.FormattingEnabled = true;
            inputGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            inputGender.Location = new Point(206, 92);
            inputGender.Name = "inputGender";
            inputGender.Size = new Size(133, 28);
            inputGender.TabIndex = 41;
            inputGender.Text = "Select gender";
            // 
            // inputBirthDate
            // 
            inputBirthDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputBirthDate.ForeColor = Color.Black;
            inputBirthDate.Location = new Point(700, 91);
            inputBirthDate.Name = "inputBirthDate";
            inputBirthDate.PlaceholderText = "dd/mm/yyyy";
            inputBirthDate.Size = new Size(133, 30);
            inputBirthDate.TabIndex = 39;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(255, 109, 0);
            label18.FlatStyle = FlatStyle.Flat;
            label18.Location = new Point(699, 90);
            label18.Name = "label18";
            label18.Size = new Size(135, 32);
            label18.TabIndex = 40;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(255, 109, 0);
            label19.Location = new Point(699, 70);
            label19.Name = "label19";
            label19.Size = new Size(79, 20);
            label19.TabIndex = 38;
            label19.Text = "BirthDate";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputEmailAddress
            // 
            inputEmailAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmailAddress.ForeColor = Color.Black;
            inputEmailAddress.Location = new Point(370, 166);
            inputEmailAddress.Name = "inputEmailAddress";
            inputEmailAddress.PlaceholderText = "Enter student's email address";
            inputEmailAddress.Size = new Size(298, 30);
            inputEmailAddress.TabIndex = 30;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(255, 109, 0);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(369, 165);
            label6.Name = "label6";
            label6.Size = new Size(300, 32);
            label6.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 109, 0);
            label7.Location = new Point(369, 145);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 29;
            label7.Text = "Email";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPhoneNumber
            // 
            inputPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputPhoneNumber.ForeColor = Color.Black;
            inputPhoneNumber.Location = new Point(370, 91);
            inputPhoneNumber.Name = "inputPhoneNumber";
            inputPhoneNumber.PlaceholderText = "Enter phone number";
            inputPhoneNumber.Size = new Size(298, 30);
            inputPhoneNumber.TabIndex = 27;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 109, 0);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(369, 90);
            label4.Name = "label4";
            label4.Size = new Size(300, 32);
            label4.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 109, 0);
            label5.Location = new Point(369, 70);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 26;
            label5.Text = "Phone Number";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputName
            // 
            inputName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.ForeColor = Color.Black;
            inputName.Location = new Point(41, 166);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Enter student's name";
            inputName.Size = new Size(298, 30);
            inputName.TabIndex = 24;
            // 
            // label16
            // 
            label16.BackColor = Color.FromArgb(255, 109, 0);
            label16.FlatStyle = FlatStyle.Flat;
            label16.Location = new Point(40, 165);
            label16.Name = "label16";
            label16.Size = new Size(300, 32);
            label16.TabIndex = 25;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(255, 109, 0);
            label17.Location = new Point(40, 145);
            label17.Name = "label17";
            label17.Size = new Size(111, 20);
            label17.TabIndex = 23;
            label17.Text = "Student Name";
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(255, 109, 0);
            label15.Location = new Point(205, 70);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 20;
            label15.Text = "Gender";
            label15.TextAlign = ContentAlignment.MiddleLeft;
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
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Student ID";
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
            label1.Text = "Student Information";
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
            // panelStudents
            // 
            panelStudents.Controls.Add(DGVStudent);
            panelStudents.Controls.Add(valueEnrollments);
            panelStudents.Controls.Add(label9);
            panelStudents.Controls.Add(label10);
            panelStudents.Controls.Add(filterEnrollments);
            panelStudents.Controls.Add(label27);
            panelStudents.Controls.Add(filterGender);
            panelStudents.Controls.Add(label26);
            panelStudents.Controls.Add(inputSearchValue);
            panelStudents.Controls.Add(label23);
            panelStudents.Controls.Add(btnRefresh);
            panelStudents.Controls.Add(btnSearch);
            panelStudents.Controls.Add(btnDelete);
            panelStudents.Controls.Add(btnUpdate);
            panelStudents.Controls.Add(btnCreate);
            panelStudents.Controls.Add(btnClearAll);
            panelStudents.Controls.Add(requiredName);
            panelStudents.Controls.Add(requiredEmail);
            panelStudents.Controls.Add(requiredBirthDate);
            panelStudents.Controls.Add(requiredGender);
            panelStudents.Controls.Add(valueID);
            panelStudents.Controls.Add(inputGender);
            panelStudents.Controls.Add(inputBirthDate);
            panelStudents.Controls.Add(label18);
            panelStudents.Controls.Add(label19);
            panelStudents.Controls.Add(inputEmailAddress);
            panelStudents.Controls.Add(label6);
            panelStudents.Controls.Add(label7);
            panelStudents.Controls.Add(inputPhoneNumber);
            panelStudents.Controls.Add(label4);
            panelStudents.Controls.Add(label5);
            panelStudents.Controls.Add(inputName);
            panelStudents.Controls.Add(label16);
            panelStudents.Controls.Add(label17);
            panelStudents.Controls.Add(label14);
            panelStudents.Controls.Add(label15);
            panelStudents.Controls.Add(label3);
            panelStudents.Controls.Add(label2);
            panelStudents.Controls.Add(label1);
            panelStudents.Controls.Add(button1);
            panelStudents.Dock = DockStyle.Fill;
            panelStudents.Location = new Point(0, 0);
            panelStudents.Name = "panelStudents";
            panelStudents.Size = new Size(1260, 800);
            panelStudents.TabIndex = 1;
            // 
            // DGVStudent
            // 
            DGVStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVStudent.BackgroundColor = Color.White;
            DGVStudent.BorderStyle = BorderStyle.None;
            DGVStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVStudent.EnableHeadersVisualStyles = false;
            DGVStudent.GridColor = Color.FromArgb(255, 72, 0);
            DGVStudent.Location = new Point(20, 340);
            DGVStudent.Name = "DGVStudent";
            DGVStudent.ReadOnly = true;
            DGVStudent.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVStudent.RowHeadersVisible = false;
            DGVStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 138, 51);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DGVStudent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGVStudent.RowTemplate.Height = 29;
            DGVStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVStudent.Size = new Size(1220, 450);
            DGVStudent.TabIndex = 69;
            DGVStudent.CellClick += DGVStudent_CellClick;
            // 
            // valueEnrollments
            // 
            valueEnrollments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueEnrollments.ForeColor = Color.FromArgb(255, 109, 0);
            valueEnrollments.Location = new Point(865, 91);
            valueEnrollments.Name = "valueEnrollments";
            valueEnrollments.Size = new Size(133, 30);
            valueEnrollments.TabIndex = 68;
            valueEnrollments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(255, 109, 0);
            label9.FlatStyle = FlatStyle.Flat;
            label9.Location = new Point(864, 90);
            label9.Name = "label9";
            label9.Size = new Size(135, 32);
            label9.TabIndex = 67;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(255, 109, 0);
            label10.Location = new Point(864, 70);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 66;
            label10.Text = "Enrollments";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StudentsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 800);
            Controls.Add(panelStudents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentsManagementForm";
            panelStudents.ResumeLayout(false);
            panelStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox filterEnrollments;
        private Label label27;
        private ComboBox filterGender;
        private Label label26;
        private TextBox inputSearchValue;
        private Label label23;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnClearAll;
        private Label requiredName;
        private Label requiredEmail;
        private Label requiredBirthDate;
        private Label requiredGender;
        private Label valueID;
        private ComboBox inputGender;
        private TextBox inputBirthDate;
        private Label label18;
        private Label label19;
        private TextBox inputEmailAddress;
        private Label label6;
        private Label label7;
        private TextBox inputPhoneNumber;
        private Label label4;
        private Label label5;
        private TextBox inputName;
        private Label label16;
        private Label label17;
        private Label label14;
        private Label label15;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel panelStudents;
        private Label valueEnrollments;
        private Label label9;
        private Label label10;
        private DataGridView DGVStudent;
    }
}