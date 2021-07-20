namespace Payslip_TDD
{
    public class Payslip
    {
        private string Name;

        public Payslip(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}