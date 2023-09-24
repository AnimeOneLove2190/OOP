using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class PersonRandomBuilder : Person, IPersonBuilder
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public List<string> NameList { get; set; }
        public Person CreatePerson()
        {
            if (NameList == null || NameList.Count == 0)
            {
                Console.WriteLine("Список имён пуст");
                Name = null;
            }
            if (MinAge < 0)
            {
                Console.WriteLine("Минимальный возраст не может быть отрицательным");
                MinAge = 0;
            }
            if (MinHeight < 0)
            {
                Console.WriteLine("Минимальный рост не может быть отрицательным");
                MinHeight = 0;
            }
            Random godOfAll = new Random();
            int numOfName = godOfAll.Next(0, NameList.Count);
            Name = NameList[numOfName];
            Age = godOfAll.Next(MinAge, MaxAge);
            Height = godOfAll.Next(MinHeight, MaxHeight);
            Person createdPerson = new Person(Name, Age, Height);
            return createdPerson;
        }
    }
}
