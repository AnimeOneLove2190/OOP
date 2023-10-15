--579ä
SELECT
Department.Id,
Department.Name,
SUM(PartOfTimeSheet.Hours) AS CountOfHours
FROM Department
JOIN Employee ON Department.Id = Employee.Department
JOIN PartOfTimeSheet ON Employee.Id = EmployeedId
GROUP BY Department.Id, Department.Name