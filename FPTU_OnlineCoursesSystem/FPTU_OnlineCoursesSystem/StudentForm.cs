using System.Data.SqlClient;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;

namespace FPTU_OnlineCoursesSystem
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            initializeFilterComboBoxes();
            dynamicColumnFiltering();
            viewListCourses();
            setButtonHoverEffect();
            attachFilterEventHandlers();
            displayNumber();
            informationControls = new Control[] { infoName, infoCategory, infoInstructor, infoEnrollment, infoRating, infoDate, infoDuration, infoPrice };
        }
        #region Variables

        Control[] informationControls;
        ComboBox[] filterComboBoxes;

        private void initializeFilterComboBoxes()
        {
            filterComboBoxes = new ComboBox[] { filterCategory, filterInstructor, filterRating, filterPrice };
        }

        #endregion

        #region UIInteraction

        private void setButtonHoverEffect()
        {
            ButtonHover.ApplyHoverEffect(btnEnroll);
            ButtonHover.ApplyHoverEffect(btnAddToCart, null, null, true);

            ButtonHover.ApplyHoverEffect(btnRefresh, Path.Combine(Images.BaseImagePath, Images.RefreshIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverRefreshIconPath));

            ButtonHover.ApplyHoverEffect(btnSearch, Path.Combine(Images.BaseImagePath, Images.SearchIconPath),
                Path.Combine(Images.BaseImagePath, Images.HoverSearchIconPath));
        }
        private void hideInformationImage()
        {
            courseInformationFrame.Image = null;
            courseInformationFrame.Enabled = false;
            courseInformationFrame.SendToBack();
        }

        private void displayNumber()
        {
            if (numberCart.Text != "0")
            {
                numberCart.Visible = true;
            }

            if (numberEnrollment.Text != "0")
            {
                numberEnrollment.Visible = true;
            }
        }

        private void UpdateCourseCount(Label number, string action)
        {
            if (int.TryParse(number.Text, out int currentNumberCourses))
            {
                Helpers.ShowSuccess($"{infoName.Text} {action} successfully!");

                number.Text = (++currentNumberCourses).ToString();
                number.Visible = true;
            }
        }

        #endregion

        #region DatabaseInteraction
        private void viewListCourses()
        {
            CRUD.ViewData(DGVCoursesList, StudentFormQueryString.courseDataQuery);
        }

        private string courseDescription(string courseName)
        {
            SqlParameter[] parameters = { new SqlParameter("@CourseName", courseName) };

            return CRUD.GetSingleValue(StudentFormQueryString.courseDescriptionQuery, parameters, "CourseDescription");
        }


        private void courseReviews(string courseName)
        {
            SqlParameter[] parameters = { new SqlParameter("@CourseName", courseName) };

            CRUD.ViewData(DGVCourseReview, StudentFormQueryString.courseReviewQuery, parameters);
        }

        #endregion

        #region Searching
        private void searchData(string searchValue)
        {
            Searching.SearchData(DGVCoursesList, StudentFormQueryString.searchQuery, searchValue);
        }

        private void dynamicColumnFiltering()
        {
            Searching.DynamicColumnFiltering(filterComboBoxes, StudentFormQueryString.comboBoxesQuery, StudentFormVariables.columnFilters);
        }

        private void filterData()
        {
            string[] columnFloat = { "RatingValue", "CoursePrice" };
            Searching.FilterData(DGVCoursesList, StudentFormQueryString.filterQuery, filterComboBoxes, StudentFormVariables.columnFilters, columnFloat);
        }

        #endregion

        #region EventHandlers
        private void inputSearchValue_TextChanged(object sender, EventArgs e)
        {
            searchData(inputSearch.Text);
        }

        private void DGVCoursesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hideInformationImage();

            // Call the common method to handle cell click
            CellClick.DGVCellClick(sender, e, informationControls, StudentFormVariables.columnNames, btnEnroll, btnAddToCart);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVCoursesList.Rows[e.RowIndex];

                if (row != null)
                {
                    // Retrieve and display the course description
                    string courseName = row.Cells["Course"].Value.ToString();
                    infoDescription.Text = courseDescription(courseName);

                    // Load reviews for the selected course
                    courseReviews(courseName);
                }
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inputSearch.Text = string.Empty;
            ButtonClick.RefreshComboboxes(filterComboBoxes);
            viewListCourses();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Label numberEnrolled = numberEnrollment;
            UpdateCourseCount(numberEnrolled, "enrolled");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Label numberCartAdded = numberCart;
            UpdateCourseCount(numberCartAdded, "added to cart");
        }

        #endregion
    }
}
