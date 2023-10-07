using System;
using System.Collections.Generic;
using System.Text;
using Quest01.AllPersons;
using Quest01.Employees;
using Quest01.Products;
using System.Linq;
using Quest01.Interfaces;

namespace Quest01
{
    class LinqService : ILinqService
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
                throw new Exception("Продукт с минимальной ценой не найден (такое вообще возможно?)");
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
        //feature569
        public void GetProductListWihtCategory(List<Product> productList, Categories searchCategory)
        {
            if (productList == null || productList.Count == 0)
            {
                throw new Exception("LinqService.GetProductListWihtCategory: один или несколько параметров содержат null");
            }
            var categoryProductList = productList.Where(x => x.Category == searchCategory).ToList();
            if (categoryProductList == null || categoryProductList.Count == 0)
            {
                throw new Exception("Товары с выбранной категорией не найдены");
            }
            else
            {
                foreach (var product in categoryProductList)
                {
                    Console.WriteLine(product.Name);
                    Console.WriteLine(product.Price);
                    Console.WriteLine(product.Category);
                }
            }
        }
        //feature570
        public void GetStudentsListWithSpec(List<Student> studentList, Spezialitations searchSpec)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.GetStudentsListWithSpec: один или несколько параметров содержат null");
            }
            var studentsSpecList = studentList.Where(x => x.Spezialisation == searchSpec).ToList();
            if (studentsSpecList == null || studentsSpecList.Count == 0)
            {
                throw new Exception("Студенты с искомой специализацией не найдены");
            }
            else
            {
                foreach (var student in studentsSpecList)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Age);
                    Console.WriteLine(student.CountOfFriends);
                }
            }
        }
        //feature571
        public void GetStudentNameList(List<Student> studentList)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.GetStudentNameList: один или несколько параметров содержат null");
            }
            var studentsNameList = studentList.Select(x => x.Name).ToList();
            if (studentsNameList == null || studentsNameList.Count == 0)
            {
                throw new Exception("Список имён пуст");
            }
            else
            {
                foreach (var name in studentsNameList)
                {
                    Console.WriteLine(name);
                }
            }
        }
        public void GetProductNameList(List<Product> productList, Categories searcCategory)
        {
            if (productList == null || productList.Count == 0)
            {
                throw new Exception("LinqService.GetProductNameList: один или несколько параметров содержат null");
            }
            var poroductNamesList = productList.Where(x => x.Category == searcCategory).Select(x => x.Name).ToList();
            if (poroductNamesList == null || productList.Count == 0)
            {
                throw new Exception("Товары с выбранной категорией не найдены");
            }
            else
            {
                foreach (var name in poroductNamesList)
                {
                    Console.WriteLine(name);
                }
            }

        }
        //feature573
        public void GetProductNamesWithPriceHigher(List<Product> productList, int searchMinPrice)
        {
            if (productList == null || productList.Count == 0)
            {
                throw new Exception("LinqService.GetProductNamesWithPriceHigher: один или несколько параметров содержат null");
            }
            var productNamesWithPriceHigher = productList.Where(x => x.Price > searchMinPrice).Select(x => x.Name).ToList();
            if (productNamesWithPriceHigher == null || productNamesWithPriceHigher.Count == 0)
            {
                
               throw new Exception("Товары с ценой выше указанной не найдены");
            }
            else
            {
                foreach (var name in productNamesWithPriceHigher)
                {
                    Console.WriteLine(name);
                }
            }
        }
        public void GetEmployeesNameListByPosition(List<Employee> employeeList, JobTitle searchJobTitle)
        {
            if (employeeList == null || employeeList.Count == 0)
            {
                throw new Exception("LinqService.GetEmployeesNameListByPosition: один или несколько параметров содержат null");
            }
            var employeesNameListByPosition = employeeList.Where(x => x.Job == searchJobTitle).OrderBy(x => x.FullName).Select(x => x.FullName).ToList();
            if (employeesNameListByPosition == null || employeesNameListByPosition.Count == 0)
            {
                throw new Exception("Сотрудники с выбранной должностью не найдены");
            }
            else
            {
                foreach (var name in employeesNameListByPosition)
                {
                    Console.WriteLine(name);
                }
            }
        }
        public void GetBookNameListByGenre(List<Book> bookList, Genre searchGenre)
        {
            if (bookList == null || bookList.Count == 0)
            {
                throw new Exception("LinqService.GetBookNameListByGenre: один или несколько параметров содержат null");
            }
            var bookNameListByGenre = bookList.Where(x => x.Genres.Contains(searchGenre)).OrderByDescending(x => x.PublicationYear).Select(x => x.Title).ToList();
            if (bookNameListByGenre == null)
            {
                throw new Exception("Произведения с выбранным жанром не найдены");
            }
            else
            {
                foreach (var name in bookNameListByGenre)
                {
                    Console.WriteLine(name);
                }
            }
        }
        //feature576
        public void SortStudentsWithFriendsByAge(List<Student> studentList, int searchFriendsCount)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.SortStudentsWithFriendsByAge: один или несколько параметров содержат null");
            }
            var studentsWithFriendsByAge = studentList.Where(x => x.CountOfFriends > searchFriendsCount).OrderBy(x => x.Age).ToList();
            if (studentsWithFriendsByAge == null || studentsWithFriendsByAge.Count == 0)
            {
                throw new Exception("Пользователи с указанным количеством друзей не найдены");
            }
            else
            {
                foreach (var student in studentsWithFriendsByAge)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Age);
                    Console.WriteLine(student.CountOfFriends);
                    Console.WriteLine(student.Spezialisation);
                }
            }
        }
    }
}
