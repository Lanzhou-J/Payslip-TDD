using System;

namespace Payslip_TDD.InputOutput
{
    public class ConsoleInput : IInput
    {
        public string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
