-- Create the database
CREATE DATABASE FPTU_OnlineCourseSystem_DB;
GO

-- Use the database
USE FPTU_OnlineCourseSystem_DB;
GO


-- Create the Instructor table
CREATE TABLE Instructor (
    InstructorID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    InstructorName VARCHAR(50) NOT NULL,
    InstructorGender VARCHAR(10) NOT NULL,
    InstructorBirthDate DATE NOT NULL,
    InstructorEmail VARCHAR(50) NOT NULL,
    InstructorPhone VARCHAR(20),
    Specialization VARCHAR(50) NOT NULL,
    Experience VARCHAR(10) NOT NULL
);

-- Create the Student table
CREATE TABLE Student (
    StudentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StudentName VARCHAR(50) NOT NULL,
    StudentGender VARCHAR(10) NOT NULL,
    StudentBirthDate DATE NOT NULL,
    StudentEmail VARCHAR(50) NOT NULL,
    StudentPhone VARCHAR(20),
    NumberOfEnrollments INT 
);

-- Create the Category table
CREATE TABLE Category (
    CategoryID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL,
    CategoryDescription TEXT 
);

-- Create the Course table
CREATE TABLE Course (
    CourseID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL,
    CategoryID INT NOT NULL FOREIGN KEY REFERENCES Category(CategoryID),
    CourseDescription TEXT,
    InstructorID INT NOT NULL FOREIGN KEY REFERENCES Instructor(InstructorID),
    NumberOfEnrollments INT,
    RatingValue FLOAT,
    CreationDate DATE,
    CoursePrice FLOAT NOT NULL,
    Duration VARCHAR(10)
);

-- Create the Enrollment table
CREATE TABLE Enrollment (
    EnrollmentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL FOREIGN KEY REFERENCES Student(StudentID),
    CourseID INT NOT NULL FOREIGN KEY REFERENCES Course(CourseID),
    EnrollmentDate DATE NOT NULL,
	PaymentStatus VARCHAR(10) NOT NULL,
	EnrollmentStatus VARCHAR(10)
);

-- Create the Rating table
CREATE TABLE Rating (
    RatingID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CourseID INT NOT NULL FOREIGN KEY REFERENCES Course(CourseID),
    StudentID INT NOT NULL FOREIGN KEY REFERENCES Student(StudentID),
    RatingValue FLOAT NOT NULL,
    Review TEXT 
);




