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

        private object[] inputInsertValues()
        {
            string name = inputName.Text;
            string description = inputDescription.Text;

            return new object[] { name, description };
        }

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

        private void setupButtonHoverEffects()
        {
            ButtonHover.ApplyHoverEffects(new[] { btnCreate, btnUpdate, btnDelete });

            ButtonHover.ApplyHoverEffect(btnRefresh, Path.Combine(Images.BaseImagePath, Images.RefreshIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverRefreshIconPath));

            ButtonHover.ApplyHoverEffect(btnSearch, Path.Combine(Images.BaseImagePath, Images.SearchIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverSearchIconPath));
        }

        private void clearAllInputs()
        {
            ButtonClick.ClearAllInputs(tableName, inputControls);
        }

        private void clearAndLoad()
        {
            clearAllInputs();
            viewData();
        }

        #endregion

        #region Validation

        private bool validateName()
        {
            return Validator.ValidateField(inputName, labelName,
                "Student name" + ValidationMessages.RequiredField, Validator.IsValidText, "Student's name" + ValidationMessages.InvalidText,
                true);
        }
        #endregion

        #region CRUD
        // Load category data into DataGridView
        private void viewData()
        {
            CRUD.ViewData(DGVCategory, CategoryQueryString.dataQuery);
        }

        private void insertCategoryData(object[] inputInsertValue)
        {
            CRUD.InsertData(CategoryQueryString.insertQuery, CategoryVariables.paramaters, inputInsertValue);
        }

        private void updateCAtegoryData(object[] inputUpdateValue)
        {
            CRUD.UpdateData(CategoryQueryString.updateQuery, CategoryVariables.fullParamaters, inputUpdateValue);
        }

        private void deleteCategoryData(int ID)
        {
            CRUD.DeleteData(tableName, ID);
        }

        #endregion

        #region Searching
        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVCategory, CategoryQueryString.searchQuery, searchValue);
        }

        #endregion

        #region Event Handlers
        private void DGVCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, CategoryVariables.columnNames, btnUpdate, btnDelete);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!validateName())
            {
                Helpers.ShowError("Please check category's information again.");
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
                Helpers.ShowError("Please check category's information again.");
                return;
            }

            updateCAtegoryData(inputUpdateValues());
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

        #endregion


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


    }
}
