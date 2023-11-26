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
    public partial class EnrollmentsManagementForm : Form
    {
        // Database connection string 
        string connectionString = "Data Source=TAIKUN\\SQLEXPRESS;Initial Catalog=FPTU_OnlineCourseSystem_DB;Integrated Security=True; MultipleActiveResultSets=true";

        public EnrollmentsManagementForm()
        {
            InitializeComponent();
            LoadEnrollmentData();
            valueEnrollmentID.Text = GetNextValueID();
        }

        // Load Enrollment data into DataGridView
        private void LoadEnrollmentData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Enrollment.EnrollmentID AS 'Enrollment ID', Enrollment.StudentID AS 'Student ID', Student.StudentName AS 'Student Name', " +
                               "Enrollment.CourseID AS 'Course ID', Course.CourseName AS 'Course Name', CONVERT(varchar, Enrollment.EnrollmentDate, 103) AS 'Date', Enrollment.EnrollmentStatus AS 'Status', Enrollment.PaymentStatus AS 'Payment' " +
                               "FROM Enrollment " +
                               "INNER JOIN Student ON Enrollment.StudentID = Student.StudentID " +
                               "INNER JOIN Course ON Enrollment.CourseID = Course.CourseID";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    DGVEnrollment.DataSource = dataTable;
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

        private void DGVEnrollment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVEnrollment.Rows[e.RowIndex];

                if (row != null)
                {
                    valueEnrollmentID.Text = row.Cells["Enrollment ID"].Value.ToString();
                    valueCourseID.Text = row.Cells["Course ID"].Value.ToString();
                    valueStudentID.Text = row.Cells["Student ID"].Value.ToString();
                    inputStudentName.Text = row.Cells["Student Name"].Value.ToString();
                    inputCourseName.Text = row.Cells["Course Name"].Value.ToString();
                    inputEnrollmentDate.Text = row.Cells["Date"].Value.ToString();
                    inputEnrollmentStatus.Text = row.Cells["Status"].Value.ToString();
                    inputPaymentStatus.Text = row.Cells["Payment"].Value.ToString();
                }
            }
        }
    }
}
