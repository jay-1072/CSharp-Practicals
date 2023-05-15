using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_DIP
{   
    public interface IEmployeeDAL
    {
        Employee1 GetEmployeeDetails(long id);
    }

    public class Employee1
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

    public class EmployeeDAL1 : IEmployeeDAL
    {
        public Employee1 GetEmployeeDetails(long id)
        {
            Employee1 employee = new Employee1()
            {
                Id = id,
                Name = "Bob",
                Department = "ASP.Net",
                Salary = 50000
            };

            return employee;
        }
    }

    public class DataAccessFactory
    {
        public static IEmployeeDAL GetEmployeeDataAccessObj()
        {
            return new EmployeeDAL1();
        }
    }

    public class EmployeeBL1
    {
        IEmployeeDAL employeeDAL;
        public EmployeeBL1()
        {
            employeeDAL = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee1 GetEmployeeDetails(long id)
        {
            return employeeDAL.GetEmployeeDetails(id);
        }
    }
}