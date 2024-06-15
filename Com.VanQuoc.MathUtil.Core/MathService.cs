using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.VanQuoc.MathUtil.Core
{
    public class MathService
    {
        public int GetGCD(int a, int b)
        {
            if (a == 0) return Math.Abs(b);
            if (b == 0) return Math.Abs(a);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return Math.Abs(a);
        }
    }
}
