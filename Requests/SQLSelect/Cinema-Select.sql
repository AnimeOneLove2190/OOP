--581a
SELECT
Place.Id AS PlaceId,
Place.Number AS PlaceNumber,
Place.RowId,
Row.Number AS RowNumber,
Row.HallId,
Hall.Name
FROM Place
JOIN Row ON Place.RowId = Row.Id
JOIN Hall ON Row.HallId = Hall.Id
--581b
DECLARE @Genres VARCHAR(255);
SET @Genres = '(Genre.Name)';
SELECT
Movie.Id AS MovieId,
Movie.Name,
Movie.Description,
Movie.Duration,
STRING_AGG(Genre.Name, ',') AS Genres
FROM Movie
JOIN MovieGenre ON MovieGenre.MovieId = Movie.Id
JOIN Genre ON MovieGenre.GenreId = Genre.Id
GROUP BY Movie.Id, Movie.Name, Movie.Description, Movie.Duration
--580v
SELECT
Row.Id AS RowId,
Row.Number,
SUM (Place.Capacity) RowCapacity
FROM Row
JOIN Place ON Row.Id = Place.RowId
GROUP BY Row.Id, Row.Number
SELECT
Hall.Id AS HallId,
SUM (Place.Capacity) HallCapacity
FROM Hall
JOIN Row ON Row.HallId = Hall.Id
JOIN Place ON Row.Id = Place.RowId
GROUP BY Hall.Id
--580g
SELECT
Hall.Id AS HallId,
Hall.Name AS HallName,
SUM (Place.Capacity) HallCapacity
FROM Hall
JOIN Row ON Row.HallId = Hall.Id
JOIN Place ON Row.Id = Place.RowId
GROUP BY Hall.Id, Hall.Name
--580d
SELECT
Movie.Id,
Movie.Name,
COUNT (Ticket.Id) AS PurchasedTickets,
SUM (Ticket.Price) AS TotalAmount
FROM Movie
JOIN Session ON Movie.Id = Session.MovieId
JOIN Ticket ON Session.Id = Ticket.SessionId
WHERE Ticket.IsSold = 1
GROUP BY Movie.Id, Movie.Name
--580e
SELECT
Genre.Id,
Genre.Name,
Genre.Description
FROM Genre
WHERE Genre.Description != '' AND Genre.Description IS NOT NULL