CREATE DATABASE TourManagementDB;
GO
USE TourManagementDB;
GO
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    Role NVARCHAR(20) CHECK (Role IN ('Admin', 'Staff', 'Customer')),
    CreatedDate DATETIME DEFAULT GETDATE()
);
CREATE TABLE Tours (
    TourID INT PRIMARY KEY IDENTITY(1,1),
    TourName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Price DECIMAL(18, 2) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    AvailableSlots INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    TourID INT NOT NULL FOREIGN KEY REFERENCES Tours(TourID),
    BookingDate DATE DEFAULT GETDATE(),
    NumberOfPeople INT NOT NULL,
    TotalPrice DECIMAL(18, 2), -- Chuyển từ cột tính toán sang cột lưu trữ giá trị
    Status NVARCHAR(20) DEFAULT 'Pending' CHECK (Status IN ('Pending', 'Confirmed', 'Cancelled'))
);

CREATE TABLE Feedbacks (
    FeedbackID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    TourID INT NOT NULL FOREIGN KEY REFERENCES Tours(TourID),
    FeedbackText NVARCHAR(MAX),
    Rating INT CHECK (Rating BETWEEN 1 AND 5),
    FeedbackDate DATETIME DEFAULT GETDATE()
);
INSERT INTO Users (Username, Password, FullName, Email, Phone, Role)
VALUES 
('admin', 'admin123', 'Administrator', 'admin@tour.com', '0123456789', 'Admin'),
('staff1', 'staff123', 'Staff One', 'staff1@tour.com', '0987654321', 'Staff'),
('customer1', 'customer123', 'Customer One', 'customer1@tour.com', '0912345678', 'Customer');
INSERT INTO Tours (TourName, Description, Price, StartDate, EndDate, AvailableSlots)
VALUES
('Tour Hạ Long', 'Tham quan Vịnh Hạ Long 3 ngày 2 đêm', 3000000, '2024-12-10', '2024-12-12', 20),
('Tour Đà Nẵng', 'Khám phá Đà Nẵng 5 ngày 4 đêm', 5000000, '2025-01-15', '2025-01-19', 30);
INSERT INTO Bookings (UserID, TourID, NumberOfPeople)
VALUES
(3, 1, 2),
(3, 2, 1);
INSERT INTO Feedbacks (UserID, TourID, FeedbackText, Rating)
VALUES
(3, 1, 'Tour rất tuyệt vời!', 5),
(3, 2, 'Hướng dẫn viên nhiệt tình.', 4);
Go
CREATE TRIGGER trg_CalculateTotalPrice
ON Bookings
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật TotalPrice dựa trên giá tour và số người đặt
    UPDATE b
    SET b.TotalPrice = b.NumberOfPeople * t.Price
    FROM Bookings b
    INNER JOIN Tours t ON b.TourID = t.TourID
    WHERE b.BookingID IN (SELECT BookingID FROM inserted);
END;