using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;

namespace EFVaiaa.Interfaces
{
    interface IGenreCRUDService
    {
        public void Create(GenreCreate genreCreate);
        public GenreView Get(int id);
        public List<GenreView> GetList();
        public void Update(GenreUpdate genreUpdate);
        public void Delete(int id);
    }
}
