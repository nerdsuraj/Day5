using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Flipcoin
    {
        public static double num, tailPercent, headPercent;
        public static double coinNum;
        public static double headCount = 0;
        public static double tailCount = 0;


        public static void randomMethod()
        {
            Random obj = new Random();

            num = obj.NextDouble();
        }

            public static void flipcoin()
        {
            Console.WriteLine();

            Console.WriteLine("Flip coin .");

            Console.WriteLine("Enter number of times you want to flip coin");

            coinNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < coinNum; i++)
            {
                randomMethod();

                if (num <= 0.5)
                {
                    tailCount += 1;
                }
                else
                {
                    headCount += 1;
                }
            }

            tailPercent = (tailCount / coinNum) * 100;

            headPercent = (headCount / coinNum) * 100;

            Console.WriteLine("Total HeadCounts : {0}  Total TailCounts : {1}", headCount, tailCount);

            Console.WriteLine("Headpercent : " + headPercent + "%" + " & Tailpercent : " + tailPercent + "%");
        }

    }
}

