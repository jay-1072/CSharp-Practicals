using Liskov_Substitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }

    public interface IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public decimal GetMinimumSalary();
    }

    public abstract class Employee1 : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee1()
        {            
        }

        public Employee1(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public abstract decimal GetMinimumSalary();
        public abstract decimal CalculateBonus(decimal salary);
       
        public override string ToString()
        {
            return string.Format($"Id = {this.ID} Name = {this.Name}");
        }
    }

    public class PermenantEmployee1 : Employee1 
    {
        public PermenantEmployee1()
        {            
        }

        public PermenantEmployee1(int id, string name) : base(id, name)
        {            
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee1 : Employee1
    {
        public TemporaryEmployee1()
        {
        }

        public TemporaryEmployee1(int id, string name) : base(id, name)
        {
        }

        public override decimal GetMinimumSalary()
        {
            return 10000;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class ContractBasedEmployee1 : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ContractBasedEmployee1()
        {            
        }

        public ContractBasedEmployee1(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return $"Id = {this.ID} Name = {this.Name}";
        }
    }
}