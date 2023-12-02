namespace FPTU_OnlineCoursesSystem
{
    partial class InstructorsManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorsManagementForm));
            panelInstructors = new Panel();
            labelPhone = new Label();
            DGVInstructor = new DataGridView();
            filterGender = new ComboBox();
            label28 = new Label();
            filterExperience = new ComboBox();
            label27 = new Label();
            filterSpecialization = new ComboBox();
            label26 = new Label();
            inputSearch = new TextBox();
            label23 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            btnClear = new Button();
            labelSpecialization = new Label();
            labelExperienceRequired = new Label();
            labelName = new Label();
            labelEmailAddress = new Label();
            labelBirthdate = new Label();
            labelGender = new Label();
            inputExperience = new ComboBox();
            valueID = new Label();
            inputGender = new ComboBox();
            inputBirthdate = new TextBox();
            label18 = new Label();
            label19 = new Label();
            inputPhone = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            inputEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            inputSpecialization = new TextBox();
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
            panelInstructors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInstructor).BeginInit();
            SuspendLayout();
            // 
            // panelInstructors
            // 
            panelInstructors.Controls.Add(labelPhone);
            panelInstructors.Controls.Add(DGVInstructor);
            panelInstructors.Controls.Add(filterGender);
            panelInstructors.Controls.Add(label28);
            panelInstructors.Controls.Add(filterExperience);
            panelInstructors.Controls.Add(label27);
            panelInstructors.Controls.Add(filterSpecialization);
            panelInstructors.Controls.Add(label26);
            panelInstructors.Controls.Add(inputSearch);
            panelInstructors.Controls.Add(label23);
            panelInstructors.Controls.Add(btnRefresh);
            panelInstructors.Controls.Add(btnSearch);
            panelInstructors.Controls.Add(btnDelete);
            panelInstructors.Controls.Add(btnUpdate);
            panelInstructors.Controls.Add(btnCreate);
            panelInstructors.Controls.Add(btnClear);
            panelInstructors.Controls.Add(labelSpecialization);
            panelInstructors.Controls.Add(labelExperienceRequired);
            panelInstructors.Controls.Add(labelName);
            panelInstructors.Controls.Add(labelEmailAddress);
            panelInstructors.Controls.Add(labelBirthdate);
            panelInstructors.Controls.Add(labelGender);
            panelInstructors.Controls.Add(inputExperience);
            panelInstructors.Controls.Add(valueID);
            panelInstructors.Controls.Add(inputGender);
            panelInstructors.Controls.Add(inputBirthdate);
            panelInstructors.Controls.Add(label18);
            panelInstructors.Controls.Add(label19);
            panelInstructors.Controls.Add(inputPhone);
            panelInstructors.Controls.Add(label8);
            panelInstructors.Controls.Add(label9);
            panelInstructors.Controls.Add(label10);
            panelInstructors.Controls.Add(label11);
            panelInstructors.Controls.Add(inputEmail);
            panelInstructors.Controls.Add(label6);
            panelInstructors.Controls.Add(label7);
            panelInstructors.Controls.Add(inputSpecialization);
            panelInstructors.Controls.Add(label4);
            panelInstructors.Controls.Add(label5);
            panelInstructors.Controls.Add(inputName);
            panelInstructors.Controls.Add(label16);
            panelInstructors.Controls.Add(label17);
            panelInstructors.Controls.Add(label14);
            panelInstructors.Controls.Add(label15);
            panelInstructors.Controls.Add(label3);
            panelInstructors.Controls.Add(label2);
            panelInstructors.Controls.Add(label1);
            panelInstructors.Controls.Add(button1);
            panelInstructors.Dock = DockStyle.Fill;
            panelInstructors.Location = new Point(0, 0);
            panelInstructors.Name = "panelInstructors";
            panelInstructors.Size = new Size(1260, 800);
            panelInstructors.TabIndex = 0;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.ForeColor = Color.Red;
            labelPhone.Location = new Point(864, 122);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 17);
            labelPhone.TabIndex = 66;
            labelPhone.Text = "labelPhone";
            labelPhone.Visible = false;
            // 
            // DGVInstructor
            // 
            DGVInstructor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInstructor.BackgroundColor = Color.White;
            DGVInstructor.BorderStyle = BorderStyle.None;
            DGVInstructor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVInstructor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVInstructor.EnableHeadersVisualStyles = false;
            DGVInstructor.GridColor = Color.FromArgb(255, 72, 0);
            DGVInstructor.Location = new Point(20, 340);
            DGVInstructor.Name = "DGVInstructor";
            DGVInstructor.ReadOnly = true;
            DGVInstructor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVInstructor.RowHeadersVisible = false;
            DGVInstructor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 138, 51);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DGVInstructor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGVInstructor.RowTemplate.Height = 29;
            DGVInstructor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVInstructor.Size = new Size(1220, 450);
            DGVInstructor.TabIndex = 65;
            DGVInstructor.CellClick += DGVInstructor_CellClick;
            // 
            // filterGender
            // 
            filterGender.AccessibleName = "Gender";
            filterGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterGender.ForeColor = Color.FromArgb(255, 109, 0);
            filterGender.FormattingEnabled = true;
            filterGender.Location = new Point(661, 291);
            filterGender.Name = "filterGender";
            filterGender.Size = new Size(198, 31);
            filterGender.TabIndex = 63;
            filterGender.Text = "Gender";
            // 
            // label28
            // 
            label28.BackColor = Color.FromArgb(255, 109, 0);
            label28.FlatStyle = FlatStyle.Flat;
            label28.Location = new Point(660, 290);
            label28.Name = "label28";
            label28.Size = new Size(200, 33);
            label28.TabIndex = 64;
            // 
            // filterExperience
            // 
            filterExperience.AccessibleName = "Experience";
            filterExperience.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterExperience.ForeColor = Color.FromArgb(255, 109, 0);
            filterExperience.FormattingEnabled = true;
            filterExperience.Location = new Point(341, 291);
            filterExperience.Name = "filterExperience";
            filterExperience.Size = new Size(198, 31);
            filterExperience.TabIndex = 61;
            filterExperience.Text = "Experience";
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
            // filterSpecialization
            // 
            filterSpecialization.AccessibleName = "Specialization";
            filterSpecialization.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            filterSpecialization.ForeColor = Color.FromArgb(255, 109, 0);
            filterSpecialization.FormattingEnabled = true;
            filterSpecialization.Location = new Point(21, 291);
            filterSpecialization.Name = "filterSpecialization";
            filterSpecialization.Size = new Size(198, 31);
            filterSpecialization.TabIndex = 59;
            filterSpecialization.Text = "Specialization";
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
            inputSearch.ForeColor = Color.Black;
            inputSearch.Location = new Point(21, 241);
            inputSearch.Name = "inputSearch";
            inputSearch.PlaceholderText = "Search for anything....";
            inputSearch.Size = new Size(838, 30);
            inputSearch.TabIndex = 0;
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
            btnSearch.Click += btnSearch_Click;
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
            btnCreate.Cursor = Cursors.Hand;
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
            btnClear.Location = new Point(864, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 32);
            btnClear.TabIndex = 51;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClearAll_Click;
            // 
            // labelSpecialization
            // 
            labelSpecialization.AutoSize = true;
            labelSpecialization.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpecialization.ForeColor = Color.Red;
            labelSpecialization.Location = new Point(369, 122);
            labelSpecialization.Name = "labelSpecialization";
            labelSpecialization.Size = new Size(115, 17);
            labelSpecialization.TabIndex = 50;
            labelSpecialization.Text = "labelSpecialization";
            labelSpecialization.Visible = false;
            // 
            // labelExperienceRequired
            // 
            labelExperienceRequired.AutoSize = true;
            labelExperienceRequired.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelExperienceRequired.ForeColor = Color.Red;
            labelExperienceRequired.Location = new Point(699, 122);
            labelExperienceRequired.Name = "labelExperienceRequired";
            labelExperienceRequired.Size = new Size(99, 17);
            labelExperienceRequired.TabIndex = 49;
            labelExperienceRequired.Text = "labelExperience";
            labelExperienceRequired.Visible = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.Red;
            labelName.Location = new Point(40, 197);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 17);
            labelName.TabIndex = 47;
            labelName.Text = "labelName";
            labelName.Visible = false;
            // 
            // labelEmailAddress
            // 
            labelEmailAddress.AutoSize = true;
            labelEmailAddress.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmailAddress.ForeColor = Color.Red;
            labelEmailAddress.Location = new Point(369, 197);
            labelEmailAddress.Name = "labelEmailAddress";
            labelEmailAddress.Size = new Size(67, 17);
            labelEmailAddress.TabIndex = 46;
            labelEmailAddress.Text = "labelEmail";
            labelEmailAddress.Visible = false;
            // 
            // labelBirthdate
            // 
            labelBirthdate.AutoSize = true;
            labelBirthdate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBirthdate.ForeColor = Color.Red;
            labelBirthdate.Location = new Point(699, 197);
            labelBirthdate.Name = "labelBirthdate";
            labelBirthdate.Size = new Size(88, 17);
            labelBirthdate.TabIndex = 45;
            labelBirthdate.Text = "labelBirthdate";
            labelBirthdate.Visible = false;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelGender.ForeColor = Color.Red;
            labelGender.Location = new Point(205, 122);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(79, 17);
            labelGender.TabIndex = 44;
            labelGender.Text = "labelGender";
            labelGender.Visible = false;
            // 
            // inputExperience
            // 
            inputExperience.AccessibleName = "Select years";
            inputExperience.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputExperience.ForeColor = Color.Black;
            inputExperience.FormattingEnabled = true;
            inputExperience.Items.AddRange(new object[] { "1 year", "2 years", "3 years", "4 years", "5 years" });
            inputExperience.Location = new Point(700, 92);
            inputExperience.Name = "inputExperience";
            inputExperience.Size = new Size(133, 28);
            inputExperience.TabIndex = 43;
            inputExperience.Text = "Select years";
            // 
            // valueID
            // 
            valueID.AccessibleName = "valueID";
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
            inputGender.AccessibleName = "Select gender";
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
            // inputBirthdate
            // 
            inputBirthdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputBirthdate.ForeColor = Color.Black;
            inputBirthdate.Location = new Point(700, 166);
            inputBirthdate.Name = "inputBirthdate";
            inputBirthdate.PlaceholderText = "dd/mm/yyyy";
            inputBirthdate.Size = new Size(133, 30);
            inputBirthdate.TabIndex = 39;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(255, 109, 0);
            label18.FlatStyle = FlatStyle.Flat;
            label18.Location = new Point(699, 165);
            label18.Name = "label18";
            label18.Size = new Size(135, 32);
            label18.TabIndex = 40;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(255, 109, 0);
            label19.Location = new Point(699, 145);
            label19.Name = "label19";
            label19.Size = new Size(77, 20);
            label19.TabIndex = 38;
            label19.Text = "Birthdate";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPhone
            // 
            inputPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputPhone.ForeColor = Color.Black;
            inputPhone.Location = new Point(865, 91);
            inputPhone.Name = "inputPhone";
            inputPhone.PlaceholderText = "Enter number";
            inputPhone.Size = new Size(133, 30);
            inputPhone.TabIndex = 36;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(255, 109, 0);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(864, 90);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(255, 109, 0);
            label9.Location = new Point(864, 70);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 35;
            label9.Text = "Phone Number";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 109, 0);
            label10.FlatStyle = FlatStyle.Flat;
            label10.Location = new Point(699, 90);
            label10.Name = "label10";
            label10.Size = new Size(135, 32);
            label10.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(255, 109, 0);
            label11.Location = new Point(699, 70);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 32;
            label11.Text = "Experience";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmail.ForeColor = Color.Black;
            inputEmail.Location = new Point(370, 166);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Enter instructor's email address";
            inputEmail.Size = new Size(298, 30);
            inputEmail.TabIndex = 30;
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
            // inputSpecialization
            // 
            inputSpecialization.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputSpecialization.ForeColor = Color.Black;
            inputSpecialization.Location = new Point(370, 91);
            inputSpecialization.Name = "inputSpecialization";
            inputSpecialization.PlaceholderText = "Enter instruction's specialization";
            inputSpecialization.Size = new Size(298, 30);
            inputSpecialization.TabIndex = 27;
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
            label5.Size = new Size(110, 20);
            label5.TabIndex = 26;
            label5.Text = "Specialization";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputName
            // 
            inputName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.ForeColor = Color.Black;
            inputName.Location = new Point(41, 166);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Enter instructor's name";
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
            label17.Size = new Size(126, 20);
            label17.TabIndex = 23;
            label17.Text = "Instructor Name";
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
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Instructor ID";
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
            label1.Text = "Instructor Information";
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
            // InstructorsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 800);
            Controls.Add(panelInstructors);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InstructorsManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InstructorsManagementForm";
            panelInstructors.ResumeLayout(false);
            panelInstructors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInstructor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInstructors;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox inputName;
        private Label label16;
        private Label label17;
        private Label label14;
        private Label label15;
        private TextBox inputPhone;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox inputEmail;
        private Label label6;
        private Label label7;
        private TextBox inputSpecialization;
        private Label label4;
        private Label label5;
        private TextBox inputBirthdate;
        private Label label18;
        private Label label19;
        private ComboBox inputGender;
        private Label valueID;
        private ComboBox inputExperience;
        private Label labelGender;
        private Label labelBirthdate;
        private Label labelSpecialization;
        private Label labelExperienceRequired;
        private Label labelName;
        private Label labelEmailAddress;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private TextBox inputSearch;
        private Button btnRefresh;
        private Button btnSearch;
        private Label label23;
        private ComboBox filterGender;
        private Label label28;
        private ComboBox filterExperience;
        private Label label27;
        private ComboBox filterSpecialization;
        private Label label26;
        private DataGridView DGVInstructor;
        private Label labelPhone;
    }
}