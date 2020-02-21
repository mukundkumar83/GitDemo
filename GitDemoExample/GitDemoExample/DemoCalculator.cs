using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitDemoExample
{
    public class DemoCalculator
    {
        public int Sum(int a ,int b)
        {
            if(a!=0 && b!=0)
            {
                return a + b;
            }

            return 0;
        }
    }
}
