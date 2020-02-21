using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitDemoExample;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemoExample.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            int a = 10;
            int b = 20;
            DemoCalculator demoCalculator = new DemoCalculator();
            int result =demoCalculator.Sum(a, b);
            Assert.AreEqual(30,result);
        }
    }
}