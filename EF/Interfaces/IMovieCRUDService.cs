using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;

namespace EFVaiaa.Interfaces
{
    interface IMovieCRUDService
    {
        public void CreateMovie(MovieCreate movieCreate);
        public MovieView GetMovie(int id);
        public List<MovieView> GetListMovies();
        public void UpdateMovie(MovieUpdate movieUpdate);
        public void DeleteMovie(int id);
    }
}
