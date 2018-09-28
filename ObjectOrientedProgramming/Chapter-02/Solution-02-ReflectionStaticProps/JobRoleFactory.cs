using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientedProgramming_Solution_02
{

    public class JobRoleFactory
    {
        private static ICalculationRule _developer;
        public static ICalculationRule DEVELOPER
        {
            get
            {
                if (_developer == null) _developer = new TenOrTwentyPercent();
                return _developer;
            }
        }

        private static ICalculationRule _tester;
        public static ICalculationRule TESTER
        {
            get
            {
                if (_tester == null) _tester = new TenOrTwentyPercent();
                return _tester;
            }
        }

        private static ICalculationRule _dba;
        public static ICalculationRule DBA
        {
            get
            {
                if (_dba == null) _dba = new FifteenOrTwentyFivePercent();
                return _dba;
            }
        }
        
        public ICalculationRule GetRuleCalculation(Employee e)
        {
            string employeeType = e.Role.ToString();
            var _typeof = (typeof(JobRoleFactory));
            var property = _typeof.GetProperty(employeeType, BindingFlags.Public | BindingFlags.Static);
            return property.GetValue(null, null) as ICalculationRule;
        }
    }
}
