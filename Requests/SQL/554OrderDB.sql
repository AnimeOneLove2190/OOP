CREATE TABLE Product (
Id INT PRIMARY KEY,
Name VARCHAR(255) NOT NULL,
Price INT NOT NULL,
IsAvailable BIT NOT NULL,
);
CREATE TABLE SomeOrder (
Id INT PRIMARY KEY,
OrderDate DATETIME NOT NULL,
IsCompleted BIT NOT NULL,
);
CREATE TABLE OrderProduct  (
Quantity INT NOT NULL,
OrderId INT NOT NULL,
ProductId INT NOT NULL,
FOREIGN KEY (OrderId) REFERENCES SomeOrder(Id),
FOREIGN KEY (ProductId) REFERENCES Product(Id),
PRIMARY KEY (OrderId, ProductId)
);