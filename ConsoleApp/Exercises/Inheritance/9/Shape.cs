using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Circumference { get; }

        public abstract void Print();
    }

}
