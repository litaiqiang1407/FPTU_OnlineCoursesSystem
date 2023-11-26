using System.Data.SqlClient;
using System.Data;
using FPTU_OnlineCoursesSystem.UIInteraction;


namespace FPTU_OnlineCoursesSystem.DBInteraction
{
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

        // Method to check if a value already exists in a table and insert a new record if it doesn't
        public static void Upsert(string tableName, string columnName, string value)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Check if the value already exists in the related table
                    string checkRelatedTableQuery = $"SELECT {tableName}ID FROM {tableName} WHERE {columnName} = @{columnName}";
                    SqlCommand checkCommand = new SqlCommand(checkRelatedTableQuery, connection);
                    checkCommand.Parameters.AddWithValue($"@{columnName}", value);
                    object result = checkCommand.ExecuteScalar();

                    if (result == null)
                    {
                        // If the value doesn't exist, add a new record to the related table
                        string insertRelatedTableQuery = $"INSERT INTO {tableName} ({columnName}) VALUES (@{columnName})";
                        SqlCommand insertCommand = new SqlCommand(insertRelatedTableQuery, connection);
                        insertCommand.Parameters.AddWithValue($"@{columnName}", value);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Helpers.ShowError("Check related table - " + ex.Message);
                }
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
        public static void DeleteData(string queryString, string tableName, object value)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {value}?", 
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter($"@{tableName}ID", value);

                DBConnection.ExecuteNonQuery(queryString, parameters);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Delete data - " + ex.Message);
            }
        }

    }
}
