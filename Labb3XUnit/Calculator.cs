using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3XUnit
{
    public class Calculator
    {

        public double Division(double nr1, double nr2)
        {
            if (nr2 == 0)
            {
                return 0;
            }
            return nr1 / nr2;
        }

        public double Muliplication(double nr1, double nr2)
        {
            return nr1 * nr2;
        }
        public double Addition(double nr1, double nr2)
        {
            return nr1 + nr2;
        }
        public double Subtraction(double nr1, double nr2)
        {
            return nr1 - nr2;
        }
    }
}
