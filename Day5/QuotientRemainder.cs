using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class QuotientRemainder
    {
        public static void quotientRemainder()
        {
            Console.WriteLine();

            Console.WriteLine("Quotient Remainder");

            Console.WriteLine("Enter the Dividend value");

            int divd = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Divisor value");

            int div = int.Parse(Console.ReadLine());

            int remainder = divd % div;

            int quotient = divd / div;
            Console.WriteLine("Quotient value : " + quotient);

            Console.WriteLine("Remainder value : " + remainder);

        }
    }
}
