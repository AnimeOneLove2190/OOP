using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.PlayLists
{
    class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int TechDuration { get; set; }
        private string duration;
        public string Duration
        {
            get
            {
                if (TechDuration <= 0)
                {
                    duration = "00 : 00";
                }
                int countOfMinutes = TechDuration / 60;
                int countOfSeconds = TechDuration % 60;
                int countOfHours = countOfMinutes / 60;
                int hasOneTen = countOfSeconds / 10;
                if (countOfHours == 0)
                {
                    if (hasOneTen > 0)
                    {
                        duration = $"{countOfMinutes} : {countOfSeconds}";
                    }
                    else
                    {
                        duration = $"{countOfMinutes} : 0{countOfSeconds}";
                    }
                }
                if (countOfHours > 0)
                {
                    if (hasOneTen > 0)
                    {
                        duration = $"{countOfHours} : {countOfMinutes} : {countOfSeconds}";
                    }
                    else
                    {
                        duration = $"{countOfHours} : {countOfMinutes} : 0{countOfSeconds}";
                    }
                }
                return duration;
            }
        }
    }
}
