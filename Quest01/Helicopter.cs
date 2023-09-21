using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class Helicopter : Transport
    {
        public int Carrying { get; set; }
        public override string GetInfo()
        {
            return $"Мой владелец: {Owner}. Моя скорость: {Speed} км/ч. Моя грузоподъёмность: {Carrying} кг";
        }
    }
}
