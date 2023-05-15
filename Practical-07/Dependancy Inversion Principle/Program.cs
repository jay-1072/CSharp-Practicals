using Without_DIP;
using With_DIP;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine($"\n********************* Without DIP *************************");
        EmployeeBL employeeBL = new EmployeeBL();
        Employee e1 = employeeBL.GetEmployeeDetails(190170116026);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nId: {e1.Id} Name: {e1.Name} Department: {e1.Department} Salary: {e1.Salary}");
        Console.ResetColor();

        Console.WriteLine($"\n********************* With DIP *************************");
        EmployeeBL1 employeeBL1 = new EmployeeBL1();
        Employee1 e2 = employeeBL1.GetEmployeeDetails(190170116021);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nId: {e2.Id} Name: {e2.Name} Department: {e2.Department} Salary: {e2.Salary}");
        Console.ResetColor();

        Console.ReadLine();
    }
}