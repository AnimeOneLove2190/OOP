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
           ,[Number])
     VALUES
           (1
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
INSERT INTO [dbo].[Ticket]
           ([Id]
           ,[IsSold]
           ,[PlaceId])
     VALUES
           (1
           ,1
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
           ,'Violet is trying to learn to live without her lover. The second full-length anime based on the series of the same name'
           ,139)
GO
INSERT INTO [dbo].[Session]
           ([Id]
           ,[Start]
           ,[MovieId]
           ,[HallId]
           ,[DateOfSale])
     VALUES
           (1
           ,2020-04-15-00-00-00
           ,1
           ,1
           ,2020-04-14-00-00-00)
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

