/*Implement `Shape` class with `CalculateArea()`.
 * Extend to `Rectangle` and `Circle` with area calculations.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            Console.WriteLine("This is the parent class Shape");
            return 0;
        }
    }
    public class Circle : Shape
    {
        private double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Rectangle : Shape
    {
        private double length { get; set; }
        private double breadth { get; set; }
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double CalculateArea()
        {
            return length * breadth;
        }
    }
}
