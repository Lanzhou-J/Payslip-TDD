using System.Collections.Generic;
using Payslip_TDD.InputOutput;

namespace Payslip_TDD.Test
{
    public class MockInput:IInput
    {
        private readonly Queue <string>_testResponses = new Queue<string>();
        
        public MockInput(IEnumerable<string> testResponse)
        {
            foreach (var response in testResponse)
            {
                _testResponses.Enqueue(response);
            }
        }
        public string Ask(string question)
        {
            var response = _testResponses.Dequeue();
            return response;
        }
    }
}