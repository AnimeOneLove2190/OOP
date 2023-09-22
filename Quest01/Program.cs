using System;
using System.Collections.Generic;

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
            employeeOne.FullName = "Зубенко Михаил Петрович";
            employeeOne.Id = 0;
            employeeOne.Job = JobTitle.Mafia;
            employeeOne.Wage = 22500;
            employeeOne.DayOfBirth = new DateTime(1983, 07, 18);
            employeeOne.EmploymentDate = new DateTime(2001, 08, 19);
            Employee employeeTwo = new Employee();
            employeeTwo.FullName = "Violet Evergarden";
            employeeTwo.Id = 1;
            employeeTwo.Job = JobTitle.RoyalArmySpecialOfficer;
            employeeTwo.Job = JobTitle.AutoRecordingDoll;
            employeeTwo.Wage = 63567;
            employeeTwo.DayOfBirth = new DateTime(2004, 02, 17);
            employeeTwo.EmploymentDate = new DateTime(2018, 05, 03);
            Employee employeeThree = new Employee();
            employeeThree.FullName = "Hanji Zoe";
            employeeThree.Id = 2;
            employeeThree.Job = JobTitle.CommanderOfTheParadiseIslandSurveyCorps;
            employeeThree.Wage = 116116;
            employeeThree.DayOfBirth = new DateTime(1982, 06, 06);
            employeeThree.EmploymentDate = new DateTime(2018, 10, 15);
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);
            employeeList.Add(employeeThree);
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employeesMaxWageList = employeeService.GetEmployeesListMaxWage(employeeList);
            employeesMaxWageList[0].GetInfo();
            List<Employee> employeesMinWageList = employeeService.GetEmployeesListMinWage(employeeList);
            employeesMinWageList[0].GetInfo();
            List<Employee> employeesMaxAgeList = employeeService.GetEmployeesListMaxAge(employeeList);
            employeesMaxAgeList[0].GetInfo();
            List<Employee> employeesMinAgeList = employeeService.GetEmployeesListMinAge(employeeList);
            employeesMinAgeList[0].GetInfo();
            //Feature530
            Helicopter helicopter = new Helicopter();
            helicopter.Owner = "Ростех";
            helicopter.Speed = 250;
            helicopter.Carrying = 4000;
            Console.WriteLine(helicopter.GetInfo());
            Car hayachi = new Car();
            hayachi.Owner = "Давлетшин Даниил";
            hayachi.Speed = 110;
            hayachi.Сonsumption = 6;
            Console.WriteLine(hayachi.GetInfo());
            Boat meteor = new Boat();
            meteor.Owner = "Зеленодольский завод имени А. М.Горького";
            meteor.Speed = 77;
            meteor.Displacement = 53;
            Console.WriteLine(meteor.GetInfo());
        }
    }
}
