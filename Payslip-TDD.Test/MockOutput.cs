using Payslip_TDD.InputOutput;

namespace Payslip_TDD.Test
{
    public class MockOutput : IOutput
    {
        public void Write(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}