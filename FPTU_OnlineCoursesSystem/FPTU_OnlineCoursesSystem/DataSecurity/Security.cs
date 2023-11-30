using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.DBInteraction;
using System.Data.SqlClient;
using System.Data;

namespace FPTU_OnlineCoursesSystem.DataSecurity
{
    public static class Security
    {

        // Check if email is registered
        public static bool EmailRegistered(string process, string email)
        {
            string adminExistenceQuery = "SELECT COUNT(*) FROM AdminAccount WHERE AdminAccountEmail = @AdminAccountEmail";
            string studentExistenceQuery = "SELECT COUNT(*) FROM StudentAccount WHERE StudentAccountEmail = @StudentAccountEmail";

            SqlParameter[] emailAdminExistenceParameters = { new SqlParameter("@AdminAccountEmail", email) };
            SqlParameter[] emailStudentExistenceParameters = { new SqlParameter("@StudentAccountEmail", email) };

            int adminEmailCount = (int)DBConnection.ExecuteQuery(adminExistenceQuery, emailAdminExistenceParameters).Rows[0][0];
            int studentEmailCount = (int)DBConnection.ExecuteQuery(studentExistenceQuery, emailStudentExistenceParameters).Rows[0][0];

            // For login process
            if (process == "login")
            {
                if (adminEmailCount == 0 && studentEmailCount == 0)
                {
                    Helpers.ShowError("Email not found. Please sign up to create an account.");
                    return false;
                }
                return true;
            }

            // For signup process
            if (process == "signup" && (adminEmailCount > 0 || studentEmailCount > 0))
            {
                Helpers.ShowError("Email already registered. Log in or use a different email for a new account.");
                return true;
            }

            return false;
        }

        public static bool AuthenticateUser(string email, string password, string accountType)
        {
            string tableName = (accountType == "admin") ? "AdminAccount" : "StudentAccount";

            string getPasswordQuery = $"SELECT {tableName}PasswordHash FROM {tableName} WHERE {tableName}Email = @Email";
            SqlParameter[] getPasswordParameters = { new SqlParameter("@Email", email) };

            DataTable resultTable = DBConnection.ExecuteQuery(getPasswordQuery, getPasswordParameters);

            // Check if password is correct
            if (resultTable.Rows.Count > 0)
            {
                string storedHash = resultTable.Rows[0][$"{tableName}PasswordHash"].ToString();

                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    return true;
                }
                else
                {
                    Helpers.ShowError("Incorrect password.");
                }
            }
            return false;
        }
    }
}
