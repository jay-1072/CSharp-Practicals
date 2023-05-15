using Liskov_Substitution;

public class Program
{
    public static void Main(string[] args)
    {
        Employee employeeAlice = new PermenantEmployee(101, "Alice");
        Employee employeeBob = new TemporaryEmployee(101, "Bob");
        Employee employeeJohn = new ContractBasedEmployee(101, "John");

        Console.WriteLine(string.Format($"Employee {employeeAlice.ToString()} Bonus = {employeeAlice.CalculateBonus(10000)}"));
        Console.WriteLine(string.Format($"Employee {employeeBob.ToString()} Bonus = {employeeBob.CalculateBonus(10000)}"));
        //Console.WriteLine(string.Format($"Employee {employeeJohn.ToString()} Bonus = {employeeJohn.CalculateBonus(10000)}"));

        List<IEmployee> iEmployee = new List<IEmployee>();
        iEmployee.Add(new PermenantEmployee1(101, "Alice"));
        iEmployee.Add(new TemporaryEmployee1(102, "Bob"));
        iEmployee.Add(new ContractBasedEmployee1(103, "John"));

        foreach (var employee in iEmployee)
        {
            Console.WriteLine(string.Format($"Employee {employee.ToString()} Minimum Salary = {employee.GetMinimumSalary()}"));
        }
    }
}