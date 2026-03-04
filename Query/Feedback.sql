CREATE TABLE Feedbacks (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100) NOT NULL,
    FeedbackDate DATETIME NOT NULL DEFAULT GETDATE(),
    Status NVARCHAR(20) NOT NULL DEFAULT 'Pending',
    StarRating INT NOT NULL,
    FeedbackDescription NVARCHAR(500) NOT NULL DEFAULT '',

    CONSTRAINT CK_Feedback_Status 
        CHECK (Status IN ('Pending', 'Completed')),

    CONSTRAINT CK_Feedback_StarRating 
        CHECK (StarRating BETWEEN 1 AND 5)
);