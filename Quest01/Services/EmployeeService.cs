using System;
using System.Collections.Generic;
using System.Text;
using Quest01.Employees;

namespace Quest01.Services
{
    class EmployeeService
    {
        public List<Employee> GetEmployeesListMaxWage(List<Employee> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetEmployeesListMaxWage");
                return list;
            }
            List<Employee> employeesMaxWageList = new List<Employee>();
            Employee employeeWithMaxWage = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (employeeWithMaxWage.Wage < list[i].Wage)
                {
                    employeeWithMaxWage = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Wage == employeeWithMaxWage.Wage)
                {
                    employeesMaxWageList.Add(list[i]);
                }
            }
            return employeesMaxWageList;
        }
        public List<Employee> GetEmployeesListMinWage(List<Employee> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetEmployeesListMinWage");
                return list;
            }
            List<Employee> employeesMinWageList = new List<Employee>();
            Employee employeeWithMinWage = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (employeeWithMinWage.Wage > list[i].Wage)
                {
                    employeeWithMinWage = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Wage == employeeWithMinWage.Wage)
                {
                    employeesMinWageList.Add(list[i]);
                }
            }
            return employeesMinWageList;
        }
        public List<Employee> GetEmployeesListMaxAge(List<Employee> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetEmployeesListMaxAge");
                return list;
            }
            List<Employee> employeesMaxAgeList = new List<Employee>();
            Employee employeeWithMaxAge = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (employeeWithMaxAge.GetAge() < list[i].GetAge())
                {
                    employeeWithMaxAge = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetAge() == employeeWithMaxAge.GetAge())
                {
                    employeesMaxAgeList.Add(list[i]);
                }
            }
            return employeesMaxAgeList;
        }
        public List<Employee> GetEmployeesListMinAge(List<Employee> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetEmployeesListMinAge");
                return list;
            }
            List<Employee> employeesMinAgeList = new List<Employee>();
            Employee employeeWithMinAge = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (employeeWithMinAge.GetAge() > list[i].GetAge())
                {
                    employeeWithMinAge = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetAge() == employeeWithMinAge.GetAge())
                {
                    employeesMinAgeList.Add(list[i]);
                }
            }
            return employeesMinAgeList;
        }
    }
}
