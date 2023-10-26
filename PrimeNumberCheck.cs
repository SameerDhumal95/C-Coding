using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding
{
    public class PrimeNumberCheck
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean flag = false;
            if(num==0||num==1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for(int i = 2; i < num;i++)
                {
                    if(num%i==0)
                    {
                        flag = true;
                    }
                }
                if(flag)
                {
                    Console.WriteLine("Not prime");

                }
                else
                {
                    Console.WriteLine("prime");
                }
            }
        }
    }
}
