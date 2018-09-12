using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class util
    {
        public static int Sum(params int[] paraList)
        {
            Console.WriteLine("using parameter list");
            if(paraList == null)
            {
                throw new ArgumentException("util.sum: null parameter list");
            }
            if (paraList.Length == 0)
            {
                throw new ArgumentException("util.Sum: empty parameter list");
            }
            int sumtotal = 0;
            foreach (int i in paraList)
            {
                sumtotal +=i;
            }
            return sumtotal;
        }

        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            int sumTotal = param1 + param2 + param3 + param4;
            return sumTotal;
        }
    }
}
