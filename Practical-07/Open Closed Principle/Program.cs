using WithOCP;
using WithoutOCP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n************************ Without Open Closed Principle *********************\n");

        Employee1 employee1 = new Employee1(190170116026, "Jay", 10000.51M, EmployeeType.Permenant);
        Employee1 employee2 = new Employee1(170190116025, "Abc", 15000.99M, EmployeeType.ContractBased);
        Employee1 employee3 = new Employee1(110110116021, "Def", 25000.42M, EmployeeType.Temporary);

        Console.ForegroundColor = ConsoleColor.Green;

        decimal employee1Bonus = employee1.CalculateBonus(employee1.Salary, employee1.Type);
        Console.WriteLine($"Id: {employee1.Id} Name: {employee1.Name} Bonus: {employee1Bonus}");

        decimal employee2Bonus = employee2.CalculateBonus(employee2.Salary, employee2.Type);
        Console.WriteLine($"Id: {employee2.Id} Name: {employee2.Name} Bonus: {employee2Bonus}");

        decimal employee3Bonus = employee3.CalculateBonus(employee3.Salary, employee3.Type);
        Console.WriteLine($"Id: {employee3.Id} Name: {employee3.Name} Bonus: {employee3Bonus}");

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("\n************************ With Open Closed Principle *********************\n");

        Permenant pEmployee = new Permenant(120130190110, "Pemp1", 10000.51M);
        ContractBased cEmployee = new ContractBased(150170116021, "Cemp1", 20000.42M);
        Temporary tEmployee = new Temporary(110120116022, "Temp1", 25000.43M);

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"Id: {pEmployee.Id} Name: {pEmployee.Name} Bonus: {pEmployee.CalculateBonus(pEmployee.Salary)}");
        Console.WriteLine($"Id: {cEmployee.Id} Name: {cEmployee.Name} Bonus: {cEmployee.CalculateBonus(cEmployee.Salary)}");
        Console.WriteLine($"Id: {tEmployee.Id} Name: {tEmployee.Name} Bonus: {tEmployee.CalculateBonus(tEmployee.Salary)}");

        Console.ForegroundColor = ConsoleColor.White;

        Console.ReadLine();
    }
}