using System.Data.SqlClient;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.DataValidator;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;
using FPTU_OnlineCoursesSystem.DataSecurity;

namespace FPTU_OnlineCoursesSystem
{
    public partial class SignupForm : Form
    {
        private Form activeForm = null;

        public SignupForm()
        {
            InitializeComponent();
            setupButtonHoverEffects();
        }

        #region Helper

        private string getSelectedGender()
        {
            if (inputMale.Checked)
            {
                return "Male";
            }
            else if (inputFemale.Checked)
            {
                return "Female";
            }
            else if (inputOther.Checked)
            {
                return "Other";
            }

            return null;
        }

        private DateTime? parsedBirthdate()
        {
            return Helpers.ParseDate(inputBirthdate.Text);
        }

        private object[] studentInformationValues()
        {
            string email = inputEmail.Text;
            string name = inputName.Text;
            string gender = getSelectedGender();
            DateTime? birthdate = parsedBirthdate();
            string phoneNumber = inputPhoneNumber.Text;

            return new object[] { email, name, gender, birthdate, phoneNumber };
        }

        // Email and password values for student account
        private string[] studentAccountValues()
        {
            string email = inputEmail.Text;
            string password = inputPassword.Text;
            
            // Hash the password
            string hashedPassword = hashPassword(password);

            return new string[] { email, hashedPassword };
        }

        #endregion

        #region ValidateField

        // Function to validate the name field
        private bool validateName()
        {
            return Validator.ValidateField(inputName, labelNameRequired,
                "Full Name" + ValidationMessages.RequiredField, Validator.IsValidText,
                "Full Name" + ValidationMessages.InvalidText, true);
        }

        // Function to validate the email field
        private bool validateEmail()
        {
            return Validator.ValidateField(inputEmail, labelEmailRequired,
                "Email Address" + ValidationMessages.RequiredField, Validator.IsValidEmail,
                ValidationMessages.InvalidEmail, true);
        }

        // Function to validate the password field
        private bool validatePassword()
        {
            return Validator.ValidateField(inputPassword, labelPasswordRequired,
                "Password" + ValidationMessages.RequiredField, Validator.IsValidPassword,
                ValidationMessages.InvalidPassword, true);
        }

        // Function to validate the phone number field
        private bool validatePhoneNumber()
        {
            return Validator.ValidateField(inputPhoneNumber, labelPhoneNumber, "",
                Validator.IsValidPhoneNumber, ValidationMessages.InvalidPhoneNumber, false);
        }

        // Function to validate the birthdate field
        private bool validateBirthdate()
        {
            return Validator.ValidateField(inputBirthdate, labelBirthdate, "",
                Validator.IsValidDate, ValidationMessages.InvalidDate, false);
        }

        // Function to validate all fields
        private bool validateAllFields()
        {
            bool isNameValid = validateName();
            bool isEmailValid = validateEmail();
            bool isPasswordValid = validatePassword();
            bool isPhoneNumberValid = validatePhoneNumber();
            bool isBirthdateValid = validateBirthdate();

            return Validator.ValidateAllFields(
                (isNameValid, () => validateName(), inputName),
                (isEmailValid, () => validateEmail(), inputEmail),
                (isPasswordValid, () => validatePassword(), inputPassword),
                (isPhoneNumberValid, () => validatePhoneNumber(), inputPhoneNumber),
                (isBirthdateValid, () => validateBirthdate(), inputBirthdate)
            );
        }

        #endregion

        #region RegistrationProcessing.

        // Function to check if the email is already registered
        private bool isEmailRegistered(string email)
        {
         return Security.EmailRegistered("signup", email);
        }

        // Function to hash the password
        private string hashPassword(string password)
        {
            // Use BCrypt to hash the password
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Function to create the student account
        private void createStudentAccount(string[] studentAccountValues)
        {
            CRUD.InsertData(SignUpQueryString.createStudentAccounttQuery, SignUpVariables.columnStudentAccountNames, studentAccountValues);
        }

        // Function to insert the student data
        private void insertStudentData(object[] studentInformations)
        {
            CRUD.InsertData(SignUpQueryString.insertStudentInformationQuery, SignUpVariables.columnStudentNames, studentInformations);
        }

        #endregion

        #region Event Handlers

        private void setupButtonHoverEffects()
        {
            ButtonHover.ApplyHoverEffect(btnSignup);
        }

        private void inputName_KeyDown(object sender, KeyEventArgs e)
        {
            labelNameRequired.Visible = false;

            if (e.KeyCode == Keys.Enter)
            {
                validateName();
            }
        }

        private void inputEmail_KeyDown(object sender, KeyEventArgs e)
        {
            labelEmailRequired.Visible = false;

            if (e.KeyCode == Keys.Enter)
            {
                validateEmail();
            }
        }

        private void inputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            labelPasswordRequired.Visible = false;

            if (e.KeyCode == Keys.Enter)
            {
                validatePassword();
            }
        }

        private void inputPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            labelPhoneNumber.Visible = false;

            if (e.KeyCode == Keys.Enter)
            {
                validatePhoneNumber();
            }
        }

        private void inputBirthdate_KeyDown(object sender, KeyEventArgs e)
        {
            labelBirthdate.Visible = false;

            if (e.KeyCode == Keys.Enter)
            {
                validateBirthdate();
            }
        }

        // Function to handle the sign up button click event
        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Validate all fields
            if (!validateAllFields())
            {
                return;
            }

            string email = inputEmail.Text;

            // Check if the email is already registered
            if (isEmailRegistered(email))
            {
                return;
            }

            // Create the student account and insert the student data
            createStudentAccount(studentAccountValues());
            insertStudentData(studentInformationValues());

            // Show success message
            Helpers.ShowSuccess("Sign up successful. Let's log in.");

            // Open the login form
            Navigator.OpenChildForm(activeForm, new LoginForm(), panelAccountCreation);

        }

        #endregion
    }
}
