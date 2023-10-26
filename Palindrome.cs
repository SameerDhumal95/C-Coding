using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            string str = "Naman".ToUpper();
            string rstr = "";

            for(int i= str.Length-1; i>=0; i--)
            {
                rstr = rstr + str[i];
            }

            if(rstr==str)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
