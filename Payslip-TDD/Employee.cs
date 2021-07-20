using System;

namespace Payslip_TDD
{
    public class Employee
    {
        private readonly string _lastName;
        private readonly string _firstName;
        public string FullName { get; }
        public SalaryPackage SalaryPackage { get; private set; }

        public Employee(string firstName, string lastName, SalaryPackage salaryPackage)
        {
            _lastName = lastName;
            SalaryPackage = salaryPackage;
            _firstName = firstName;
            FullName = CreateFullName();
        }

        private string CreateFullName()
        {
            var fullName = "";
            fullName = _firstName + " " +  _lastName;
            return fullName;
        }
        
    }
}