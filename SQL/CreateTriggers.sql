-- Create the trigger to update NumberOfEnrollments in the Student table
CREATE TRIGGER UpdateStudentEnrollments
ON Enrollment
AFTER INSERT
AS
BEGIN
    DECLARE @StudentID INT;
    
    SELECT @StudentID = StudentID
    FROM inserted;
    
    UPDATE Student
    SET NumberOfEnrollments = (
        SELECT COUNT(*)
        FROM Enrollment
        WHERE StudentID = @StudentID
    )
    WHERE StudentID = @StudentID;
END;
GO

-- Create the trigger to update NumberOfEnrollments in the Course table
CREATE TRIGGER UpdateCourseEnrollments
ON Enrollment
AFTER INSERT
AS
BEGIN
    DECLARE @CourseID INT;
    
    SELECT @CourseID = CourseID
    FROM inserted;
    
    UPDATE Course
    SET NumberOfEnrollments = (
        SELECT COUNT(*)
        FROM Enrollment
        WHERE CourseID = @CourseID
    )
    WHERE CourseID = @CourseID;
END;
GO
