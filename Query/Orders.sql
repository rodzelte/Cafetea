CREATE TABLE Orders (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50),               -- Order ID
    NameOfPurchaser NVARCHAR(100),   -- Customer name
    NameOfOrderPurchase NVARCHAR(200), -- Items ordered
    Status NVARCHAR(50),             -- Pending / Completed / Cancelled
    OrderDate DATETIME,              -- Date and time of order
    Total DECIMAL(10,2)              -- Total price
);
GO


-- Add CustomerId to Orders table
ALTER TABLE Orders
ADD CustomerId INT NULL;

-- Add foreign key constraint
ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_Customers
FOREIGN KEY (CustomerId) REFERENCES Customers(Id);


INSERT INTO Orders (Name, NameOfPurchaser, NameOfOrderPurchase, Status, OrderDate, Total)
VALUES
('Order-1', 'John', 'Coffee, Cake', 'Completed', GETDATE(), 150.00),
('Order-2', 'Alice', 'Tea, Sandwich', 'Pending', GETDATE(), 120.50),
('Order-3', 'Bob', 'Coffee', 'Completed', DATEADD(DAY, -1, GETDATE()), 75.00),
('Order-4', 'Mary', 'Juice, Cake', 'Completed', DATEADD(DAY, -3, GETDATE()), 180.75),
('Order-5', 'Steve', 'Sandwich', 'Cancelled', DATEADD(DAY, -5, GETDATE()), 90.00);
GO