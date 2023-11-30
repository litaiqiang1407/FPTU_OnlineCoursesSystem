namespace FPTU_OnlineCoursesSystem.DBInteraction
{
    public static class SignUpQueryString
    {
        // A string to create a new student account
        public static string createStudentAccounttQuery = "INSERT INTO StudentAccount (StudentAccountEmail, StudentAccountPasswordHash) " +
                                                          "VALUES (@StudentAccountEmail, @StudentAccountPasswordHash)";

        public static string getStudentIDQuery = "SELECT StudentAccountID " +
                                                 "FROM StudentAccount " +
                                                 "WHERE StudentAccountEmail = @StudentAccountEmail";

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

        public static string searchQuery = "SELECT " +
                                           "InstructorID AS 'ID', " +
                                           "InstructorName AS 'Name', " +
                                           "InstructorGender AS Gender, " +
                                           "Specialization, " +
                                           "Experience, " +
                                           "InstructorEmail AS Email, " +
                                           "InstructorPhone AS 'Phone Number', " +
                                           "CONVERT(varchar, InstructorBirthDate, 103) AS Birthdate " +
                                           "FROM Instructor " +
                                           "WHERE InstructorName LIKE @SearchValue " +
                                           "OR Specialization LIKE @SearchValue " +
                                           "OR Experience LIKE @SearchValue " +
                                           "OR InstructorEmail LIKE @SearchValue " +
                                           "OR InstructorPhone LIKE @SearchValue " +
                                           "OR InstructorBirthDate LIKE @SearchValue";

        public static string specializationQuery = "SELECT DISTINCT Specialization FROM Instructor";

        public static string experienceQuery = "SELECT DISTINCT Experience FROM Instructor";

        public static string genderQuery = "SELECT DISTINCT InstructorGender FROM Instructor";

        public static string[] comboBoxesQuery = { genderQuery, specializationQuery, experienceQuery  };

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
        public static string insertQuery = "INSERT INTO " +
                                           "Instructor (InstructorName, InstructorGender, Specialization, " +
                                           "Experience, InstructorEmail, InstructorPhone, InstructorBirthDate) " +
                                           "VALUES (@InstructorName, @InstructorGender, @Specialization, " +
                                           "@Experience, @InstructorEmail, @InstructorPhone, @InstructorBirthDate)";

        public static string updateQuery = "UPDATE Instructor " +
                                           "SET InstructorName = @InstructorName, " +
                                           "InstructorGender = @InstructorGender, Specialization = @Specialization, " +
                                           "Experience = @Experience, InstructorEmail = @InstructorEmail, " +
                                           "InstructorPhone = @InstructorPhone, InstructorBirthDate = @InstructorBirthDate " +
                                           "WHERE InstructorID = @InstructorID";

    }

    public static class StudentQueryString
    {
        public static string dataQuery = "SELECT " +
                                         "StudentID AS 'ID', " +
                                         "StudentName AS 'Name', " +
                                         "StudentGender AS 'Gender', " +
                                         "StudentEmail AS 'Email', " +
                                         "StudentPhone AS 'Phone Number', " +
                                         "CONVERT(varchar, StudentBirthDate, 103) AS 'Birthdate', " +
                                         "NumberOfEnrollments AS 'Enrollments' " +
                                         "FROM Student";

        public static string searchQuery = "SELECT " +
                                           "StudentID AS 'ID', " +
                                           "StudentName AS 'Name', " +
                                           "StudentGender AS 'Gender', " +
                                           "StudentEmail AS 'Email', " +
                                           "StudentPhone AS 'Phone Number', " +
                                           "CONVERT(varchar, StudentBirthDate, 103) AS 'Birthdate', " +
                                           "NumberOfEnrollments AS 'Enrollments' " +
                                           "FROM Student " +
                                           "WHERE StudentName LIKE @SearchValue " +
                                           "OR StudentGender LIKE @SearchValue " +
                                           "OR StudentEmail LIKE @SearchValue " +
                                           "OR StudentPhone LIKE @SearchValue " +
                                           "OR StudentBirthDate LIKE @SearchValue ";

        public static string genderQuery = "SELECT DISTINCT StudentGender FROM Student";

        public static string enrollmentsQuery = "SELECT DISTINCT NumberOfEnrollments FROM Student";

        public static string[] comboBoxesQuery = { genderQuery, enrollmentsQuery };

        public static string filterQuery = "SELECT " +
                                           "StudentID AS 'ID', " +
                                           "StudentName AS 'Name', " +
                                           "StudentGender AS 'Gender', " +
                                           "StudentEmail AS 'Email', " +
                                           "StudentPhone AS 'Phone Number', " +
                                           "CONVERT(varchar, StudentBirthDate, 103) AS 'Birthdate', " +
                                           "NumberOfEnrollments AS 'Enrollments' " +
                                           "FROM Student " +
                                           "WHERE (@StudentGender IS NULL OR StudentGender = @StudentGender) " +
                                           "AND (@NumberOfEnrollments IS NULL OR NumberOfEnrollments = @NumberOfEnrollments) ";

        public static string insertQuery = "INSERT INTO Student (StudentName, StudentGender, StudentEmail, StudentPhone, StudentBirthDate) " +
                                           "VALUES (@StudentName, @StudentGender, @StudentEmail, @StudentPhone, @StudentBirthDate)";

        public static string updateQuery = "UPDATE Student SET StudentName = @StudentName, " +
                                           "StudentGender = @StudentGender, " +
                                           "StudentEmail = @StudentEmail, " +
                                           "StudentPhone = @StudentPhone, " +
                                           "StudentBirthDate = @StudentBirthDate " +
                                           "WHERE StudentID = @StudentID";
    }

    public static class CategoryQueryString
    {
        public static string dataQuery = "SELECT " +
                                         "CategoryID AS 'ID', " +
                                         "CategoryName AS 'Name', " +
                                         "CategoryDescription AS 'Description' " +
                                         "FROM Category";
        public static string searchQuery = "SELECT " +
                                           "CategoryID AS 'ID', " +
                                           "CategoryName AS 'Name', " +
                                           "CategoryDescription AS 'Description' " +
                                           "FROM Category " +
                                           "WHERE CategoryName LIKE @SearchValue " +
                                           "OR CategoryDescription LIKE @SearchValue";
        public static string insertQuery = "INSERT INTO Category (CategoryName, CategoryDescription) " +
                                           "VALUES (@CategoryName, @CategoryDescription)";

        public static string updateQuery = "UPDATE Category SET CategoryName = @CategoryName, " +
                                           "CategoryDescription = @CategoryDescription " +
                                           "WHERE CategoryID = @CategoryID";

    }

    public static class CourseQueryString
    {
        // A string to get course data
        public static string dataQuery = "SELECT " +
                                         "Course.CourseID AS 'ID', " +
                                         "Course.CourseName AS 'Course Name', " +
                                         "Category.CategoryName AS 'Category', " +
                                         "Instructor.InstructorName AS 'Instructor', " +
                                         "Course.CourseDescription AS 'Description', " +
                                         "Course.NumberOfEnrollments AS 'Enrollments', " +
                                         "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                         "Course.RatingValue AS 'Rating', " +
                                         "FORMAT(Course.CoursePrice, 'C') AS 'Price ($)' " +
                                         "FROM Course " +
                                         "INNER JOIN Category ON Course.CategoryID = Category.CategoryID " +
                                         "INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID";

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


        public static string categoryQuery = "SELECT DISTINCT Category.CategoryName AS 'Category' " +
                                             "FROM Course INNER JOIN Category ON Course.CategoryID = Category.CategoryID";

        public static string instructorQuery = "SELECT DISTINCT Instructor.InstructorName AS 'Instructor' " +
                                               "FROM Course INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID";

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
                                           "FORMAT(Course.CoursePrice, 'C')  AS 'Price ($)' " +
                                           "FROM Course " +
                                           "INNER JOIN Category ON Course.CategoryID = Category.CategoryID " +
                                           "INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID " +
                                           "WHERE (@Category IS NULL OR Category.CategoryName = @Category) " +
                                           "AND (@Instructor IS NULL OR Instructor.InstructorName = @Instructor) " +
                                           "AND (@Date IS NULL OR CONVERT(VARCHAR, Course.CreationDate, 103) = @Date)" +
                                           "AND (@RatingValue IS NULL OR Course.RatingValue = @RatingValue)" +
                                           "AND (@CoursePrice IS NULL OR Course.CoursePrice = @CoursePrice)";

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
    }

    public static class EnrollmentQueryString
    {
        public static string dataQuery = "SELECT " +
                                         "Enrollment.EnrollmentID AS 'Enrollment ID', " +
                                         "Enrollment.StudentID AS 'Student ID', " +
                                         "Student.StudentName AS 'Student Name', " +
                                         "Enrollment.CourseID AS 'Course ID', " +
                                         "Course.CourseName AS 'Course Name', " +
                                         "CONVERT(VARCHAR, Enrollment.EnrollmentDate, 103) AS 'Date', " +
                                         "Enrollment.EnrollmentStatus AS 'Status', " +
                                         "Enrollment.PaymentStatus AS 'Payment' " +
                                         "FROM Enrollment " +
                                         "INNER JOIN Student ON Enrollment.StudentID = Student.StudentID " +
                                         "INNER JOIN Course ON Enrollment.CourseID = Course.CourseID";

        public static string searchQuery = "SELECT " +
                                           "Enrollment.EnrollmentID AS 'Enrollment ID', " +
                                           "Enrollment.StudentID AS 'Student ID', " +
                                           "Student.StudentName AS 'Student Name', " +
                                           "Enrollment.CourseID AS 'Course ID', " +
                                           "Course.CourseName AS 'Course Name', " +
                                           "CONVERT(VARCHAR, Enrollment.EnrollmentDate, 103) AS 'Date', " +
                                           "Enrollment.EnrollmentStatus AS 'Status', " +
                                           "Enrollment.PaymentStatus AS 'Payment' " +
                                           "FROM Enrollment " +
                                           "INNER JOIN Student ON Enrollment.StudentID = Student.StudentID " +
                                           "INNER JOIN Course ON Enrollment.CourseID = Course.CourseID " +
                                           "WHERE Enrollment.EnrollmentID LIKE @SearchValue " +
                                           "OR Student.StudentName LIKE @SearchValue " +
                                           "OR Course.CourseName LIKE @SearchValue " +
                                           "OR CONVERT(VARCHAR, Enrollment.EnrollmentDate, 103) LIKE @SearchValue " +
                                           "OR Enrollment.EnrollmentStatus LIKE @SearchValue " +
                                           "OR Enrollment.PaymentStatus LIKE @SearchValue";

        public static string enrollmentDateQuery = "SELECT DISTINCT CONVERT(VARCHAR, Enrollment.EnrollmentDate, 103) AS 'EnrollmentDate' FROM Enrollment";

        public static string enrollmentStatusQuery = "SELECT DISTINCT Enrollment.EnrollmentStatus AS 'EnrollmentStatus' FROM Enrollment";

        public static string paymentStatusQuery = "SELECT DISTINCT Enrollment.PaymentStatus AS 'PaymentStatus' FROM Enrollment";

        public static string[] comboBoxesQuery = { enrollmentDateQuery, enrollmentStatusQuery, paymentStatusQuery };

        public static string filterQuery = "SELECT " +
                                           "Enrollment.EnrollmentID AS 'Enrollment ID', " +
                                           "Enrollment.StudentID AS 'Student ID', " +
                                           "Student.StudentName AS 'Student Name', " +
                                           "Enrollment.CourseID AS 'Course ID', " +
                                           "Course.CourseName AS 'Course Name', " +
                                           "CONVERT(VARCHAR, Enrollment.EnrollmentDate, 103) AS 'Date', " +
                                           "Enrollment.EnrollmentStatus AS 'Status', " +
                                           "Enrollment.PaymentStatus AS 'Payment' " +
                                           "FROM Enrollment " +
                                           "INNER JOIN Student ON Enrollment.StudentID = Student.StudentID " +
                                           "INNER JOIN Course ON Enrollment.CourseID = Course.CourseID " +
                                           "WHERE (@EnrollmentDate IS NULL OR CONVERT(VARCHAR, Enrollment.EnrollmentDate, 103) = @EnrollmentDate) " +
                                           "AND (@EnrollmentStatus IS NULL OR Enrollment.EnrollmentStatus = @EnrollmentStatus) " +
                                           "AND (@PaymentStatus IS NULL OR Enrollment.PaymentStatus = @PaymentStatus)";

        public static string updateQuery = "UPDATE Enrollment SET " +
                                           "StudentID = (SELECT StudentID " +
                                           "FROM Student " +
                                           "WHERE StudentName = @StudentName), " +
                                           "CourseID = (SELECT CourseID FROM Course WHERE CourseName = @CourseName), " +
                                           "EnrollmentDate = @EnrollmentDate, " +
                                           "EnrollmentStatus = @EnrollmentStatus, " +
                                           "PaymentStatus = @PaymentStatus " +
                                           "WHERE EnrollmentID = @EnrollmentID";
    }

    public static class RatingQueryString
    {
        public static string dataQuery = "SELECT " +
                                         "Rating.RatingID AS 'Rating ID', " +
                                         "Rating.StudentID AS 'Student ID', " +
                                         "Student.StudentName AS 'Student Name', " +
                                         "Rating.CourseID AS 'Course ID', " +
                                         "Course.CourseName AS 'Course Name', " +
                                         "Rating.RatingValue AS 'Value', " +
                                         "Rating.Review AS 'Review' " +
                                         "FROM Rating " +
                                         "INNER JOIN Student ON Rating.StudentID = Student.StudentID " +
                                         "INNER JOIN Course ON Rating.CourseID = Course.CourseID";

        public static string searchQuery = "SELECT " +
                                           "Rating.RatingID AS 'Rating ID', " +
                                           "Rating.StudentID AS 'Student ID', " +
                                           "Student.StudentName AS 'Student Name', " +
                                           "Rating.CourseID AS 'Course ID', " +
                                           "Course.CourseName AS 'Course Name', " +
                                           "Rating.RatingValue AS 'Value', " +
                                           "Rating.Review AS 'Review' " +
                                           "FROM Rating " +
                                           "INNER JOIN Student ON Rating.StudentID = Student.StudentID " +
                                           "INNER JOIN Course ON Rating.CourseID = Course.CourseID " +
                                           "WHERE Rating.RatingID LIKE @SearchValue " +
                                           "OR Student.StudentName LIKE @SearchValue " +
                                           "OR Course.CourseName LIKE @SearchValue " +
                                           "OR Rating.RatingValue LIKE @SearchValue " +
                                           "OR Rating.Review LIKE @SearchValue";

        public static string updateQuery = "UPDATE Rating SET " +
                                           "StudentID = (SELECT StudentID FROM Student WHERE StudentName = @StudentName), " +
                                           "CourseID = (SELECT CourseID FROM Course WHERE CourseName = @CourseName), " + 
                                           "Review = @Review " +
                                           "WHERE RatingID = @RatingID";
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

        public static string topRevenueCoursesQuery = "SELECT TOP 5 CourseName, " +
                                                       "SUM(Course.NumberOfEnrollments * Course.CoursePrice) AS TotalRevenue " +
                                                       "FROM Enrollment " +
                                                       "INNER JOIN Course ON Enrollment.CourseID = Course.CourseID " +
                                                       "WHERE (@Month IS NULL OR MONTH(Enrollment.EnrollmentDate) = @Month) " +
                                                       "AND (@Year IS NULL OR YEAR(Enrollment.EnrollmentDate) = @Year) " +
                                                       "GROUP BY CourseName " +
                                                       "ORDER BY TotalRevenue";

        public static string monthlyRevenueQuery = "SELECT " +
                                                   "ISNULL(SUM(Course.NumberOfEnrollments * Course.CoursePrice), 0) AS MonthlyRevenue " +
                                                   "FROM Course " +
                                                   "INNER JOIN Enrollment ON Course.CourseID = Enrollment.CourseID " +
                                                   "WHERE Course.CategoryID = (SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName) " +
                                                   "AND MONTH(Enrollment.EnrollmentDate) = @Month " +
                                                   "AND (@Year IS NULL OR YEAR(Enrollment.EnrollmentDate) = @Year)";
    }

    public static class StudentFormQueryString
    {
        public static string courseDataQuery = "SELECT " +
                                               "Course.CourseName AS 'Course', " +
                                               "Category.CategoryName AS 'Category', " +
                                               "Instructor.InstructorName AS 'Instructor', " +
                                               "Course.NumberOfEnrollments AS 'Enrollments', " +
                                               "Course.RatingValue AS 'Rating', " +
                                               "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                               "Course.Duration, " +
                                               "FORMAT(Course.CoursePrice, 'C') AS 'Price($)' " +
                                               "FROM Course " +
                                               "INNER JOIN Category  ON Course.CategoryID = Category.CategoryID " +
                                               "INNER JOIN Instructor  ON Course.InstructorID = Instructor.InstructorID";

        public static string courseDescriptionQuery = "SELECT CourseDescription FROM Course WHERE CourseName = @CourseName";

        public static string courseReviewQuery = "SELECT Student.StudentName AS 'Student', " +
                                                 "Rating.RatingValue AS 'Rating', " +
                                                 "Rating.Review AS 'Content' " +
                                                 "FROM Rating " +
                                                 "INNER JOIN Student ON Rating.StudentID = Student.StudentID " +
                                                 "INNER JOIN Course ON Rating.CourseID = Course.CourseID " +
                                                 "WHERE Course.CourseName = @CourseName";

        public static string searchQuery = "SELECT " +
                                           "Course.CourseName AS 'Course', " +
                                           "Category.CategoryName AS 'Category', " +
                                           "Instructor.InstructorName AS 'Instructor', " +
                                           "Course.NumberOfEnrollments AS 'Enrollments', " +
                                           "Course.RatingValue AS 'Rating', " +
                                           "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                           "Course.Duration, " +
                                           "FORMAT(Course.CoursePrice, 'C') AS 'Price($)' " +
                                           "FROM Course " +
                                           "INNER JOIN Category  ON Course.CategoryID = Category.CategoryID " +
                                           "INNER JOIN Instructor  ON Course.InstructorID = Instructor.InstructorID " +
                                           "WHERE Course.CourseName LIKE @SearchValue " +
                                           "OR Category.CategoryName LIKE @SearchValue " +
                                           "OR Instructor.InstructorName LIKE @SearchValue " +
                                           "OR Course.NumberOfEnrollments LIKE @SearchValue " +
                                           "OR Course.RatingValue LIKE @SearchValue " +
                                           "OR CONVERT(VARCHAR, Course.CreationDate, 103) LIKE @SearchValue " +
                                           "OR Course.Duration LIKE @SearchValue " +
                                           "OR FORMAT(Course.CoursePrice, 'C') LIKE @SearchValue";

        public static string categoryQuery = "SELECT DISTINCT Category.CategoryName AS 'Category' " +
                                              "FROM Course INNER JOIN Category ON Course.CategoryID = Category.CategoryID";

        public static string instructorQuery = "SELECT DISTINCT Instructor.InstructorName AS 'Instructor' " +
                                                "FROM Course INNER JOIN Instructor ON Course.InstructorID = Instructor.InstructorID";

        public static string ratingeQuery = "SELECT DISTINCT Course.RatingValue AS 'RatingValue' FROM Course";

        public static string priceQuery = "SELECT DISTINCT FORMAT(Course.CoursePrice, 'C') AS 'CoursePrice' FROM Course";

        public static string[] comboBoxesQuery = { categoryQuery, instructorQuery, ratingeQuery, priceQuery };

        public static string filterQuery = "SELECT " +
                                           "Course.CourseName AS 'Course', " +
                                           "Category.CategoryName AS 'Category', " +
                                           "Instructor.InstructorName AS 'Instructor', " +
                                           "Course.NumberOfEnrollments AS 'Enrollments', " +
                                           "Course.RatingValue AS 'Rating', " +
                                           "CONVERT(VARCHAR, Course.CreationDate, 103) AS 'Date', " +
                                           "Course.Duration, " +
                                           "FORMAT(Course.CoursePrice, 'C') AS 'Price($)' " +
                                           "FROM Course " +
                                           "INNER JOIN Category  ON Course.CategoryID = Category.CategoryID " +
                                           "INNER JOIN Instructor  ON Course.InstructorID = Instructor.InstructorID " +
                                           "WHERE (@Category IS NULL OR Category.CategoryName = @Category) " +
                                           "AND (@Instructor IS NULL OR Instructor.InstructorName = @Instructor) " +
                                           "AND (@RatingValue IS NULL OR Course.RatingValue = @RatingValue) " +
                                           "AND (@CoursePrice IS NULL OR Course.CoursePrice = @CoursePrice)";
    }
}
