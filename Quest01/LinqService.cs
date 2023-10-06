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
