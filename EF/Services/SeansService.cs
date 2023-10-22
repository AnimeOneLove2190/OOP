using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;
using EFVaiaa.EntitiesCinema;
using System.Linq;
using EFVaiaa.Interfaces;

namespace EFVaiaa.Services
{
    class SeansService : ISeansService
    {
        readonly HallCRUDService hallCRUDService = new HallCRUDService();
        public void CreateSeans(int hallId, int sessionId, int ticketPrice)
        {
            var allPlaces = hallCRUDService.GetAllPlacesInHall(hallId);
            if (allPlaces == null || allPlaces.Count == 0)
            {
                throw new Exception($"CreateSeans: Hall with id <{hallId}> not found");
            }
            if (ticketPrice <= 0)
            {
                throw new Exception($"CreateSeans: Price cannot be negative");
            }
            for (int i = 0; i < allPlaces.Count; i++)
            {
                using (CinemaEFContext context = new CinemaEFContext())
                {
                    var session = context.Sessions.FirstOrDefault(x => x.Id == sessionId);
                    if (session == null)
                    {
                        throw new Exception($"CreateSeans: Session with id <{sessionId}> not found");
                    }
                    if (session.HallId != hallId)
                    {
                        throw new Exception("CreateSeans: The hall specified in the session and the hall specified in the input parameters do not match");
                    }
                    var ticket = new Ticket
                    {
                        IsSold = false,
                        DateOfSale = null,
                        Price = ticketPrice,
                        PlaceId = allPlaces[i].Id,
                        SessionId = sessionId,
                    };
                    context.Add(ticket);
                    context.SaveChanges();
                }
            }
        }
    }
}
