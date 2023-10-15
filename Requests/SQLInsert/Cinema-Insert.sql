USE [Cinema]
GO

INSERT INTO [dbo].[Hall]
           ([Id]
           ,[Name])
     VALUES
           (1
           ,'Hall One')
GO
INSERT INTO [dbo].[Row]
           ([Id]
           ,[Number]
		   ,[HallId])
     VALUES
           (1
           ,1
		   ,1)
GO
INSERT INTO [dbo].[Place]
           ([Id]
           ,[Capacity]
           ,[RowId])
     VALUES
           (1
           ,100
           ,1)
GO
INSERT INTO [dbo].[Movie]
           ([Id]
           ,[Name]
           ,[Description]
           ,[Duration])
     VALUES
           (1
           ,'Violet Evergarden. Movie'
           ,'Her job is to write letters. Her name is Violet Evergarden. Several years have passed since the end of the war, which inflicted deep wounds on many. The world is gradually regaining peace, people are returning to their normal lives. Violet is trying to learn to live without the person most important to her, but one day she receives a letter, and the flame of hope flares up in her chest again.'
           ,139)
GO
INSERT INTO [dbo].[Session]
           ([Id]
           ,[Start]
           ,[MovieId]
           ,[HallId])
     VALUES
           (1
           ,'2020-04-15 10:00:00'
           ,1
           ,1)
GO
INSERT INTO [dbo].[Genre]
           ([Id]
           ,[Name]
           ,[Description])
     VALUES
           (1
           ,'Romance'
           ,'Emotionally elevated attitude created by various ideas, feelings, emotions, and living conditions')
GO
INSERT INTO [dbo].[MovieGenre]
           ([MovieId]
           ,[GenreId])
     VALUES
           (1
           ,1)
GO
INSERT INTO [dbo].[Ticket]
           ([Id]
           ,[IsSold]
           ,[DateOfSale]
           ,[Price]
           ,[PlaceId]
           ,[SessionId])
     VALUES
           (1
           ,1
           ,'2020-14-04 21:00:00'
           ,450
           ,1
           ,1)
GO

