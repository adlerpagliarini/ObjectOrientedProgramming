using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class TenOrTwentyPercent : ICalculationRule
    {
        public double CalculateSalaryDiscount(Employee employee)
        {
            if (employee.Salary > 3000.0)
                return employee.Salary * 0.8;
            return employee.Salary * 0.9;
        }
    }
}
