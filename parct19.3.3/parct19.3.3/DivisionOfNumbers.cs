using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parct19._3._3
{
    public class DivisionOfNumbers
    {
        public double Quotient(double num1, double num2, int numberOfNums)
        {
            double res = 0;
            if (numberOfNums == 0)
            {
                res = num1 / num2;
            }
            else if (numberOfNums == 1)
            {
                res = Math.Round(num1 / num2, 1);
            }
            else if (numberOfNums == 2)
            {
                res = Math.Round(num1 / num2, 2);
            }
            else if (numberOfNums == 3)
            {
                res = Math.Round(num1 / num2, 3);
            }
            else if (numberOfNums == 4)
            {
                res = Math.Round(num1 / num2, 4);
            }
            return res;
        }
    }
}
