using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity;

namespace Test.Business.Interface
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployee();
    }
}
