using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming_Solution_01
{
    
    public class JobRoleFactory
    {
        public readonly static JobRoleFactory DEVELOPER = new JobRoleFactory(new TenOrTwentyPercent());
        public readonly static JobRoleFactory TESTER = new JobRoleFactory(new TenOrTwentyPercent());
        public readonly static JobRoleFactory DBA = new JobRoleFactory(new FifteenOrTwentyFivePercent());

        private readonly ICalculationRule _calculationRule;
        private JobRoleFactory(ICalculationRule calculationRule)
        {
            _calculationRule = calculationRule;
        }

        public ICalculationRule GetRuleCalculation()
        {
            return _calculationRule;            
        }
    }
}
