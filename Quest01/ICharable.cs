using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    interface ICharable
    {
        public Dictionary<char, int> GetCharStatistics(string text);
    }
}
