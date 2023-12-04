using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace FPTU_OnlineCoursesSystem
{
    public partial class ReportsManagementForm : Form
    {
        // Timer to update the time label
        private System.Windows.Forms.Timer timer;

        Size normalCategoriesChartSize;

        public ReportsManagementForm()
        {
            InitializeComponent();
            loadDataWithoutFilter();
            startTimer();
            labelYearBarChart.Text = DateTime.Now.Year.ToString();
            normalCategoriesChartSize = categoryRevenueChart.Size;
        }

        #region UIInteraction
        // Method to start the timer
        private void startTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer.Tick += timer_Tick;
            timer.Start();

        }

        // Method to update the time label
        private void timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current time
            timeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        #endregion
        // Function to load data without filter
        private void loadDataWithoutFilter()
        {
            try
            {
                loadDataForFilter(null, null);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("LoadDataWithoutFilter - " + ex.Message);
            }
        }

        // Function to load data with filter
        private void loadDataWithFilter(string selectedMonth, string selectedYear)
        {
            try
            {
                if (selectedMonth != null && selectedYear == null)
                {
                    selectedYear = DateTime.Now.Year.ToString();
                }
                else if (selectedMonth == null && selectedYear != null)
                {
                    loadDataForFilter(null, selectedYear);
                    return;
                }

                loadDataForFilter(selectedMonth, selectedYear);

            }
            catch (Exception ex)
            {
                Helpers.ShowError("LoadDataWithFilter - " + ex.Message);
            }
        }

        private void loadDataForFilter(string selectedMonth, string selectedYear)
        {
            loadCategoriesRevenueList(selectedMonth, selectedYear);
            topRevenueCourses(selectedMonth, selectedYear);
            categoryRevenue(selectedYear ?? DateTime.Now.Year.ToString());
        }

        // Function to load data into the DGVCategoryList
        private void loadCategoriesRevenueList(string selectedMonth, string selectedYear)
        {

            try
            {
                SqlParameter[] parameters = {
                                            new SqlParameter("@Month", (object)selectedMonth ?? DBNull.Value),
                                            new SqlParameter("@Year", (object)selectedYear ?? DBNull.Value)
                                            };

                CRUD.ViewData(DGVCategoryList, ReportQueryString.categoryRevenueQuery, parameters);

                calculateTotal(selectedMonth, selectedYear);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("LoadCategoriesRevenueList - " + ex.Message);
            }
        }

        // Function to calculate the total courses sold and total revenue
        private void calculateTotal(string selectedMonth, string selectedYear)
        {
            try
            {

                SqlParameter[] parameters = {
                                            new SqlParameter("@Month", (object)selectedMonth ?? DBNull.Value),
                                            new SqlParameter("@Year", (object)selectedYear ?? DBNull.Value)
                                            };

                DataTable resultTable = DBConnection.ExecuteQuery(ReportQueryString.totalQuery, parameters);

                if (resultTable.Rows.Count > 0)
                {
                    int totalCoursesSold = Convert.ToInt32(resultTable.Rows[0]["TotalCoursesSold"]);
                    decimal totalRevenue = Convert.ToDecimal(resultTable.Rows[0]["TotalRevenue"]);

                    valueTotalCoursesSold.Text = totalCoursesSold.ToString();
                    valueTotalRevenue.Text = totalRevenue.ToString("C");
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError("CalculateTotal - " + ex.Message);
            }
        }

        // Function to load data into the topRevenueChart
        private void topRevenueCourses(string selectedMonth, string selectedYear)
        {
            try
            {
                SqlParameter[] parameters = {
                                             new SqlParameter("@Month", string.IsNullOrEmpty(selectedMonth) ? (object)DBNull.Value : selectedMonth),
                                             new SqlParameter("@Year", string.IsNullOrEmpty(selectedYear) ? (object)DBNull.Value : selectedYear)
                                             };

                DataTable dataTable = DBConnection.ExecuteQuery(ReportQueryString.topRevenueCoursesQuery, parameters);

                topRevenueChart.Series.Clear();
                topRevenueChart.Series.Add(new Series("TopCoursesRevenue"));
                topRevenueChart.Series["TopCoursesRevenue"].ChartType = SeriesChartType.Bar;

                foreach (DataRow row in dataTable.Rows)
                {
                    string courseName = row["CourseName"].ToString();
                    double totalRevenue = Convert.ToDouble(row["TotalRevenue"]);

                    topRevenueChart.Series["TopCoursesRevenue"].Points.AddXY(courseName, totalRevenue);
                }

                if (topRevenueChart.Legends.FindByName("TopCoursesLegend") == null)
                {
                    Legend legend = new Legend("TopCoursesLegend");
                    topRevenueChart.Legends.Add(legend);
                }

                topRevenueChart.Series["TopCoursesRevenue"].IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Best revenue - " + ex.Message);
            }
        }

        // Function to load data into the categoryRevenueChart
        private void categoryRevenue(string selectedYear)
        {
            categoryRevenueChart.Series.Clear();
            categoryRevenueChart.Legends.Clear();

            Color[] lineColors = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Brown, Color.Cyan, Color.Magenta, Color.Yellow, Color.Lime };

            try
            {
                string query = "SELECT CategoryName FROM Category";
                DataTable categoryTable = DBConnection.ExecuteQuery(query, null);

                int colorIndex = 0; // To choose the color for the line
                double maxRevenue = 0.0; // To calculate the maximum revenue

                foreach (DataRow row in categoryTable.Rows)
                {
                    string categoryName = row["CategoryName"].ToString();
                    Series series = new Series(categoryName)
                    {
                        ChartType = SeriesChartType.Spline,
                        Color = lineColors[colorIndex],
                        BorderWidth = 2
                    };

                    colorIndex = (colorIndex + 1) % lineColors.Length;

                    for (int month = 1; month <= 12; month++)
                    {
                        double monthlyRevenue = getMonthlyRevenue(categoryName, month, selectedYear);
                        series.Points.AddXY(month, monthlyRevenue);
                        maxRevenue = Math.Max(maxRevenue, monthlyRevenue);
                    }

                    categoryRevenueChart.Series.Add(series);
                }

                // Set the maximum value for the y axis
                int maxRevenueInt = Convert.ToInt32(maxRevenue);
                maxRevenue = maxRevenueInt + 1000;

                categoryRevenueChart.ChartAreas[0].AxisY.Maximum = maxRevenue;
                categoryRevenueChart.ChartAreas[0].AxisY.Interval = Math.Round(maxRevenue / 5, 0);               

                // Set the legend
                categoryRevenueChart.Legends.Add(new Legend("Legend"));
            }
            catch (Exception ex)
            {
                Helpers.ShowError("CategoryRevenue - " + ex.Message);
            }
        }

        // Function to get the monthly revenue of a category
        private double getMonthlyRevenue(string categoryName, int month, string selectedYear)
        {
            try
            {
                SqlParameter[] parameters = {
                                             new SqlParameter("@CategoryName", categoryName),
                                             new SqlParameter("@Month", month),
                                             new SqlParameter("@Year", string.IsNullOrEmpty(selectedYear) ? (object)DBNull.Value : selectedYear)
                                             };

                DataTable resultTable = DBConnection.ExecuteQuery(ReportQueryString.monthlyRevenueQuery, parameters);

                if (resultTable.Rows.Count > 0)
                {
                    object result = resultTable.Rows[0]["MonthlyRevenue"];
                    return Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Get monthly revenue - " + ex.Message);
            }

            return 0.0;
        }

        #region Event handlers
        // Method to handle the selected index changed event of the filterMonth combobox
        private void filterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = filterMonth.SelectedItem?.ToString();
            string selectedYear = filterYear.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString();

            loadDataWithFilter(selectedMonth, selectedYear);

        }

        // Method to handle the selected index changed event of the filterYear combobox
        private void filterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = filterMonth.SelectedItem?.ToString();
            string selectedYear = filterYear.SelectedItem?.ToString();

            loadDataWithFilter(selectedMonth, selectedYear);

            labelYearBarChart.Text = selectedYear;
        }
        #endregion

    }
}
