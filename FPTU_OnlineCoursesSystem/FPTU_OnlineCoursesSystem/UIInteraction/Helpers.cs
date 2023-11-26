using System.Data;
using System.Globalization;
using FPTU_OnlineCoursesSystem.DBInteraction;

namespace FPTU_OnlineCoursesSystem.UIInteraction
{
    public static class Helpers
    {
        public static string GetNextID(string tableName)
        {
            int nextID = 1;

            try
            {
                string query = $"SELECT MAX({tableName}ID) FROM {tableName}";
                DataTable resultTable = DBConnection.ExecuteQuery(query, null);

                if (resultTable.Rows.Count > 0)
                {
                    object result = resultTable.Rows[0][0];

                    if (result != null && result != DBNull.Value)
                    {
                        nextID = Convert.ToInt32(result) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            string nextValueIDText = nextID.ToString();

            return nextValueIDText;
        }

        public static DateTime? ParseDate(string inputText)
        {
            if (DateTime.TryParseExact(inputText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parseDate))
            {
                return parseDate;
            }

            return null;
        }

        public static void ShowError(string message)
        {
            MessageBox.Show("Error: " + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
