using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class AngleClass
    {
        private double angleRadians; // angle in radians

      
        public double AngleDegrees // PROPERTY – angle in degrees
        {
            get { return angleRadians * 180.0 / 3.14; }
            set { angleRadians = value / 180.0 * 3.14; }
        }

        public void writeAngleRadians()
        {
            Console.WriteLine($"The angle in radians is {angleRadians}");
        }


    }

}
