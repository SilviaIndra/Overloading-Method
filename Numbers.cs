using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Method
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            return (new int[] { number1, number2, }).Max();
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            return (new int[] { number1, number2, (int) number3 }).Max();
        }

        public int FindMaximum(int number1 , int number2)
        {
            return (new int[] { number1, number2,}).Max();
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            return (new int[] { number1, number2, (int) number3 }).Max();
        }
    }
}
