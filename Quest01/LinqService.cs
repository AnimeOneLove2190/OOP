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
    }
}
