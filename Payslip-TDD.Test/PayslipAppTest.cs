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
            var input = new MockInput(new[]{firstName, lastName});
            var output = new MockOutput();
            
            var payslipApp = new PayslipApp(input, output);
            var payslip = payslipApp.GeneratePayslip();
            var result = payslip.ToString();
            const string expectedResult = "Name: Tom Smith";
             
            Assert.Equal(expectedResult, result);
        }      
    }
}