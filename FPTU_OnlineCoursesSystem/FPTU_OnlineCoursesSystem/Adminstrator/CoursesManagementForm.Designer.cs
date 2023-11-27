namespace FPTU_OnlineCoursesSystem
{
    partial class CoursesManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesManagementForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            filterCreationDate = new ComboBox();
            label28 = new Label();
            filterInstructors = new ComboBox();
            label27 = new Label();
            filterCategories = new ComboBox();
            label26 = new Label();
            inputSearch = new TextBox();
            label23 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            btnClear = new Button();
            labelRequiredCategory = new Label();
            labelRequiredName = new Label();
            labelRequiredInstructor = new Label();
            valueID = new Label();
            inputCreationDate = new TextBox();
            label18 = new Label();
            label19 = new Label();
            inputPrice = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            inputDescription = new TextBox();
            label6 = new Label();
            label7 = new Label();
            inputCategory = new TextBox();
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
            panelCourses = new Panel();
            labelDate = new Label();
            valueRating = new Label();
            labelPrice = new Label();
            valueEnrollments = new Label();
            label12 = new Label();
            label21 = new Label();
            DGVCourse = new DataGridView();
            filterPrice = new ComboBox();
            lbol = new Label();
            filterRatingValue = new ComboBox();
            label20 = new Label();
            inputInstructor = new TextBox();
            panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCourse).BeginInit();
            SuspendLayout();
            // 
            // filterCreationDate
            // 
            filterCreationDate.AccessibleName = "Creation Date";
            filterCreationDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterCreationDate.ForeColor = Color.FromArgb(255, 109, 0);
            filterCreationDate.FormattingEnabled = true;
            filterCreationDate.Location = new Point(361, 291);
            filterCreationDate.Name = "filterCreationDate";
            filterCreationDate.Size = new Size(158, 31);
            filterCreationDate.TabIndex = 63;
            filterCreationDate.Text = "Creation Date";
            // 
            // label28
            // 
            label28.BackColor = Color.FromArgb(255, 109, 0);
            label28.FlatStyle = FlatStyle.Flat;
            label28.Location = new Point(360, 290);
            label28.Name = "label28";
            label28.Size = new Size(160, 33);
            label28.TabIndex = 64;
            // 
            // filterInstructors
            // 
            filterInstructors.AccessibleName = "Instructors";
            filterInstructors.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterInstructors.ForeColor = Color.FromArgb(255, 109, 0);
            filterInstructors.FormattingEnabled = true;
            filterInstructors.Location = new Point(191, 291);
            filterInstructors.Name = "filterInstructors";
            filterInstructors.Size = new Size(158, 31);
            filterInstructors.TabIndex = 61;
            filterInstructors.Text = "Instructors";
            // 
            // label27
            // 
            label27.BackColor = Color.FromArgb(255, 109, 0);
            label27.FlatStyle = FlatStyle.Flat;
            label27.Location = new Point(190, 290);
            label27.Name = "label27";
            label27.Size = new Size(160, 33);
            label27.TabIndex = 62;
            // 
            // filterCategories
            // 
            filterCategories.AccessibleName = "Categories";
            filterCategories.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterCategories.ForeColor = Color.FromArgb(255, 109, 0);
            filterCategories.FormattingEnabled = true;
            filterCategories.Location = new Point(21, 291);
            filterCategories.Name = "filterCategories";
            filterCategories.Size = new Size(158, 31);
            filterCategories.TabIndex = 59;
            filterCategories.Text = "Categories";
            // 
            // label26
            // 
            label26.BackColor = Color.FromArgb(255, 109, 0);
            label26.FlatStyle = FlatStyle.Flat;
            label26.Location = new Point(20, 290);
            label26.Name = "label26";
            label26.Size = new Size(160, 33);
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
            inputSearch.TextChanged += inputSearchValue_TextChanged;
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
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 109, 0);
            btnDelete.Enabled = false;
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
            btnUpdate.Enabled = false;
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
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 109, 0);
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
            btnCreate.TabIndex = 52;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
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
            btnClear.Location = new Point(865, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 32);
            btnClear.TabIndex = 51;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClearAll_Click;
            // 
            // labelRequiredCategory
            // 
            labelRequiredCategory.AutoSize = true;
            labelRequiredCategory.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequiredCategory.ForeColor = Color.Red;
            labelRequiredCategory.Location = new Point(369, 122);
            labelRequiredCategory.Name = "labelRequiredCategory";
            labelRequiredCategory.Size = new Size(142, 17);
            labelRequiredCategory.TabIndex = 50;
            labelRequiredCategory.Text = "labelRequiredCategory";
            labelRequiredCategory.Visible = false;
            // 
            // labelRequiredName
            // 
            labelRequiredName.AutoSize = true;
            labelRequiredName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequiredName.ForeColor = Color.Red;
            labelRequiredName.Location = new Point(40, 197);
            labelRequiredName.Name = "labelRequiredName";
            labelRequiredName.Size = new Size(124, 17);
            labelRequiredName.TabIndex = 47;
            labelRequiredName.Text = "labelRequiredName";
            labelRequiredName.Visible = false;
            // 
            // labelRequiredInstructor
            // 
            labelRequiredInstructor.AutoSize = true;
            labelRequiredInstructor.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequiredInstructor.ForeColor = Color.Red;
            labelRequiredInstructor.Location = new Point(205, 122);
            labelRequiredInstructor.Name = "labelRequiredInstructor";
            labelRequiredInstructor.Size = new Size(144, 17);
            labelRequiredInstructor.TabIndex = 44;
            labelRequiredInstructor.Text = "labelRequiredInstructor";
            labelRequiredInstructor.Visible = false;
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
            // inputCreationDate
            // 
            inputCreationDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputCreationDate.ForeColor = Color.Black;
            inputCreationDate.Location = new Point(701, 166);
            inputCreationDate.Name = "inputCreationDate";
            inputCreationDate.PlaceholderText = "dd/mm/yyyy";
            inputCreationDate.Size = new Size(133, 30);
            inputCreationDate.TabIndex = 39;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(255, 109, 0);
            label18.FlatStyle = FlatStyle.Flat;
            label18.Location = new Point(700, 165);
            label18.Name = "label18";
            label18.Size = new Size(135, 32);
            label18.TabIndex = 40;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(255, 109, 0);
            label19.Location = new Point(700, 145);
            label19.Name = "label19";
            label19.Size = new Size(109, 20);
            label19.TabIndex = 38;
            label19.Text = "Creation Date";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPrice
            // 
            inputPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputPrice.ForeColor = Color.Black;
            inputPrice.Location = new Point(866, 91);
            inputPrice.Name = "inputPrice";
            inputPrice.PlaceholderText = "Enter price";
            inputPrice.Size = new Size(133, 30);
            inputPrice.TabIndex = 36;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(255, 109, 0);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(865, 90);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(255, 109, 0);
            label9.Location = new Point(865, 70);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 35;
            label9.Text = "Price";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 109, 0);
            label10.FlatStyle = FlatStyle.Flat;
            label10.Location = new Point(700, 90);
            label10.Name = "label10";
            label10.Size = new Size(135, 32);
            label10.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(255, 109, 0);
            label11.Location = new Point(700, 70);
            label11.Name = "label11";
            label11.Size = new Size(102, 20);
            label11.TabIndex = 32;
            label11.Text = "Rating Value";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputDescription
            // 
            inputDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputDescription.ForeColor = Color.Black;
            inputDescription.Location = new Point(371, 166);
            inputDescription.Name = "inputDescription";
            inputDescription.PlaceholderText = "Enter Description";
            inputDescription.Size = new Size(298, 30);
            inputDescription.TabIndex = 30;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(255, 109, 0);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(370, 165);
            label6.Name = "label6";
            label6.Size = new Size(300, 32);
            label6.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 109, 0);
            label7.Location = new Point(370, 145);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 29;
            label7.Text = "Description";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputCategory
            // 
            inputCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputCategory.ForeColor = Color.Black;
            inputCategory.Location = new Point(371, 91);
            inputCategory.Name = "inputCategory";
            inputCategory.PlaceholderText = "Enter category";
            inputCategory.Size = new Size(133, 30);
            inputCategory.TabIndex = 27;
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
            label5.Size = new Size(74, 20);
            label5.TabIndex = 26;
            label5.Text = "Category";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputName
            // 
            inputName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.ForeColor = Color.Black;
            inputName.Location = new Point(41, 166);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Enter course's name";
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
            label17.Size = new Size(105, 20);
            label17.TabIndex = 23;
            label17.Text = "Course Name";
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
            label15.Size = new Size(79, 20);
            label15.TabIndex = 20;
            label15.Text = "Instructor";
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
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Course ID";
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
            label1.Text = "Course Information";
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
            panelCourses.Controls.Add(labelDate);
            panelCourses.Controls.Add(valueRating);
            panelCourses.Controls.Add(labelPrice);
            panelCourses.Controls.Add(valueEnrollments);
            panelCourses.Controls.Add(label12);
            panelCourses.Controls.Add(label21);
            panelCourses.Controls.Add(DGVCourse);
            panelCourses.Controls.Add(filterPrice);
            panelCourses.Controls.Add(lbol);
            panelCourses.Controls.Add(filterRatingValue);
            panelCourses.Controls.Add(label20);
            panelCourses.Controls.Add(inputInstructor);
            panelCourses.Controls.Add(filterCreationDate);
            panelCourses.Controls.Add(label28);
            panelCourses.Controls.Add(filterInstructors);
            panelCourses.Controls.Add(label27);
            panelCourses.Controls.Add(filterCategories);
            panelCourses.Controls.Add(label26);
            panelCourses.Controls.Add(inputSearch);
            panelCourses.Controls.Add(label23);
            panelCourses.Controls.Add(btnRefresh);
            panelCourses.Controls.Add(btnSearch);
            panelCourses.Controls.Add(btnDelete);
            panelCourses.Controls.Add(btnUpdate);
            panelCourses.Controls.Add(btnCreate);
            panelCourses.Controls.Add(btnClear);
            panelCourses.Controls.Add(labelRequiredCategory);
            panelCourses.Controls.Add(labelRequiredName);
            panelCourses.Controls.Add(labelRequiredInstructor);
            panelCourses.Controls.Add(valueID);
            panelCourses.Controls.Add(inputCreationDate);
            panelCourses.Controls.Add(label18);
            panelCourses.Controls.Add(label19);
            panelCourses.Controls.Add(inputPrice);
            panelCourses.Controls.Add(label8);
            panelCourses.Controls.Add(label9);
            panelCourses.Controls.Add(label10);
            panelCourses.Controls.Add(label11);
            panelCourses.Controls.Add(inputDescription);
            panelCourses.Controls.Add(label6);
            panelCourses.Controls.Add(label7);
            panelCourses.Controls.Add(inputCategory);
            panelCourses.Controls.Add(label4);
            panelCourses.Controls.Add(label5);
            panelCourses.Controls.Add(inputName);
            panelCourses.Controls.Add(label16);
            panelCourses.Controls.Add(label17);
            panelCourses.Controls.Add(label14);
            panelCourses.Controls.Add(label15);
            panelCourses.Controls.Add(label3);
            panelCourses.Controls.Add(label2);
            panelCourses.Controls.Add(label1);
            panelCourses.Controls.Add(button1);
            panelCourses.Dock = DockStyle.Fill;
            panelCourses.Location = new Point(0, 0);
            panelCourses.Name = "panelCourses";
            panelCourses.Size = new Size(1260, 800);
            panelCourses.TabIndex = 1;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = Color.Red;
            labelDate.Location = new Point(701, 197);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(63, 17);
            labelDate.TabIndex = 80;
            labelDate.Text = "labelDate";
            labelDate.Visible = false;
            // 
            // valueRating
            // 
            valueRating.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueRating.ForeColor = Color.FromArgb(255, 109, 0);
            valueRating.Location = new Point(701, 91);
            valueRating.Name = "valueRating";
            valueRating.Size = new Size(133, 30);
            valueRating.TabIndex = 79;
            valueRating.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.ForeColor = Color.Red;
            labelPrice.Location = new Point(865, 122);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(64, 17);
            labelPrice.TabIndex = 78;
            labelPrice.Text = "labelPrice";
            labelPrice.Visible = false;
            // 
            // valueEnrollments
            // 
            valueEnrollments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueEnrollments.ForeColor = Color.FromArgb(255, 109, 0);
            valueEnrollments.Location = new Point(536, 91);
            valueEnrollments.Name = "valueEnrollments";
            valueEnrollments.Size = new Size(133, 30);
            valueEnrollments.TabIndex = 77;
            valueEnrollments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(255, 109, 0);
            label12.FlatStyle = FlatStyle.Flat;
            label12.Location = new Point(535, 90);
            label12.Name = "label12";
            label12.Size = new Size(135, 32);
            label12.TabIndex = 76;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(255, 109, 0);
            label21.Location = new Point(535, 70);
            label21.Name = "label21";
            label21.Size = new Size(95, 20);
            label21.TabIndex = 74;
            label21.Text = "Enrollments";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DGVCourse
            // 
            DGVCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCourse.BackgroundColor = Color.White;
            DGVCourse.BorderStyle = BorderStyle.None;
            DGVCourse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCourse.EnableHeadersVisualStyles = false;
            DGVCourse.GridColor = Color.FromArgb(255, 72, 0);
            DGVCourse.Location = new Point(20, 340);
            DGVCourse.Name = "DGVCourse";
            DGVCourse.ReadOnly = true;
            DGVCourse.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVCourse.RowHeadersVisible = false;
            DGVCourse.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 138, 51);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DGVCourse.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DGVCourse.RowTemplate.Height = 29;
            DGVCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCourse.Size = new Size(1220, 450);
            DGVCourse.TabIndex = 72;
            DGVCourse.CellClick += DGVCourse_CellClick;
            // 
            // filterPrice
            // 
            filterPrice.AccessibleName = "Price";
            filterPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterPrice.ForeColor = Color.FromArgb(255, 109, 0);
            filterPrice.FormattingEnabled = true;
            filterPrice.Location = new Point(701, 291);
            filterPrice.Name = "filterPrice";
            filterPrice.Size = new Size(158, 31);
            filterPrice.TabIndex = 70;
            filterPrice.Text = "Price";
            // 
            // lbol
            // 
            lbol.BackColor = Color.FromArgb(255, 109, 0);
            lbol.FlatStyle = FlatStyle.Flat;
            lbol.Location = new Point(700, 290);
            lbol.Name = "lbol";
            lbol.Size = new Size(160, 33);
            lbol.TabIndex = 71;
            // 
            // filterRatingValue
            // 
            filterRatingValue.AccessibleName = "Rating Value";
            filterRatingValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterRatingValue.ForeColor = Color.FromArgb(255, 109, 0);
            filterRatingValue.FormattingEnabled = true;
            filterRatingValue.Location = new Point(531, 291);
            filterRatingValue.Name = "filterRatingValue";
            filterRatingValue.Size = new Size(158, 31);
            filterRatingValue.TabIndex = 68;
            filterRatingValue.Text = "Rating Value";
            // 
            // label20
            // 
            label20.BackColor = Color.FromArgb(255, 109, 0);
            label20.FlatStyle = FlatStyle.Flat;
            label20.Location = new Point(530, 290);
            label20.Name = "label20";
            label20.Size = new Size(160, 33);
            label20.TabIndex = 69;
            // 
            // inputInstructor
            // 
            inputInstructor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputInstructor.ForeColor = Color.Black;
            inputInstructor.Location = new Point(206, 91);
            inputInstructor.Name = "inputInstructor";
            inputInstructor.PlaceholderText = "Enter instructor";
            inputInstructor.Size = new Size(133, 30);
            inputInstructor.TabIndex = 66;
            // 
            // CoursesManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 800);
            Controls.Add(panelCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursesManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoursesManagementForm";
            panelCourses.ResumeLayout(false);
            panelCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox filterCreationDate;
        private Label label28;
        private ComboBox filterInstructors;
        private Label label27;
        private ComboBox filterCategories;
        private Label label26;
        private TextBox inputSearch;
        private Label label23;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnClear;
        private Label labelRequiredCategory;
        private Label labelRequiredName;
        private Label labelRequiredInstructor;
        private Label valueID;
        private TextBox inputCreationDate;
        private Label label18;
        private Label label19;
        private TextBox inputPrice;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox inputDescription;
        private Label label6;
        private Label label7;
        private TextBox inputCategory;
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
        private Panel panelCourses;
        private TextBox inputInstructor;
        private ComboBox filterPrice;
        private Label lbol;
        private ComboBox filterRatingValue;
        private Label label20;
        private DataGridView DGVCourse;
        private Label label12;
        private Label label21;
        private Label valueEnrollments;
        private Label labelPrice;
        private Label valueRating;
        private Label labelDate;
    }
}