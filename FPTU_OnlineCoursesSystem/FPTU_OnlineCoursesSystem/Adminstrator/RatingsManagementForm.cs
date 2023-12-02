using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.DataValidator;

namespace FPTU_OnlineCoursesSystem
{
    public partial class RatingsManagementForm : Form
    {

        public RatingsManagementForm()
        {
            InitializeComponent();
            setupButtonHoverEffects();
            viewData();
            getNextID();
            inputControls = new Control[] { valueRatingID, valueStudentID, inputStudentName, valueCourseID, inputCourseName, valueRating, inputReview };
        }

        #region Variables

        string tableName = RatingVariables.tableName;
        Control[] inputControls;

        private object[] inputUpdateValues()
        {
            string ratingID = valueRatingID.Text;
            string studentName = inputStudentName.Text;
            string courseName = inputCourseName.Text;
            string review = inputReview.Text;

            return new object[] { ratingID, studentName, courseName, review };
        }

        #endregion

        #region UIInteraction

        // Get the next available valueID
        private void getNextID()
        {
            valueRatingID.Text = Helpers.GetNextID(tableName);
        }

        private void setupButtonHoverEffects()
        {
            ButtonHover.ApplyHoverEffects(new[] { btnCreate, btnUpdate, btnDelete, btnClear });

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

        private bool validateStudentName()
        {
            return Validator.ValidateField(inputStudentName, labelStudentName,
                "Student name" + ValidationMessages.RequiredField, Validator.IsValidText, 
                ValidationMessages.InvalidText, true);
        }

        private bool validateCourseName()
        {
            return Validator.ValidateField(inputCourseName, labelCourseName,
                "Course name" + ValidationMessages.RequiredField, Validator.IsValidText, 
                ValidationMessages.InvalidText, true);
        }

        private bool validateAllFields()
        {
            bool isValidStudentName = validateStudentName();
            bool isValidCourseName = validateCourseName();

            return Validator.ValidateAllFields(
                (isValidCourseName, () => validateCourseName(), inputCourseName),
                (isValidStudentName, () => validateStudentName(), inputStudentName)
                );
        }

        #endregion

        #region CRUD

        // Load student data into DataGridView
        private void viewData()
        {
            CRUD.ViewData(DGVRating, RatingQueryString.dataQuery);
        }

        private void upsertData()
        {
            CRUD.UpsertData("Course", "CourseName", inputCourseName.Text);
            CRUD.UpsertData("Student", "StudentName", inputStudentName.Text);
        }

        private void updateRatingData(object[] inputUpdateValue)
        {
            CRUD.UpdateData(RatingQueryString.updateQuery, RatingVariables.paramaters, inputUpdateValue);
        }

        private void deleteRatingData(int ID)
        {
            CRUD.DeleteData(tableName, ID);
        }
        #endregion

        #region Searching

        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVRating, RatingQueryString.searchQuery, searchValue);
        }

        #endregion

        #region EventHandlers
        private void DGVRating_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, RatingVariables.columnNames, new[] { btnUpdate, btnDelete });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validateAllFields())
            {
                return;
            }

            upsertData();
            updateRatingData(inputUpdateValues());
            Helpers.ShowError("Update rating successfully!");

            clearAndLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ratingID = int.Parse(valueRatingID.Text);

            deleteRatingData(ratingID);
            Helpers.ShowError("Delete rating successfully!");

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllInputs();

        }

        #endregion
    }
}
