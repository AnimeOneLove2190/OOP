﻿using System;
using System.Collections.Generic;
using Quest01.Interfaces;
using Quest01.Messages;
using Quest01.Transports;
using Quest01.Computers;
using Quest01.Flats;
using Quest01.Shapes;
using Quest01.Operations;
using Quest01.Employees;
using Quest01.Services;

namespace Quest01
{
    class Program
    {
        static void Main(string[] args)
        {
            var FlatAutoProp = new FlatWithAutoProperties
            {
                FullName = "Зубенко Михаил Петрович",
                Id = 0,
                Type = Flats.Type.fiveRooms
            };
            var employeeOne = new Employee
            {
                FullName = "Зубенко Михаил Петрович",
                Id = 0,
                Job = JobTitle.Mafia,
                Wage = 22500,
                DayOfBirth = new DateTime(1983, 07, 18),
                EmploymentDate = new DateTime(2001, 08, 19)
            };
            var employeeTwo = new Employee
            {
                FullName = "Violet Evergarden",
                Id = 1,
                Job = JobTitle.AutoRecordingDoll,
                Wage = 63567,
                DayOfBirth = new DateTime(2004, 02, 17),
                EmploymentDate = new DateTime(2018, 05, 03)
            };
            var employeeThree = new Employee
            {
                FullName = "Hanji Zoe",
                Id = 2,
                Job = JobTitle.CommanderOfTheParadiseIslandSurveyCorps,
                Wage = 116116,
                DayOfBirth = new DateTime(1982, 06, 06),
                EmploymentDate = new DateTime(2018, 10, 15)
            };
            var employeeList = new List<Employee>
            {
                employeeOne,
                employeeTwo,
                employeeThree
            };
            var employeeService = new EmployeeService();
            var employeesMaxWageList = employeeService.GetEmployeesListMaxWage(employeeList);
            employeesMaxWageList[0].GetInfo();
            var employeesMinWageList = employeeService.GetEmployeesListMinWage(employeeList);
            employeesMinWageList[0].GetInfo();
            var employeesMaxAgeList = employeeService.GetEmployeesListMaxAge(employeeList);
            employeesMaxAgeList[0].GetInfo();
            var employeesMinAgeList = employeeService.GetEmployeesListMinAge(employeeList);
            employeesMinAgeList[0].GetInfo();
            //Feature530
            var helicopter = new Helicopter
            {
                Owner = "Ростех",
                Speed = 250,
                Carrying = 4000
            };
            Console.WriteLine(helicopter.GetInfo());
            var hayachi = new Car
            {
                Owner = "Давлетшин Даниил",
                Speed = 110,
                Сonsumption = 6
            };
            Console.WriteLine(hayachi.GetInfo());
            var meteor = new Boat
            {
                Owner = "Зеленодольский завод имени А. М.Горького",
                Speed = 77,
                Displacement = 53
            };
            Console.WriteLine(meteor.GetInfo());
            //feature531
            var desktop = new DesktopComputer
            {
                Model = "TopComp LP 111902013",
                VideoCard = "AMD Radeon R2",
                RAM = 1,
                CPU = "AMD E1 6010",
                TypeOfShell = TypeOfShell.Vertical,
                BodyMaterial = BodyMaterial.Plastic
            };
            Console.WriteLine(desktop.GetInfo());
            var monoblock = new Monoblock
            {
                Model = "Lenovo C20-05",
                VideoCard = "AMD Radeon R2",
                RAM = 4,
                CPU = "AMD E1-6010",
                BodyMaterial = BodyMaterial.Plastic,
                ScreenDiagonal = 19.5,
                Webcam = true
            };
            Console.WriteLine(monoblock.GetInfo());
            var veteranOfLabourran = new Laptop
            {
                Model = "Lenovo B590",
                VideoCard = "NVIDIA GeForce GT 720M",
                RAM = 8,
                CPU = "Intel(R) Core(TM) i5-3230M",
                BodyMaterial = BodyMaterial.Plastic,
                Webcam = true,
                BatteryCapacity = 202
            };
            Console.WriteLine(veteranOfLabourran.GetInfo());
            //Feature532
            //feature533
            //Мяв
            string meow = "Мяв";
            Console.WriteLine(meow);
            //Ня
            string nya = "Ня";
            Console.WriteLine(nya);
            //feature541
            var techService = new TechnicalService();
            var textService = new TextService();
            var charService = new CharService();
            var text = "Эрвин Смит - 13-й Главнокомандующий Разведкорпуса. Рассудительный, умный и уважаемый человек. Несмотря на аналогичную Леви заботу о членах своего отряда, в случае необходимости без колебаний готов пожертвовать ими ради остального человечества. Он также разработал вид военного построения, позволяющего заранее обнаружить находящегося далеко противника. Также на протяжении большой части своей службы в качестве командира отстаивал независимость Разведкорпуса, тем самым спасая его от расформирования.";
            var charsCount = charService.GetCharStatistics(text);
            techService.WriteDictionary(charsCount);
            //feature542
            var wordsStatistic = textService.GetWordStatistics(text);
            techService.WriteDictionary(wordsStatistic);
        }
    }
}
