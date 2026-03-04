----------------------------------------
-- 1️⃣ Delete child tables first
----------------------------------------
DELETE FROM Feedbacks;
DELETE FROM Orders;

----------------------------------------
-- 2️⃣ Delete standalone tables
----------------------------------------
DELETE FROM PromoCodes;
DELETE FROM Users;

----------------------------------------
-- 3️⃣ Delete parent table
----------------------------------------
DELETE FROM Customers;

----------------------------------------
-- 4️⃣ Reset identity counters
----------------------------------------
DBCC CHECKIDENT ('Feedbacks', RESEED, 0);
DBCC CHECKIDENT ('Orders', RESEED, 0);
DBCC CHECKIDENT ('Customers', RESEED, 0);
DBCC CHECKIDENT ('PromoCodes', RESEED, 0);
DBCC CHECKIDENT ('Users', RESEED, 0);