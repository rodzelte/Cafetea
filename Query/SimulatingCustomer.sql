----------------------------------------
-- 1️⃣ Insert a Customer
----------------------------------------
INSERT INTO Customers (CustomerName, Contact, Email, FavoriteOrder, VisitsCount, LastVisitDate)
VALUES ('John Doe', '09171234567', 'johndoe@example.com', 'Cappuccino', 1, GETDATE());

-- Capture the new Customer Id
DECLARE @CustomerId INT;
SET @CustomerId = SCOPE_IDENTITY();  -- Gets the last inserted identity value

----------------------------------------
-- 2️⃣ Insert an Order for this Customer
----------------------------------------
INSERT INTO Orders (Name, NameOfOrderPurchase, Status, OrderDate, Total, CustomerId)
VALUES ('ORD-1001', 'Cappuccino, Blueberry Muffin', 'Completed', GETDATE(), 250.75, @CustomerId);

----------------------------------------
-- 3️⃣ Insert Feedback for this Customer
----------------------------------------
INSERT INTO Feedbacks (CustomerId, FeedbackDate, Status, StarRating, FeedbackDescription)
VALUES (@CustomerId, GETDATE(), 'Completed', 5, 'Great service and tasty drinks!');