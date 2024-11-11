using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Circumference { get; }
        public abstract void Print();
        public static void PrintAll(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

        }

        public static void PrintCircles(Shape[] shapes)
        {
            foreach(Shape shape in shapes)
            {
                if(shape is Circle)
                {
                    Console.WriteLine(shape);
                }
            }
        }
    }

}
