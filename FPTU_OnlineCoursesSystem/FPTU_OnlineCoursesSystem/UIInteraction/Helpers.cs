using System.Data;
using System.Globalization;
using FPTU_OnlineCoursesSystem.DBInteraction;

namespace FPTU_OnlineCoursesSystem.UIInteraction
{
    public static class Helpers
    {
        // Method to get the next ID of a table
        public static string GetNextID(string tableName)
        {
            try
            {
                string query = $"SELECT IDENT_CURRENT('{tableName}') + 1 AS NextID";
                object result = DBConnection.ExecuteScalar(query, null);

                int nextID = result != null ? Convert.ToInt32(result) : 1;

                return nextID.ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return "1"; // Default to 1 in case of an exception
            }
        }

        // Method to parse a date string to a DateTime object
        public static DateTime? ParseDate(string inputText)
        {
            if (DateTime.TryParseExact(inputText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parseDate))
            {
                return parseDate;
            }

            return null;
        }

        // Method to show a message box with an error icon
        public static void ShowError(string message)
        {
            MessageBox.Show("Error: " + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Method to show a message box with an information icon
        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
