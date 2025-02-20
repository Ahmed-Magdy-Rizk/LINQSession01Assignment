using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01Solution
{
    internal static class intExtension
    {
        public static int Reverse(this int number) // Extension Method Must be In static And NonGeneric Class
        {
            int remainder, reversedNumber = 0;
            while (number > 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }
            return reversedNumber;
        }
    }
}
