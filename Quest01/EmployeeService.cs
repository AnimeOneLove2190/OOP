using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class EmployeeService
    {
        public void GetInfo (Employee employee)
        {
            if(employee == null)
            {
                Console.WriteLine("Сработала защита в GetInfo");
                return;
            }
            Console.WriteLine($"Full name: {employee.FullName}");
            Console.WriteLine($"Id: {employee.Id}");
            Console.WriteLine($"Job title: {employee.Job}");
            Console.WriteLine($"Wage: {employee.Wage}");
            Console.WriteLine($"DOB: {employee.DayOfBirth}");
            Console.WriteLine($"Hired: {employee.EmploymentDate}");
        }
        public int GetAge (Employee employee)
        {
            DateTime currentDate = DateTime.Today;
            if(currentDate < employee.DayOfBirth)
            {
                Console.WriteLine("Он што, из будущего?");
                return 0;
            }
            int age = currentDate.Year - employee.DayOfBirth.Year;
            if(currentDate.Month < employee.DayOfBirth.Month || currentDate.Month == employee.DayOfBirth.Month && currentDate.Day < employee.DayOfBirth.Day)
            {
                age--;
            }
            return age;
        }
    }
}
