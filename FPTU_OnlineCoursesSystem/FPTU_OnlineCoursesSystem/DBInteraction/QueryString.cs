namespace FPTU_OnlineCoursesSystem.DBInteraction
{
    public static class SignUpQueryString
    {
        // A string to create a new student account
        public static string createStudentAccounttQuery = "INSERT INTO StudentAccount (StudentAccountEmail, StudentAccountPasswordHash) " +
                                                          "VALUES (@StudentAccountEmail, @StudentAccountPasswordHash)";

        public static string getStudentIDQuery = "SELECT StudentAccountID FROM StudentAccount WHERE StudentAccountEmail = @StudentAccountEmail";

        public static string insertStudentInformationQuery = "INSERT INTO Student (StudentEmail, StudentName, StudentGender, StudentBirthDate, StudentPhone) " +
                                                             "VALUES (@StudentEmail, @StudentName, @StudentGender, @StudentBirthDate, @StudentPhone)";

        public static string createAdminAccountQuery = "INSERT INTO AdminAccount (AdminAccountEmail, AdminAccountPasswordHash) " +
                                                        "VALUES (@AdminAccountEmail, @AdminAccountPasswordHash)";
    }

    public static class InstructorQueryString
    {

        // A string to get instructor data
        public static string dataQuery = "SELECT " +
                                         "InstructorID AS 'ID', " +
                                         "InstructorName AS 'Name', " +
                                         "InstructorGender AS 'Gender', " +
                                         "Specialization, " +
                                         "Experience, " +
                                         "InstructorEmail AS 'Email', " +
                                         "InstructorPhone AS 'Phone Number', " +
                                         "CONVERT(VARCHAR, InstructorBirthDate, 103) AS 'Birthdate' " +
                                         "FROM Instructor";

        public static string searchQuery = "SELECT InstructorID AS 'ID', InstructorName AS 'Name', " +
                                           "InstructorGender AS Gender, Specialization, Experience, " +
                                           "InstructorEmail AS Email, InstructorPhone AS 'Phone Number', " +
                                           "CONVERT(varchar, InstructorBirthDate, 103) AS Birthdate FROM Instructor " +
                                           "WHERE InstructorName LIKE @SearchValue " +
                                           "OR Specialization LIKE @SearchValue " +
                                           "OR Experience LIKE @SearchValue " +
                                           "OR InstructorEmail LIKE @SearchValue " +
                                           "OR InstructorPhone LIKE @SearchValue " +
                                           "OR InstructorBirthDate LIKE @SearchValue";

        public static string specializationQuery = "SELECT DISTINCT Specialization FROM Instructor";

        public static string experienceQuery = "SELECT DISTINCT Experience FROM Instructor";

        public static string genderQuery = "SELECT DISTINCT InstructorGender FROM Instructor";

        public static string[] comboboxesQuery = { genderQuery, specializationQuery, experienceQuery  };

        public static string filterQuery = "SELECT " +
                                           "InstructorID AS 'ID', " +
                                           "InstructorName AS 'Name', " +
                                           "InstructorGender AS 'Gender', " +
                                           "Specialization, " +
                                           "Experience, " +
                                           "InstructorEmail AS 'Email', " +
                                           "InstructorPhone AS 'Phone Number', " +
                                           "CONVERT(VARCHAR, InstructorBirthDate, 103) AS 'Birthdate' " +
                                           "FROM Instructor " +
                                           "WHERE (@InstructorGender IS NULL OR InstructorGender = @InstructorGender) " +
                                           "AND (@Specialization IS NULL OR Specialization = @Specialization) " +
                                           "AND (@Experience IS NULL OR Experience = @Experience)";

        // A string to insert a new instructor record into the database
        public static string insertQuery = "INSERT INTO Instructor (InstructorName, InstructorGender, Specialization, " +
                                           "Experience, InstructorEmail, InstructorPhone, InstructorBirthDate) " +
                                           "VALUES (@InstructorName, @InstructorGender, @Specialization, " +
                                           "@Experience, @InstructorEmail, @InstructorPhone, @InstructorBirthDate)";

        public static string updateQuery = "UPDATE Instructor SET InstructorName = @InstructorName, " +
                                           "InstructorGender = @InstructorGender, Specialization = @Specialization, " +
                                           "Experience = @Experience, InstructorEmail = @InstructorEmail, " +
                                           "InstructorPhone = @InstructorPhone, InstructorBirthDate = @InstructorBirthDate " +
                                           "WHERE InstructorID = @InstructorID";

        public static string deleteQuery = "DELETE FROM Instructor WHERE InstructorID = @InstructorID";

    }

    public static class StudentQueryString
    {
        public static string dataQuery = "SELECT StudentID AS 'ID', StudentName AS 'Name', StudentGender AS Gender, StudentEmail AS Email, " +
                                         "StudentPhone AS 'Phone Number', CONVERT(varchar, StudentBirthDate, 103) AS BirthDate, " +
                                         "NumberOfEnrollments AS 'Enrollments' FROM Student";
    }

    public static class CategoryQueryString
    {
        public static string dataQuery = "SELECT CategoryID AS 'ID', CategoryName AS 'Name', CategoryDescription AS 'Description' FROM Category";

        public static string deleteQuery = "DELETE FROM Category WHERE CategoryID = @CategoryID";
    }

    public static class CourseQueryString
    {
        // A string to get course data
        public static string dataQuery = " SELECT Course.CourseID AS 'ID', Course.CourseName AS 'Course Name', " +
                                         " Category.CategoryName AS 'Category', Instructor.InstructorName AS 'Instructor', " +
                                         " Course.CourseDescription AS 'Description', Course.NumberOfEnrollments AS 'Enrollments', " +
                                         " CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', Course.RatingValue AS 'Rating', " +
                                         " FORMAT(Course.CoursePrice, 'C') AS 'Price ($)' " +
                                         " FROM Course " +
                                         " INNER JOIN Category ON Course.CategoryID = Category.CategoryID " +
                                         " INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID";

        // A string to search for course data
        public static string searchQuery = "SELECT " +
                                           "Course.CourseID AS 'ID', " +
                                           "Course.CourseName AS 'Course Name', " +
                                           "Category.CategoryName AS 'Category', " +
                                           "Instructor.InstructorName AS 'Instructor', " +
                                           "Course.CourseDescription AS 'Description', " +
                                           "Course.NumberOfEnrollments AS 'Enrollments', " +
                                           "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                           "Course.RatingValue AS 'Rating', " +
                                           "FORMAT(Course.CoursePrice, 'C')  AS 'Price ($)' " +
                                           "FROM Course " +
                                           "INNER JOIN Category ON Course.CategoryID = Category.CategoryID " +
                                           "INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID " +
                                           "WHERE Course.CourseName LIKE @SearchValue " +
                                           "OR Category.CategoryName LIKE @SearchValue " +
                                           "OR Instructor.InstructorName LIKE @SearchValue" +
                                           "OR Course.CourseDescription LIKE @SearchValue" +
                                           "OR Course.NumberOfEnrollments LIKE @SearchValue" +
                                           "OR CONVERT(VARCHAR, Course.CreationDate, 103) LIKE @SearchValue " +
                                           "OR Course.RatingValue LIKE @SearchValue" +
                                           "OR FORMAT(Course.CoursePrice, 'C') LIKE @SearchValue";


        public static string categoryQuery = "SELECT DISTINCT Category.CategoryName AS 'Category' FROM Course INNER JOIN Category ON Course.CategoryID = Category.CategoryID";

        public static string instructorQuery = "SELECT DISTINCT Instructor.InstructorName AS 'Instructor' FROM Course INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID";

        public static string dateQuery = "SELECT DISTINCT CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date' FROM Course";

        public static string ratingeQuery = "SELECT DISTINCT Course.RatingValue AS 'RatingValue' FROM Course";

        public static string priceQuery = "SELECT DISTINCT FORMAT(Course.CoursePrice, 'C') AS 'CoursePrice' FROM Course";       

        public static string[] comboboxesQuery = { categoryQuery, instructorQuery, dateQuery, ratingeQuery, priceQuery };

        // A string to filter course data
        public static string filterQuery = "SELECT " +
                                           "Course.CourseID AS 'ID', " +
                                           "Course.CourseName AS 'Course Name', " +
                                           "Category.CategoryName AS 'Category', " +
                                           "Instructor.InstructorName AS 'Instructor', " +
                                           "Course.CourseDescription AS 'Description', " +
                                           "Course.NumberOfEnrollments AS 'Enrollments', " +
                                           "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                           "Course.RatingValue AS 'Rating', " +
                                           " FORMAT(Course.CoursePrice, 'C')  AS 'Price ($)' " +
                                           " FROM Course " +
                                           " INNER JOIN Category ON Course.CategoryID = Category.CategoryID " +
                                           " INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID " +
                                           " WHERE (@Category IS NULL OR Category.CategoryName = @Category) " +
                                           " AND (@Instructor IS NULL OR Instructor.InstructorName = @Instructor) " +
                                           " AND (@Date IS NULL OR CONVERT(VARCHAR, Course.CreationDate, 103) = @Date)" +
                                           " AND (@RatingValue IS NULL OR Course.RatingValue = @RatingValue)" +
                                           " AND (@CoursePrice IS NULL OR Course.CoursePrice = @CoursePrice)";

        // A string to insert a new course record into the database
        public static string insertQuery = "INSERT INTO Course (CourseName, CategoryID, CourseDescription, " +
                                           "InstructorID, CreationDate, CoursePrice) " +
                                           "VALUES (@CourseName, (SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName), " +
                                           "@CourseDescription, " +
                                           "(SELECT InstructorID FROM Instructor WHERE InstructorName = @InstructorName), " +
                                           "@CreationDate, @CoursePrice)";

        // A string to update a course record in the database
        public static string updateQuery = "UPDATE Course SET CourseName = @CourseName, " +
                                           "CategoryID = (SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName), " +
                                           "CourseDescription = @CourseDescription, " +
                                           "InstructorID = (SELECT InstructorID FROM Instructor WHERE InstructorName = @InstructorName), " +
                                           "CreationDate = @CreationDate, CoursePrice = @CoursePrice WHERE CourseID = @CourseID";

        // A string to delete a course record from the database
        public static string deleteQuery = "DELETE FROM Course WHERE CourseID = @CourseID";

    }



    public static class ReportQueryString
    {
        // A string to get the number of courses, enrollments and revenue of each category
        public static string categoryRevenueQuery = "SELECT Category.CategoryID AS 'ID', Category.CategoryName AS 'Category', " +
                                                    "COUNT(Course.CourseID) AS 'Courses', " +
                                                    "ISNULL(SUM(Course.NumberOfEnrollments), 0) AS 'Sold', " +
                                                    "FORMAT(ISNULL(SUM(Course.NumberOfEnrollments * Course.CoursePrice), 0), 'C') AS 'Revenue($)' " +
                                                    "FROM Category " +
                                                    "LEFT JOIN Course ON Category.CategoryID = Course.CategoryID " +
                                                    "LEFT JOIN Enrollment ON Course.CourseID = Enrollment.CourseID " +
                                                    "WHERE (@Month IS NULL OR MONTH(Enrollment.EnrollmentDate) = @Month) " +
                                                    "AND (@Year IS NULL OR YEAR(Enrollment.EnrollmentDate) = @Year) " +
                                                    "GROUP BY Category.CategoryID, Category.CategoryName";

        public static string totalQuery = "SELECT " +
                                   "SUM(Course.NumberOfEnrollments) AS TotalCoursesSold, " +
                                   "SUM(Course.NumberOfEnrollments * Course.CoursePrice) AS TotalRevenue " +
                                   "FROM Course " +
                                   "INNER JOIN Enrollment ON Course.CourseID = Enrollment.CourseID " +
                                   "WHERE (@Month IS NULL OR MONTH(Enrollment.EnrollmentDate) = @Month) " +
                                   "AND (@Year IS NULL OR YEAR(Enrollment.EnrollmentDate) = @Year)";

        public static string bestRevenueCoursesQuery = "SELECT TOP 5 CourseName, " +
                                                     "SUM(Course.NumberOfEnrollments * Course.CoursePrice) AS TotalRevenue " +
                                                     "FROM Enrollment " +
                                                     "INNER JOIN Course ON Enrollment.CourseID = Course.CourseID " +
                                                     "WHERE (@FilterMonth IS NULL OR MONTH(Enrollment.EnrollmentDate) = @FilterMonth) " +
                                                     "AND (@FilterYear IS NULL OR YEAR(Enrollment.EnrollmentDate) = @FilterYear) " +
                                                     "GROUP BY CourseName " +
                                                     "ORDER BY TotalRevenue";

        public static string monthlyRevenueQuery = "SELECT ISNULL(SUM(Course.NumberOfEnrollments * Course.CoursePrice), 0) AS MonthlyRevenue " +
                                             "FROM Course INNER JOIN Enrollment ON Course.CourseID = Enrollment.CourseID " +
                                             "WHERE Course.CategoryID = (SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName) " +
                                             "AND MONTH(Enrollment.EnrollmentDate) = @Month AND (@Year IS NULL OR YEAR(Enrollment.EnrollmentDate) = @Year)";
    }
}
