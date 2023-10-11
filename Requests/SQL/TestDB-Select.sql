--580�
SELECT
Id,
Name,
IsRight,
QuestionId
FROM PossibleAnswer
WHERE IsRight = 1
--580�
SELECT
Id,
Name,
Description,
TestId
FROM Question
WHERE Description != ''
--580�
SELECT
FullName
FROM SomeUser
ORDER BY FullName
--580�
SELECT 
Question.Id AS QuestId,
Question.Name AS QuestName,
Test.Id AS TestId,
Test.Name AS TestName,
Course.Id AS CourseId,
Course.Name AS CourseName
FROM Question
JOIN Test ON Question.TestId = Test.Id
JOIN Course ON Test.CourseId = Course.Id