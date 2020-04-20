using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Task3
{
    public class Sphere
    {
        public Sphere()
        { }
        public double CircleLenght(double r)
        {
            return 2 * Math.PI * r;
        }
        public double CircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public double SphereVolume(double r)
        {
            return (4/3) * Math.PI * Math.Pow(r, 3);
        }
    }
}
