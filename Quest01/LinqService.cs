using System;
using System.Collections.Generic;
using System.Text;
using Quest01.AllPersons;
using Quest01.Employees;
using Quest01.Products;
using System.Linq;

namespace Quest01
{
    class LinqService
    {
        //feature567
        public void GetFirstStudentWithAge(List<Student> studentList, int searchAge)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.GetFirstStudentWithAge: один или несколько параметров содержат null");

            }
            var firstStudentWithAge = studentList.FirstOrDefault(x => x.Age > searchAge);
            if (firstStudentWithAge == null)
            {
                throw new Exception("Студент с искомым возрастом не найден");
            }
            else
            {
                Console.WriteLine(firstStudentWithAge.Name);
                Console.WriteLine(firstStudentWithAge.Age);
                Console.WriteLine(firstStudentWithAge.CountOfFriends);
            }
        }
    }
}
