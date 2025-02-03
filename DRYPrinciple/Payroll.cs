namespace DRYPrinciple
{
    public class Payroll
    {
        private const decimal TAX = 0.18m, BONUS = 0.5m;

        private decimal CalculateBaseSalary(decimal salary)
        {
            decimal total = (salary - (salary * TAX)) + (salary * BONUS);
            return total;
        }

        public decimal CalculateSalaryForFullTime(decimal baseSalary) => baseSalary + CalculateBaseSalary(baseSalary);

        public decimal CalculateSalaryForPartTime(decimal hourlyRate, decimal hoursWorked) => CalculateBaseSalary(hourlyRate * hoursWorked);
    }
}
