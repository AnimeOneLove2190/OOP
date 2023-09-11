using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class Employee
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public JobTitle Job { get; set; }
        public int Wage { get; set; }
        public DateTime DayOfBirth { get; set; }
        public DateTime EmploymentDate { get; set; }
        public Employee()
        {

        }
        readonly DateTime birthOfJesus = new DateTime(1, 1, 1);
        public Employee(string fio, int id, JobTitle job, int wage, DateTime dayOfBirth, DateTime employment)
        {
            if (string.IsNullOrEmpty(fio) || string.IsNullOrWhiteSpace(fio))
            {
                Console.WriteLine("Неверный формат ФИО");
                return;
            }
            this.FullName = fio;
            if (id <= 0)
            {
                Console.WriteLine($"Неверный формат id у {FullName}");
                return;
            }
            this.Id = id;
            if (job <= 0)
            {
                Console.WriteLine($"Неверный формат должности у {FullName}");
                return;
            }
            this.Job = job;
            if (wage <= 0)
            {
                Console.WriteLine($"Неверный формат заработной платы у {FullName}");
                return;
            }
            if (wage < 16242)
            {
                Console.WriteLine($"Заработная плата у {FullName} ниже МРОТ");
                return;
            }
            this.Wage = wage;
            if (dayOfBirth < birthOfJesus)
            {
                Console.WriteLine($"{FullName} родился до Иисуса?");
                return;
            }
            this.DayOfBirth = dayOfBirth;
            if (employment < birthOfJesus)
            {
                Console.WriteLine($"{FullName} и на работу устроился до рождения Ииисуса? Сколько лет вашей компании?");
                return;
            }
            if(employment < dayOfBirth)
            {
                Console.WriteLine($"Как {FullName} смог утсроиться на работу ещё до того, как родился?");
                return;
            }
            this.EmploymentDate = employment;
        }
        public int GetAge()
        {
            DateTime currentDate = DateTime.Today;
            if (currentDate < DayOfBirth)
            {
                Console.WriteLine("Он што, из будущего?");
                return 0;
            }
            int age = currentDate.Year - DayOfBirth.Year;
            if (currentDate.Month < DayOfBirth.Month || currentDate.Month == DayOfBirth.Month && currentDate.Day < DayOfBirth.Day)
            {
                age--;
            }
            return age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Full name: {FullName}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Job title: {Job}");
            Console.WriteLine($"Wage: {Wage}");
            Console.WriteLine($"DOB: {DayOfBirth}");
            Console.WriteLine($"Hired: {EmploymentDate}");
        }
    }
}
