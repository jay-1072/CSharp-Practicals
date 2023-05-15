using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOCP
{
	public enum EmployeeType
	{
		Permenant,
		ContractBased,
		Temporary
	}

    public class Employee1
    {
		private long id;
		 
		public long Id
		{
			get => id;
			init => id = value;
		}
        public string? Name { get; set; }
		public decimal Salary { get; set; }

		public EmployeeType Type { get; set; }

		public Employee1()
		{
		}

		public Employee1(long id, string name, decimal salary, EmployeeType type)
		{
			Id = id;
			Name = name;
			Salary = salary;
			Type = type;
		}

		public decimal CalculateBonus(decimal salary, EmployeeType employeeType)
		{
			decimal bonus = 0;

			if(employeeType == EmployeeType.Permenant)
			{
				bonus = Math.Round(salary * .1M, 2);
			}
			else if(employeeType == EmployeeType.ContractBased)
			{
				bonus = Math.Round(salary * .05M, 2);
			}
			else if(employeeType == EmployeeType.Temporary)
			{
				bonus = Math.Round(salary * .03M, 2);
			}

			return bonus;
		}
    }
}
