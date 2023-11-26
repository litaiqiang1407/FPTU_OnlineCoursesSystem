using FPTU_OnlineCoursesSystem.UIInteraction;

namespace FPTU_OnlineCoursesSystem
{
    public partial class AdministratorForm : Form
    {
        private Form activeForm = null;
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private bool _isBtnInstructorsClicked = false;
        private bool _isBtnStudentsClicked = false;
        private bool _isBtnCategoriesClicked = false;
        private bool _isBtnCoursesClicked = false;
        private bool _isBtnEnrollmentsClicked = false;
        private bool _isBtnRatingsClicked = false;
        private bool _isBtnReportsClicked = false;

        private void SetButtonImageAndText(Button button, string imageFilePath, string text)
        {
            if (imageFilePath == null)
            {
                button.BackgroundImage = new Bitmap(1, 1);
            }
            else
            {
                Image image = Image.FromFile(imageFilePath);
                button.BackgroundImage = image;
            }
            button.Text = text;
        }

        private void btnInstructors_MouseEnter(object sender, EventArgs e)
        {
            if (!_isBtnInstructorsClicked)
            {
                SetButtonImageAndText((Button)sender, null, "Instructors");
            }
        }

        private void btnInstructors_MouseLeave(object sender, EventArgs e)
        {
            if (!_isBtnInstructorsClicked)
            {
                SetButtonImageAndText((Button)sender, @"D:\Assignment\Projects\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\image\instructors.png", "");
            }
        }

        private void btnStudents_MouseEnter(object sender, EventArgs e)
        {
            if (!_isBtnStudentsClicked)
            {
                SetButtonImageAndText((Button)sender, null, "Students");
            }
        }

        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            if (!_isBtnStudentsClicked)
            {
                SetButtonImageAndText((Button)sender, @"D:\Assignment\Projects\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\image\students.png", "");
            }
        }

        private void btnCategories_MouseEnter(object sender, EventArgs e)
        {
            if (!_isBtnCategoriesClicked)
            {
                SetButtonImageAndText((Button)sender, null, "Categories");
            }
        }

        private void btnCategories_MouseLeave(object sender, EventArgs e)
        {
            if (!_isBtnCategoriesClicked)
            {
                SetButtonImageAndText((Button)sender, @"D:\Assignment\Projects\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\image\categories.png", "");
            }
        }

        private void btnCourses_MouseEnter(object sender, EventArgs e)
        {
            if (!_isBtnCoursesClicked)
            {
                SetButtonImageAndText((Button)sender, null, "Courses");
            }
        }

        private void btnCourses_MouseLeave(object sender, EventArgs e)
        {
            if (!_isBtnCoursesClicked)
            {
                SetButtonImageAndText((Button)sender, @"D:\Assignment\Projects\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\image\courses.png", "");
            }
        }

        private void btnEnrollments_MouseEnter(object sender, EventArgs e)
        {
            if (!_isBtnEnrollmentsClicked)
            {
                SetButtonImageAndText((Button)sender, null, "Enrollments");
            }
        }

        private void btnEnrollments_MouseLeave(object sender, EventArgs e)
        {
            if (!_isBtnEnrollmentsClicked)
            {
                SetButtonImageAndText((Button)sender, @"D:\Assignment\Projects\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\image\enrollments.png", "");
            }
        }

        private void btnRatings_MouseEnter(object sender, EventArgs e)
        {
            if (!_isBtnRatingsClicked)
            {
                SetButtonImageAndText((Button)sender, null, "Ratings");
            }
        }

        private void btnRatings_MouseLeave(object sender, EventArgs e)
        {
            if (!_isBtnRatingsClicked)
            {
                SetButtonImageAndText((Button)sender, @"D:\Assignment\Projects\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\image\ratings.png", "");
            }
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            if (!_isBtnReportsClicked)
            {
                SetButtonImageAndText((Button)sender, null, "Reports");
            }
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            if (!_isBtnReportsClicked)
            {
                SetButtonImageAndText((Button)sender, @"D:\Assignment\Projects\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\FPTU_OnlineCoursesSystem\image\reports.png", "");
            }
        }


        private void ApplyHoverEffect(Button button, Color foreColor, Color backColor)
        {
            button.ForeColor = foreColor;
            button.BackColor = backColor;
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            _isBtnInstructorsClicked = true;
            Navigator.OpenChildForm(activeForm, new InstructorsManagementForm(), panelMain);
            SetButtonImageAndText((Button)sender, null, "Instructors");
            ApplyHoverEffect((Button)sender, Color.FromArgb(255, 72, 0), Color.White);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            _isBtnStudentsClicked = true;
            Navigator.OpenChildForm(activeForm, new StudentsManagementForm(), panelMain);

            SetButtonImageAndText((Button)sender, null, "Students");
            ApplyHoverEffect((Button)sender, Color.FromArgb(255, 72, 0), Color.White);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            _isBtnCategoriesClicked = true;
            Navigator.OpenChildForm(activeForm, new CategoriesManagementForm(), panelMain);
            SetButtonImageAndText((Button)sender, null, "Categories");
            ApplyHoverEffect((Button)sender, Color.FromArgb(255, 72, 0), Color.White);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            _isBtnCoursesClicked = true;
            Navigator.OpenChildForm(activeForm, new CoursesManagementForm(), panelMain);
            SetButtonImageAndText((Button)sender, null, "Courses");
            ApplyHoverEffect((Button)sender, Color.FromArgb(255, 72, 0), Color.White);
        }

        private void btnEnrollments_Click(object sender, EventArgs e)
        {
            _isBtnEnrollmentsClicked = true;
            Navigator.OpenChildForm(activeForm, new EnrollmentsManagementForm(), panelMain);
            SetButtonImageAndText((Button)sender, null, "Enrollments");
            ApplyHoverEffect((Button)sender, Color.FromArgb(255, 72, 0), Color.White);
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            _isBtnRatingsClicked = true;
            Navigator.OpenChildForm(activeForm, new RatingsManagementForm(), panelMain);
            SetButtonImageAndText((Button)sender, null, "Ratings");
            ApplyHoverEffect((Button)sender, Color.FromArgb(255, 72, 0), Color.White);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            _isBtnReportsClicked = true;
            Navigator.OpenChildForm(activeForm, new ReportsManagementForm(), panelMain);
            SetButtonImageAndText((Button)sender, null, "Reports");
            ApplyHoverEffect((Button)sender, Color.FromArgb(255, 72, 0), Color.White);
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
