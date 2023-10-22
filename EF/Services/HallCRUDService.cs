using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;
using EFVaiaa.EntitiesCinema;
using System.Linq;

namespace EFVaiaa.Services
{
    public class HallCRUDService
    { 
        public void CreateHall(HallCreate hallCreate)
        {
            if (string.IsNullOrEmpty(hallCreate.Name))
            {
                throw new Exception("CreateHall: Hall Name field is required");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var hall = new Hall
                {
                    Name = hallCreate.Name,
                };
                context.Add(hall);
                context.SaveChanges();
            }
        }
        public HallView GetHall(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var hall = context.Halls.FirstOrDefault(x => x.Id == id);
                if (hall == null)
                {
                    throw new Exception($"GetHall: Hall with id <{id}> not found");
                }
                return new HallView
                {
                    Id = hall.Id,
                    Name = hall.Name,
                };
            }
        }
        public List<HallView> GetListHalls()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var halls = context.Halls.Select(x => new HallView
                {
                    Id = x.Id,
                    Name = x.Name,
                }
                ).ToList();
                return halls;
            }
        }
        public void UpdateHall(HallUpdate hallUpdate)
        {
            if (hallUpdate == null)
            {
                throw new Exception("UpdateHall: One or more parameters contain null");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var hall = context.Halls.FirstOrDefault(x => x.Id == hallUpdate.Id);
                if (hall == null)
                {
                    throw new Exception($"UpdateHall: Hall with id <{hallUpdate.Id}> not found");
                }
                hall.Name = hallUpdate.Name;
                context.SaveChanges();
            }
        }
        public void DeleteHall(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var hall = context.Halls.FirstOrDefault(x => x.Id == id);
                if (hall == null)
                {
                    throw new Exception($"DeleteHall: Hall with id <{id}> not found");
                }
                context.Remove(hall);
                context.SaveChanges();
            }
        }
        public void CreateRow(RowCreate rowCreate)
        {
            if (rowCreate == null || rowCreate.HallId <= 0)
            {
                throw new Exception("CreateRow: Row HallId field must not be empty or contain a negative value");
            }
            if (rowCreate.Number <= 0)
            {
                throw new Exception("CreateRow: Row Number field must not be empty or contain a negative value");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var row = new Row
                {
                    Number = rowCreate.Number,
                    HallId = rowCreate.HallId,
                };
                context.Add(row);
                context.SaveChanges();
            }
        }
        public RowView GetRow(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var row = context.Rows.FirstOrDefault(x => x.Id == id);
                if (row == null)
                {
                    throw new Exception($"GetRow: Row with id <{id}> not found");
                }
                return new RowView
                {
                    Id = row.Id,
                    Number = row.Number,
                    HallId = row.HallId,
                };
            }
        }
        public List<RowView> GetListRows()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var rows = context.Rows.Select(x => new RowView
                {
                    Id = x.Id,
                    Number = x.Number,
                    HallId = x.HallId,
                }
                ).ToList();
                return rows;
            }
        }
        public void UpdateRow(RowUpdate rowUpdate)
        {
            if (rowUpdate == null)
            {
                throw new Exception("UpdateRow: One or more parameters contain null");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var row = context.Rows.FirstOrDefault(x => x.Id == rowUpdate.Id);
                if (row == null)
                {
                    throw new Exception($"UpdateRow: Row with id <{rowUpdate.Id}> not found");
                }
                row.Number = rowUpdate.Number;
                row.HallId = rowUpdate.HallId;
                context.SaveChanges();
            }
        }
        public void DeleteRow(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var row = context.Rows.FirstOrDefault(x => x.Id == id);
                if (row == null)
                {
                    throw new Exception($"DeleteRow: Row with id <{id}> not found");
                }
                context.Remove(row);
                context.SaveChanges();
            }
        }
        public void CreatePlace(PlaceCreate placeCreate)
        {
            if (placeCreate == null || placeCreate.RowId <= 0)
            {
                throw new Exception("CreatePlace: Place RowId field must not be empty or contain a negative value");
            }
            if (placeCreate.Number <= 0)
            {
                throw new Exception("CreateRow: Place Number field must not be empty or contain a negative value");
            }
            if (placeCreate.Capacity <= 0)
            {
                throw new Exception("CreateRow: Place Capacity field must not be empty or contain a negative value");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var place = new Place
                {
                    Capacity = placeCreate.Capacity,
                    Number = placeCreate.Number,
                    RowId = placeCreate.RowId,
                };
                context.Add(place);
                context.SaveChanges();
            }
        }
        public PlaceView GetPlace(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var place = context.Places.FirstOrDefault(x => x.Id == id);
                if (place == null)
                {
                    throw new Exception($"GetPlace: Place with id <{id}> not found");
                }
                return new PlaceView
                {
                    Id = place.Id,
                    Capacity = place.Capacity,
                    Number = place.Number,
                    RowId = place.RowId,
                };
            }
        }
        public List<PlaceView> GetListPlaces()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var places = context.Places.Select(x => new PlaceView
                {
                    Id = x.Id,
                    Capacity = x.Capacity,
                    Number = x.Number,
                    RowId = x.RowId,
                }
                ).ToList();
                return places;
            }
        }
        public void UpdatePlace(PlaceUpdate placeUpdate)
        {
            if (placeUpdate == null)
            {
                throw new Exception("UpdatePlace: One or more parameters contain null");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var place = context.Places.FirstOrDefault(x => x.Id == placeUpdate.Id);
                if (place == null)
                {
                    throw new Exception($"UpdatePlace: Place with id <{placeUpdate.Id}> not found");
                }
                place.Capacity = placeUpdate.Capacity;
                place.Number = placeUpdate.Number;
                place.RowId = placeUpdate.RowId;
                context.SaveChanges();
            }
        }
        public void DeletePlace(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var place = context.Places.FirstOrDefault(x => x.Id == id);
                if (place == null)
                {
                    throw new Exception($"DeletePlace: Place with id <{id}> not found");
                }
                context.Remove(place);
                context.SaveChanges();
            }
        }
        public List<PlaceView> GetAllPlacesInHall(int hallId)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var hall = context.Halls.FirstOrDefault(x => x.Id == hallId);
                if (hall == null)
                {
                    throw new Exception($"GetAllPlacesInHall: Hall with id <{hallId}> not found");
                }
                var rows = context.Rows.Where(x => x.HallId == hallId).Select(x => new RowView
                {
                    Id = x.Id,
                    Number = x.Number,
                    HallId = x.HallId,
                }).ToList();
                List<PlaceView> allPlaces = new List<PlaceView>();
                for (int i = 0; i < rows.Count; i++)
                {
                    var places = context.Places.Where(x => x.RowId == rows[i].Id).Select(x => new PlaceView
                    {
                        Id = x.Id,
                        Capacity = x.Capacity,
                        Number = x.Number,
                        RowId = x.RowId,
                    }).ToList();
                    for (int j = 0; j < places.Count; j++)
                    {
                        allPlaces.Add(places[j]);
                    }
                }
                return allPlaces;
            }
        }
    }
}
