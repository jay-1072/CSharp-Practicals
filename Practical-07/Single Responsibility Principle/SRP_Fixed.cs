using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_SRP
{
    public abstract class Shape
    {
        protected const decimal PI = (decimal)Math.PI;
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Radius { get; set; }

        public Shape(decimal height, decimal width)
        {
            Height = height;
            Width = width;
        }

        public Shape(decimal radius)
        {
            Radius = radius;
        }

        public abstract decimal GetArea();
        public abstract decimal GetPerimeter();
    }

    public class Rectangle : Shape
    {
        public Rectangle(decimal height, decimal width) : base(height, width) 
        { 
        }
        
        public override decimal GetArea()
        {
            return Math.Round(Height*Width, 2);
        }

        public override decimal GetPerimeter()
        {
            return Math.Round((Height + Width)*2, 2);
        }
    }

    public class Circle : Shape
    {
        public Circle(decimal radius) : base(radius)
        {
        }

        public override decimal GetArea()
        {
            return Math.Round(PI*Radius*Radius, 2);
        }

        public override decimal GetPerimeter()
        {
            return Math.Round(2*PI*Radius, 2);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(decimal height, decimal width) : base(height, width)
        {
        }

        public override decimal GetArea()
        {
            return Math.Round((Height * Width) / 2, 2);
        }

        public override decimal GetPerimeter()
        {
            return Math.Round( Height*Width, 2);    
        }
    }

    public class SRP_Fixed
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.1m, 5.2m);
            Console.WriteLine($"\nRectangle Area is : {rectangle.GetArea()}");
            Console.WriteLine($"\nRectangle Perimeter is : {rectangle.GetPerimeter()}");

            Circle circle = new Circle(2.2m);
            Console.WriteLine($"\nCircle Area is : {circle.GetArea()}");
            Console.WriteLine($"\nCircle Perimeter is : {circle.GetPerimeter()}");

            Triangle triangle = new Triangle(4.1m, 3.5m);
            Console.WriteLine($"\nTriangle Area is : {triangle.GetArea()}");
            Console.WriteLine($"\nTriangle Perimeter is : {triangle.GetPerimeter()}");
        }               
    }
}