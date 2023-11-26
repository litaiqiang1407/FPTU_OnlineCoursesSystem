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

namespace FPTU_OnlineCoursesSystem
{
    public partial class RatingsManagementForm : Form
    {
        // Database connection string 
        string connectionString = "Data Source=TAIKUN\\SQLEXPRESS;Initial Catalog=FPTU_OnlineCourseSystem_DB;Integrated Security=True; MultipleActiveResultSets=true";

        public RatingsManagementForm()
        {
            InitializeComponent();
            LoadRatingData();
            valueRatingID.Text = GetNextValueID();
        }

        // Load rating data into DataGridView
        private void LoadRatingData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Rating.RatingID AS 'Rating ID', Rating.StudentID AS 'Student ID', Student.StudentName AS 'Student Name', " +
                               "Rating.CourseID AS 'Course ID', Course.CourseName AS 'Course Name', Rating.RatingValue AS 'Value', Rating.Review AS 'Review' " +
                               "FROM Rating " +
                               "INNER JOIN Student ON Rating.StudentID = Student.StudentID " +
                               "INNER JOIN Course ON Rating.CourseID = Course.CourseID";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    DGVRating.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Get the next available valueID
        private string GetNextValueID()
        {
            int nextValueID = 1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT MAX(EnrollmentID) FROM Enrollment";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        nextValueID = Convert.ToInt32(result) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the next valueID: " + ex.Message);
            }

            string nextValueIDText = nextValueID.ToString();
            return nextValueIDText;
        }

        private void DGVRating_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVRating.Rows[e.RowIndex];

                if (row != null)
                {
                    valueRatingID.Text = row.Cells["Rating ID"].Value.ToString();
                    valueCourseID.Text = row.Cells["Course ID"].Value.ToString();
                    valueStudentID.Text = row.Cells["Student ID"].Value.ToString();
                    inputStudentName.Text = row.Cells["Student Name"].Value.ToString();
                    inputCourseName.Text = row.Cells["Course Name"].Value.ToString();
                    inputReview.Text = row.Cells["Review"].Value.ToString();
                }
            }
        }

        private void ClearInputFields()
        {
            valueRatingID.Text = GetNextValueID();
            valueCourseID.Text = "";
            valueStudentID.Text = "";
            inputStudentName.Text = "";
            inputCourseName.Text = "";
            inputReview.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Retrieve the RatingID to be deleted
            string ratingID = valueRatingID.Text;

            // Execute an SQL DELETE statement to remove the record
            // Update the query accordingly based on your table structure
            string deleteRatingQuery = "DELETE FROM Rating WHERE RatingID = @RatingID";

            // Confirm message box before deleting the record
            DialogResult confirmDeletion = MessageBox.Show("Are you sure you want to delete this rating?",
                                                    "Confirm Deletion",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmDeletion == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(deleteRatingQuery, connection);
                        command.Parameters.AddWithValue("@RatingID", ratingID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
                }

                LoadRatingData();
                ClearInputFields();
            }

            
        }
    }
}
