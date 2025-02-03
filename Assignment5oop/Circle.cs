using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5oop
{
    internal class Circle : ICircle

    {
        public double Radius { get ; set ; }

        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($" circle With Radius : {Radius} , Area :{Area}");
        }
       

    }
}
