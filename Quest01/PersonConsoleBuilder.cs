using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class PersonConsoleBuilder : Person, IPersonBuilder
    {
        public Person CreatePerson()
        {
            Console.WriteLine("Введите имя персонажа");
            string tempName = Console.ReadLine();
            while (string.IsNullOrEmpty(tempName) || string.IsNullOrWhiteSpace(tempName))
            {
                Console.WriteLine("Имя персонажа не может быть пустым");
                tempName = Console.ReadLine();
            }
            Name = tempName;
            Console.WriteLine("Введите возраст персонажа");
            int tempAge = int.Parse(Console.ReadLine());
            while (tempAge < 0)
            {
                Console.WriteLine("Возраст персонажа не может быть отрицательным");
                tempAge = int.Parse(Console.ReadLine());
            }
            Age = tempAge;
            Console.WriteLine("Введите рост персонажа");
            int tempHeight = int.Parse(Console.ReadLine());
            while (tempHeight < 0)
            {
                Console.WriteLine("Рост персонажа не может быть отрицательным");
                tempHeight = int.Parse(Console.ReadLine());
            }
            Height = tempHeight;
            Person createdPerson = new Person(Name, Age, Height);
            return createdPerson;
        }
    }
}
