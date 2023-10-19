﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesCinema
{
    public class Row
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public ICollection<Place> Places { get; set; }
    }
}
