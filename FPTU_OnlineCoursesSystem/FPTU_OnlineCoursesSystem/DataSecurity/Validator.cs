using System.Text.RegularExpressions;
using FPTU_OnlineCoursesSystem.UIInteraction;
using FPTU_OnlineCoursesSystem.Variables;

namespace FPTU_OnlineCoursesSystem.DataValidator
{
    // Class contains methods for validating user input and fields
    public static class Validator
    {
        #region ValidInput

        // Method validates a text input (e.g., name) containing only letters and spaces
        public static bool IsValidText(string text)
        {
            return Regex.IsMatch(text, ValidationRegex.Text);
        }

        // Method validates an email address 
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, ValidationRegex.Email);
        }

        // Method validates a password with a minimum length of 8 characters
        public static bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        // Method validates a phone number with a minimum length of 7 digits
        public static bool IsValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number, ValidationRegex.PhoneNumber);
        }

        // Method validates a date in the format dd/mm/yy
        public static bool IsValidDate(string date)
        {
            return Regex.IsMatch(date, ValidationRegex.Date);
        }

        // Method validates a price with optional decimal points
        public static bool IsValidPrice(string price)
        {
            return Regex.IsMatch(price, ValidationRegex.Price);
        }

        #endregion

        #region ValidField

        // Validate a field (e.g., TextBox) based on whether it is required, a validation function, and display error messages
        public static bool ValidateField(TextBox textBox, Label label, string requiredMessage, 
            Func<string, bool> validationFunc, string validationMessage, bool isRequired)
        {
            string fieldValue = textBox.Text; // Extract the field value from the TextBox
            bool emptyField = string.IsNullOrEmpty(fieldValue); // Check if the field is empty
            bool validField = validationFunc(fieldValue); // Apply the provided validation function to the field value

            // Determine the validation logic based on whether the field is required or optional
            if (isRequired)
            {
                // Validation for a required field
                if (emptyField || !validField)
                {
                    // Display an error message if the field is empty or fails validation
                    label.Text = emptyField ? requiredMessage : validationMessage;
                    label.Visible = true;
                    textBox.Focus();
                    return false;
                }
                else
                {
                    // Move focus to the next control (simulate Tab key)
                    SendKeys.Send("{TAB}");
                    return true;
                }
            }
            else
            {
                // Validation for an optional field
                if (!emptyField && !validField)
                {
                    // Display an error message if the optional field fails validation
                    label.Text = validationMessage;
                    label.Visible = true;
                    textBox.Focus();
                    return false;
                }
                else
                {
                    // Move focus to the next control (simulate Tab key) if validation passes or field is empty
                    SendKeys.Send("{TAB}");
                    return true;
                }
            }
        }

        // Validate all fields
        public static bool ValidateAllFields(params (bool isValid, Action validationAction, Control focusControl)[] validations)
        {
            bool overallValidation = true; // Overall validation status for all fields
            Control firstInvalidField = null; // Reference to the first invalid field for focus

            foreach (var validation in validations)
            {
                if (!validation.isValid)
                {
                    validation.validationAction.Invoke(); // Invoke the specified validation action
                    overallValidation = false; // Set overall validation status to false

                    // Determine the first invalid field based on TabIndex
                    if (firstInvalidField == null || validation.focusControl.TabIndex < firstInvalidField.TabIndex)
                    {
                        firstInvalidField = validation.focusControl;
                    }
                }
            }

            // If overall validation fails, focus on the first invalid field and show an error message
            if (!overallValidation)
            {
                firstInvalidField?.Focus();
                Helpers.ShowError("Incomplete details. Ensure all required fields are filled correctly.");
            }
            return overallValidation; 
        }

        #endregion
    }

}
