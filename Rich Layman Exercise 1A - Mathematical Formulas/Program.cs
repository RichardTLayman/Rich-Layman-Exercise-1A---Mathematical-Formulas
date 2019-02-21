using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich_Layman_Exercise_1A___Mathematical_Formulas
{
    class MathFormulas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the Circumference of a Circle, the Area of a Circle, the Volume of  Hemisphere, the Area of a Triangle, and solve a quadratic equation. \n");

            int r1;
            double Circumference;
            Console.WriteLine("To calculate the Circumference of a circle. Enter the radius: \n");
            r1 = Convert.ToInt32(Console.ReadLine());
            Circumference = 2 * Math.PI * r1;
            Console.WriteLine("The Circumference of the circle is: " + Circumference );
            Console.WriteLine("\n");

            int r2;
            double Area;
            Console.WriteLine("To calculate the Area of a circle. Enter the radius: \n");
            r2 = Convert.ToInt32(Console.ReadLine());
            Area = Math.PI * Math.Sqrt(r2);
            Console.WriteLine("The Area of a circle of a given radius is: " + Area );
            Console.WriteLine("\n");

            int r3;
            double Volume;
            Console.WriteLine("To calculate the Volume of a hemisphere. Enter the radius: \n");
            r3 = Convert.ToInt32(Console.ReadLine());
            Volume = (4.0 / 3) * Math.PI * Math.Pow(r3, 3) / 2;
            Console.WriteLine("The Volume of this hemisphere is : " + Volume);
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
