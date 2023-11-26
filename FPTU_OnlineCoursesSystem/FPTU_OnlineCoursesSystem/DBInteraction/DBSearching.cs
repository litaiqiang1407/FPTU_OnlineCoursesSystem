using System.Data;
using FPTU_OnlineCoursesSystem.UIInteraction;
using System.Data.SqlClient;

namespace FPTU_OnlineCoursesSystem.DBInteraction
{
    public static class Searching
    {

        // Method to search data in a DataGridView
        public static void SearchData(DataGridView dataGridView, string searchQuery, string searchValue)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@SearchValue", "%" + searchValue + "%") 
                };

                // Call the function to populate the DataGridView with search results
                CRUD.ViewData(dataGridView, searchQuery, parameters);
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Search data - " + ex.Message);
            }
        }

        // Method to filter data in a DataGridView
        public static void FilterData(DataGridView dataGridView, string filterQuery, ComboBox[] filterComboBoxes, string[] filterColumns, string[] convertibleFilters = null)
        {
            convertibleFilters ??= Array.Empty<string>();
            try
            {
                // Create parameters for filter values
                List<SqlParameter> parameters = new List<SqlParameter>();
                for (int i = 0; i < filterComboBoxes.Length; i++)
                {
                    string filterValue = filterComboBoxes[i].SelectedItem as string;
                    if (convertibleFilters != null &&  convertibleFilters.Contains(filterColumns[i]))
                    {                    
                        // Convert the value if it's in the convertibleFilters array
                        parameters.Add(new SqlParameter($"@{filterColumns[i]}", string.IsNullOrEmpty(filterValue) ? (object)DBNull.Value : float.Parse(filterValue)));
                    }
                    else
                    {
                        // No conversion needed for this filter
                        parameters.Add(new SqlParameter($"@{filterColumns[i]}", (object)filterValue ?? DBNull.Value));
                    }
                }

                // Use DBConnection to execute the filter query and get the result as a DataTable
                DataTable dataTable = DBConnection.ExecuteQuery(filterQuery, parameters.ToArray());

                // Set the DataTable as the DataSource for the specified DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Helpers.ShowError("Filter data - " + ex.Message);
            }
        }

        // Method to populate filter ComboBoxes
        public static void DynamicColumnFiltering(ComboBox[] filterComboBoxes, string[] queryComboboxData, string[] columnNames)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.connectionString))
                {
                    connection.Open();

                    // Loop through each ComboBox, query, and column name
                    for (int i = 0; i < filterComboBoxes.Length; i++)
                    {
                        string query = queryComboboxData[i];
                        string columnName = columnNames[i];
                        ComboBox comboBox = filterComboBoxes[i];

                        try
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                if (reader[columnName] != DBNull.Value)
                                {
                                    string filterValue = reader[columnName].ToString();
                                    if (filterValue.Contains("$"))
                                    {
                                        filterValue = filterValue.Replace("$", "");
                                    }
                                    comboBox.Items.Add(filterValue);
                                }
                                
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            Helpers.ShowError("DynamicColumnFiltering - " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.ShowError("DynamicColumnFiltering - " + ex.Message);
            }
        }
    }
}
