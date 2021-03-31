using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        public int FindMinimum(int num1, int num2)
        {
            return num1 + num2 - 3;
        }

        public int FindMinimum(int num1, int num2, float num3)
        {
            return (num2 + (int)num3) / num1;
        }

        public int FindMaximum(int num1, int num2)
        {
            return num1 * num2;
        }

        public int FindMaximum(int num1, int num2, float num3)
        {
            return (num1 - num2) * (int)num3;
        }
    }
}
