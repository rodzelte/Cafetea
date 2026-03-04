----------------------------------------
-- STEP 1: (Skip adding CustomerId if it exists)
-- Only migrate data if needed
----------------------------------------
UPDATE f
SET f.CustomerId = c.Id
FROM Feedbacks f
JOIN Customers c ON f.CustomerName = c.CustomerName
WHERE f.CustomerId IS NULL; -- only update rows without a value
GO

----------------------------------------
-- STEP 2: Drop old CustomerName column (if it exists)
----------------------------------------
IF EXISTS (
    SELECT 1 
    FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE TABLE_NAME = 'Feedbacks' 
      AND COLUMN_NAME = 'CustomerName'
)
BEGIN
    ALTER TABLE Feedbacks
    DROP COLUMN CustomerName;
END
GO

----------------------------------------
-- STEP 3: Add foreign key Feedbacks → Customers (if not exists)
----------------------------------------
IF NOT EXISTS (
    SELECT 1 
    FROM sys.foreign_keys 
    WHERE name = 'FK_Feedbacks_Customers'
)
BEGIN
    ALTER TABLE Feedbacks
    ADD CONSTRAINT FK_Feedbacks_Customers
    FOREIGN KEY (CustomerId) REFERENCES Customers(Id);
END
GO

----------------------------------------
-- STEP 4: Add PromoCodeId to Orders (if not exists)
----------------------------------------
IF NOT EXISTS (
    SELECT 1 
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'Orders' AND COLUMN_NAME = 'PromoCodeId'
)
BEGIN
    ALTER TABLE Orders
    ADD PromoCodeId INT NULL;

    ALTER TABLE Orders
    ADD CONSTRAINT FK_Orders_PromoCodes
    FOREIGN KEY (PromoCodeId) REFERENCES PromoCodes(Id);
END
GO

----------------------------------------
-- STEP 5: Ensure Orders.CustomerId FK exists
----------------------------------------
IF NOT EXISTS (
    SELECT 1 
    FROM sys.foreign_keys 
    WHERE name = 'FK_Orders_Customers'
)
BEGIN
    ALTER TABLE Orders
    ADD CONSTRAINT FK_Orders_Customers
    FOREIGN KEY (CustomerId) REFERENCES Customers(Id);
END
GO

----------------------------------------
-- STEP 6: Optional CHECK constraints (if not exist)
----------------------------------------
IF NOT EXISTS (
    SELECT 1 
    FROM sys.check_constraints
    WHERE name = 'CK_Orders_Status'
)
BEGIN
    ALTER TABLE Orders
    ADD CONSTRAINT CK_Orders_Status
    CHECK (Status IN ('Pending', 'Completed', 'Cancelled'));
END
GO

IF NOT EXISTS (
    SELECT 1 
    FROM sys.check_constraints
    WHERE name = 'CK_Feedback_Status'
)
BEGIN
    ALTER TABLE Feedbacks
    ADD CONSTRAINT CK_Feedback_Status 
    CHECK (Status IN ('Pending', 'Completed'));
END
GO

IF NOT EXISTS (
    SELECT 1 
    FROM sys.check_constraints
    WHERE name = 'CK_Feedback_StarRating'
)
BEGIN
    ALTER TABLE Feedbacks
    ADD CONSTRAINT CK_Feedback_StarRating 
    CHECK (StarRating BETWEEN 1 AND 5);
END
GO