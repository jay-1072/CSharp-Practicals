using System;
using Without_SRP;


namespace Without_SRP
{
    public class Shape
    {
        public const decimal PI = (decimal)Math.PI;
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Radius { get; set; }

        public Shape(decimal height, decimal width, decimal radius)
        {
            Height = height;
            Width = width;
            Radius = radius;
        }

        public decimal CalcRectangleArea()
        {
            return Math.Round(Height * Width, 2);
        }

        public decimal CalcCircleArea()
        {
            return Math.Round(PI*Radius*Radius, 2);
        }

        public decimal CalcTriangleArea()
        {
            return Math.Round((Height * Width)/2, 2);
        }
    }

    public class SRP_Violated
    {
        public static void Main(string[] args)
        {
            Shape shape = new Shape(5, 2, 3);
            
            decimal rectangleArea = shape.CalcRectangleArea();
            Console.WriteLine($"\nRectangle Area: {rectangleArea}");

            decimal circleArea = shape.CalcCircleArea();
            Console.WriteLine($"\nCircle Area: {circleArea}");

            decimal triangleArea = shape.CalcTriangleArea();
            Console.WriteLine($"\nTriangle Area: {triangleArea}");
        }
    }
}