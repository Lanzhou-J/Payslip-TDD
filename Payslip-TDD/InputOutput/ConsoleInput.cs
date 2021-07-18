using System;

namespace Payslip_TDD.InputOutput
{
    public class ConsoleInput : IInput
    {
        public string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
