--579ã
SELECT 
Employee.Id,
Employee.FirstName,
Employee.LastName,
PartOfTimeSheet.Hours AS CountOfHours,
PartOfTimeSheet.DayOfDate
FROM Employee
JOIN PartOfTimeSheet ON Employee.Id = PartOfTimeSheet.EmployeedId