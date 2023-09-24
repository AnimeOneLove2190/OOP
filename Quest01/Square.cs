using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class Square : Shape
    {
        public Point UpperLeftCorn { get; set; }
        public Point LowerRightCorn { get; set; }
        public double GetRibLength()
        {
            if (!(UpperLeftCorn.CoordinateY > LowerRightCorn.CoordinateY && UpperLeftCorn.CoordinateX < LowerRightCorn.CoordinateX))
            {
                Console.WriteLine("Координаты левого верхнего и правого нижнего углов указаны неправильно");
                return 0;
            }
            double length = UpperLeftCorn.CoordinateY - LowerRightCorn.CoordinateY;
            double width = LowerRightCorn.CoordinateX - UpperLeftCorn.CoordinateX;
            if (!(length == width))
            {
                Console.WriteLine("Ребра не равны, это не квадрат");
                return 0;
            }
            return length;
        }
        public override double GetPerimeter()
        {
            double ribLength = GetRibLength();
            double perimeter = ribLength * 4;
            return perimeter;
        }
        public override double GetArea()
        {
            double ribLenght = GetRibLength();
            double area = ribLenght * ribLenght;
            return area;
        }
        public override string ToString()
        {
            return $"Класс: квадрат. Длина ребра: {GetRibLength()}. Периметр: {GetPerimeter()}. Площадь: {GetArea()}";
        }
    }
}
