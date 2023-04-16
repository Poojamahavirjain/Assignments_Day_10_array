using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigementDay10
{
    internal class ReverseArrayNumber
    {
        static void Main(string[] args)
        {

            int[] num = { 20, 30, 40, 80, 90, 120 };

            for (int i = num.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(num[i]);
            }
        }

    }
}
