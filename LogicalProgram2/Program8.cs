using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram2
{
    
    
        public class Program8
        {
            public static void BinaryTriangle()
            {

                Console.Write("Enter integer value of z: ");
                int z = Convert.ToInt32(Console.ReadLine());
           int i , j, k = 1;
            for (i=z; i <= z; i++)
            {
                for(j=1;j<=z;j++)
                {
                    if (j <= i)
                    {
                        Console.Write(k % 2);
                        k++;
                    }
                    else
                    { 
                    Console.WriteLine(" ");
                    }

                }
                Console.WriteLine("\n");
            }

            }
        }
    
}
