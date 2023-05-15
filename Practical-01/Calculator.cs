using System;

namespace practical_1
{
    public class Calculator
    {
        public static void Add(decimal x, decimal y)
        {         
            Console.WriteLine($"\nThe sum of the {x} and {y} is {Math.Round(x + y, 2)}");
        }

        public static void Subtract(decimal x, decimal y)
        {
            Console.WriteLine($"\nThe subtraction of the {x} and {y} is {Math.Round(x - y, 2)}");
        }

        public static void Multiply(decimal x, decimal y)
        {
            Console.WriteLine($"\nThe multiplication of the {x} and {y} is {Math.Round(x * y, 2)}");
        }

        public static void Divide(decimal x, decimal y)
        {
            Console.WriteLine($"\nThe division of the {x} and {y} is {Math.Round(x / y, 2)}");            
        }
    }
}