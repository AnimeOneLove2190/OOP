using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;
using EFVaiaa.EntitiesCinema;
using System.Linq;
using EFVaiaa.Interfaces;

namespace EFVaiaa.Services
{
    public class TicketCRUDService : ITicketCDRUDService
    {
        public void CreateTicket(TicketCreate ticketCreate)
        {
            if (ticketCreate == null)
            {
                throw new Exception("CreateTicket: One or more input parameters contain null");
            }
            if (ticketCreate.Price <= 0)
            {
                throw new Exception("CreateTicket: Price field must not be empty or contain a negative value");
            }
            if (ticketCreate.PlaceId <= 0)
            {
                throw new Exception("CreateTicket: PlaceId field must not be empty or contain a negative value");
            }
            if (ticketCreate.SessionId <= 0)
            {
                throw new Exception("CreateTicket: SessionId field must not be empty or contain a negative value");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var ticket = new Ticket
                {
                    IsSold = ticketCreate.IsSold,
                    DateOfSale = ticketCreate.DateOfSale,
                    Price = ticketCreate.Price,
                    PlaceId = ticketCreate.PlaceId,
                    SessionId = ticketCreate.SessionId,
                };
                context.Add(ticket);
                context.SaveChanges();
            }
        }
        public TicketView GetTicket(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var ticket = context.Tickets.FirstOrDefault(x => x.Id == id);
                if (ticket == null)
                {
                    throw new Exception($"GetTicket: Ticket with id <{id}> not found");
                }
                return new TicketView
                {
                    Id = ticket.Id,
                    IsSold = ticket.IsSold,
                    DateOfSale = ticket.DateOfSale,
                    Price = ticket.Price,
                    PlaceId = ticket.PlaceId,
                    SessionId = ticket.SessionId,
                };
            }
        }
        public List<TicketView> GetListTickets()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var tickets = context.Tickets.Select(x => new TicketView
                {
                    Id = x.Id,
                    IsSold = x.IsSold,
                    DateOfSale = x.DateOfSale,
                    Price = x.Price,
                    PlaceId = x.PlaceId,
                    SessionId = x.SessionId,
                }
                ).ToList();
                return tickets;
            }
        }
        public void UpdateTicket(TicketUpdate ticketUpdate)
        {
            if (ticketUpdate == null)
            {
                throw new Exception("UpdateTicket: One or more input parameters contain null");
            }
            if (ticketUpdate.Price <= 0)
            {
                throw new Exception("UpdateTicket: Price field must not be empty or contain a negative value");
            }
            if (ticketUpdate.PlaceId <= 0)
            {
                throw new Exception("UpdateTicket: PlaceId field must not be empty or contain a negative value");
            }
            if (ticketUpdate.SessionId <= 0)
            {
                throw new Exception("UpdateTicket: SessionId field must not be empty or contain a negative value");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var ticket = context.Tickets.FirstOrDefault(x => x.Id == ticketUpdate.Id);
                if (ticket == null)
                {
                    throw new Exception($"UpdateTicket: Ticket with id <{ticketUpdate.Id}> not found");
                }
                ticket.IsSold = ticketUpdate.IsSold;
                ticket.DateOfSale = ticketUpdate.DateOfSale;
                ticket.Price = ticketUpdate.Price;
                ticket.PlaceId = ticketUpdate.PlaceId;
                ticket.SessionId = ticketUpdate.SessionId;
                context.SaveChanges();
            }
        }
        public void DeleteTicket(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var ticket = context.Tickets.FirstOrDefault(x => x.Id == id);
                if (ticket == null)
                {
                    throw new Exception($"DeleteTicket: Ticket with id <{id}> not found");
                }
                context.Remove(ticket);
                context.SaveChanges();
            }
        }
    }
}
