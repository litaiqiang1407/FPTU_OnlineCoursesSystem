using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FPTU_OnlineCoursesSystem
{
    public partial class CategoriesManagementForm : Form
    {
        
        public CategoriesManagementForm()
        {
            InitializeComponent();
            viewData();
            getNextID();
            inputControls = new Control[] { valueID, inputName, inputDescription };
        }

        string tableName = CategoryVariables.tableName;

        Control[] inputControls;

        // Load category data into DataGridView
        private void viewData()
        {
            CRUD.ViewData(DGVCategory, CategoryQueryString.dataQuery);
        }

        // Get the next available valueID
        private void getNextID()
        {
            valueID.Text = Helpers.GetNextID(tableName);
        }

        private void deleteCategoryData(int categoryID)
        {
            CRUD.DeleteData(tableName, CategoryQueryString.deleteQuery, categoryID);
        }

        private void DGVCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, CategoryVariables.columnNames, btnUpdate, btnDelete);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(valueID.Text);
            deleteCategoryData(categoryID);
        }
    }
}
