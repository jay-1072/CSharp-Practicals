using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liskov_Substitution;

namespace Liskov_Substitution
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("Id = {0} Name = {1}", this.Id, this.Name);
        }
    }

    public class PermenantEmployee : Employee
    {
        public PermenantEmployee()
        {
        }

        public PermenantEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {
        }

        public TemporaryEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class ContractBasedEmployee : Employee
    {
        public ContractBasedEmployee()
        {
        }

        public ContractBasedEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}