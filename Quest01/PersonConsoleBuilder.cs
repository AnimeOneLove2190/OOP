using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class PersonConsoleBuilder :  IPersonBuilder
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
            Console.WriteLine("Введите возраст персонажа");
            int tempAge = int.Parse(Console.ReadLine());
            while (tempAge < 0)
            {
                Console.WriteLine("Возраст персонажа не может быть отрицательным");
                tempAge = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите рост персонажа");
            int tempHeight = int.Parse(Console.ReadLine());
            while (tempHeight < 0)
            {
                Console.WriteLine("Рост персонажа не может быть отрицательным");
                tempHeight = int.Parse(Console.ReadLine());
            }
            Person createdPerson = new Person(tempName, tempAge, tempHeight);
            return createdPerson;
        }
    }
}
