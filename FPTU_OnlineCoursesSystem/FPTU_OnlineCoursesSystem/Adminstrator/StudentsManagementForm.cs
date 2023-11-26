using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTU_OnlineCoursesSystem
{
    public partial class StudentsManagementForm : Form
    {
        // Database connection string 
        string connectionString = "Data Source=TAIKUN\\SQLEXPRESS;Initial Catalog=FPTU_OnlineCourseSystem_DB;Integrated Security=True; MultipleActiveResultSets=true";

        public StudentsManagementForm()
        {
            InitializeComponent();
            viewData();
            getNextID();
        }

        string tableName = StudentVariables.tableName;

        // Load student data into DataGridView
        private void viewData()
        {
           CRUD.ViewData(DGVStudent, StudentQueryString.dataQuery);
        }

        // Get the next available valueID
        private void getNextID()
        {
            valueID.Text = Helpers.GetNextID(tableName);
        }

        private bool IsValidMail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidText(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool IsValidDate(string input)
        {
            DateTime parsedDate;
            return DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
        }


        // Validate a field based on provided validation function and display appropriate messages
        private void ValidateField(TextBox textBox, Label requiredLabel, string requiredMessage, Func<string, bool> validationFunc, string validationMessage)
        {
            string fieldText = textBox.Text;

            if (string.IsNullOrEmpty(fieldText) || !validationFunc(fieldText))
            {
                requiredLabel.Text = string.IsNullOrEmpty(fieldText) ? requiredMessage : validationMessage;
                requiredLabel.Visible = true;
                textBox.Focus();
            }
            else
            {
                requiredLabel.Visible = false;
            }
        }

        private void DGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVStudent.Rows[e.RowIndex];

                if (row != null)
                {
                    valueID.Text = row.Cells["ID"].Value.ToString();
                    inputGender.Text = row.Cells["Gender"].Value.ToString();
                    inputName.Text = row.Cells["Name"].Value.ToString();
                    inputEmailAddress.Text = row.Cells["Email"].Value.ToString();
                    valueEnrollments.Text = row.Cells["Enrollments"].Value.ToString();
                    inputPhoneNumber.Text = row.Cells["Phone Number"].Value.ToString();
                    inputBirthDate.Text = row.Cells["BirthDate"].Value.ToString();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve values from input fields
            int studentID = Convert.ToInt32(valueID.Text);
            string studentName = inputName.Text;
            string studentGender = inputGender.Text;
            string studentEmail = inputEmailAddress.Text;
            string studentPhoneNumber = inputPhoneNumber.Text;
            int studentEnrollments = Convert.ToInt32(valueEnrollments.Text);
            string studentBirthDate = inputBirthDate.Text;

            // Validate input fields
            if (!IsValidText(studentName) && !IsValidMail(studentEmail) && !IsValidDate(studentBirthDate))
            {
                ValidateField(inputName, requiredName, "Name is required", IsValidText, "Name is invalid");
                ValidateField(inputEmailAddress, requiredEmail, "Email address is required", IsValidMail, "Email address is invalid");
                ValidateField(inputBirthDate, requiredBirthDate, "Birth date is required", IsValidDate, "Birth date is invalid");
                MessageBox.Show("Error: Please enter valid data for the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if (!IsValidText(studentName))
            {
                ValidateField(inputName, requiredName, "Name is required", IsValidText, "Name is invalid");
                MessageBox.Show("Error: Please enter valid data for the Name fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidMail(studentEmail))
            {
                ValidateField(inputEmailAddress, requiredEmail, "Email address is required", IsValidMail, "Email address is invalid");
                MessageBox.Show("Error: Please enter valid data for the Email Address fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidDate(studentBirthDate))
            {
                ValidateField(inputBirthDate, requiredBirthDate, "Birth date is required", IsValidDate, "Birth date is invalid");
                MessageBox.Show("Error: Please enter valid data for the Birth Date fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Execute an SQL INSERT statement to add a new record
            // Update the query accordingly based on table structure
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateStudentQuery = "UPDATE Student SET StudentName = @StudentName, " +
                                                "StudentGender = @StudentGender, StudentEmail = @StudentEmail, StudentPhone = @StudentPhone, " +
                                                "StudentBirthDate = @StudentBirthDate WHERE StudentID = @StudentID";
                    
                    SqlCommand command = new SqlCommand(updateStudentQuery, connection);

                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    command.Parameters.AddWithValue("@StudentGender", studentGender);
                    command.Parameters.AddWithValue("@StudentEmail", studentEmail);
                    command.Parameters.AddWithValue("@StudentPhone", studentPhoneNumber);
                    command.Parameters.AddWithValue("@StudentBirthDate", DateTime.ParseExact(studentBirthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture));

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Student updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the student: " + ex.Message);
            }
        }
    }
}
