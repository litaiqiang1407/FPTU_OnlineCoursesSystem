﻿using System.Data;
using System.Data.SqlClient;
using FPTU_OnlineCoursesSystem.DBInteraction;
using FPTU_OnlineCoursesSystem.DataValidator;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;
using FPTU_OnlineCoursesSystem.DataSecurity;



namespace FPTU_OnlineCoursesSystem
{
    public partial class LoginForm : Form
    {
        private Form activeForm = null;

        public LoginForm()
        {
            InitializeComponent();
            setupButtonHoverEffects();
        }

        #region Helper Methods

        private void setupButtonHoverEffects()
        {
            ButtonHover.ApplyHoverEffects(new[] { btnLogin, btnSignup });
        }

        private bool validateEmail()
        {
            return Validator.ValidateField(inputEmail, labelEmailRequired,
                "Email" + ValidationMessages.RequiredField, Validator.IsValidEmail,
                ValidationMessages.InvalidEmail, true);
        }

        private bool validatePassword()
        {
            return Validator.ValidateField(inputPassword, labelPassword,
                "Password" + ValidationMessages.RequiredField, Validator.IsValidPassword,
                ValidationMessages.InvalidPassword, true);
        }

        private void toggleVisibilityBasedOnLabelPassword()
        {
            cbxRememberMe.Visible = !labelPassword.Visible;
            labelForgotPassword.Visible = !labelPassword.Visible;
        }

        private bool validateAllFields()
        {
            bool isEmailValid = validateEmail();
            bool isPasswordValid = validatePassword();

            return Validator.ValidateAllFields(
                (isEmailValid, () => validateEmail(), inputEmail),
                (isPasswordValid, () => validatePassword(), inputPassword)
            );
        }

        // check if email is registered
        private bool isEmailRegistered(string email)
        {
            return Security.EmailRegistered("login", email);
        }

        // Authenticate user
        private bool authenticateUser(string email, string password, string accountType)
        {
            string tableName = (accountType == "admin") ? "AdminAccount" : "StudentAccount";

            string getPasswordQuery = $"SELECT {tableName}PasswordHash FROM {tableName} WHERE {tableName}Email = @Email";
            SqlParameter[] getPasswordParameters = { new SqlParameter("@Email", email) };

            DataTable resultTable = DBConnection.ExecuteQuery(getPasswordQuery, getPasswordParameters);

            // Check if password is correct
            if (resultTable.Rows.Count > 0)
            {
                string storedHash = resultTable.Rows[0][$"{tableName}PasswordHash"].ToString();

                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    return true;
                }
                else
                {
                    Helpers.ShowError("Incorrect password.");
                }
            }
            return false;
        }


        #endregion

        #region Event Handlers

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
            labelPassword.Visible = false;
            toggleVisibilityBasedOnLabelPassword();
            if (e.KeyCode == Keys.Enter)
            {
                validatePassword();
                toggleVisibilityBasedOnLabelPassword();
                if (validateEmail() && validatePassword())
                {
                    btnLogin.PerformClick();
                }
            }
        }

        // Login button click event handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string password = inputPassword.Text;

            // Validate all fields
            if (!validateAllFields())
            {
                toggleVisibilityBasedOnLabelPassword();
                return;
            }

            // Check if email is registered
            if (isEmailRegistered(email))
            {
                // Authenticate admin
                if (authenticateUser(email, password, "admin"))
                {
                    Form adminForm = new AdministratorForm();
                    adminForm.Show();
                    return;
                }

                // Authenticate student
                if (authenticateUser(email, password, "student"))
                {
                    Form studentForm = new StudentForm();
                    studentForm.Show();
                    return;
                }
            }
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            Navigator.OpenChildForm(activeForm, new ForgotPasswordForm(), panelAdminLogin);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Navigator.OpenChildForm(activeForm, new SignupForm(), panelAdminLogin);
        }
        #endregion


    }
}
