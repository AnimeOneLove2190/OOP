using System;
using System.Collections.Generic;
using System.Text;
using Quest01.AllPersons;
using Quest01.Products;
using Quest01.Employees;

namespace Quest01.Interfaces
{
    interface ILinqService
    {
        public void GetFirstStudentWithName(List<Student> studentList, string searchName);
        public void GetProductWithMinPrice(List<Product> productList);
        public void GetFirstStudentWithAge(List<Student> studentList, int searchAge);
        public void GetStdentsWithAgeList(List<Student> studentList, int searchAge);
        public void GetProductListWihtCategory(List<Product> productList, Categories searchCategory);
        public void GetStudentsListWithSpec(List<Student> studentList, Spezialitations searchSpec);
        public void GetStudentNameList(List<Student> studentList);
        public void GetProductNameList(List<Product> productList, Categories searcCategory);
        public void GetProductNamesWithPriceHigher(List<Product> productList, int searchMinPrice);
        public void GetEmployeesNameListByPosition(List<Employee> employeeList, JobTitle searchJobTitle);
        public void GetBookNameListByGenre(List<Book> bookList, Genre searchGenre);
        public void SortStudentsWithFriendsByAge(List<Student> studentList, int searchFriendsCount);
    }
}
