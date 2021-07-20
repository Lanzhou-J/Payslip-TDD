using Xunit;

namespace Payslip_TDD.Test
{
    public class PayslipAppTest
    {
        [Fact]
        public void GeneratePayslipShould_CreateAPayslipWithFullName_WhenInputContainsFirstNameAndLastName()
        {
            const string firstName = "Tom";
            const string lastName = "Smith";
            const string annualSalary = "60050";
            const string superRate = "9";
            var input = new MockInput(new[]{firstName, lastName, annualSalary, superRate});
            var output = new MockOutput();
            
            var payslipApp = new PayslipApp(input, output);
            var payslip = payslipApp.GeneratePayslip();
            var result = payslip.ToString();
            const string expectedResult = "Name: Tom Smith";
             
            Assert.Equal(expectedResult, result);
        }
        
        [Fact]
        public void GenerateEmployeeShould_CreateEmployeeWithCorrectFullName_WhenInputContainsFirstNameAndLastName()
        {
            const string firstName = "Tom";
            const string lastName = "Smith";
            const string annualSalary = "60050";
            const string superRate = "9";
            var input = new MockInput(new[]{firstName, lastName, annualSalary, superRate});
            var output = new MockOutput();
            
            var payslipApp = new PayslipApp(input, output);
            var employee = payslipApp.GenerateEmployee();

            Assert.Equal("Tom Smith", employee.FullName);
        }
    }
}