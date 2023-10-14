--582a
SELECT
SomeUser.Id,
SomeUser.Name,
SomeUser.RegistrationDate
FROM SomeUser
ORDER BY (SomeUser.RegistrationDate)
--582b
SELECT
Task.Id AS TaskId,
Task.Name,
STRING_AGG(SomeUser.Name, '/') AS Users
FROM Task
JOIN TaskUser ON Task.Id = TaskUser.TaskId
JOIN SomeUser ON TaskUser.SomeUserId = SomeUser.Id
GROUP BY Task.Id, Task.Name
--582v
SELECT
SomeUser.Id AS TaskId,
SomeUser.Name,
STRING_AGG(Task.Name, '/') AS Tascks
FROM SomeUser
JOIN TaskUser ON SomeUser.Id = TaskUser.SomeUserId
JOIN Task ON TaskUser.TaskId = Task.Id
GROUP BY SomeUser.Id, SomeUser.Name