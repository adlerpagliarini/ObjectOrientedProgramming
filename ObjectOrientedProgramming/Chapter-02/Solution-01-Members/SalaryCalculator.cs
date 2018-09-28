using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientedProgramming_Solution_01
{
    public class SalaryCalculator
    {
        public double CalculateSalaryAfterDiscount(Employee employee)
        {
            if (employee.Role == JobRoles.DEVELOPER)
                return JobRoleFactory.DEVELOPER.GetRuleCalculation().CalculateSalaryDiscount(employee);
            if(employee.Role == JobRoles.TESTER)
                return JobRoleFactory.TESTER.GetRuleCalculation().CalculateSalaryDiscount(employee);
            if (employee.Role == JobRoles.DBA)
                return JobRoleFactory.DBA.GetRuleCalculation().CalculateSalaryDiscount(employee);
            throw new NotImplementedException();
        }
    }
}
