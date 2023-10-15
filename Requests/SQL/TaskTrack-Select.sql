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
SomeUser.Id AS UserId,
SomeUser.Name,
STRING_AGG(Task.Name, '/') AS Tasks
FROM SomeUser
JOIN TaskUser ON SomeUser.Id = TaskUser.SomeUserId
JOIN Task ON TaskUser.TaskId = Task.Id
GROUP BY SomeUser.Id, SomeUser.Name
--582g
SELECT
Role.Id,
Role.Name,
STRING_AGG(Task.Name, '/') AS Tasks
FROM Role
JOIN UserRole ON Role.Id = UserRole.RoleId
JOIN TaskUser ON UserRole.SomeUserId = TaskUser.SomeUserId
JOIN Task ON TaskUser.TaskId = Task.Id
GROUP BY Role.Id, Role.Name
--580d
SELECT
Task.Id AS TaskId,
Task.Name,
Task.IsCompleted,
STRING_AGG(SomeUser.Name, '/') AS Users
FROM Task
JOIN TaskUser ON Task.Id = TaskUser.TaskId
JOIN SomeUser ON TaskUser.SomeUserId = SomeUser.Id
WHERE Task.IsCompleted = 1
GROUP BY Task.Id, Task.Name, Task.IsCompleted
--580e
SELECT
SomeUser.Id AS UserId,
SomeUser.Name,
COUNT(Task.Id) AS Tasks
FROM SomeUser
JOIN TaskUser ON SomeUser.Id = TaskUser.SomeUserId
JOIN Task ON TaskUser.TaskId = Task.Id
GROUP BY SomeUser.Id, SomeUser.Name
--580j
SELECT
SomeUser.Id AS UserId,
SomeUser.Name,
COUNT(Task.Id) AS CompletedTasks
FROM SomeUser
JOIN TaskUser ON SomeUser.Id = TaskUser.SomeUserId
JOIN Task ON TaskUser.TaskId = Task.Id
WHERE Task.IsCompleted = 1
GROUP BY SomeUser.Id, SomeUser.Name