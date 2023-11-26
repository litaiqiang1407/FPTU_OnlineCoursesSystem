-- Create StudentAccount table
CREATE TABLE StudentAccount (
    StudentAccountID INT IDENTITY(1,1) PRIMARY KEY,
    StudentAccountEmail VARCHAR(50) NOT NULL,
    StudentAccountPasswordHash VARCHAR(60) NOT NULL,
);