using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Square : Shape
    {
        public override double Area { get; }
        public double side;
        public override double Circumference { get; }

        public Square(double side)
        {
            this.side = side;
            this.Area = side * side;
            this.Circumference = 4 * side;
        }

        public override string ToString()
        {

            return $"A square with the side {this.side}";
        }

        public override void Print()
        {
            Console.WriteLine($"A square with side {side:f1} has an area of {Area:f2} and a circumference of {Circumference:f2}.");
        }
    }
}
