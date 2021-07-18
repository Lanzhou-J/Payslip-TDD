using System;
using Payslip_TDD.InputOutput;

namespace Payslip_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ConsoleInput();
            var output = new ConsoleOutput();
            var payslipApp = new PayslipApp(input, output);
            
        }
    }
}