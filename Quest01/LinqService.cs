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
        public void GetFirstStudentWithName(List<Student> studentList, string searchName)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.GetFirstStudentWithName: один или несколько параметров содержат null");
            }
            var firstStudentWithName = studentList.FirstOrDefault(x => x.Name == searchName);
            if (firstStudentWithName == null)
            {
                throw new Exception("Студент с выбранным именем не найден");
            }
            else
            {
                Console.WriteLine(firstStudentWithName.Name);
                Console.WriteLine(firstStudentWithName.Age);
                Console.WriteLine(firstStudentWithName.CountOfFriends);
            }
        }
        public void GetProductWithMinPrice(List<Product> productList)
        {
            if (productList == null || productList.Count == 0)
            {
                throw new Exception("LinqService.GetProductWithMinPrice: один или несколько параметров содержат null");
            }
            var minPrice = productList.Min(x => x.Price);
            var productWithMinPrice = productList.FirstOrDefault(x => x.Price == minPrice);
            if (productWithMinPrice == null)
            {
                throw new Exception("Студент с искомым возрастом не найден");
            }
            else
            {
                Console.WriteLine(productWithMinPrice.Name);
                Console.WriteLine(productWithMinPrice.Price);
                Console.WriteLine(productWithMinPrice.Category);
            }
        }
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
        //feature568
        public void GetStdentsWithAgeList(List<Student> studentList, int searchAge)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.GetFirstStudentWithName: один или несколько параметров содержат null");
            }
            var studentsWithAgeList = studentList.Where(x => x.Age == searchAge).ToList();
            if (studentsWithAgeList == null || studentsWithAgeList.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach (var student in studentsWithAgeList)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Age);
                    Console.WriteLine(student.CountOfFriends);
                }
            }
        }
    }
}
