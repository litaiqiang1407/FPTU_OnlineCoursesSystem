using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FPTU_OnlineCoursesSystem
{
    public partial class ReportsManagementForm : Form
    {
        // Connection string to your SQL Server
        private string connectionString = "Data Source=TAIKUN\\SQLEXPRESS;Initial Catalog=FPTU_OnlineCourseSystem_DB;Integrated Security=True; MultipleActiveResultSets=true";

        private System.Windows.Forms.Timer timer;

        public ReportsManagementForm()
        {
            InitializeComponent();
            LoadDataWithoutFilter();
            StartTimer();
            labelYearBarChart.Text = DateTime.Now.Year.ToString();
        }
        private void StartTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current time
            timeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void filterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = filterMonth.SelectedItem.ToString();
            string selectedYear = filterYear.SelectedItem?.ToString();

            if (selectedMonth != null && selectedYear == null)
            {
                // Only month is selected, filterYear will be the current year
                selectedYear = DateTime.Now.Year.ToString();
            }

            LoadDataWithFilter(selectedMonth, selectedYear);

        }

        private void filterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = filterMonth.SelectedItem?.ToString();
            string selectedYear = filterYear.SelectedItem?.ToString();

            LoadDataWithFilter(selectedMonth, selectedYear);

            labelYearBarChart.Text = selectedYear;
        }

        private void LoadDataWithoutFilter()
        {
            try
            {
                LoadCategoriesRevenueList(null, null); // Load all data initially
                BestRevenueCourses(null, null);
                CategoryRevenue(DateTime.Now.Year.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadDataWithFilter(string selectedMonth, string selectedYear)
        {
            try
            {
                if (selectedMonth != null && selectedYear == null)
                {
                    // Only month is selected, filterYear will be the current year
                    selectedYear = DateTime.Now.Year.ToString();
                }
                else if (selectedMonth == null && selectedYear != null)
                {
                    // Only year is selected, load data for the entire year
                    LoadCategoriesRevenueList(null, selectedYear);
                    BestRevenueCourses(null, selectedYear);
                    CategoryRevenue(selectedYear);
                    return; // Return to avoid unnecessary additional processing
                }

                LoadCategoriesRevenueList(selectedMonth, selectedYear);
                BestRevenueCourses(selectedMonth, selectedYear);
                CategoryRevenue(selectedYear);
                // You can call other functions here with the filtered data
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadCategoriesRevenueList(string selectedMonth, string selectedYear)
        {

            try
            {               
                SqlParameter[] parameters = {
                                            new SqlParameter("@Month", (object)selectedMonth ?? DBNull.Value),
                                            new SqlParameter("@Year", (object)selectedYear ?? DBNull.Value)
                                            };

                CRUD.ViewData(DGVCategoryList, ReportQueryString.categoryRevenueQuery, parameters);

                CalculateTotal(selectedMonth, selectedYear);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("An error occurred while loading data: " + ex.Message);
            }
        }

        private void CalculateTotal(string selectedMonth, string selectedYear)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string totalQuery = "SELECT " +
                                   "SUM(Course.NumberOfEnrollments) AS TotalCoursesSold, " +
                                   "SUM(Course.NumberOfEnrollments * Course.CoursePrice) AS TotalRevenue " +
                                   "FROM Course " +
                                   "INNER JOIN Enrollment ON Course.CourseID = Enrollment.CourseID " +
                                   "WHERE (@Month IS NULL OR MONTH(Enrollment.EnrollmentDate) = @Month) " +
                                   "AND (@Year IS NULL OR YEAR(Enrollment.EnrollmentDate) = @Year)";

                    SqlCommand command = new SqlCommand(totalQuery, connection);
                    command.Parameters.AddWithValue("@Month", (object)selectedMonth ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Year", (object)selectedYear ?? DBNull.Value);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int totalCoursesSold = Convert.ToInt32(reader["TotalCoursesSold"]);
                        decimal totalRevenue = Convert.ToDecimal(reader["TotalRevenue"]);

                        valueTotalCoursesSold.Text = totalCoursesSold.ToString();
                        valueTotalRevenue.Text = totalRevenue.ToString("C"); // Display as currency
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError("An error occurred while calculating total system data: " + ex.Message);
            }
        }


        private void BestRevenueCourses(string month, string year)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the top 5 courses with the highest revenue
                    string bestRevenueCoursesQuery = "SELECT TOP 5 CourseName, " +
                                                     "SUM(Course.NumberOfEnrollments * Course.CoursePrice) AS TotalRevenue " +
                                                     "FROM Enrollment " +
                                                     "INNER JOIN Course ON Enrollment.CourseID = Course.CourseID " +
                                                     "WHERE (@FilterMonth IS NULL OR MONTH(Enrollment.EnrollmentDate) = @FilterMonth) " +
                                                     "AND (@FilterYear IS NULL OR YEAR(Enrollment.EnrollmentDate) = @FilterYear) " +
                                                     "GROUP BY CourseName " +
                                                     "ORDER BY TotalRevenue"; // Order by descending to get the highest revenue first

                    SqlCommand command = new SqlCommand(bestRevenueCoursesQuery, connection);
                    command.Parameters.AddWithValue("@FilterMonth", string.IsNullOrEmpty(month) ? (object)DBNull.Value : month);
                    command.Parameters.AddWithValue("@FilterYear", string.IsNullOrEmpty(year) ? (object)DBNull.Value : year);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Set up the chart control
                    topRevenueCourses.Series.Clear();
                    topRevenueCourses.Series.Add(new Series("TopCourses"));
                    topRevenueCourses.Series["TopCourses"].ChartType = SeriesChartType.Bar;

                    // Add data points to the chart
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string courseName = row["CourseName"].ToString();
                        double totalRevenue = Convert.ToDouble(row["TotalRevenue"]);

                        topRevenueCourses.Series["TopCourses"].Points.AddXY(courseName, totalRevenue);
                    }

                    // Check if the Legend exists before adding a new one
                    if (topRevenueCourses.Legends.FindByName("TopCoursesLegend") == null)
                    {
                        Legend legend = new Legend("TopCoursesLegend");
                        topRevenueCourses.Legends.Add(legend);
                    }

                    topRevenueCourses.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    topRevenueCourses.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 8;
                    topRevenueCourses.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                    topRevenueCourses.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

                    // Enable data point labels
                    topRevenueCourses.Series["TopCourses"].IsValueShownAsLabel = true;
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Best revenue - " + ex.Message);
            }
        }

        private void CategoryRevenue(string selectedYear)
        {
            categoryRevenueChart.Series.Clear();
            categoryRevenueChart.Legends.Clear();

            // Suggested colors for lines
            Color[] lineColors = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Brown, Color.Cyan, Color.Magenta, Color.Yellow, Color.Lime };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryName FROM Category";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    int colorIndex = 0; // Index for selecting colors from the array

                    while (reader.Read())
                    {
                        string categoryName = reader["CategoryName"].ToString();
                        Series series = new Series(categoryName)
                        {
                            ChartType = SeriesChartType.Spline,
                            Color = lineColors[colorIndex], // Set the color for the line
                            BorderWidth = 2
                        };

                        colorIndex = (colorIndex + 1) % lineColors.Length; // Move to the next color

                        for (int month = 1; month <= 12; month++)
                        {
                            double monthlyRevenue = GetMonthlyRevenue(categoryName, month, selectedYear);
                            series.Points.AddXY(month, monthlyRevenue);
                        }

                        categoryRevenueChart.Series.Add(series);
                    }
                }
            }

            categoryRevenueChart.ChartAreas[0].AxisX.Title = "Month";
            categoryRevenueChart.ChartAreas[0].AxisY.Title = "Revenue";
            categoryRevenueChart.ChartAreas[0].AxisX.Minimum = 1; // Set the minimum value for the X-axis
            categoryRevenueChart.ChartAreas[0].AxisX.Maximum = 12; // Set the maximum value for the X-axis

            categoryRevenueChart.Legends.Add(new Legend("Legend"));
            categoryRevenueChart.Legends["Legend"].DockedToChartArea = "ChartArea1";
            categoryRevenueChart.Legends["Legend"].IsDockedInsideChartArea = false;
        }

        private double GetMonthlyRevenue(string categoryName, int month, string selectedYear)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string monthlyRevenueQuery = "SELECT " +
                                             "ISNULL(SUM(Course.NumberOfEnrollments * Course.CoursePrice), 0) AS MonthlyRevenue " +
                                             "FROM Course " +
                                             "INNER JOIN Enrollment ON Course.CourseID = Enrollment.CourseID " +
                                             "WHERE Course.CategoryID = (SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName) " +
                                             "AND MONTH(Enrollment.EnrollmentDate) = @Month " +
                                             "AND (@Year IS NULL OR YEAR(Enrollment.EnrollmentDate) = @Year)";

                using (SqlCommand command = new SqlCommand(monthlyRevenueQuery, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    command.Parameters.AddWithValue("@Month", month);
                    command.Parameters.AddWithValue("@Year", string.IsNullOrEmpty(selectedYear) ? (object)DBNull.Value : selectedYear);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        return Convert.ToDouble(result);
                }
            }
            return 0.0;
        }
    }
}
