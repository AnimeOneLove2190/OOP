--580a
SELECT
SomeOrder.Id,
SomeOrder.IsCompleted,
SomeOrder.OrderDate,
SUM (Product.Price * OrderProduct.Quantity) AS TotalAmount
FROM SomeOrder
JOIN OrderProduct ON SomeOrder.Id = OrderProduct.OrderId
JOIN Product ON OrderProduct.ProductId = Product.Id
WHERE SomeOrder.IsCompleted = 1
GROUP BY SomeOrder.Id, SomeOrder.IsCompleted, SomeOrder.OrderDate
ORDER BY TotalAmount DESC
--580b
SELECT
SomeOrder.Id,
SomeOrder.IsCompleted,
SomeOrder.OrderDate,
SUM (OrderProduct.Quantity) AS TotalQuantity
FROM SomeOrder
JOIN OrderProduct ON SomeOrder.Id = OrderProduct.OrderId
JOIN Product ON OrderProduct.ProductId = Product.Id
WHERE SomeOrder.IsCompleted = 1
GROUP BY SomeOrder.Id, SomeOrder.IsCompleted, SomeOrder.OrderDate
ORDER BY TotalQuantity DESC
--580v
SELECT
Product.Name,
Product.Price
FROM Product
WHERE IsAvailable = 1
--580g
DECLARE @OrderId INT;
SET @OrderId = 3;
SELECT
Product.Name,
Product.Price
FROM SomeOrder
JOIN OrderProduct ON SomeOrder.Id = OrderProduct.OrderId
JOIN Product ON OrderProduct.ProductId = Product.Id
WHERE SomeOrder.Id = @OrderId