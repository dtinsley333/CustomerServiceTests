using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using CustomerServiceConsole;


namespace CustomerServiceTests
{
    public class EmployeeTests
    {


        Employee emp = new Employee
        {
            EmployeeId = 123,
            FirstName = "Bob",
            LastName = "Smith",
            DepartmentName = "Accounting"
        };


        [Fact]
        public void TrueTest()
        {
            bool isMonday = true;
            Assert.True(isMonday);
        }

        [Fact]
        public void CanCreateEmployee()
        {
            Assert.NotNull(emp);
        }

        [Fact]
        public void EmployeeHasADepartment()
        {
            Assert.NotNull(emp.DepartmentName);
        }
    }
}

