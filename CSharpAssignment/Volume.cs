

namespace Math.VolumeFormulae
{
    public class Volume
    {
       

          public  static double VolumnOfSphere(double radius)
            {
                double volSphere = 4 * 3.14 * radius * radius * radius / 3;
                return volSphere;
            }
        public   double VolumnOfCuboid(double length, double width, double height)
        {
            double volcuboid = length * width * height;
            return volcuboid;
        }
        
        public  double VolumeOfCylinder(double radius,double height)
        {
            return 3.1 * radius * radius * height;

        }
        public static String GetAuthorName()
        {
            return "Omkar Jadhav";
        }

        public  void Quit()
        { 
        
        }
       


    }
}
