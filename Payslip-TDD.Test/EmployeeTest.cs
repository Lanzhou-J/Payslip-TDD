using System;
using Xunit;

namespace Payslip_TDD.Test
{
    public class EmployeeTest
    {
        [Theory]
        [InlineData("Tom", "Smith", "Tom Smith")]
        [InlineData("Rex", "Smith", "Rex Smith")]
        public void EmployeeConstructorShould_CombineFirstNameAndLastNameWithASpaceInTheMiddleToSetFullName(string firstName, string lastName, string expectedResult)
        {
            var employee = new Employee(firstName, lastName);
            var result = employee.FullName;
            Assert.Equal(expectedResult, result);
        }
    }
}