using FPTU_OnlineCoursesSystem.UIInteraction;

namespace FPTU_OnlineCoursesSystem
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            SetupButtonHoverEffects();
        }
        // Display child form
        private Form activeForm = null; // Set a value indicating that no form is active

        private void SetupButtonHoverEffects()
        {
            // Apply for Login button
            ButtonHover.ApplyHoverEffect(btnLogin);
            // Apply for SignUp button
            ButtonHover.ApplyHoverEffect(btnSignup, null, null, true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Navigator.OpenChildForm(activeForm, new LoginForm(), panelRoleSelection);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Navigator.OpenChildForm(activeForm, new SignupForm(), panelRoleSelection);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}