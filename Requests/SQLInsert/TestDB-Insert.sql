USE [TestDB]
GO

INSERT INTO [dbo].[Course]
           ([Id]
           ,[Name]
           ,[Description])
     VALUES
           (1
           ,'Auto recording doll'
           ,'Self-recording doll training course')
GO
INSERT INTO [dbo].[Test]
           ([Id]
           ,[Name]
           ,[Description]
           ,[CourseId])
     VALUES
           (1
           ,'Professional suitability'
           ,'Testing the professional skills of the auto-recording doll'
           ,1)
GO
INSERT INTO [dbo].[SomeUser]
           ([Id]
           ,[Login]
           ,[RegistrationDate]
           ,[FullName])
     VALUES
           (1
           ,'Former Special Forces Officer of the Royal Leidenschaftlig Army'
           ,'2018-04-09'
           ,'Voilet Evergarden')
GO
INSERT INTO [dbo].[Question]
           ([Id]
           ,[Name]
           ,[Description]
           ,[TestId])
     VALUES
           (1
           ,'Letter'
           ,'Write a letter on behalf of your sister to your brother'
           ,1)
GO
INSERT INTO [dbo].[PossibleAnswer]
           ([Id]
           ,[Name]
           ,[IsRight]
           ,[QuestionId])
     VALUES
           (2
           ,'Any meaningful existing text'
           ,0
           ,1)
GO
INSERT INTO [dbo].[RecordAnswer]
           ([SomeUserId]
           ,[PossibleAnswerId])
     VALUES
           (1
           ,1)
GO


