using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class Rectangle: Shape
    {
        public double width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return width * Height;
        }
    }
}
