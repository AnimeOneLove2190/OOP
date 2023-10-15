--579á
SELECT
Position.Id,
Position.Name,
COUNT(Employee.Id) AS TotalEmployees
FROM Position
JOIN Employee ON Position.Id = Employee.PositionId
GROUP BY Position.Id, Position.Name