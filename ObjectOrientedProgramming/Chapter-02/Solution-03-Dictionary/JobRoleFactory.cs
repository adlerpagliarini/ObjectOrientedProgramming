using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientedProgramming_Solution_03
{

    public class JobRoleFactory
    {
        public static IDictionary<JobRoles, ICalculationRule> DictionaryFactory = new Dictionary<JobRoles, ICalculationRule>{
            { JobRoles.DEVELOPER, new TenOrTwentyPercent() },
            { JobRoles.TESTER, new TenOrTwentyPercent() },
            { JobRoles.DBA, new FifteenOrTwentyFivePercent() }
        };
    }
}
