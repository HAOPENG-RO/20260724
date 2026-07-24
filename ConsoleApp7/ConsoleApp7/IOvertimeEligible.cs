using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal interface IOvertimeEligible
    {
        void AddOvertimeHours(int hours);
        int GetOvertimeHours();
    }
}
