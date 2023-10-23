using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.DTOCinema
{
    public class SessionCreate
    {
        public DateTime Start { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
    }
}
