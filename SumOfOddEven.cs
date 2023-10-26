using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding
{
    public class SumOfOddEven
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number:");
            int lnum = Convert.ToInt32(Console.ReadLine());
            int sEven = 0, sOdd = 0;

            for(int i = fnum; i <= lnum; i++)
            {
                if(i%2 == 0)
                {
                    sEven = sEven + i;
                }
                else
                {
                    sOdd = sOdd + i;
                }
            }

            Console.WriteLine("Sum of Even Numbers:" + sEven);
            Console.WriteLine("Sum of Odd Numbers:" + sOdd);
        }
    }
}
