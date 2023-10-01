using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.Computers
{
    class Computer
    {
        public string Model { get; set; }
        public string VideoCard { get; set; }
        public int RAM { get; set; }
        public string CPU { get; set; }
        public virtual string GetInfo()
        {
            return $"Модель: {Model}. Видеокарта: {VideoCard}. Оперативная память: {RAM} гб. Процессор: {CPU}";
        }
    }
}
