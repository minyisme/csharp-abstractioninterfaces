using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractionInterfacesPractice.Tests
{
    [TestClass]
    public class AbstractionTests
    {
        [TestMethod]
        public void TestGetTotalSalaray()
        {
            var workerbee = new WorkerBee("workerbee");
            var boss = new Boss("boss");
            var employees = new Employee[2] { boss, workerbee };
            var employeeManager = new EmployeeManager();

            Assert.AreEqual(employeeManager.GetTotalSalary(employees), 11);
        }

        [TestMethod]
        public void TestFunWithMathsMultiply()
        {
            var evenNums = new EvenNumberProvider();
            var funWithNums = new FunWithMaths();
            var result = funWithNums.MultiplyNumbers(evenNums);

            Assert.AreEqual(3840, result);
        }

        [TestMethod]
        public void TestFunWithMathsMultMock()
        {
            var mockNums = new MockNumberProvider();
            var funWithNums = new FunWithMaths();
            var result = funWithNums.MultiplyNumbers(mockNums);

            Assert.AreEqual(6, result);
        }
    }
}
