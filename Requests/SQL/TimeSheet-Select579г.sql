--579g
SELECT 
Employee.Id,
Employee.FirstName,
Employee.LastName,
SUM (PartOfTimeSheet.Hours) AS Hours
FROM Employee
JOIN PartOfTimeSheet ON Employee.Id = PartOfTimeSheet.EmployeedId
GROUP BY Employee.Id, Employee.FirstName, Employee.LastName