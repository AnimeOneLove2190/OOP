--579a
SELECT 
Employee.Id,
Employee.FirstName,
Employee.LastName,
Department.Name AS DepartmentName,
Position.Name AS PositionName
FROM Employee
JOIN Department ON Employee.Department = Department.Id
JOIN Position ON Employee.PositionId = Position.Id