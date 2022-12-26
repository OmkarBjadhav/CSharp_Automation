using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram2
{
    public class Program7
    {
        public static void TempArray()
        {
            float[] temp = new float[7];

            Console.Write("Give the temp of 7 days :\n");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Temp = {0} : ", i);
                temp[i] = float.Parse(Console.ReadLine());
                //Console.WriteLine(temp[i]);

            }
            float max = temp[0];
            float min = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] > max)
                {
                    max = temp[i];
                }
                else if (temp[i] < min)
                {
                    min = temp[i];
                }




            }
            Console.WriteLine("The maximum temp " + max);
            Console.WriteLine("The minimum Temp " + min);



        }

    }
}
