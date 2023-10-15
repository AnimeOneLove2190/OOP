--579a
SELECT 
Employee.Id,
Employee.FirstName,
Employee.LastName,
Department.Name AS DepartmentName,
Position.Name AS PositionName
FROM Employee
JOIN Department ON Employee.DepartmentId = Department.Id
JOIN Position ON Employee.PositionId = Position.Id
--579á
SELECT
Position.Id,
Position.Name,
COUNT(Employee.Id) AS TotalEmployees
FROM Position
JOIN Employee ON Position.Id = Employee.PositionId
GROUP BY Position.Id, Position.Name
--579â
SELECT
Department.Id,
Department.Name,
COUNT(Employee.Id) AS TotalEmployees
FROM Department
JOIN Employee ON Department.Id = Employee.DepartmentId
GROUP BY Department.Id, Department.Name
--579g
SELECT 
Employee.Id,
Employee.FirstName,
Employee.LastName,
SUM (PartOfTimeSheet.Hours) AS Hours
FROM Employee
JOIN PartOfTimeSheet ON Employee.Id = PartOfTimeSheet.EmployeedId
GROUP BY Employee.Id, Employee.FirstName, Employee.LastName
--579ä
SELECT
Department.Id,
Department.Name,
SUM(PartOfTimeSheet.Hours) AS CountOfHours
FROM Department
JOIN Employee ON Department.Id = Employee.DepartmentId
JOIN PartOfTimeSheet ON Employee.Id = EmployeedId
GROUP BY Department.Id, Department.Name