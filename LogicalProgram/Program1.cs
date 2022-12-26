

namespace LogicalProgram
{
    public class Program1
    {
        public static void EvenOrOdd()
        {
            int i = 0;
            Console.WriteLine("Even number  :");
            for(i=0;i<=30;i++)
            {
                if(i%2==0)
                {
                    // Print the number on same line 
                    //(print and println in java)
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine("\nOdd number  :");//(\n Function has to be Explain)
            for (i = 0; i <= 30; i++)
            {
                if(i%2!=0)
                {
                    Console.Write(i+" ");
                }
            }
        
        
        
        }


    }
}
