using System.Data.SqlClient;
using System.Data;
using FPTU_OnlineCoursesSystem.UIInteraction;


namespace FPTU_OnlineCoursesSystem.DBInteraction
{
    // Class to perform CRUD operations on the database
    public static class CRUD
    {
        // Method to display data in a DataGridView
        public static void ViewData(DataGridView dataGridView, string queryString, SqlParameter[] parameters = null)
        {
            try
            {
                // Execute the query using DBConnection class
                DataTable dataTable = DBConnection.ExecuteQuery(queryString, parameters);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView.DataSource = dataTable;
                }
                else
                {
                    dataGridView.DataSource = null;
                }

               
            }
            catch (Exception ex)
            {
                Helpers.ShowError("View data - " + ex.Message);
            }
        }

        // Method to get a single value from the database
        public static string GetSingleValue(string queryString, SqlParameter[] parameters = null, string columnName = "")
        {
            try
            {
                // Execute the query using DBConnection class
                DataTable result = DBConnection.ExecuteQuery(queryString, parameters);

                if (result.Rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(columnName) && result.Columns.Contains(columnName))
                    {
                        return result.Rows[0][columnName].ToString();
                    }
                    else
                    {
                        // If no specific column name provided, return the first column of the first row
                        return result.Rows[0][0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Get single value - " + ex.Message);
            }

            return string.Empty;
        }

        // Method to check if a value already exists in a table insert a new record if it doesn't
        public static void UpsertData(string tableName, string columnName, object value)
        {
            try
            {
                string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @{columnName}";
                SqlParameter[] parameters = { new SqlParameter($"@{columnName}", value) };

                int count = (int)DBConnection.ExecuteQuery(checkQuery, parameters).Rows[0][0];

                if (count == 0)
                {
                    string insertQuery = $"INSERT INTO {tableName} ({columnName}) VALUES (@{columnName})";
                    SqlParameter[] insertParameters = { new SqlParameter($"@{columnName}", value) };

                    DBConnection.ExecuteQuery(insertQuery, insertParameters);
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError("UpsertData - " + ex.Message);
            }
        }

        // Method to insert data into the database
        public static void InsertData(string queryString, string[] columnNames, object[] inputValues)
        {
            try
            {
                // Create an array of parameters
                SqlParameter[] parameters = new SqlParameter[columnNames.Length];
                for (int i = 0; i < columnNames.Length; i++)
                {
                    parameters[i] = new SqlParameter($"@{columnNames[i]}", inputValues[i] ?? DBNull.Value);
                }

                // Execute the query using DBConnection class
                DBConnection.ExecuteNonQuery(queryString, parameters);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Insert data - " + ex.Message);
            }
        }

        // Method to update data in the database
        public static void UpdateData(string queryString, string[] columnNames, object[] inputValues)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[columnNames.Length];
                for (int i = 0; i < columnNames.Length; i++)
                {
                    parameters[i] = new SqlParameter($"@{columnNames[i]}", inputValues[i] ?? DBNull.Value);
                }

                DBConnection.ExecuteNonQuery(queryString, parameters);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Update data - " + ex.Message);
            }
        }

        // Method to delete data from the database
        public static void DeleteData(string tableName, object value)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {value}?", 
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                string deleteQuery = $"DELETE FROM {tableName} WHERE {tableName}ID = @{tableName}ID";

                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter($"@{tableName}ID", value);

                DBConnection.ExecuteNonQuery(deleteQuery, parameters);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Delete data - " + ex.Message);
            }
        }

    }
}
