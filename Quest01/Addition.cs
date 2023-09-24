using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class Addition : Calculate, ICalculable
    {
        public override int DoOperation(int numOne, int numTwo)
        {
            int result = numOne + numTwo;
            return result;
        }
    }
}
