using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity;

namespace Test.DataAccess.Interface
{
    public interface IEmployee
    {
        List<Employee> GetAll();
        string GetEmployeeNameByID(int empID);
    }
}
