using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Circle : Shape
    {
        public override double Area { get; }

        public override double Circumference { get; }

        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            this.Area = radius * radius * Math.PI;
            this.Circumference = 2 * radius * Math.PI;
        }

        public override string ToString()
        {

            return $"A circle with the radius {this.radius}";
        }

        public override void Print()
        {
            Console.WriteLine($"A circle with radius {radius:f1} has an area of {Area:f2} and a circumference of {Circumference:f2}.");

        }
    }
}
