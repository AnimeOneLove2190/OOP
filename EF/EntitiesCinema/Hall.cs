using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesCinema
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Row> Rows { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
