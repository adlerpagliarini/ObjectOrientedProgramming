using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientedProgramming_Solution_03
{
    public class SalaryCalculator
    {
        public double CalculateSalaryAfterDiscount(Employee employee)
        {
            return JobRoleFactory.DictionaryFactory[employee.Role].CalculateSalaryDiscount(employee);
        }
    }
}
