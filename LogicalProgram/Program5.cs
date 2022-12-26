using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public  class Program5
    {
        public static void SumOfOdd()
        {
           
            int a=0; int b=1;int c = 0;
            int i=0; 
   
            for( i=0;i<=10;i++)
            {
                if(i%2 !=0)
                {
                    i = c;
                    c = a + b;
                   
                    a = b;
                    b = c;
                    Console.WriteLine(c);
                }
                


            }
            Console.WriteLine(i);
        
        }
    }
}
