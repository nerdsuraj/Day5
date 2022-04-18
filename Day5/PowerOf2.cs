using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class PowerOf2
    {
        
        
        public static int n;
        public static int i = 0;
        public static int num = 1;

        public static int power2method()
        {

            Console.WriteLine("Enter value of n for calculating 2^n");

            n = Convert.ToInt32(Console.ReadLine());

            if (n >= 31)
            {
                Console.WriteLine("This 2^n Power Program works for number less than 31 ");
            }
            return n;
        }
        public static void method()
        {
            Console.WriteLine();

            Console.WriteLine("Power of 2 .");

            power2method();

            if (n < 31)
            {
                while (i < n)
                {
                    i++;
                    num = num * 2;
                }
                Console.WriteLine("Value of 2^{0} is {1}", n, num);
            }
        }
    }
}
