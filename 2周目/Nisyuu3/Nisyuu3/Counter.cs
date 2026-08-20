using System;
using System.Collections.Generic;
using System.Text;

namespace Nisyuu3
{
    internal class Counter
    {
        static int count = 0;

        public Counter()
        {
            count++;
        }
        public static int GetCount()
        {
            return count;
        }
    }
}
