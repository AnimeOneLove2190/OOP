USE [OrderDB]
GO

INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name]
           ,[Price]
           ,[IsAvailable])
     VALUES
           (1
           ,'Passport Cover'
           ,150
           ,1)
GO
INSERT INTO [dbo].[SomeOrder]
           ([Id]
           ,[OrderDate]
           ,[IsCompleted])
     VALUES
           (1
           ,'2022-02-01 03:04:05'
           ,1)
GO
INSERT INTO [dbo].[OrderProduct]
           ([Quantity]
           ,[OrderId]
           ,[ProductId])
     VALUES
           (3
           ,1
           ,1)
GO


