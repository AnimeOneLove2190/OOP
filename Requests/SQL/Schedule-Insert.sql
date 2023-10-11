USE [Schedule]
GO

INSERT INTO [dbo].[Teacher]
           ([Id]
           ,[FullName])
     VALUES
           (1
           ,'Handji Zoe')
GO
INSERT INTO [dbo].[Discipline]
           ([Id]
           ,[Name]
		   ,[TeacherId])
     VALUES
           (1
           ,'The use of thunder spears in real combat against titans and people'
		   ,1)
GO
INSERT INTO [dbo].[Class]
           ([Id]
           ,[Name]
           ,[Number])
     VALUES
           (1
           ,'Class One'
           ,1)
GO
INSERT INTO [dbo].[SomeGroup]
           ([Id]
           ,[Name]
           ,[NumberOfStudents])
     VALUES
           (1
           ,'Elite unit of the reconnaissance corps'
           ,10)
GO
INSERT INTO [dbo].[Student]
           ([Id]
           ,[FullName]
           ,[GroupId])
     VALUES
           (1
           ,'Eren Yeager'
           ,1)
GO
INSERT INTO [dbo].[Lesson]
           ([Id]
		   ,[DateTimeLesson]
           ,[DisciplineId]
           ,[TeacherId]
           ,[ClassId])
     VALUES
           (1
		   ,'2011-17-08 11:00:00'
           ,1
           ,1
           ,1)
GO
INSERT INTO [dbo].[GroupLesson]
           ([GroupId]
           ,[LessonId])
     VALUES
           (1
           ,1)
GO

