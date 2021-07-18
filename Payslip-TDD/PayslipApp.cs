using Payslip_TDD.InputOutput;

namespace Payslip_TDD
{
    public class PayslipApp
    {
        private readonly IInput _input;
        private readonly IOutput _output;
        
        public PayslipApp(IInput input, IOutput output)
        {
            _input = input;
            _output = output;
        }
    }
}