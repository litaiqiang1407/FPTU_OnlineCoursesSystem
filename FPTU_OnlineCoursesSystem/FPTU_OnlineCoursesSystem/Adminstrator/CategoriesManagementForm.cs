using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;
using FPTU_OnlineCoursesSystem.DataValidator;

namespace FPTU_OnlineCoursesSystem
{
    public partial class CategoriesManagementForm : Form
    {

        public CategoriesManagementForm()
        {
            InitializeComponent();
            viewData();
            setupButtonHoverEffects();
            getNextID();
            inputControls = new Control[] { valueID, inputName, inputDescription };
        }

        #region Variables

        string tableName = CategoryVariables.tableName;

        Control[] inputControls;

        // Input values for insert query
        private object[] inputInsertValues()
        {
            string name = inputName.Text;
            string description = inputDescription.Text;

            return new object[] { name, description };
        }

        // Input values for update query
        private object[] inputUpdateValues()
        {
            string ID = valueID.Text;
            string name = inputName.Text;
            string description = inputDescription.Text;

            return new object[] { ID, name, description };
        }

        #endregion

        #region UIInteractions

        // Get the next available valueID
        private void getNextID()
        {
            valueID.Text = Helpers.GetNextID(tableName);
        }

        // Setup hover effects for buttons
        private void setupButtonHoverEffects()
        {
            ButtonHover.ApplyHoverEffects(new[] { btnCreate, btnUpdate, btnDelete });

            ButtonHover.ApplyHoverEffect(btnRefresh, Path.Combine(Images.BaseImagePath, Images.RefreshIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverRefreshIconPath));

            ButtonHover.ApplyHoverEffect(btnSearch, Path.Combine(Images.BaseImagePath, Images.SearchIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverSearchIconPath));
        }

        // Clear all input fields
        private void clearAllInputs()
        {
            ButtonClick.ClearAllInputs(tableName, inputControls);
        }

        // Clear all input fields and reload data
        private void clearAndLoad()
        {
            clearAllInputs();
            viewData();
        }

        #endregion

        #region Validation

        // Validate category name
        private bool validateName()
        {
            return Validator.ValidateField(inputName, labelName,
                "Catgory name" + ValidationMessages.RequiredField, Validator.IsValidText, ValidationMessages.InvalidText,
                true);
        }
        #endregion

        #region CRUD

        // Load category data into DataGridView
        private void viewData()
        {
            CRUD.ViewData(DGVCategory, CategoryQueryString.dataQuery);
        }

        // Insert category data
        private void insertCategoryData(object[] inputInsertValue)
        {
            CRUD.InsertData(CategoryQueryString.insertQuery, CategoryVariables.paramaters, inputInsertValue);
        }

        // Update category data
        private void updateCategoryData(object[] inputUpdateValue)
        {
            CRUD.UpdateData(CategoryQueryString.updateQuery, CategoryVariables.fullParamaters, inputUpdateValue);
        }

        // Delete category data
        private void deleteCategoryData(int ID)
        {
            CRUD.DeleteData(tableName, ID);
        }

        #endregion

        #region Searching

        // Search category data
        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVCategory, CategoryQueryString.searchQuery, searchValue);
        }

        #endregion

        #region Event Handlers

        // Load data into input fields when a row is clicked
        private void DGVCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, CategoryVariables.columnNames, new[] { btnUpdate, btnDelete });
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!validateName())
            {
                return;
            }

            insertCategoryData(inputInsertValues());
            Helpers.ShowSuccess("Category created successfully.");

            clearAndLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validateName())
            {
                return;
            }

            updateCategoryData(inputUpdateValues());
            Helpers.ShowSuccess("Category updated successfully.");
            clearAndLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(valueID.Text);
            deleteCategoryData(categoryID);
            Helpers.ShowSuccess("Category deleted successfully.");
            clearAndLoad();
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            searchData(inputSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            inputSearch_TextChanged(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inputSearch.Text = string.Empty;
            viewData();
        }

        #endregion

    }
}
