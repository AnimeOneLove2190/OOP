using System;

namespace Quest01
{
    class Program
    {
        static void Main(string[] args)
        {
            FlatWithAutoProperties FlatAutoProp = new FlatWithAutoProperties();
            FlatAutoProp.FullName = "Зубенко Михаил Петрович";
            FlatAutoProp.Id = 0;
            FlatAutoProp.Type = Type.fiveRooms;
        }
    }
}
