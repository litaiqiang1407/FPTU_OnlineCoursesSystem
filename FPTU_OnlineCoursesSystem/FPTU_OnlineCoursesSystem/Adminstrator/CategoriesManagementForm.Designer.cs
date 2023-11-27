namespace FPTU_OnlineCoursesSystem
{
    partial class CategoriesManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesManagementForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            inputSearch = new TextBox();
            label23 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            labelName = new Label();
            valueID = new Label();
            inputDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            inputName = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelCategory = new Panel();
            DGVCategory = new DataGridView();
            panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCategory).BeginInit();
            SuspendLayout();
            // 
            // inputSearch
            // 
            inputSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputSearch.Location = new Point(21, 241);
            inputSearch.Name = "inputSearch";
            inputSearch.PlaceholderText = "Search for anything....";
            inputSearch.Size = new Size(840, 30);
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
            // valueID
            // 
            valueID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueID.ForeColor = Color.FromArgb(255, 109, 0);
            valueID.Location = new Point(41, 91);
            valueID.Name = "valueID";
            valueID.Size = new Size(298, 30);
            valueID.TabIndex = 42;
            valueID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputDescription
            // 
            inputDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputDescription.ForeColor = Color.Black;
            inputDescription.Location = new Point(370, 91);
            inputDescription.Multiline = true;
            inputDescription.Name = "inputDescription";
            inputDescription.PlaceholderText = "Enter category's description";
            inputDescription.Size = new Size(631, 105);
            inputDescription.TabIndex = 27;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 109, 0);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(369, 90);
            label4.Name = "label4";
            label4.Size = new Size(633, 107);
            label4.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 109, 0);
            label5.Location = new Point(369, 70);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 26;
            label5.Text = "Description";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputName
            // 
            inputName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.ForeColor = Color.Black;
            inputName.Location = new Point(41, 166);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Enter category's name";
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
            label17.Size = new Size(121, 20);
            label17.TabIndex = 23;
            label17.Text = "Category Name";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 109, 0);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(40, 90);
            label3.Name = "label3";
            label3.Size = new Size(300, 32);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 109, 0);
            label2.Location = new Point(40, 70);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Category ID";
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
            label1.Text = "Category Information";
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
            // panelCategory
            // 
            panelCategory.Controls.Add(DGVCategory);
            panelCategory.Controls.Add(inputSearch);
            panelCategory.Controls.Add(label23);
            panelCategory.Controls.Add(btnRefresh);
            panelCategory.Controls.Add(btnSearch);
            panelCategory.Controls.Add(btnDelete);
            panelCategory.Controls.Add(btnUpdate);
            panelCategory.Controls.Add(btnCreate);
            panelCategory.Controls.Add(labelName);
            panelCategory.Controls.Add(valueID);
            panelCategory.Controls.Add(inputDescription);
            panelCategory.Controls.Add(label4);
            panelCategory.Controls.Add(label5);
            panelCategory.Controls.Add(inputName);
            panelCategory.Controls.Add(label16);
            panelCategory.Controls.Add(label17);
            panelCategory.Controls.Add(label3);
            panelCategory.Controls.Add(label2);
            panelCategory.Controls.Add(label1);
            panelCategory.Controls.Add(button1);
            panelCategory.Dock = DockStyle.Fill;
            panelCategory.Location = new Point(0, 0);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(1260, 800);
            panelCategory.TabIndex = 1;
            // 
            // DGVCategory
            // 
            DGVCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategory.BackgroundColor = Color.White;
            DGVCategory.BorderStyle = BorderStyle.None;
            DGVCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCategory.EnableHeadersVisualStyles = false;
            DGVCategory.GridColor = Color.FromArgb(255, 72, 0);
            DGVCategory.Location = new Point(20, 340);
            DGVCategory.Name = "DGVCategory";
            DGVCategory.ReadOnly = true;
            DGVCategory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVCategory.RowHeadersVisible = false;
            DGVCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 138, 51);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DGVCategory.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGVCategory.RowTemplate.Height = 29;
            DGVCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCategory.Size = new Size(1220, 450);
            DGVCategory.TabIndex = 70;
            DGVCategory.CellClick += DGVCategory_CellClick;
            // 
            // CategoriesManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 800);
            Controls.Add(panelCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriesManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriesManagementForm";
            panelCategory.ResumeLayout(false);
            panelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox inputSearch;
        private Label label23;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Label labelName;
        private Label valueID;
        private TextBox inputDescription;
        private Label label4;
        private Label label5;
        private TextBox inputName;
        private Label label16;
        private Label label17;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel panelCategory;
        private DataGridView DGVCategory;
    }
}