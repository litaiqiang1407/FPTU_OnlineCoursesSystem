using FPTU_OnlineCoursesSystem.DataValidator;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;

namespace FPTU_OnlineCoursesSystem
{
   
    public partial class CoursesManagementForm : Form
    { 

        // Constructor
        public CoursesManagementForm()
        {
            InitializeComponent();
            getNextID(); // Fetch the next available ID for a new course
            viewData(); // Load existing data into the DataGridView
            initializeFilterComboBoxes(); // Initialize filter ComboBoxes for data filtering                
            dynamicColumnFiltering(); // Set up dynamic column filtering based on filter ComboBox selections
            attachFilterEventHandlers(); // Attach event handlers for filter ComboBox changes
            setButtonHoverEffects(); //// Button hover effects     
            inputControls = new Control[] { valueID, inputName, inputCategory, inputInstructor, 
                inputDescription, valueEnrollments, inputCreationDate, valueRating, inputPrice };
        }

        #region Variables

        string tableName = CourseVariables.tableName;
        Control[] inputControls;
        ComboBox[] filterComboBoxes;

        private void initializeFilterComboBoxes()
        {
            filterComboBoxes = new ComboBox[] { filterCategories, filterInstructors, 
                filterCreationDate, filterRatingValue, filterPrice };
        }

        // Parse date from the input date field
        private DateTime? parseDate()
        {
            return Helpers.ParseDate(inputCreationDate.Text);
        }

        // Get input values for inserting a new record
        private object[] inputInsertValues()
        {
            string courseName = inputName.Text;
            string instructorName = inputInstructor.Text;
            string categoryName = inputCategory.Text;
            string courseDescription = inputDescription.Text;
            DateTime? creationDate = parseDate();
            float price = string.IsNullOrEmpty(inputPrice.Text) ? 0 : float.Parse(inputPrice.Text);

            return new object[] { courseName, categoryName, instructorName, courseDescription, creationDate, price };
        }

        // Get input values for updating a record
        private object[] inputUpdateValues()
        {
            string courseID = valueID.Text;
            string courseName = inputName.Text;
            string instructorName = inputInstructor.Text;
            string categoryName = inputCategory.Text;
            string courseDescription = inputDescription.Text;
            DateTime? creationDate = parseDate();
            float price = float.Parse(inputPrice.Text.Replace("$", ""));

            return new object[] { courseID, courseName, categoryName, instructorName, courseDescription, creationDate, price };
        }

        #endregion

        #region FormInteractions
        private void getNextID()
        {
            valueID.Text = Helpers.GetNextID(tableName);
        }

        // Set hover effects for buttons
        private void setButtonHoverEffects()
        {
            ButtonHover.ApplyHoverEffects(new[] { btnCreate, btnUpdate, btnDelete, btnClear });

            ButtonHover.ApplyHoverEffect(btnRefresh, Path.Combine(Images.BaseImagePath, Images.RefreshIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverRefreshIconPath));

            ButtonHover.ApplyHoverEffect(btnSearch, Path.Combine(Images.BaseImagePath, Images.SearchIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverSearchIconPath));
        }

        // Clear all inputs
        private void clearAllInputs()
        {
            ButtonClick.ClearAllInputs(tableName, inputControls);
        }

        // Clear all inputs and reload data in the DataGridView
        private void clearAndReloadData()
        {
            clearAllInputs();
            viewData();
        }

        #endregion

        #region Validation

        // Validate course name field
        private bool validateCourseName()
        {
            // Use the Validator class to validate the 'Course Name' field
            return Validator.ValidateField(inputName, labelRequiredName, 
                ValidationMessages.RequiredField, 
                Validator.IsValidText, ValidationMessages.InvalidText, 
                true);
        }

        // Validate instructor name field
        private bool validateInstructorName()
        {
            return Validator.ValidateField(inputInstructor, labelRequiredInstructor, 
                "", Validator.IsValidText, ValidationMessages.InvalidText, false);
        }

        // Validate category name field
        private bool validateCategoryName()
        {
            return Validator.ValidateField(inputCategory, labelRequiredCategory, 
                "", Validator.IsValidText, ValidationMessages.InvalidText, false);
        }

        // Validate creation date field
        private bool validateCreationDate()
        {
            return Validator.ValidateField(inputCreationDate, labelDate, 
                "", Validator.IsValidDate, ValidationMessages.InvalidDate, false);
        }

        // Validate course price field
        private bool validateCoursePrice()
        {
            return Validator.ValidateField(inputPrice, labelPrice, 
                "", Validator.IsValidPrice, ValidationMessages.InvalidPrice, false);
        }

        // Validate all fields
        private bool validateAllFields()
        {
            // Validate each individual field and combine the results
            bool isValidCourseName = validateCourseName();
            bool isValidInstructorName = validateInstructorName();
            bool isValidCategoryName = validateCategoryName();
            bool isValidCreationDate = validateCreationDate();
            bool isValidPrice = validateCoursePrice();

            return Validator.ValidateAllFields(
                (isValidCourseName, () => validateCourseName(), inputName),
                (isValidInstructorName, () => validateInstructorName(), inputInstructor),
                (isValidCategoryName, () => validateCategoryName(), inputCategory),
                (isValidCreationDate, () => validateCreationDate(), inputCreationDate),
                (isValidPrice, () => validateCoursePrice(), inputPrice)
                );
        }

        #endregion

        #region CRUD

        // View data in the DataGridView
        private void viewData()
        {
            CRUD.ViewData(DGVCourse, CourseQueryString.dataQuery);
        }

        private void upsertData()
        {
            CRUD.UpsertData("Category", "CategoryName", inputCategory.Text);
            CRUD.UpsertData("Instructor", "InstructorName", inputInstructor.Text);
        }

        // Insert data into the database
        private void insertCourseData(object[] inputInsertValues)
        {
            
            CRUD.InsertData(CourseQueryString.insertQuery, CourseVariables.paramaters, inputInsertValues);
        }

        // Update data in the database
        private void updateCourseData(object[] inputUpdateValues)
        {
            CRUD.UpdateData(CourseQueryString.updateQuery, CourseVariables.fullParamaters, inputUpdateValues);
        }

        // Delete data from the database
        private void deleteCourseData(int ID)
        {
            CRUD.DeleteData(tableName, ID);
        }

        #endregion

        #region Searching

        // Search data
        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVCourse, CourseQueryString.searchQuery, searchValue);
        }

        private void dynamicColumnFiltering()
        {
            Searching.DynamicColumnFiltering(filterComboBoxes, CourseQueryString.comboboxesQuery, CourseVariables.columnFilters);
        }

        // Filter data
        private void filterData()
        {
            string[] columnFloat = { "RatingValue", "CoursePrice" };
            Searching.FilterData(DGVCourse, CourseQueryString.filterQuery, filterComboBoxes, CourseVariables.columnFilters, columnFloat);
        }

        #endregion

        #region EventsHandlers

        private void DGVCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick.DGVCellClick(sender, e, inputControls, CourseVariables.columnNames, new[] { btnUpdate, btnDelete });
        }

        // Search data
        private void inputSearchValue_TextChanged(object sender, EventArgs e)
        {
            searchData(inputSearch.Text);
        }

        // Filter data
        private void attachFilterEventHandlers()
        {
            foreach (var comboBox in filterComboBoxes)
            {
                comboBox.SelectedIndexChanged += FilterComboboxes_SelectedIndexChanged;
            }
        }

        // Filter data
        private void FilterComboboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }

        // Creation process
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!validateAllFields())
            {
                return;
            }

            upsertData();
            insertCourseData(inputInsertValues());
            Helpers.ShowSuccess("Course created successfully!");

            clearAndReloadData();
        }

        // Update process
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validateAllFields())
            {
                return;
            }

            upsertData();
            updateCourseData(inputUpdateValues());
            Helpers.ShowSuccess("Course updated successfully!");

            clearAndReloadData();
        }

        // Delete process
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int courseID = Convert.ToInt32(valueID.Text);

            deleteCourseData(courseID);
            Helpers.ShowSuccess("Course deleted successfully!");

            clearAndReloadData();
        }

        // Refresh data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inputSearch.Text = string.Empty;
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
