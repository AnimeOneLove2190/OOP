using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.Interfaces
{
    interface ITechService
    {
        public void WriteDictionary(Dictionary<DateTime, int> someDictionary);
        public void WriteDictionary(Dictionary<int, int> someDictionary);
        public void WriteDictionary(Dictionary<int, Dictionary<int, int>> someDictionary);
    }
}
