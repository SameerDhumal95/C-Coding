using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding
{
    public class PalindromeNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rnum = 0;
            int snum = num;

            while (snum > 0)
            {
                int n = snum % 10;//1//2//1
                rnum = rnum * 10 + n;//1//12//121
                snum = snum / 10;//12//1
            }

            if (rnum == num)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
