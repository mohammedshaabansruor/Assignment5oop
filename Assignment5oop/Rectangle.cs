using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5oop
{
    internal class Rectangle : IRectangle
    {
        public double Width { get ; set ; }
        public double Height { get; set; }

        public Rectangle(double width,double height)
        {
            Width = width;
            Height = height;
        }
        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with width: {Width}, height: {Height}, Area: {Area}");

        }
    }
}
