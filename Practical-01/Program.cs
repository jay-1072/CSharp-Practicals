using practical_1;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("\nEnter first number : ");
            decimal number1;
            bool IsNumber1ConversionSuccessfull = decimal.TryParse(Console.ReadLine(), out number1);

            if (IsNumber1ConversionSuccessfull)
            {
                Console.Write("\nEnter second number : ");
                decimal number2;
                bool IsNumber2ConversionSuccessfull = decimal.TryParse(Console.ReadLine(), out number2);

                if (IsNumber2ConversionSuccessfull)
                {
                    Calculator.Add( number1, number2 );
                    Calculator.Subtract( number1, number2 );
                    Calculator.Multiply( number1, number2 );
                    
                    if (number2 == 0)
                    {                        
                        Console.WriteLine($"\nCannot divide {number1} by {number2}");                        
                    }
                    else
                    {
                        Calculator.Divide( number1, number2 );
                    }
                }
                else
                {
                    Console.WriteLine($"\nThe number must be between {decimal.MinValue} and {decimal.MaxValue}");
                }
            }
            else
            {
                Console.WriteLine($"\nThe number must be between {decimal.MinValue} and {decimal.MaxValue}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"\n{e.Message}");
        }

        Console.ReadLine();
    }
}
