using NUnit.Framework;
using ObjectOrientedProgramming_Solution_02;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Tests.Chapter_02
{
    public class SalaryCalculator_Solution_02_Test
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
            var jobRoleFactory = new JobRoleFactory();
            var returnTypeDeveloper = jobRoleFactory.GetRuleCalculation(new Employee() { Salary = 0, Role = JobRoles.DEVELOPER });
            var returnTypeTester = jobRoleFactory.GetRuleCalculation(new Employee() { Salary = 0, Role = JobRoles.TESTER });
            var returnTypeDBA = jobRoleFactory.GetRuleCalculation(new Employee() { Salary = 0, Role = JobRoles.DBA });

            Assert.IsInstanceOf<TenOrTwentyPercent>(returnTypeDeveloper);
            Assert.IsInstanceOf<TenOrTwentyPercent>(returnTypeTester);
            Assert.IsInstanceOf<FifteenOrTwentyFivePercent>(returnTypeDBA);
        }
    }
}
