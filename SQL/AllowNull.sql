-- Modify the Instructor table to allow null values
ALTER TABLE Instructor
ALTER COLUMN InstructorGender VARCHAR(10) NULL;

ALTER TABLE Instructor
ALTER COLUMN InstructorBirthDate DATE NULL;

ALTER TABLE Instructor
ALTER COLUMN InstructorEmail VARCHAR(50) NULL;

ALTER TABLE Instructor
ALTER COLUMN Specialization VARCHAR(50) NULL;

ALTER TABLE Instructor
ALTER COLUMN Experience VARCHAR(10) NULL

-- Modify the Student table to allow null values
ALTER TABLE Student
ALTER COLUMN StudentGender VARCHAR(10) NOT NULL;

ALTER TABLE Student
ALTER COLUMN StudentBirthDate DATE NOT NULL;

ALTER TABLE Student
ALTER COLUMN StudentEmail VARCHAR(50) NOT NULL;

-- Modify the Category table to allow null values
ALTER TABLE Category
ALTER COLUMN CategoryDescription TEXT NULL;

-- Modify the Category table to allow null values
ALTER TABLE Course
ALTER COLUMN CoursePrice FLOAT NULL;

-- Modify the Enrollment table to allow null values
ALTER TABLE Enrollment
ALTER COLUMN EnrollmentDate DATE NOT NULL;

ALTER TABLE Enrollment
ALTER COLUMN EnrollmentStatus VARCHAR(10) NULL;


-- Modify the Rating table to allow null values
ALTER TABLE Rating
ALTER COLUMN RatingValue FLOAT NULL;
