using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.DTOCinema
{
    public class TicketUpdate
    {
        public int Id { get; set; }
        public bool IsSold { get; set; }
        public Nullable<DateTime> DateOfSale { get; set; }
        public int Price { get; set; }
        public int PlaceId { get; set; }
        public int SessionId { get; set; }
    }
}
