using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram2
{
    public  class Program9
    {
        public static void NumberOfOccurrence()
        {

            Console.Write("Enter integer value of a: ");
            int v= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number you want to search: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (v > 0)
            {
                int rem = v % 10;
                if (rem == d)
                {
                    count++;
                    v = 10;
                }
            
                
            }
            Console.WriteLine(count);
        }
    }
}
