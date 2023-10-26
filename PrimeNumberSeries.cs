using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class PrimeNumberSeries
    {
      public static void Main(string[] args) 
      {
        Console.WriteLine("Enter the First Num:");
        int startnum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the last Num:");
        int endnum = Convert.ToInt32(Console.ReadLine());

        if (startnum==1||startnum==0)
        {
            startnum =2;
        }
                    
        for(int i = startnum;i <= endnum; i++) 
        {
            Boolean flag = true;
                 
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0) 
                {
                    flag = false;
                    break;
                }

            }
            if(flag) 
            {
                Console.Write(i + " , ");
            }
           
          
        }

      }
    }

