using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class PersonRandomBuilder : IPersonBuilder
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public List<string> NameList { get; set; }
        public Person CreatePerson()
        {
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
            string tempName = null;
            if (NameList == null || NameList.Count == 0)
            {
                Console.WriteLine("Список имён пуст");
            }
            else
            {
                int numOfName = godOfAll.Next(0, NameList.Count);
                tempName = NameList[numOfName];
            }
            int tempAge = godOfAll.Next(MinAge, MaxAge);
            int tempHeight = godOfAll.Next(MinHeight, MaxHeight);
            Person createdPerson = new Person(tempName, tempAge, tempHeight);
            return createdPerson;
        }
    }
}
