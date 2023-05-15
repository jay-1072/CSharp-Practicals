using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_DIP
{
    public class Employee
    {
		private long id;
		public long Id
		{
			get => id;
			set => id = value;
		}
		public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }

	public class EmployeeDAL
	{
        public Employee GetEmployeeDetails(long id)
        {
            Employee employee = new Employee()
            {
                Id = id,
                Name = "Alice",
                Department = "JAVA",
                Salary = 50000
            };

            return employee;
        }
    }

    public class DataAccessFactory
    {
        public static EmployeeDAL GetEmployeeDataAccessObj()
        {
            return new EmployeeDAL();
        }
    }

    public class EmployeeBL
    {
        EmployeeDAL employeeDAL;
        public EmployeeBL()
        {
            employeeDAL = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(long id)
        {
            return employeeDAL.GetEmployeeDetails(id);
        }
    }
}
