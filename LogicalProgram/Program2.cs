using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public  class Program2
    {
        public static void Sequence()
        {
            int num = 3;
            int i;
            for (i=1;i<=20;i++)
            {

                Console.WriteLine(num+"*"+i+"="+ num * i);
            }
        
        }
    }
}
