using System.Data.SqlClient;
using System.Data;


namespace FPTU_OnlineCoursesSystem.DBInteraction
{
    public static class DBConnection
    {
        // Connection string to the database
        public static string connectionString = "Data Source=TAIKUN\\SQLEXPRESS;Initial Catalog=FPTU_OnlineCourseSystem_DB;" +
            "Integrated Security=True;MultipleActiveResultSets=true";


        // Method to get a new SqlConnection object using the connection string
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        // Method to execute a query and return a DataTable
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            // Using statement ensures that resources are released after execution
            using (SqlConnection connection = GetConnection())
            {
                connection.Open(); // Open the database connection

                // Using statement ensures that SqlCommand resources are released after execution
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SqlCommand if provided
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            // Handle null or empty strings by setting the value to DBNull.Value
                            parameter.Value = parameter.Value ?? DBNull.Value;
                            command.Parameters.Add(parameter);
                        }
                    }

                    // Use SqlDataAdapter to fill a DataTable with the results of the query
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        // Method to execute a non-query (e.g., INSERT, UPDATE, DELETE) and return the number of affected rows
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            // Using statement ensures that resources are released after execution
            using (SqlConnection connection = GetConnection())
            {
                connection.Open(); // Open the database connection

                // Using statement ensures that SqlCommand resources are released after execution
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SqlCommand if provided
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            // Handle null or empty strings by setting the value to DBNull.Value
                            parameter.Value = parameter.Value ?? DBNull.Value;
                            command.Parameters.Add(parameter);
                        }
                    }

                    // Execute the non-query and return the number of affected rows
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
