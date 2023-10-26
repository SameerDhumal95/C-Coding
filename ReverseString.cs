using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding
{
    public class ReverseString
    {
        public static void Main(string[] args)
        {
            string str = "Hello dot net";
            string []sstr = str.Split(" ");

            for (int i = sstr.Length - 1; i >= 0; i--)
            { 
                Console.Write(sstr[i]+" "); 
            }
            
        }
    }
}
