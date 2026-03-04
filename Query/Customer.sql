CREATE TABLE Customers (
    Id INT IDENTITY(1,1) PRIMARY KEY,       -- Unique customer ID
    CustomerName NVARCHAR(100) NOT NULL,    -- Customer full name
    Contact NVARCHAR(50) NULL,              -- Phone or contact info
    Email NVARCHAR(100) NULL,               -- Email address
    FavoriteOrder NVARCHAR(200) NULL,       -- Most ordered item
    VisitsCount INT DEFAULT 0,              -- Number of visits
    LastVisitDate DATETIME NULL             -- Date of last visit
);
GO