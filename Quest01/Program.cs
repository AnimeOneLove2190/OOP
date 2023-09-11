using System;

namespace Quest01
{
    class Program
    {
        static void Main(string[] args)
        {
            FlatWithAutoProperties FlatAutoProp = new FlatWithAutoProperties();
            FlatAutoProp.FullName = "Зубенко Михаил Петрович";
            FlatAutoProp.Id = 0;
            FlatAutoProp.Type = Type.fiveRooms;
            Employee employeeOne = new Employee();
            EmployeeService employeeService = new EmployeeService();
            employeeOne.FullName = "Зубенко Михаил Петрович";
            employeeOne.Id = 0;
            employeeOne.Job = JobTitle.mafia;
            employeeOne.Wage = 22500;
            employeeOne.DayOfBirth = new DateTime(1983, 07, 18);
            employeeOne.EmploymentDate = new DateTime(2001, 08, 19);
            employeeService.GetInfo(employeeOne);
            int ageOne = employeeService.GetAge(employeeOne);
            Console.WriteLine(ageOne);
        }
    }
}
