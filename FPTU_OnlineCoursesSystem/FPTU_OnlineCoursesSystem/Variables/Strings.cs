namespace FPTU_OnlineCoursesSystem.Variables
{

    // A class to store regular expressions for data validation
    public static class ValidatorRegex
    {

        public static string Text = @"^[A-Za-z0-9\s]+$"; // Alphanumeric characters and spaces

        public static string Email = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; // Email format

        public static string PhoneNumber = @"^\d{7,}$"; // 7+ digits, numeric only

        public static string Date = @"^\d{2}\/\d{2}\/\d{4}$"; // Date format: dd/mm/yyyy

        public static string Price = @"^\$?\d+(\.\d{1,2})?$"; // Price format: xx.xx
    }

    // A class to store validation messages
    public static class ValidationMessages 
    {
        public static string RequiredField = " is required."; 

        public static string InvalidText = " only contains letters and spaces."; 

        public static string InvalidEmail = "Email format: email@fpt.edu.vn";

        public static string InvalidPassword = "Password must have at least 8 characters.";

        public static string InvalidPhoneNumber = "Phone: numeric only.";

        public static string InvalidDate = "Date format: dd/mm/yyyy";

        public static string InvalidPrice = "Price format: xx.xx";
    }

    public static class SignUpVariables
    {
        public static string studentAccountEamilParamater = "@StudentAccountEmail";

        public static string[] columnStudentAccountNames = { "StudentAccountEmail", "StudentAccountPasswordHash" };

        public static string[] columnStudentNames = { "StudentEmail", "StudentName", "StudentGender", "StudentBirthDate", "StudentPhone" };

        public static string[] columnAdminAccountNames = { "AdminAccountEmail", "AdminAccountPasswordHash" };
    }

    public static class CategoryVariables
    {
        public static string tableName = "Category";

        public static string[] columnNames = { "ID", "Name", "Description" };
    }

    public static class  StudentVariables
    {
        public static string tableName = "Student";
    }

    public static class InstructorVariables
    {
        public static string tableName = "Instructor";

        public static string[] columnNames = { "ID", "Name", "Gender", "Specialization", "Experience", "Email", "Phone Number", "Birthdate" };

        public static string[] paramaters = { "InstructorName", "InstructorGender", "Specialization", "Experience", "InstructorEmail", "InstructorPhone", "InstructorBirthDate" };

        public static string[] fullParamaters = paramaters.Prepend("InstructorID").ToArray();

        public static string[] columnFilters = { "InstructorGender", "Specialization", "Experience"  };
    }

    public static class CourseVariables
    {
        public static string tableName = "Course";

        public static string[] columnNames = { "ID", "Course Name", "Category", "Instructor", "Description", "Enrollments", "Date", "Rating", "Price ($)" };
       
        // Parameters for inserting course data into database
        public static string[] paramaters = { "CourseName", "CategoryName", "InstructorName", "CourseDescription", "CreationDate", "CoursePrice" };

        // Parameters for updating course data in database
        public static string[] fullParamaters = paramaters.Prepend("CourseID").ToArray();

        public static string[] columnFilters = { "Category", "Instructor", "Date", "RatingValue", "CoursePrice" };
    }

    
}
