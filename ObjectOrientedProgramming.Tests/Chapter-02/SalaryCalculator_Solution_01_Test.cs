using NUnit.Framework;
using ObjectOrientedProgramming_Solution_01;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Tests
{
    public class SalaryCalculator_Solution_01_Test
    {
        [Test]
        public void CalculateSalaryDiscountForDeveloper()
        {
            var employee = new Employee() { Salary = 3000, Role = JobRoles.DEVELOPER };
            var salaryCalculator = new SalaryCalculator();
            var result = salaryCalculator.CalculateSalaryAfterDiscount(employee);
            Assert.AreEqual(2700.0, result);
        }

        [Test]
        public void CalculateSalaryDiscountForTester()
        {
            var employee = new Employee() { Salary = 3000, Role = JobRoles.TESTER };
            var salaryCalculator = new SalaryCalculator();
            var result = salaryCalculator.CalculateSalaryAfterDiscount(employee);
            Assert.AreEqual(2700.0, result);
        }

        [Test]
        public void CalculateSalaryDiscountForDBA()
        {
            var employee = new Employee() { Salary = 3000, Role = JobRoles.DBA };
            var salaryCalculator = new SalaryCalculator();
            var result = salaryCalculator.CalculateSalaryAfterDiscount(employee);
            Assert.AreEqual(2550, result);
        }

        [Test]
        public void ValidInstanceOf_Factory()
        {
            var returnTypeDeveloper = JobRoleFactory.DEVELOPER.GetRuleCalculation();
            var returnTypeTester = JobRoleFactory.TESTER.GetRuleCalculation();
            var returnTypeDBA = JobRoleFactory.DBA.GetRuleCalculation();

            Assert.IsInstanceOf<TenOrTwentyPercent>(returnTypeDeveloper);
            Assert.IsInstanceOf<TenOrTwentyPercent>(returnTypeTester);
            Assert.IsInstanceOf<FifteenOrTwentyFivePercent>(returnTypeDBA);
        }
    }
}
