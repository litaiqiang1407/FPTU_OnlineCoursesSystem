-- Delete all existing data
DELETE FROM Enrollment;
DELETE FROM Rating;
DELETE FROM Course;
DELETE FROM Student;
DELETE FROM Instructor;
DELETE FROM Category;

-- Reset identity for each table
DBCC CHECKIDENT ('Enrollment', RESEED, 0);
DBCC CHECKIDENT ('Rating', RESEED, 0);
DBCC CHECKIDENT ('Course', RESEED, 0);
DBCC CHECKIDENT ('Student', RESEED, 0);
DBCC CHECKIDENT ('Instructor', RESEED, 0);
DBCC CHECKIDENT ('Category', RESEED, 0);

-- Insert new data

-- Insert 10 records into Category table (10 categories related to IT and others)
INSERT INTO Category (CategoryName, CategoryDescription)
VALUES
    ('Programming', 'Courses related to programming and software development'),
    ('Mathematics', 'Mathematics courses'),
    ('Science', 'Science courses'),
    ('Business', 'Courses related to business and entrepreneurship'),
    ('Art', 'Courses related to arts and creativity'),
    ('Language', 'Language learning courses'),
    ('History', 'Courses related to historical events and knowledge'),
    ('Music', 'Courses related to music and musical instruments'),
    ('Fitness', 'Fitness and wellness courses'),
    ('Cooking', 'Cooking and culinary courses');

-- Insert 20 records into Instructor table
-- (10 existing instructors and 10 new instructors)
INSERT INTO Instructor (InstructorName, InstructorGender, InstructorBirthDate, InstructorEmail, InstructorPhone, Specialization, Experience)
VALUES
    -- Existing instructors
    ('John Doe', 'Male', '1980-01-15', 'johndoe@fpt.edu.vn', '0123456789', 'Software Development', '10 years'),
    ('Jane Smith', 'Female', '1985-03-20', 'janesmith@fpt.edu.vn', '0987654321', 'Data Science', '8 years'),
    ('Bob Johnson', 'Male', '1990-07-10', 'bobjohnson@fpt.edu.vn', '0369847521', 'Web Development', '5 years'),
    ('Amy Davis', 'Female', '1988-04-05', 'amydavis@fpt.edu.vn', '0765432109', 'Machine Learning', '7 years'),
    ('Michael Brown', 'Male', '1982-11-28', 'michaelbrown@fpt.edu.vn', '0912345678', 'Mobile App Development', '9 years'),
    ('Laura Johnson', 'Female', '1983-09-12', 'laurajohnson@fpt.edu.vn', '0584928371', 'Data Analysis', '6 years'),
    ('Chris Lee', 'Male', '1987-06-19', 'chrislee@fpt.edu.vn', '0654789214', 'Network Security', '8 years'),
    ('Sophia Miller', 'Female', '1989-12-25', 'sophiamiller@fpt.edu.vn', '0756829134', 'UI/UX Design', '7 years'),
    ('Alex Wang', 'Male', '1991-10-31', 'alexwang@fpt.edu.vn', '0398765432', 'Cloud Computing', '4 years'),
    ('Emily Anderson', 'Female', '1993-08-17', 'emilyanderson@fpt.edu.vn', '0934567890', 'Digital Marketing', '5 years'),
    -- New instructors
    ('Mark Taylor', 'Male', '1981-02-28', 'marktaylor@fpt.edu.vn', '0567123456', 'AI and Machine Learning', '12 years'),
    ('Sarah White', 'Female', '1986-07-14', 'sarahwhite@fpt.edu.vn', '0890765432', 'Digital Marketing', '10 years'),
    ('Richard Wilson', 'Male', '1992-05-22', 'richardwilson@fpt.edu.vn', '0765467123', 'Database Administration', '8 years'),
    ('Olivia Brown', 'Female', '1984-03-09', 'oliviabrown@fpt.edu.vn', '0987654321', 'Software Engineering', '11 years'),
    ('Matthew Clark', 'Male', '1987-11-17', 'matthewclark@fpt.edu.vn', '0654321987', 'Web Design', '9 years'),
    ('Isabella Garcia', 'Female', '1983-09-05', 'isabellagarcia@fpt.edu.vn', '0790876543', 'Data Analysis', '10 years'),
    ('Daniel Lee', 'Male', '1990-04-10', 'daniellee@fpt.edu.vn', '0654219876', 'Cybersecurity', '8 years'),
    ('Ava Martin', 'Female', '1989-12-15', 'avamartin@fpt.edu.vn', '0790123456', 'UX/UI Design', '9 years'),
    ('William Harris', 'Male', '1985-08-27', 'williamharris@fpt.edu.vn', '0987654321', 'Cloud Computing', '10 years'),
    ('Sophia Turner', 'Female', '1987-10-02', 'sophiaturner@fpt.edu.vn', '0654219876', 'Data Science', '9 years');

-- Insert 20 records into Student table
-- (10 existing students and 10 new students)
INSERT INTO Student (StudentName, StudentGender, StudentBirthDate, StudentEmail, StudentPhone, NumberOfEnrollments)
VALUES
    -- Existing students
    ('Alice Brown', 'Female', '1995-12-05', 'alicebrown@fpt.edu.vn', '0123456789', 3),
    ('David Lee', 'Male', '1998-09-25', 'davidlee@fpt.edu.vn', '0987654321', 2),
    ('Emily Davis', 'Female', '1997-08-15', 'emilydavis@fpt.edu.vn', '0369847521', 4),
    ('Michael Wilson', 'Male', '1996-05-10', 'michaelwilson@fpt.edu.vn', '0758239145', 5),
    ('Sophia Chen', 'Female', '1998-03-18', 'sophiachen@fpt.edu.vn', '0698123456', 2),
    ('Daniel Smith', 'Male', '1997-04-22', 'danielsmith@fpt.edu.vn', '0887654321', 3),
    ('Olivia Johnson', 'Female', '1999-02-08', 'oliviajohnson@fpt.edu.vn', '0975123456', 4),
    ('William Davis', 'Male', '1995-10-01', 'williamdavis@fpt.edu.vn', '0654321879', 3),
    ('Ella Anderson', 'Female', '1996-07-20', 'ellaanderson@fpt.edu.vn', '0934567891', 2),
    ('James Wang', 'Male', '1999-01-15', 'jameswang@fpt.edu.vn', '0665987451', 3),
    -- New students
    ('Liam Thomas', 'Male', '1997-06-12', 'liamthomas@fpt.edu.vn', '0654219876', 4),
    ('Oliver Martin', 'Male', '1996-08-30', 'olivermartin@fpt.edu.vn', '0790123456', 3),
    ('Lucas Johnson', 'Male', '1999-01-07', 'lucasjohnson@fpt.edu.vn', '0987654321', 2),
    ('Mia Harris', 'Female', '1997-03-16', 'miaharris@fpt.edu.vn', '0654321987', 3),
    ('Amelia Turner', 'Female', '1998-07-25', 'ameliaturner@fpt.edu.vn', '0765467123', 4),
    ('Henry Wilson', 'Male', '1995-05-21', 'henrywilson@fpt.edu.vn', '0790876543', 3),
    ('Aria Clark', 'Female', '1996-09-10', 'ariaclark@fpt.edu.vn', '0654219876', 4),
    ('Ethan Garcia', 'Male', '1998-11-03', 'ethangarcia@fpt.edu.vn', '0790123456', 3),
    ('Emma Davis', 'Female', '1995-04-09', 'emmadavis@fpt.edu.vn', '0987654321', 2),
    ('James Smith', 'Male', '1999-02-28', 'jamessmith@fpt.edu.vn', '0654321987', 3);

-- Insert 20 records into Course table
-- (10 existing courses and 10 new courses)
INSERT INTO Course (CourseName, CategoryID, CourseDescription, InstructorID, NumberOfEnrollments, RatingValue, CreationDate, CoursePrice, Duration)
VALUES
    -- Existing courses
    ('Introduction to Python', 1, 'Learn the basics of Python programming.', 1, 50, 4.5, '2023-01-10', 100, '2 months'),
    ('Calculus I', 2, 'Fundamental calculus concepts.', 3, 30, 4.2, '2023-02-15', 80, '3 months'),
    ('Data Analysis with Python', 1, 'Using Python for data analysis.', 2, 40, 4.7, '2023-03-20', 120, '2.5 months'),
    ('Business Strategy Fundamentals', 4, 'Learn the basics of business strategy.', 4, 25, 4.0, '2023-04-25', 90, '2 months'),
    ('Oil Painting Techniques', 5, 'Master the art of oil painting.', 5, 35, 4.6, '2023-05-10', 110, '3 months'),
    ('Spanish for Beginners', 6, 'Beginner-level Spanish language course.', 6, 20, 4.8, '2023-06-15', 70, '2 months'),
    ('World History: Ancient Civilizations', 7, 'Explore ancient civilizations and their history.', 7, 30, 4.3, '2023-07-20', 100, '3 months'),
    ('Piano for Beginners', 8, 'Start learning to play the piano.', 8, 25, 4.4, '2023-08-25', 90, '2.5 months'),
    ('Yoga and Meditation', 9, 'Learn yoga and meditation techniques.', 9, 30, 4.7, '2023-09-10', 110, '2 months'),
    ('Cooking 101: Basic Cooking Skills', 10, 'Master basic cooking skills and techniques.', 10, 35, 4.5, '2023-10-15', 120, '3 months'),
    -- New courses
    ('Advanced Python Programming', 1, 'Deepen your Python skills.', 11, 45, 4.6, '2023-11-10', 120, '3 months'),
    ('Statistics for Data Science', 2, 'Statistics for data analysis.', 12, 35, 4.5, '2023-12-15', 100, '2.5 months'),
    ('Advanced Business Strategies', 4, 'Advanced business strategy concepts.', 13, 20, 4.3, '2024-01-20', 110, '2 months'),
    ('Intermediate Guitar Techniques', 5, 'Enhance your guitar skills.', 14, 25, 4.4, '2024-02-25', 90, '2.5 months'),
    ('Organic Chemistry', 5, 'In-depth study of organic chemistry.', 15, 30, 4.7, '2024-03-10', 130, '3 months'),
    ('Advanced Photography Editing', 5, 'Advanced photo editing techniques.', 16, 15, 4.8, '2024-04-15', 100, '2 months'),
    ('Financial Planning and Investment', 4, 'Financial planning and investment strategies.', 17, 20, 4.2, '2024-05-20', 120, '3 months'),
    ('Introduction to Psychology', 3, 'Introduction to psychology concepts.', 18, 40, 4.6, '2024-06-25', 90, '2 months'),
    ('Digital Art Masterclass', 5, 'Master digital art and graphic design.', 19, 20, 4.4, '2024-07-10', 140, '3 months'),
    ('Android App Development', 10, 'Creating Android apps with Java and Kotlin.', 20, 30, 4.5, '2024-08-15', 110, '2 months');

-- Insert 20 records into Enrollment table
-- (10 existing enrollments and 10 new enrollments)
INSERT INTO Enrollment (StudentID, CourseID, EnrollmentDate, PaymentStatus, EnrollmentStatus)
VALUES
    -- Existing enrollments
    (1, 1, '2023-01-12', 'Paid', 'Active'),
    (1, 2, '2023-02-18', 'Paid', 'Active'),
    (2, 2, '2023-02-20', 'Paid', 'Active'),
    (3, 3, '2023-03-25', 'Paid', 'Active'),
    (4, 4, '2023-04-30', 'Paid', 'Active'),
    (5, 5, '2023-05-12', 'Paid', 'Active'),
    (6, 6, '2023-06-18', 'Paid', 'Active'),
    (7, 7, '2023-07-22', 'Paid', 'Active'),
    (8, 8, '2023-08-27', 'Paid', 'Active'),
    (9, 9, '2023-09-14', 'Paid', 'Active'),
    -- New enrollments
    (10, 10, '2023-11-12', 'Paid', 'Active'),
    (9, 4, '2023-12-18', 'Paid', 'Active'),
    (8, 6, '2024-01-20', 'Paid', 'Active'),
    (7, 3, '2024-02-25', 'Paid', 'Active'),
    (6, 7, '2024-03-30', 'Paid', 'Active'),
    (5, 8, '2024-04-12', 'Paid', 'Active'),
    (4, 9, '2024-05-18', 'Paid', 'Active'),
    (3, 10, '2024-06-22', 'Paid', 'Active'),
    (2, 2, '2024-07-27', 'Paid', 'Active'),
    (1, 1, '2024-08-14', 'Paid', 'Active');

-- Insert 20 records into Rating table
-- (10 existing ratings and 10 new ratings)
INSERT INTO Rating (CourseID, StudentID, RatingValue, Review)
VALUES
    -- Existing ratings
    (1, 1, 4.5, 'Great course, highly recommended.'),
    (2, 1, 4.0, 'Good content, but challenging.'),
    (2, 2, 4.2, 'Enjoyed the course, helpful instructor.'),
    (3, 3, 4.8, 'Fantastic course, learned a lot.'),
    (4, 4, 3.7, 'Decent course, could be more engaging.'),
    (5, 5, 4.5, 'Excellent art techniques covered.'),
    (6, 6, 4.9, 'Amazing language course, very effective.'),
    (7, 7, 4.1, 'Informative and well-structured history course.'),
    (8, 8, 4.4, 'Learned piano basics effectively.'),
    (9, 9, 4.7, 'Great yoga and meditation course.'),
    -- New ratings
    (10, 10, 4.3, 'Good course, helpful content.'),
    (9, 4, 4.5, 'Informative cooking techniques.'),
    (8, 6, 4.6, 'Excellent piano tutorials.'),
    (7, 3, 4.2, 'Insightful historical perspectives.'),
    (6, 7, 4.7, 'Well-explained language lessons.'),
    (5, 8, 4.4, 'Effective fitness and wellness tips.'),
    (4, 9, 4.8, 'Amazing business strategy insights.'),
    (3, 10, 4.3, 'Comprehensive data analysis course.'),
    (2, 2, 4.5, 'Great statistics lectures.'),
    (1, 1, 4.6, 'Fantastic Python programming course.');
