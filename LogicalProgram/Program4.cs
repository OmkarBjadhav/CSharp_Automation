using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Program4
    {
    public static void Table5()
        {
            int num = 0; int num2 = 0; 
           int i = 1;
            for (; i <= 30; i++)
            {
                if ((5 * i) % 2 == 0)
                {
                    Console.WriteLine("Even Number" + 5 * i);
                    i=num;
                }
                else
                {

                    Console.WriteLine("Odd Number"+5*i);
                    num2++;
                }
                Console.WriteLine(num);
               // Console.WriteLine(num2);
            }

        }
    }
}
