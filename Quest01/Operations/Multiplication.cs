using System;
using System.Collections.Generic;
using System.Text;
using Quest01.Interfaces;

namespace Quest01.Operations
{
    class Multiplication : Calculate, ICalculable
    {
        public override int DoOperation(int numOne, int numTwo)
        {
            int result = numOne * numTwo;
            return result;
        }
    }
}
