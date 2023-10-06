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
        //feature570
        public void GetStudentsListWithSpec(List<Student> studentList, Spezialitations searchSpec)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.GetFirstStudentWithName: один или несколько параметров содержат null");
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
    }
}
