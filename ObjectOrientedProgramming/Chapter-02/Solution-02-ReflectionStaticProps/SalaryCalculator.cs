using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientedProgramming_Solution_02
{
    public class SalaryCalculator
    {
        public double CalculateSalaryAfterDiscount(Employee employee)
        {
            return new JobRoleFactory().GetRuleCalculation(employee).CalculateSalaryDiscount(employee);
        }
    }
}
