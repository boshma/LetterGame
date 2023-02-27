using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ClassToDemoTestingNonPublic
    {
        internal static int tripleThis(int aNumber)
        {
            return aNumber * 3;
        }
        private int privateInstanceMethod(int aNumber)
        {
            return aNumber;
        }

        private double privateInstanceMethod(double aNumber)
        {
            return aNumber;
        }
    }
}
