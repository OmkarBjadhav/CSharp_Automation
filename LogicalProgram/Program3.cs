using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
 public  class Program3
    {
        public static void EvenSum()
        {
            int i = 0;
           int sum= 0;  
            for (i = 0; i <=50; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;

                }
               
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine(sum +"  The Number is Even");
            }
            else
                Console.WriteLine(sum + "The Number is Odd");


        }
    }
}
