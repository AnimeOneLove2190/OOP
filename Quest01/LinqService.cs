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
        //feature571
        public void GetStudentNameList(List<Student> studentList, string searchName)
        {
            if (studentList == null || studentList.Count == 0)
            {
                throw new Exception("LinqService.GetStudentNameList: один или несколько параметров содержат null");
            }
            var studentsNameList = studentList.Select(x => x.Name).ToList();
            if (studentsNameList == null || studentsNameList.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach (var name in studentsNameList)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
