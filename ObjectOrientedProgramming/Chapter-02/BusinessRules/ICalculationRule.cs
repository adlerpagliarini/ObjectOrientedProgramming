using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public interface ICalculationRule
    {
        double CalculateSalaryDiscount(Employee employee);
    }
}
