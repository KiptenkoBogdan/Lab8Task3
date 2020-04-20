using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Task3
{
    class Program: Sphere
    {
        delegate double Operations(double r);
        static void Main(string[] args)
        {
            Sphere s = new Sphere();
            Operations op1 = s.CircleLenght;
            Console.WriteLine("Circle lenght: " + op1(3));
            op1 = s.CircleArea;
            Console.WriteLine("Circle area: " + op1(3));
            op1 = s.SphereVolume;
            Console.WriteLine("Sphere volume: " + op1(3));

            Console.ReadKey();
        }
    }
}
