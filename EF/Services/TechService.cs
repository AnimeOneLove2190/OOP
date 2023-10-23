using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.Services
{
    class TechService
    {
        public void WriteDictionary(Dictionary<DateTime, int> someDictionary)
        {
            foreach (KeyValuePair<DateTime, int> incomeInDay in someDictionary)
            {
                Console.WriteLine($"{incomeInDay.Key} - {incomeInDay.Value}");
            }
        }
        public void WriteDictionary(Dictionary<int, int> someDictionary)
        {
            foreach (KeyValuePair<int, int> incomeInMovie in someDictionary)
            {
                Console.WriteLine($"{incomeInMovie.Key} - {incomeInMovie.Value}");
            }
        }
        public void WriteDictionary(Dictionary<int, Dictionary<int, int>> someDictionary)
        {
            foreach (KeyValuePair<int, Dictionary<int, int>> oneElement in someDictionary)
            {
                var oneDictionary = oneElement.Value;
                Console.WriteLine($"HallId: {oneElement.Key}");
                foreach (KeyValuePair<int, int> incomeInMovie in oneDictionary)
                {
                    Console.WriteLine($"MovieId: {incomeInMovie.Key} - {incomeInMovie.Value}");
                }
            }
        }
    }
}
