using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.Transports
{
    class Boat : Transport 
    {
        public int Displacement { get; set; }
        public override string GetInfo()
        {
            return $"Мой владелец: {Owner}. Моя скорость: {Speed} км/ч. Моё водоизмещение: {Displacement} тонны";
        }
    }
}
