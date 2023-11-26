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
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;

namespace FPTU_OnlineCoursesSystem
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            LoadCoursesListData();
        }

        // Load list courses data into DataGridView
        private void LoadCoursesListData()
        {
            try
            {
                // Query to retrieve course data
                string coursesListQuery = "SELECT " +
                                          "Course.CourseName AS 'Course', " +
                                          "Category.CategoryName AS 'Category', " +
                                          "Instructor.InstructorName AS 'Instructor', " +
                                          "Course.NumberOfEnrollments AS 'Enrollments', " +
                                          "Course.RatingValue AS 'Rating', " +
                                          "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                          "Course.Duration, " +
                                          "FORMAT(Course.CoursePrice, 'C') AS 'Price($)' " +
                                          "FROM Course " +
                                          "INNER JOIN Category  ON Course.CategoryID = Category.CategoryID " +
                                          "INNER JOIN Instructor  ON Course.InstructorID = Instructor.InstructorID";

                // Use DBConnection to execute the query and get the result as a DataTable
                DataTable dataTable = DBConnection.ExecuteQuery(coursesListQuery, null);

                // Set the DataTable as the DataSource for DataGridView
                DGVCoursesList.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Helpers.ShowError(ex.Message);
            }
        }       

        private string GetCourseDescription(string courseName)
        {
            string description = string.Empty;

            try
            {
                string query = "SELECT CourseDescription FROM Course WHERE CourseName = @CourseName";
                SqlParameter[] parameters = { new SqlParameter("@CourseName", courseName) };

                // Use DBConnection to execute the query and get the result as a DataTable
                DataTable result = DBConnection.ExecuteQuery(query, parameters);

                // Check if there are any rows returned
                if (result.Rows.Count > 0)
                {
                    // Assuming 'CourseDescription' is a string column, retrieve the value
                    description = result.Rows[0]["CourseDescription"].ToString();
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError(ex.Message);
            }
            return description;
        }

        private void LoadReviewsForCourse(string courseName)
        {
            try
            {
                // Query to retrieve reviews for the selected course
                string query = "SELECT Student.StudentName AS 'Student', " +
                                "Rating.RatingValue AS 'Rating', " +
                                "Rating.Review AS 'Content' " +
                                "FROM Rating " +
                                "INNER JOIN Student ON Rating.StudentID = Student.StudentID " +
                                "INNER JOIN Course ON Rating.CourseID = Course.CourseID " +
                                "WHERE Course.CourseName = @CourseName";

                SqlParameter[] parameters = { new SqlParameter("@CourseName", courseName) };

                // Use DBConnection to execute the query and get the result as a DataTable
                DataTable dataTable = DBConnection.ExecuteQuery(query, parameters);

                // Bind the review data to DGVReviewList
                DGVCourseReview.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Helpers.ShowError(ex.Message);
            }
        }

        private void PerformSearch(string searchValue)
        {
            try
            {
                // Query to retrieve course data
                string searchQuery = "SELECT " +
                                     "Course.CourseName AS 'Course', " +
                                     "Category.CategoryName AS 'Category', " +
                                     "Instructor.InstructorName AS 'Instructor', " +
                                     "Course.NumberOfEnrollments AS 'Enrollments', " +
                                     "Course.RatingValue AS 'Rating', " +
                                     "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                     "Course.Duration, " +
                                     "FORMAT(Course.CoursePrice, 'C') AS 'Price($)' " +
                                     "FROM Course " +
                                     "INNER JOIN Category ON Course.CategoryID = Category.CategoryID " +
                                     "INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID " +
                                     "WHERE Course.CourseName LIKE @SearchValue";

                SqlParameter[] parameters = { new SqlParameter("@SearchValue", "%" + searchValue + "%") };

                // Use DBConnection to execute the query and get the result as a DataTable
                DataTable dataTable = DBConnection.ExecuteQuery(searchQuery, parameters);

                // Set the DataTable as the DataSource for your DataGridView
                DGVCoursesList.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Helpers.ShowError(ex.Message);
            }
        }
       
        private void inputSearchValue_TextChanged(object sender, EventArgs e)
        {
            PerformSearch(inputSearchValue.Text);
        }

        private void DGVCoursesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            courseInformationFrame.Image = null;
            courseInformationFrame.Enabled = false;
            courseInformationFrame.SendToBack();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVCoursesList.Rows[e.RowIndex];

                if (row != null)
                {
                    infoName.Text = row.Cells["Course"].Value.ToString();
                    infoCategory.Text = row.Cells["Category"].Value.ToString();
                    infoInstructor.Text = row.Cells["Instructor"].Value.ToString();
                    infoEnrollment.Text = row.Cells["Enrollments"].Value.ToString();
                    infoRating.Text = row.Cells["Rating"].Value.ToString();
                    infoDate.Text = row.Cells["Date"].Value.ToString();
                    infoDuration.Text = row.Cells["Duration"].Value.ToString();
                    infoPrice.Text = row.Cells["Price($)"].Value.ToString();

                    // Retrieve and display the course description
                    string courseName = row.Cells["Course"].Value.ToString();
                    string courseDescription = GetCourseDescription(courseName);
                    infoDescription.Text = courseDescription;

                    // Load reviews for the selected course
                    LoadReviewsForCourse(courseName);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
