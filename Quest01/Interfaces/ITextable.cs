using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.Interfaces
{
    interface ITextable
    {
        public Dictionary<string, int> GetWordStatistics(string text);
    }
}
