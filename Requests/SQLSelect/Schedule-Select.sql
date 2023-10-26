--584a
SELECT
Lesson.DateTimeLesson,
Lesson.ClassId,
Lesson.DisciplineId,
Lesson.TeacherId
FROM SomeGroup
JOIN GroupLesson ON SomeGroup.Id = GroupLesson.GroupId
JOIN Lesson ON GroupLesson.LessonId = Lesson.Id
WHERE Lesson.DateTimeLesson = '2011-17-08 11:00:00' AND SomeGroup.Id = 1
--584b
SELECT
Teacher.FullName,
STRING_AGG (Discipline.Name, '/') AS Disciplines
FROM Teacher
JOIN Discipline ON Teacher.Id = Discipline.TeacherId
WHERE Teacher.FullName = 'Handji Zoe'
GROUP BY Teacher.FullName
--584v
SELECT
Class.Id,
Class.Name,
Class.Number
FROM Discipline
JOIN Lesson ON Discipline.Id = Lesson.DisciplineId
JOIN Class ON Lesson.ClassId = Class.Id
WHERE Discipline.Id = 1
--584g
SELECT
SomeGroup.Name,
SomeGroup.NumberOfStudents
FROM Student
JOIN SomeGroup ON Student.GroupId = SomeGroup.Id
WHERE Student.Id = 1
--584d
SELECT
Lesson.DateTimeLesson,
Lesson.ClassId,
Lesson.DisciplineId,
Lesson.TeacherId
FROM Teacher
JOIN Lesson ON Teacher.Id = Lesson.TeacherId
WHERE Lesson.DateTimeLesson = '2011-17-08 11:00:00' AND Teacher.Id = 1
--584e duplicate