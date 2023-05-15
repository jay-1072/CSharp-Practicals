using practical_4;
using System;
using System.Security.Cryptography;

public class Program
{                  
    public static void Main(string[] args)
    {
        Student student = new Student();
         
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        student.Name = Validation.TakeAndValidateName();            

        for(int i=0; i<5; i++)
        {            
            student.Marks[i] = Validation.TakeMarks(i+1); 
        }      

        while (true)
        {
            Console.WriteLine($"\n1-Average");
            Console.WriteLine($"2-MinMark");
            Console.WriteLine($"3-MaximumMark");
            Console.WriteLine($"4-Grade");
            Console.WriteLine($"5-Exit");

            bool flag = false;
            int choice;
            
            do
            {
                if(flag)
                {
                    Console.WriteLine("\nPlease Enter Valid Choice");
                }
                Console.Write($"\nEnter your choise : ");
            }
            while (flag = !int.TryParse(Console.ReadLine(), out choice));                  
            
            switch (choice)
            {
                case (int)Options.Average:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nStudent Name : {student.Name} && Average Marks : {student.CalculateAverageMarks(student.Marks)}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Options.MinMark:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nMinimum Marks : {student.Marks.Min()}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Options.MaximumMark:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nMaximum Marks : {student.Marks.Max()}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Options.Grade:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nGrade : {student.CalculateGrade(student.CalculateAverageMarks(student.Marks))}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    flag = !flag;
                    break;
                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"\nWrong option choosen");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTHANK YOU...");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }                
        }
    }
}