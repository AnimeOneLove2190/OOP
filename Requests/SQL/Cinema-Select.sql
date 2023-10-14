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