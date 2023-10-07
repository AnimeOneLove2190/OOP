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
    }
}
