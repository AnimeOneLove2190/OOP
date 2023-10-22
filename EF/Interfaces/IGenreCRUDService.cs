using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;

namespace EFVaiaa.Interfaces
{
    interface IGenreCRUDService
    {
        public void Create();
        public GenreView Get();
        public List<GenreView> GetList();
        public void Update();
        public void Delete();
    }
}
