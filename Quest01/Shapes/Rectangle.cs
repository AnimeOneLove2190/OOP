using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.Shapes
{
    class Rectangle : Shape
    {
        public Point UpperLeftCorn { get; set; }
        public Point LowerRightCorn { get; set; }
        public double GetLength()
        {
            if (!(UpperLeftCorn.CoordinateY > LowerRightCorn.CoordinateY && UpperLeftCorn.CoordinateX < LowerRightCorn.CoordinateX))
            {
                Console.WriteLine("Координаты левого верхнего и правого нижнего углов указаны неправильно");
                return 0;
            }
            double result = UpperLeftCorn.CoordinateY - LowerRightCorn.CoordinateY;
            return result;
        }
        public double GetWidth()
        {
            if (!(UpperLeftCorn.CoordinateY > LowerRightCorn.CoordinateY && UpperLeftCorn.CoordinateX < LowerRightCorn.CoordinateX))
            {
                Console.WriteLine("Координаты левого верхнего и правого нижнего углов указаны неправильно");
                return 0;
            }
            double result = LowerRightCorn.CoordinateX - UpperLeftCorn.CoordinateX;
            return result;
        }
        public override double GetPerimeter()
        {
            double length = GetLength();
            double width = GetWidth();
            double perimeter = (length * 2) + (width * 2);
            return perimeter;
        }
        public override double GetArea()
        {
            double length = GetLength();
            double width = GetWidth();
            double area = length * width;
            return area;
        }
        public override string ToString()
        {
            return $"Класс: прямоугольник. Длина: {GetLength()}. Ширина: {GetWidth()}. Периметр: {GetPerimeter()}. Площадь: {GetArea()}";
        }
    }
}
