using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Test.Business.Interface;
using Test.Entity;
using System.Collections.Generic;

namespace Test.UnitTest.Business
{
    [TestClass]
    public class UnitTestEmployee
    {
        [TestMethod]
        [Description("Get All Employee")]
        public void GetAllEmployee()
        {
            List<Employee> listEmp = new List<Employee>();
            listEmp.Add(new Employee { ID = 1, Name = "John Donne", Address = "Texas", Phone = "972-434-5654" });
            listEmp.Add(new Employee { ID = 1, Name = "Ann Donne", Address = "New Jersey", Phone = "973-292-1093" });
            var empDAMock = new Mock<Test.DataAccess.Interface.IEmployee>();
            empDAMock = new Mock<Test.DataAccess.Interface.IEmployee>(MockBehavior.Strict);
            empDAMock.Setup(u => u.GetAll()).Returns(listEmp);

            var employeeBusiness = new Test.Business.Employee(empDAMock.Object);
            var result = employeeBusiness.GetAllEmployee();

            Assert.AreEqual(result, listEmp); //should be true
        }

        [TestMethod]
        [Description("Get Name of the Employee by ID")]
        public void GetEmployeeNameByID()
        {
            string expectedEmpName = "Jill Dattm";
            var empDAMock = new Mock<Test.DataAccess.Interface.IEmployee>();
            empDAMock = new Mock<Test.DataAccess.Interface.IEmployee>(MockBehavior.Strict);
            empDAMock.Setup(u => u.GetEmployeeNameByID(1)).Returns(expectedEmpName);

            var employeeBusiness = new Test.Business.Employee(empDAMock.Object);
            var result = employeeBusiness.GetEmployeeNameByID(1);
            
            Assert.AreEqual(result, expectedEmpName); //should be true
        }
    }
}
