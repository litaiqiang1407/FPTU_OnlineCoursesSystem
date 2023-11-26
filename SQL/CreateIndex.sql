

-- Index for the Instructor table
CREATE INDEX IX_InstructorName ON Instructor (InstructorName);
CREATE INDEX IX_Specialization ON Instructor (Specialization);

-- Index for the Student table
CREATE INDEX IX_StudentName ON Student (StudentName);

-- Index for the Category table
CREATE INDEX IX_CategoryName ON Category (CategoryName);

-- Indexes for the Course table
CREATE INDEX IX_CourseName ON Course (CourseName);
CREATE INDEX IX_InstructorName_Course ON Course (InstructorID);
CREATE INDEX IX_CategoryName_Course ON Course (CategoryID);

-- Indexes for the Enrollment table
CREATE INDEX IX_StudentName_Enrollment ON Enrollment (StudentID);
CREATE INDEX IX_CourseName_Enrollment ON Enrollment (CourseID);

-- Indexes for the Rating table
CREATE INDEX IX_StudentName_Rating ON Rating (StudentID);
CREATE INDEX IX_CourseName_Rating ON Rating (CourseID);


