using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class FifteenOrTwentyFivePercent : ICalculationRule
    {
        public double CalculateSalaryDiscount(Employee employee)
        {
            if (employee.Salary > 3000.0)
                return employee.Salary * 0.75;
            return employee.Salary * 0.85;
        }
    }
}
