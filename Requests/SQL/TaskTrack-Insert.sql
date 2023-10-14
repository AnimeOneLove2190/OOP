USE [TaskTrack]
GO

INSERT INTO [dbo].[SomeUser]
           ([Id]
           ,[Name]
           ,[Email]
           ,[RegistrationDate])
     VALUES
           (1
           ,'Violet'
           ,'violet.evergarden@gmail.ru'
           ,'2018-03-05')
GO
INSERT INTO [dbo].[Task]
           ([Id]
           ,[Name]
           ,[IsCompleted])
     VALUES
           (1
           ,'Find Gilbert'
           ,1)
GO
INSERT INTO [dbo].[Role]
           ([Id]
           ,[Name])
     VALUES
           (1
           ,'Auto Recording Doll')
GO
INSERT INTO [dbo].[TaskUser]
           ([SomeUserId]
           ,[TaskId])
     VALUES
           (1
           ,1)
GO
INSERT INTO [dbo].[UserRole]
           ([SomeUserId]
           ,[RoleId])
     VALUES
           (1
           ,1)
GO




