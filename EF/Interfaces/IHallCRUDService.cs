using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;

namespace EFVaiaa.Interfaces
{
    interface IHallCRUDService
    {
        public void CreateHall(HallCreate hallCreate);
        public HallView GetHall(int id);
        public List<HallView> GetListHalls();
        public void UpdateHall(HallUpdate hallUpdate);
        public void DeleteHall(int id);
        public void CreateRow(RowCreate rowCreate);
        public RowView GetRow(int id);
        public List<RowView> GetListRows();
        public void UpdateRow(RowUpdate rowUpdate);
        public void DeleteRow(int id);
        public void CreatePlace(PlaceCreate placeCreate);
        public PlaceView GetPlace(int id);
        public List<PlaceView> GetListPlaces();
        public void UpdatePlace(PlaceUpdate placeUpdate);
        public void DeletePlace(int id);
        public List<PlaceView> GetAllPlacesInHall(int hallId);
    }
}
