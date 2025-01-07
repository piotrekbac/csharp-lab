using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_02
{
    public struct Point3d
    {
        public double X { get;  }
        public double  Y { get;  }
         public double Z { get; }

        public Point3d(double x, double y, double z)
        {
            X = x;
            Y = y; 
            Z = z;

        }


        public static double GetDistanceFromOrigin(double x, double y, double z)
        {
            double wynik = 0;
            wynik = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2)); 
        }
    }
}
