USE [TimeSheet]
GO

INSERT INTO [dbo].[Department]
           ([Id]
           ,[Name])
     VALUES
           (1
           ,'Post')
GO
INSERT INTO [dbo].[Position]
           ([Id]
           ,[Name])
     VALUES
           (1
           ,'AutoRecordingDoll')
GO
INSERT INTO [dbo].[Employee]
           ([Id]
           ,[FirstName]
           ,[LastName]
           ,[PositionId]
           ,[DepartmentId])
     VALUES
           (1
           ,'Violet'
           ,'Evergarden'
           ,1
           ,1)
GO
INSERT INTO [dbo].[PartOfTimeSheet]
           ([Id]
           ,[DayOfDate]
           ,[Hours]
           ,[EmployeedId])
     VALUES
           (1
           ,2018-05-03
           ,7392
           ,1)
GO


