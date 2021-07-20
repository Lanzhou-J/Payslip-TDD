namespace Payslip_TDD
{
    public class SalaryPackage
    {
        public int AnnualSalary { get; private set; }
        public double SuperRate { get; private set; }

        public SalaryPackage(int annualSalary, double superRate)
        {
            AnnualSalary = annualSalary;
            SuperRate = superRate;
        }
        
    }
}