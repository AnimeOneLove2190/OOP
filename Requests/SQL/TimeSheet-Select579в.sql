--579â
SELECT
Department.Id,
Department.Name,
COUNT(Employee.Id) AS TotalEmployees
FROM Department
JOIN Employee ON Department.Id = Employee.Department
GROUP BY Department.Id, Department.Name