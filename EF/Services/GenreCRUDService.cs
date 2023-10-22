using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.Interfaces;
using EFVaiaa.DTOCinema;
using EFVaiaa.EntitiesCinema;
using System.Linq;

namespace EFVaiaa.Services
{
    public class GenreCRUDService : IGenreCRUDService

    {
        public void Create(GenreCreate genreCreate)
        {
            if (string.IsNullOrEmpty(genreCreate.Name))
            {
                throw new Exception("Create: Genre Name field is required");
            }
            using(CinemaEFContext context = new CinemaEFContext())
            {
                var genre = new Genre
                {
                    Name = genreCreate.Name,
                    Description = genreCreate.Description
                };
                context.Add(genre);
                context.SaveChanges();
            }
        }
        public GenreView Get(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var genre = context.Genres.FirstOrDefault(x => x.Id == id);
                if (genre == null)
                {
                    throw new Exception($"Get: Genre with id <{id}> not found");
                }
                return new GenreView
                {
                    Id = genre.Id,
                    Name = genre.Name,
                    Description = genre.Description
                };
            }
        }
        public List<GenreView> GetList()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var genres = context.Genres.Select(x => new GenreView
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }
                ).ToList();
                return genres;
            }
        }
        public void Update(GenreUpdate genreUpdate)
        {
            if (genreUpdate == null)
            {
                throw new Exception("Genre Update: One or more parameters contain null");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var genre = context.Genres.FirstOrDefault(x => x.Id == genreUpdate.Id);
                if (genre == null)
                {
                    throw new Exception($"Update: Genre with id <{genreUpdate.Id}> not found");
                }
                genre.Name = genreUpdate.Name;
                genre.Description = genreUpdate.Description;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var genre = context.Genres.FirstOrDefault(x => x.Id == id);
                if (genre == null)
                {
                    throw new Exception($"Get: Genre with id <{id}> not found");
                }
                context.Remove(genre);
                context.SaveChanges();
            }
        }
    }
}
