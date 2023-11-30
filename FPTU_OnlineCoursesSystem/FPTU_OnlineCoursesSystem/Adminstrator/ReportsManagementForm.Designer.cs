namespace FPTU_OnlineCoursesSystem
{
    partial class ReportsManagementForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            button1 = new Button();
            panelCourses = new Panel();
            labelYearBarChart = new Label();
            label7 = new Label();
            label6 = new Label();
            timeLabel = new Label();
            label3 = new Label();
            topRevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DGVCategoryList = new DataGridView();
            oo = new Label();
            valueTotalRevenue = new Button();
            label4 = new Label();
            valueTotalCoursesSold = new Button();
            filterYear = new ComboBox();
            label2 = new Label();
            filterMonth = new ComboBox();
            label14 = new Label();
            categoryRevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)topRevenueChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVCategoryList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryRevenueChart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 109, 0);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(610, 40);
            label1.TabIndex = 1;
            label1.Text = "Revenue Report";
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
            button1.Size = new Size(610, 180);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // panelCourses
            // 
            panelCourses.BackColor = Color.White;
            panelCourses.Controls.Add(labelYearBarChart);
            panelCourses.Controls.Add(label7);
            panelCourses.Controls.Add(label6);
            panelCourses.Controls.Add(timeLabel);
            panelCourses.Controls.Add(label3);
            panelCourses.Controls.Add(topRevenueChart);
            panelCourses.Controls.Add(DGVCategoryList);
            panelCourses.Controls.Add(oo);
            panelCourses.Controls.Add(valueTotalRevenue);
            panelCourses.Controls.Add(label4);
            panelCourses.Controls.Add(valueTotalCoursesSold);
            panelCourses.Controls.Add(filterYear);
            panelCourses.Controls.Add(label2);
            panelCourses.Controls.Add(filterMonth);
            panelCourses.Controls.Add(label14);
            panelCourses.Controls.Add(categoryRevenueChart);
            panelCourses.Controls.Add(label1);
            panelCourses.Controls.Add(button1);
            panelCourses.Dock = DockStyle.Fill;
            panelCourses.Location = new Point(0, 0);
            panelCourses.Name = "panelCourses";
            panelCourses.Size = new Size(1260, 800);
            panelCourses.TabIndex = 4;
            // 
            // labelYearBarChart
            // 
            labelYearBarChart.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelYearBarChart.ForeColor = Color.FromArgb(255, 109, 0);
            labelYearBarChart.Location = new Point(31, 451);
            labelYearBarChart.Name = "labelYearBarChart";
            labelYearBarChart.Size = new Size(58, 30);
            labelYearBarChart.TabIndex = 88;
            labelYearBarChart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(255, 109, 0);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Location = new Point(30, 450);
            label7.Name = "label7";
            label7.Size = new Size(60, 32);
            label7.TabIndex = 87;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 109, 0);
            label6.Location = new Point(335, 70);
            label6.Name = "label6";
            label6.Size = new Size(60, 30);
            label6.TabIndex = 86;
            label6.Text = "Time";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            timeLabel.Location = new Point(396, 69);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(213, 30);
            timeLabel.TabIndex = 85;
            timeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 109, 0);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(395, 68);
            label3.Name = "label3";
            label3.Size = new Size(215, 32);
            label3.TabIndex = 84;
            // 
            // topRevenueChart
            // 
            topRevenueChart.BorderlineColor = Color.FromArgb(255, 109, 0);
            topRevenueChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            topRevenueChart.BorderlineWidth = 2;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisX.TitleForeColor = Color.FromArgb(255, 109, 0);
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisX2.TitleFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisY.TitleForeColor = Color.FromArgb(255, 109, 0);
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            topRevenueChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.HeaderSeparatorColor = Color.Transparent;
            legend1.ItemColumnSeparatorColor = Color.Transparent;
            legend1.Name = "Legend1";
            topRevenueChart.Legends.Add(legend1);
            topRevenueChart.Location = new Point(650, 60);
            topRevenueChart.Name = "topRevenueChart";
            topRevenueChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            topRevenueChart.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(255, 138, 51)
    };
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "TopCoursesRevenue";
            topRevenueChart.Series.Add(series1);
            topRevenueChart.Size = new Size(590, 360);
            topRevenueChart.TabIndex = 83;
            topRevenueChart.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            title1.ForeColor = Color.FromArgb(255, 109, 0);
            title1.Name = "Title1";
            title1.Text = "Top Courses";
            topRevenueChart.Titles.Add(title1);
            // 
            // DGVCategoryList
            // 
            DGVCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategoryList.BackgroundColor = Color.White;
            DGVCategoryList.BorderStyle = BorderStyle.None;
            DGVCategoryList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 109, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVCategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCategoryList.EnableHeadersVisualStyles = false;
            DGVCategoryList.GridColor = Color.FromArgb(255, 72, 0);
            DGVCategoryList.Location = new Point(20, 220);
            DGVCategoryList.Name = "DGVCategoryList";
            DGVCategoryList.ReadOnly = true;
            DGVCategoryList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVCategoryList.RowHeadersVisible = false;
            DGVCategoryList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 138, 51);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DGVCategoryList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGVCategoryList.RowTemplate.Height = 29;
            DGVCategoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCategoryList.Size = new Size(610, 200);
            DGVCategoryList.TabIndex = 82;
            // 
            // oo
            // 
            oo.AutoSize = true;
            oo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            oo.ForeColor = Color.FromArgb(255, 109, 0);
            oo.Location = new Point(340, 120);
            oo.Name = "oo";
            oo.Size = new Size(108, 20);
            oo.TabIndex = 77;
            oo.Text = "Total Revenue";
            // 
            // valueTotalRevenue
            // 
            valueTotalRevenue.Enabled = false;
            valueTotalRevenue.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            valueTotalRevenue.FlatAppearance.BorderSize = 2;
            valueTotalRevenue.FlatStyle = FlatStyle.Flat;
            valueTotalRevenue.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            valueTotalRevenue.Location = new Point(335, 130);
            valueTotalRevenue.Name = "valueTotalRevenue";
            valueTotalRevenue.Size = new Size(275, 60);
            valueTotalRevenue.TabIndex = 76;
            valueTotalRevenue.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 109, 0);
            label4.Location = new Point(45, 120);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 75;
            label4.Text = "Total Courses Sold";
            // 
            // valueTotalCoursesSold
            // 
            valueTotalCoursesSold.Enabled = false;
            valueTotalCoursesSold.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            valueTotalCoursesSold.FlatAppearance.BorderSize = 2;
            valueTotalCoursesSold.FlatStyle = FlatStyle.Flat;
            valueTotalCoursesSold.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            valueTotalCoursesSold.Location = new Point(40, 130);
            valueTotalCoursesSold.Name = "valueTotalCoursesSold";
            valueTotalCoursesSold.Size = new Size(275, 60);
            valueTotalCoursesSold.TabIndex = 74;
            valueTotalCoursesSold.UseVisualStyleBackColor = true;
            // 
            // filterYear
            // 
            filterYear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterYear.ForeColor = Color.Black;
            filterYear.FormattingEnabled = true;
            filterYear.Items.AddRange(new object[] { "2023", "2024" });
            filterYear.Location = new Point(196, 72);
            filterYear.Name = "filterYear";
            filterYear.Size = new Size(118, 28);
            filterYear.TabIndex = 73;
            filterYear.Text = "Select year";
            filterYear.SelectedIndexChanged += filterYear_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 109, 0);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(195, 70);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 72;
            // 
            // filterMonth
            // 
            filterMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterMonth.ForeColor = Color.Black;
            filterMonth.FormattingEnabled = true;
            filterMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            filterMonth.Location = new Point(41, 72);
            filterMonth.Name = "filterMonth";
            filterMonth.Size = new Size(118, 28);
            filterMonth.TabIndex = 70;
            filterMonth.Text = "Select month";
            filterMonth.SelectedIndexChanged += filterMonth_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(255, 109, 0);
            label14.FlatStyle = FlatStyle.Flat;
            label14.Location = new Point(40, 70);
            label14.Name = "label14";
            label14.Size = new Size(120, 32);
            label14.TabIndex = 69;
            // 
            // categoryRevenueChart
            // 
            categoryRevenueChart.BorderlineColor = Color.FromArgb(255, 109, 0);
            categoryRevenueChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            categoryRevenueChart.BorderlineWidth = 2;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.Maximum = 12D;
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisX.Title = "Month";
            chartArea2.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisX.TitleForeColor = Color.FromArgb(255, 109, 0);
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.Title = "Revenue";
            chartArea2.AxisY.TitleFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisY.TitleForeColor = Color.FromArgb(255, 109, 0);
            chartArea2.AxisY2.LineWidth = 2;
            chartArea2.BackColor = Color.White;
            chartArea2.BorderColor = Color.FromArgb(255, 109, 0);
            chartArea2.BorderWidth = 4;
            chartArea2.Name = "ChartArea1";
            categoryRevenueChart.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend";
            legend2.Title = "Categories Name";
            legend2.TitleFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            legend2.TitleForeColor = Color.FromArgb(255, 109, 0);
            categoryRevenueChart.Legends.Add(legend2);
            categoryRevenueChart.Location = new Point(20, 440);
            categoryRevenueChart.Name = "categoryRevenueChart";
            series2.BorderColor = Color.FromArgb(255, 109, 0);
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            series2.Legend = "Legend";
            series2.MarkerBorderWidth = 2;
            series2.Name = " ";
            series2.XValueMember = "Month";
            series2.YValueMembers = "TotalRevenue";
            categoryRevenueChart.Series.Add(series2);
            categoryRevenueChart.Size = new Size(1220, 340);
            categoryRevenueChart.TabIndex = 67;
            categoryRevenueChart.Text = "CourseCategoriesRevenue";
            title2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            title2.ForeColor = Color.FromArgb(255, 109, 0);
            title2.Name = "Title1";
            title2.Text = "Course Categories Revenue";
            categoryRevenueChart.Titles.Add(title2);
            // 
            // ReportsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 800);
            Controls.Add(panelCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportsManagementForm";
            panelCourses.ResumeLayout(false);
            panelCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)topRevenueChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVCategoryList).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryRevenueChart).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button1;
        private Panel panelCourses;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoryRevenueChart;
        private ComboBox filterMonth;
        private Label label14;
        private ComboBox filterYear;
        private Label label2;
        private Button valueTotalCoursesSold;
        private Label oo;
        private Button valueTotalRevenue;
        private Label label4;
        private DataGridView DGVCategoryList;
        private System.Windows.Forms.DataVisualization.Charting.Chart topRevenueChart;
        private Label label6;
        private Label timeLabel;
        private Label label3;
        private Label labelYearBarChart;
        private Label label7;
    }
}