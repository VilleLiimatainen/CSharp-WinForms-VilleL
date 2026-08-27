using System;
using System.Collections.Generic;
using System.Text;

namespace _112
{
    public class Equations
    {
        public string Plus(string value1, string value2)
        {
            var val1 = decimal.Parse(value1);
            var val2 = decimal.Parse(value2);

            return (val1 + val2).ToString();
        }

        public string Minus(string value1, string value2)
        {
            var val1 = decimal.Parse(value1);
            var val2 = decimal.Parse(value2);

            return (val1 - val2).ToString();
        }

        public string Multiply(string value1, string value2)
        {
            var val1 = decimal.Parse(value1);
            var val2 = decimal.Parse(value2);

            return (val1 * val2).ToString();
        }

        public string Divide(string value1, string value2)
        {
            var val1 = decimal.Parse(value1);
            var val2 = decimal.Parse(value2);

            if (val2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            else
                return (val1 / val2).ToString();
        }
    }
}
