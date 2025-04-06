CREATE DATABASE mdk111;

USE mdk111;

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);



CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY(1,1),
    Recipient NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    DeliveryDate DATETIME NOT NULL,
    Status NVARCHAR(50) NOT NULL
);


CREATE TABLE OrderStatuses (
    StatusId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT FOREIGN KEY REFERENCES Orders(OrderId),
    Status NVARCHAR(50) NOT NULL,
    Timestamp DATETIME DEFAULT GETDATE()
);


CREATE TABLE Couriers (
    CourierId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT FOREIGN KEY REFERENCES Users(UserId)
);


INSERT INTO Users (Username, Password, Role) VALUES ('admin', 'admin123', 'admin');
INSERT INTO Users (Username, Password, Role) VALUES ('courier', 'courier123', 'courier');

INSERT INTO Orders (Recipient, Address, DeliveryDate, Status) VALUES ('Иван Иванов', 'Улица Ленина, 1', GETDATE(), 'Pending');
INSERT INTO Orders (Recipient, Address, DeliveryDate, Status) VALUES ('Петр Петров', 'Улица Мира, 2', GETDATE(), 'Pending');
INSERT INTO Orders (Recipient, Address, DeliveryDate, Status) VALUES ('Валентин Шаляпин', 'Улица Булки, 34', GETDATE(), 'Pending');
INSERT INTO Orders (Recipient, Address, DeliveryDate, Status) VALUES ('Игорь Владимирович', 'Проспект Шарика, 11', GETDATE(), 'Pending');
INSERT INTO Orders (Recipient, Address, DeliveryDate, Status) VALUES ('Захар Горев', 'Улица Жизни, 4', GETDATE(), 'Pending');
