using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram2
{
    public class Program11
    {
        public static void ReverseString()
        {
            string str;
            Console.Write("Enter a string - ");
            str = Console.ReadLine();
            char [] chars=str.ToCharArray();
            for (int i = 1; i < chars.Length; i--)
            {
                Console.Write(chars[i]);
            }
            //Console.WriteLine($"You entered {str}");


        }
    }
}
