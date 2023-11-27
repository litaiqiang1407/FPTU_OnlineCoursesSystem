using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;

namespace FPTU_OnlineCoursesSystem
{
    public partial class AdministratorForm : Form
    {
        
        private Form activeForm = null;
        private Button lastClickedButton;

        public AdministratorForm()
        {
            InitializeComponent();
            applyHoverEffect();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            btnInstructors.Click += Button_Click;
            btnStudents.Click += Button_Click;
            btnCategories.Click += Button_Click;
            btnCourses.Click += Button_Click;
            btnEnrollments.Click += Button_Click;
            btnRatings.Click += Button_Click;
            btnReports.Click += Button_Click;
        }

        // Open form for each button
        private void OpenFormForButton(Button button)
        {
            switch (button.AccessibleName)
            {
                case "Instructors":
                    Navigator.OpenChildForm(activeForm, new InstructorsManagementForm(), panelMain);
                    break;
                case "Students":
                    Navigator.OpenChildForm(activeForm, new StudentsManagementForm(), panelMain);
                    break;
                case "Categories":
                    Navigator.OpenChildForm(activeForm, new CategoriesManagementForm(), panelMain);
                    break;
                case "Courses":
                    Navigator.OpenChildForm(activeForm, new CoursesManagementForm(), panelMain);
                    break;
                case "Enrollments":
                    Navigator.OpenChildForm(activeForm, new EnrollmentsManagementForm(), panelMain);
                    break;
                case "Ratings":
                    Navigator.OpenChildForm(activeForm, new RatingsManagementForm(), panelMain);
                    break;
                case "Reports":
                    Navigator.OpenChildForm(activeForm, new ReportsManagementForm(), panelMain);
                    break;
                default:
                    break;
            }
        }

        // Hover effect for buttons
        private void hoverEffect(Button button, string imagePath)
        {
            // Event handler for mouse entering the button area
            button.MouseEnter += (sender, e) =>
            {
                if (button != lastClickedButton)
                {
                    button.Text = button.AccessibleName;
                    button.BackgroundImage = null;
                }
            };

            // Event handler for mouse leaving the button area
            button.MouseLeave += (sender, e) =>
            {
                if (button != lastClickedButton)
                {
                    button.BackgroundImage = Image.FromFile(imagePath);
                    button.Text = "";
                }
            };
        }

        // Apply hover effect for buttons
        private void applyHoverEffect()
        {
            hoverEffect(btnInstructors, Path.Combine(Images.BaseImagePath, Images.instructors));
            hoverEffect(btnStudents, Path.Combine(Images.BaseImagePath, Images.students));
            hoverEffect(btnCategories, Path.Combine(Images.BaseImagePath, Images.categories));
            hoverEffect(btnCourses, Path.Combine(Images.BaseImagePath, Images.courses));
            hoverEffect(btnEnrollments, Path.Combine(Images.BaseImagePath, Images.enrollments));
            hoverEffect(btnRatings, Path.Combine(Images.BaseImagePath, Images.ratings));
            hoverEffect(btnReports, Path.Combine(Images.BaseImagePath, Images.reports));
        }

        // Apply button effect for clicked button
        private void applyButtonEffect(Button button)
        {
            button.Text = button.AccessibleName;
            button.BackgroundImage = null;
            button.ForeColor = Color.FromArgb(255, 72, 0);
            button.BackColor = Color.White;
        }

        // Reset button effect for last clicked button
        private void resetButtonEffect(Button button)
        {
            string imageName = button.AccessibleName.ToLower() + ".png";
            button.BackgroundImage = Image.FromFile(Path.Combine(Images.BaseImagePath, imageName));
            button.Text = "";
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(255, 72, 0);

        }

        // Button click event handler
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // If the clicked button is the same as the last clicked button, do nothing
            if (lastClickedButton != null)
            {
                resetButtonEffect(lastClickedButton);
            }

            // Apply button effect for clicked button
            applyButtonEffect(clickedButton);

            // Set last clicked button
            lastClickedButton = clickedButton;

            OpenFormForButton(clickedButton);
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Navigator.OpenChildForm(activeForm, new WelcomeForm(), panelMain);
        }

        // Exit application
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
