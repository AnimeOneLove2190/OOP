using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public Person()
        {
        }
        public Person(string name, int age, int height)
        {
            while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Имя персонажа не может быть пустым");
                name = Console.ReadLine();
            }
            this.Name = name;
            while (age < 0)
            {
                Console.WriteLine("Возраст персонажа не может быть отрицательным");
                age = int.Parse(Console.ReadLine());
            }
            this.Age = age;
            while (height < 0)
            {
                Console.WriteLine("Рост персонажа не может быть отрицательным");
                height = int.Parse(Console.ReadLine());
            }
            this.Height = height;
        }
    }
}
