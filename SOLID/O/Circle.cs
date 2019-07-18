using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.Sqrt(Radius) * Math.PI;
        }
    }
}
