using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;
using EFVaiaa.EntitiesCinema;
using System.Linq;

namespace EFVaiaa.Services
{
    public class MovieCRUDService
    {
        public void CreateMovie(MovieCreate movieCreate)
        {
            if (movieCreate == null)
            {
                throw new Exception("CreateMovie: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(movieCreate.Name))
            {
                throw new Exception("CreateMovie: Movie Name field is required");
            }
            if (movieCreate.Duration <= 0)
            {
                throw new Exception("CreateMovie: Movie Duration field must not be empty or contain a negative value");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var movie = new Movie
                {
                    Name = movieCreate.Name,
                    Description = movieCreate.Description,
                    Duration = movieCreate.Duration,
                };
                context.Add(movie);
                context.SaveChanges();
            }
        }
        public MovieView GetMovie(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var movie = context.Movies.FirstOrDefault(x => x.Id == id);
                if (movie == null)
                {
                    throw new Exception($"GetMovie: Movie with id <{id}> not found");
                }
                return new MovieView
                {
                    Id = movie.Id,
                    Name = movie.Name,
                    Description = movie.Description,
                    Duration = movie.Duration
                };
            }
        }
        public List<MovieView> GetListMovies()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var movies = context.Movies.Select(x => new MovieView
                {
                    Id = x.Id,
                    Name = x.Name,
                }
                ).ToList();
                return movies;
            }
        }
        public void UpdateMovie(MovieUpdate movieUpdate)
        {
            if (movieUpdate == null)
            {
                throw new Exception("UpdateMovie: One or more input parameters contain null");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var movie = context.Movies.FirstOrDefault(x => x.Id == movieUpdate.Id);
                if (movie == null)
                {
                    throw new Exception($"UpdateMovie: Movie with id <{movieUpdate.Id}> not found");
                }
                movie.Name = movieUpdate.Name;
                context.SaveChanges();
            }
        }
        public void DeleteMovie(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var movie = context.Movies.FirstOrDefault(x => x.Id == id);
                if (movie == null)
                {
                    throw new Exception($"DeleteMovie: Movie with id <{id}> not found");
                }
                context.Remove(movie);
                context.SaveChanges();
            }
        }
    }
}
