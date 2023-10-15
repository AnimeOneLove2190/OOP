--580a
SELECT
Id,
Name,
IsRight,
QuestionId
FROM PossibleAnswer
WHERE IsRight = 1
--580b
SELECT
Id,
Name,
Description,
TestId
FROM Question
WHERE Description != '' AND Description IS NOT NULL
--580v
SELECT
FullName
FROM SomeUser
ORDER BY FullName
--580g
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
--580d
SELECT
SomeUserId,
RecordAnswer.PossibleAnswerId,
PossibleAnswer.Name AS PossibleAnswerName,
PossibleAnswer.IsRight,
PossibleAnswer.QuestionId,
Question.Name AS QuestionName,
Question.TestId,
Test.Name AS TestName
FROM RecordAnswer
JOIN PossibleAnswer ON PossibleAnswerId = PossibleAnswer.Id
JOIN Question ON PossibleAnswer.QuestionId = Question.Id
JOIN Test ON Question.TestId = Test.Id
--580e
SELECT
SomeUserId,
RecordAnswer.PossibleAnswerId,
PossibleAnswer.Name AS PossibleAnswerName,
Question.Description,
PossibleAnswer.QuestionId,
Question.Name AS QuestionName,
Question.TestId,
Test.Name AS TestName
FROM RecordAnswer
JOIN PossibleAnswer ON PossibleAnswerId = PossibleAnswer.Id
JOIN Question ON PossibleAnswer.QuestionId = Question.Id
JOIN Test ON Question.TestId = Test.Id
WHERE PossibleAnswer.IsRight = 1
--580j
SELECT
Question.Id AS QuestionId,
COUNT(RecordAnswer.SomeUserId) AS RightAnswers
FROM Question
JOIN PossibleAnswer ON Question.Id = PossibleAnswer.QuestionId
JOIN RecordAnswer ON PossibleAnswer.Id = RecordAnswer.PossibleAnswerId
WHERE PossibleAnswer.IsRight = 1
GROUP BY Question.Id
SELECT
Test.Id AS TestId,
COUNT(RecordAnswer.SomeUserId) AS RightAnswers
FROM Test
JOIN Question ON Test.Id = Question.TestId
JOIN PossibleAnswer ON Question.Id = PossibleAnswer.QuestionId
JOIN RecordAnswer ON PossibleAnswer.Id = RecordAnswer.PossibleAnswerId
WHERE PossibleAnswer.IsRight = 1
GROUP BY Test.Id
SELECT
Course.Id AS CourseId,
COUNT(RecordAnswer.SomeUserId) AS RightAnswers
FROM Course
JOIN Test ON Course.Id = Test.CourseId
JOIN Question ON Test.Id = Question.TestId
JOIN PossibleAnswer ON Question.Id = PossibleAnswer.QuestionId
JOIN RecordAnswer ON PossibleAnswer.Id = RecordAnswer.PossibleAnswerId
WHERE PossibleAnswer.IsRight = 1
GROUP BY Course.Id
--580z
SELECT
Question.Id AS QuestionId,
Question.Name AS QuestionName,
COUNT(RecordAnswer.SomeUserId) AS RigthtAnswers
FROM Question
JOIN PossibleAnswer ON PossibleAnswer.QuestionId = Question.Id
JOIN RecordAnswer ON RecordAnswer.PossibleAnswerId = PossibleAnswer.Id
WHERE PossibleAnswer.IsRight = 1
GROUP BY Question.Id, Question.Name