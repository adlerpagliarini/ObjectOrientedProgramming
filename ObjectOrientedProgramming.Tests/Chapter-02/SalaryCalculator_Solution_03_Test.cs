using NUnit.Framework;
using ObjectOrientedProgramming_Solution_03;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Tests
{
    public class SalaryCalculator_Solution_03_Test
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
            var returnTypeDeveloper = JobRoleFactory.DictionaryFactory[JobRoles.DEVELOPER];
            var returnTypeTester = JobRoleFactory.DictionaryFactory[JobRoles.TESTER];
            var returnTypeDBA = JobRoleFactory.DictionaryFactory[JobRoles.DBA];

            Assert.IsInstanceOf<TenOrTwentyPercent>(returnTypeDeveloper);
            Assert.IsInstanceOf<TenOrTwentyPercent>(returnTypeTester);
            Assert.IsInstanceOf<FifteenOrTwentyFivePercent>(returnTypeDBA);
        }
    }
}
