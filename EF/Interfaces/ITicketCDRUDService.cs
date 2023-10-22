using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;

namespace EFVaiaa.Interfaces
{
    interface ITicketCDRUDService
    {
        public void CreateTicket(TicketCreate ticketCreate);
        public TicketView GetTicket(int id);
        public List<TicketView> GetListTickets();
        public void UpdateTicket(TicketUpdate ticketUpdate);
        public void DeleteTicket(int id);
    }
}
