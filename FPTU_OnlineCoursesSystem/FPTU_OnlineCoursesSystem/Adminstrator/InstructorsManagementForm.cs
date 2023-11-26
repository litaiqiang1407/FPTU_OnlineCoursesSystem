using FPTU_OnlineCoursesSystem.DataValidator;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;



namespace FPTU_OnlineCoursesSystem
{
    public partial class InstructorsManagementForm : Form
    {       
        public InstructorsManagementForm()
        {
            InitializeComponent();
            initializeFilterComboBoxes();
            viewData();
            setupButtonHoverEffects();
            dynamicColumnFiltering();
            attachFilterEventHandlers();
            getNextID();
            inputControls = new Control[] { valueID, inputInstructorName, inputGender, 
                inputSpecialization, inputExperience, inputEmailAddress, inputPhoneNumber, inputBirthdate };
        }

        #region Variables

        string tableName = InstructorVariables.tableName;

        Control[] inputControls;

        ComboBox[] filterComboBoxes;

        private void initializeFilterComboBoxes()
        {
            filterComboBoxes = new ComboBox[] { filterGender, filterSpecialization, filterExperience  };
        }

        private DateTime? parsedBirthdate()
        {
            return Helpers.ParseDate(inputBirthdate.Text);
        }

        private object[] inputInsertValues()
        {
            string name = inputInstructorName.Text;
            string email = inputEmailAddress.Text;
            string gender = inputGender.Text;
            string specialization = inputSpecialization.Text;
            string experience = inputExperience.Text;
            string phoneNumber = inputPhoneNumber.Text;
            DateTime? birthdate = parsedBirthdate();

            return new object[] { name, email, gender, specialization, experience, phoneNumber, birthdate };
        }

        private object[] inputUpdateValues()
        {
            string id = valueID.Text;
            string name = inputInstructorName.Text;
            string gender = inputGender.Text;
            string specialization = inputSpecialization.Text;
            string experience = inputExperience.Text;
            string email = inputEmailAddress.Text;
            string phoneNumber = inputPhoneNumber.Text;
            DateTime? birthdate = parsedBirthdate();

            return new object[] { id, name, gender, specialization, experience, email, phoneNumber, birthdate };
        }

        #endregion

        #region FormInteraction
        private void getNextID()
        {
            valueID.Text = Helpers.GetNextID(tableName);
        }

        private void setupButtonHoverEffects()
        {
            ButtonHover.ApplyHoverEffects(new[] { btnCreate, btnUpdate, btnDelete, btnClearAll });

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
            return Validator.ValidateField(inputInstructorName, labelInstructorNameRequired,
                "Instructor name" + ValidationMessages.RequiredField, Validator.IsValidText, "Instructor's name" + ValidationMessages.InvalidText,
                true);
        }

        private bool validateEmail()
        {
            return Validator.ValidateField(inputEmailAddress, labelEmailAddress,
                "", Validator.IsValidEmail, ValidationMessages.InvalidEmail,
                false);
        }

        private bool validateSpecialization()
        {
            return Validator.ValidateField(inputSpecialization, labelSpecialization,
                "", Validator.IsValidText, "Specialization" + ValidationMessages.InvalidText,
                false);
        }

        private bool validateBirthdate()
        {
            return Validator.ValidateField(inputBirthdate, labelBirthdate,
                "", Validator.IsValidDate, ValidationMessages.InvalidDate,
                false);
        }

        private bool validatePhoneNumber()
        {
            return Validator.ValidateField(inputPhoneNumber, labelPhoneNumber,
                "", Validator.IsValidPhoneNumber, ValidationMessages.InvalidPhoneNumber,
                false);
        }

        private bool ValidateAllFields()
        {
            bool isValidName = validateName();
            bool isValidEmail = validateEmail();
            bool isValidSpecialization = validateSpecialization();
            bool isValidBirthdate = validateBirthdate();
            bool isValidPhoneNumber = validatePhoneNumber();

            return Validator.ValidateAllFields(
                (isValidName, () => validateName(), inputInstructorName),
                (isValidEmail, () => validateEmail(), inputEmailAddress),
                (isValidSpecialization, () => validateSpecialization(), inputSpecialization),
                (isValidBirthdate, () => validateBirthdate(), inputBirthdate),
                (isValidPhoneNumber, () => validatePhoneNumber(), inputPhoneNumber)
                );
        }

        #endregion

        #region CRUD

        private void viewData()
        {
            CRUD.ViewData(DGVInstructor, InstructorQueryString.dataQuery);
        }

        private void insertInstructorData(object[] inputInsertValue)
        {
            CRUD.InsertData(InstructorQueryString.insertQuery, InstructorVariables.paramaters, inputInsertValue);
        }

        private void updateInstructorData(object[] inputUpdateValue)
        {
            CRUD.UpdateData(InstructorQueryString.updateQuery, InstructorVariables.fullParamaters, inputUpdateValue);
        }   

        private void deleteInstructorData(int instructorID)
        {
            CRUD.DeleteData(InstructorQueryString.deleteQuery, tableName, instructorID);
        }

        #endregion


        #region Searching

        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVInstructor, InstructorQueryString.searchQuery, searchValue);
        }
        private void dynamicColumnFiltering()
        {
            Searching.DynamicColumnFiltering(filterComboBoxes, InstructorQueryString.comboboxesQuery, InstructorVariables.columnFilters);
        }

        private void filterData()
        {
            Searching.FilterData(DGVInstructor, InstructorQueryString.filterQuery, filterComboBoxes, InstructorVariables.columnFilters);
        }
        #endregion

        #region EventHandlers
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateAllFields())
            {
                Helpers.ShowError("Please check instructor's information again.");
                return;
            }

            insertInstructorData(inputInsertValues());
            clearAndLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateAllFields())
            {
                Helpers.ShowError("Please check instructor's information again.");
                return;
            }
            updateInstructorData(inputUpdateValues());
            clearAndLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(valueID.Text);
            deleteInstructorData(id);
            clearAndLoad();
        }

        private void inputSearchValue_TextChanged(object sender, EventArgs e)
        {
            searchData(inputSearchValue.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            inputSearchValue_TextChanged(sender, e);
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

        private void DGVInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, InstructorVariables.columnNames, btnUpdate, btnDelete);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inputSearchValue.Text = string.Empty;
            ButtonClick.RefreshComboboxes(filterComboBoxes);
            viewData();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAllInputs();
        }

        #endregion
    }
}