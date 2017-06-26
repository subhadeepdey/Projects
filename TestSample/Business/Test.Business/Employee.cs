using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DataAccess.Interface;

namespace Test.Business
{
    public class Employee : Test.Business.Interface.IEmployee
    {
        private IEmployee employeeDA { get; set; }
        public Employee(IEmployee empDA)
        {
            employeeDA = empDA;
        }
        public List<Test.Entity.Employee> GetAllEmployee()
        {
            return employeeDA.GetAll();
        }

        public string GetEmployeeNameByID(int empID)
        {
            return employeeDA.GetEmployeeNameByID(empID);
        }
    }
}
