using System;
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

        public Employee GenerateEmployee()
        {
            var firstName = _input.Ask("Please input your name: ");
            var lastName = _input.Ask("Please input your surname: ");
            var annualSalary = _input.Ask("Please enter your annual salary: ");
            var superRate = _input.Ask("Please enter your super rate: ");
            var salaryPackage = new SalaryPackage(Int32.Parse(annualSalary), Int32.Parse(superRate));
            return new Employee(firstName, lastName, salaryPackage);
        }

        public Payslip GeneratePayslip()
        {
            var employee = GenerateEmployee();
            var name = employee.FullName;
            return new Payslip(name);
        }
    }
}