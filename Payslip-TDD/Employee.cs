using System;

namespace Payslip_TDD
{
    public class Employee
    {
        private readonly string _lastName;
        private readonly string _firstName;

        public Employee(string firstName, string lastName)
        {
            _lastName = lastName;
            _firstName = firstName;
            FullName = CreateFullName();
        }
        
        public string FullName { get; }

        private string CreateFullName()
        {
            var fullName = "";
            fullName = _firstName + " " +  _lastName;
            return fullName;
        }



    }
}