
using Math.VolumeFormulae;

namespace Math.Formulae
{
    public  class Program
    {
        public static void Main(String[] args)
        {
           double result= Volume.VolumnOfSphere(12);
            Console.WriteLine(result);
            Volume obj = new Volume();
            double result1 =obj.VolumnOfCuboid(10,10,10);
          

             result1 = obj.VolumnOfCuboid(20, 20, 20);

             result1 = obj.VolumnOfCuboid(30, 30, 30);
            Console.WriteLine(result1);
            Volume.GetAuthorName();
            obj.Quit();       }  
    }
}
