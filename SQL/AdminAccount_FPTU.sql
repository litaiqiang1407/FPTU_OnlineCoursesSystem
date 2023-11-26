-- Create AdminAccount table
CREATE TABLE AdminAccount (
    AdminAccountID INT IDENTITY(1,1) PRIMARY KEY,
    AdminAccountEmail VARCHAR(50) NOT NULL,
    AdminAccountPasswordHash VARCHAR(60) NOT NULL
);

