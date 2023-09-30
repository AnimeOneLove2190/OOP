using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.Flats
{
    class FlatWithAutoProperties
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Area { get; set; }
        public string FullName { get; set; }
        public Type Type { get; set; }
    }
}
