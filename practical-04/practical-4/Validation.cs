using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_4
{
    public class Validation
    {
        private static string message = string.Empty;
        public static bool ValidateMarks(string input, out decimal val)
        {
            return decimal.TryParse(input, out val) && (val >= 0 && val <= 100);
        }

        public static decimal TakeMarks(int i)
        {
            Console.Write($"\nEnter marks{i} : ");

            decimal val;

            bool IsValidInput = ValidateMarks(Console.ReadLine(), out val);

            if (!IsValidInput)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nPlease Enter marks between 0 and 100");
                Console.ForegroundColor = ConsoleColor.Yellow;
                val = TakeMarks(i);
            }

            return val;
        }

        public static void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{message}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static string TakeAndValidateName()
        {
            Console.Write("\nEnter student name : ");
            string name = Console.ReadLine();

            bool IsNumber = name.Any(char.IsDigit);

            if (IsNumber)
            {
                message = "Invalid student name\nStudent name should only contains letters";
                PrintMessage(message);
                name = TakeAndValidateName();
            }
            else if (name.Length > 15)
            {
                message = "Student name should contain atmost 15 characters";
                PrintMessage(message);
                name = TakeAndValidateName();
            }

            return name;
        }
    }
}
