using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Tasks
{
    internal class Rectangle : Shape
    {
        double width;
        double height;
        public Rectangle(string color, double area, double width, double height) : base(color, area)
        {
            this.width = width;
            this.height = height;
        }
        public double area(double width, double height)
        {
            return width * height;
        }
    }
}
