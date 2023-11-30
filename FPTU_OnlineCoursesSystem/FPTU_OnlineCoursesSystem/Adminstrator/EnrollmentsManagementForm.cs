using FPTU_OnlineCoursesSystem.Variables;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.DataValidator;

namespace FPTU_OnlineCoursesSystem
{
    public partial class EnrollmentsManagementForm : Form
    {
        public EnrollmentsManagementForm()
        {
            InitializeComponent();
            initializeFilterComboBoxes();
            viewData();
            setupButtonHoverEffects();
            dynamicColumnFiltering();
            attachFilterEventHandlers();
            getNextID();
            inputControls = new Control[] { valueEnrollmentID, valueStudentID, inputStudentName, 
                valueCourseID, inputCourseName, inputEnrollmentDate, inputEnrollmentStatus, inputPaymentStatus };
        }

        #region Variables

        string tableName = EnrollmentVariables.tableName;
        Control[] inputControls;
        ComboBox[] filterComboBoxes;

        private void initializeFilterComboBoxes()
        {
            filterComboBoxes = new ComboBox[] { filterEnrollmentDate, filterEnrollmentStatus, filterPaymentStatus };
        }

        private DateTime? parsedEnrollmentDate()
        {
            return Helpers.ParseDate(inputEnrollmentDate.Text);
        }

        private object[] inputUpdateValues()
        {
            string enrollmentID = valueEnrollmentID.Text;
            string studentName = inputStudentName.Text;
            string courseName = inputCourseName.Text;
            DateTime? enrollmentDate = parsedEnrollmentDate();
            string enrollmentStatus = inputEnrollmentStatus.Text;
            string paymentStatus = inputPaymentStatus.Text;

            return new object[] { enrollmentID, studentName, courseName, enrollmentDate, enrollmentStatus, paymentStatus };
        }
        #endregion

        #region UIInteraction

        // Get the next available valueID
        private void getNextID()
        {
            valueEnrollmentID.Text = Helpers.GetNextID(tableName);
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

        private bool validateEnrollmentDate()
        {
            return Validator.ValidateField(inputEnrollmentDate, labelEnrollmentDate,
                "", Validator.IsValidDate, ValidationMessages.InvalidDate, false);
        }

        private bool validateAllFields()
        {
            bool isValidStudentName = validateStudentName();
            bool isValidCourseName = validateCourseName();
            bool isValidEnrollmentDate = validateEnrollmentDate();

            return Validator.ValidateAllFields(
                (isValidCourseName, () => validateCourseName(), inputCourseName),
                (isValidStudentName, () => validateStudentName(), inputStudentName),
                (isValidEnrollmentDate, () => validateEnrollmentDate(), inputEnrollmentDate)
                );
        }
        #endregion

        #region CRUD

        // Load student data into DataGridView
        private void viewData()
        {
            CRUD.ViewData(DGVEnrollment, EnrollmentQueryString.dataQuery);
        }

        private void upsertData()
        {
            CRUD.UpsertData("Student", "StudentName", inputStudentName.Text);
            CRUD.UpsertData("Course", "CourseName", inputCourseName.Text);
        }

        private void updateEnrollmentData(object[] inputUpdateValue)
        {
            CRUD.UpdateData(EnrollmentQueryString.updateQuery, EnrollmentVariables.paramaters, inputUpdateValue);
        }

        private void deleteEnrollmentData(int ID)
        {
            CRUD.DeleteData(tableName, ID);
        }
        #endregion

        #region Searching

        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVEnrollment, EnrollmentQueryString.searchQuery, searchValue);
        }
        private void dynamicColumnFiltering()
        {
            Searching.DynamicColumnFiltering(filterComboBoxes, EnrollmentQueryString.comboBoxesQuery, EnrollmentVariables.columnFilters);
        }

        private void filterData()
        {
            Searching.FilterData(DGVEnrollment, EnrollmentQueryString.filterQuery, filterComboBoxes, EnrollmentVariables.columnFilters);
        }

        #endregion

        #region EventHandlers

        private void DGVEnrollment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, EnrollmentVariables.columnNames, btnUpdate, btnDelete);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validateAllFields())
            {
                return;
            }

            upsertData();
            updateEnrollmentData(inputUpdateValues());
            Helpers.ShowSuccess("Enrollment updated successfully.");

            clearAndLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int enrollmentID = int.Parse(valueEnrollmentID.Text);
            deleteEnrollmentData(enrollmentID);
            Helpers.ShowSuccess("Enrollment deleted successfully.");
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

        private void FilterComboboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void attachFilterEventHandlers()
        {
            foreach (var comboBox in filterComboBoxes)
            {
                comboBox.SelectedIndexChanged += FilterComboboxes_SelectedIndexChanged;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inputSearch.Text = string.Empty;
            ButtonClick.RefreshComboboxes(filterComboBoxes);
            viewData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllInputs();
        }

        #endregion
    }
}
