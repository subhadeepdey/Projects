using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DataAccess.Interface;
namespace Test.DataAccess
{
    public class Employee : IEmployee
    {
        public List<Test.Entity.Employee> GetAll()
        {
            throw new  NotImplementedException();
        }
        public string GetEmployeeNameByID(int empID)
        {
            throw new NotImplementedException();
        }
    }
}
