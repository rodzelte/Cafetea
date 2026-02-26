CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

INSERT INTO Users (Username, Password, Role)
VALUES 
('client1', '1234', 'Client'),
('staff1', '1234', 'Staff'),
('admin1', '1234', 'SuperAdmin');