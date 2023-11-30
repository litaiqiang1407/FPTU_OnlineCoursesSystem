using FPTU_OnlineCoursesSystem.DataValidator;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;

namespace FPTU_OnlineCoursesSystem
{
    public partial class StudentsManagementForm : Form
    {

        public StudentsManagementForm()
        {
            InitializeComponent();
            initializeFilterComboBoxes();
            viewData();
            setupButtonHoverEffects();
            dynamicColumnFiltering();
            attachFilterEventHandlers();
            getNextID();
            inputControls = new Control[] { valueID, inputName, inputGender, 
                inputEmail, inputPhone, inputBirthdate, valueEnrollments };
        }

        #region Variables

        string tableName = StudentVariables.tableName;

        Control[] inputControls;

        ComboBox[] filterComboBoxes;

        private void initializeFilterComboBoxes()
        {
            filterComboBoxes = new ComboBox[] { filterGender, filterEnrollments };
        }

        private DateTime? parsedBirthdate()
        {
            return Helpers.ParseDate(inputBirthdate.Text);
        }

        private object[] inputInsertValues()
        {
            string name = inputName.Text;
            string gender = inputGender.Text;
            string email = inputEmail.Text;
            string phone = inputPhone.Text;
            DateTime? birthdate = parsedBirthdate();

            return new object[] { name, gender, email, phone, birthdate };
        }

        private object[] inputUpdateValues()
        {
            string ID = valueID.Text;
            string name = inputName.Text;
            string gender = inputGender.Text;
            string email = inputEmail.Text;
            string phone = inputPhone.Text;
            DateTime? birthdate = parsedBirthdate();

            return new object[] { ID, name, gender, email, phone, birthdate };
        }

        #endregion

        #region UIInteraction
        // Get the next available valueID
        private void getNextID()
        {
            valueID.Text = Helpers.GetNextID(tableName);
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

        private bool validateName()
        {
            return Validator.ValidateField(inputName, labelName,
                "Student name" + ValidationMessages.RequiredField, Validator.IsValidText, 
                ValidationMessages.InvalidText, true);
        }

        private bool validateEmail()
        {
            return Validator.ValidateField(inputEmail, labelEmail,
                "Email", Validator.IsValidEmail, ValidationMessages.InvalidEmail,
                true);
        }

        private bool validatePhoneNumber()
        {
            return Validator.ValidateField(inputPhone, labelPhone,
                "", Validator.IsValidPhoneNumber, ValidationMessages.InvalidPhoneNumber,
                false);
        }

        private bool validateBirthdate()
        {
            return Validator.ValidateField(inputBirthdate, labelBirthdate,
                "", Validator.IsValidDate, ValidationMessages.InvalidDate,
                false);
        }

        private bool validateAllFields()
        {
            bool isValidName = validateName();
            bool isValidEmail = validateEmail();
            bool isValidPhoneNumber = validatePhoneNumber();
            bool isValidBirthdate = validateBirthdate();


            return Validator.ValidateAllFields(
                (isValidName, () => validateName(), inputName),
                (isValidEmail, () => validateEmail(), inputEmail),
                (isValidPhoneNumber, () => validatePhoneNumber(), inputPhone),
                (isValidBirthdate, () => validateBirthdate(), inputBirthdate)
                );
        }

        #endregion

        #region CRUD

        // Load student data into DataGridView
        private void viewData()
        {
            CRUD.ViewData(DGVStudent, StudentQueryString.dataQuery);
        }

        private void insertStudentData(object[] inputInsertValue)
        {
            CRUD.InsertData(StudentQueryString.insertQuery, StudentVariables.paramaters, inputInsertValue);
        }

        private void updateStudentData(object[] inputUpdateValue)
        {
            CRUD.UpdateData(StudentQueryString.updateQuery, StudentVariables.fullParamaters, inputUpdateValue);
        }

        private void deleteStudentData(int ID)
        {
            CRUD.DeleteData(tableName, ID);
        }

        #endregion

        #region Searching

        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVStudent, StudentQueryString.searchQuery, searchValue);
        }
        private void dynamicColumnFiltering()
        {
            Searching.DynamicColumnFiltering(filterComboBoxes, StudentQueryString.comboBoxesQuery, StudentVariables.columnFilters);
        }

        private void filterData()
        {
            Searching.FilterData(DGVStudent, StudentQueryString.filterQuery, filterComboBoxes, StudentVariables.columnFilters);
        }

        #endregion

        #region EventHandlers
        private void DGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, StudentVariables.columnNames, btnUpdate, btnDelete);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!validateAllFields())
            {
                return;
            }

            insertStudentData(inputInsertValues());
            Helpers.ShowSuccess("Student created successfully.");

            clearAndLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validateAllFields())
            {
                return;
            }

            updateStudentData(inputUpdateValues());
            Helpers.ShowSuccess("Student updated successfully.");

            clearAndLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(valueID.Text);

            deleteStudentData(id);
            Helpers.ShowSuccess("Student deleted successfully.");

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
