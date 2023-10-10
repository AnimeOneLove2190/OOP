USE [Schedule]
GO

INSERT INTO [dbo].[Discipline]
           ([Id]
           ,[Name])
     VALUES
           (1
           ,'The use of thunder spears in real combat against titans and people')
GO
INSERT INTO [dbo].[Teacher]
           ([Id]
           ,[FullName]
           ,[DisciplineId])
     VALUES
           (1
           ,'Handji Zoe'
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
           ([DateTimeLesson]
           ,[DisciplineId]
           ,[TeacherId]
           ,[GroupId]
           ,[ClassId])
     VALUES
           (1011-08-17-11-00-00
           ,1
           ,1
           ,1
           ,1)
GO


