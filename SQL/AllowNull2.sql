-- Modify the Student table to allow null values
ALTER TABLE Student
ALTER COLUMN StudentGender VARCHAR(10) NULL;

ALTER TABLE Student
ALTER COLUMN StudentBirthDate DATE NULL;