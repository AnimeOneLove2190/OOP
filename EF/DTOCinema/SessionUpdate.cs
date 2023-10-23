using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.DTOCinema
{
    class SessionUpdate
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
    }
}
