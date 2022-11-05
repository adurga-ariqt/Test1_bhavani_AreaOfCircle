using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_bhavani_AreaOfCircle
{
    public class Circle
    {
        double pi = 3.14;
        double areaOfCircle;
        double perimeter;
        public int Radius { get; set; }

        public void  GerCircleAndPerimeter()
        { areaOfCircle = pi * Radius * Radius;
            Console.WriteLine(" Area of the Circle:" + areaOfCircle);
            perimeter = 2 * pi * Radius;
            Console.WriteLine(" perimeter of the circle :" + perimeter);
        }
    }
}
