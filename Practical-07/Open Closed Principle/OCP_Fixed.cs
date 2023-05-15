using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithoutOCP;

namespace WithOCP
{
    public abstract class Employee2
    {
		private long id;

		public long Id
		{
			get => id;
			set => id = value;
		}

        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee2(long id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public abstract decimal CalculateBonus(decimal salary);	
    }

	public class Permenant : Employee2
	{
        public Permenant(long id, string name, decimal salary) : base(id, name, salary)
        {            
        }

        public override decimal CalculateBonus(decimal salary)
		{
			decimal bonus = 0;
			bonus = Math.Round(salary * .1M);
			return bonus;
		}
	}

	public class ContractBased : Employee2
	{
        public ContractBased(long id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
			decimal bonus = 0;
			bonus = Math.Round(salary * .05M, 2);
			return bonus;
        }
    }

	public class Temporary : Employee2
	{
        public Temporary(long id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
			decimal bonus = 0;
			bonus = Math.Round(salary * .03M, 2);
			return bonus;
        }
    }
}
