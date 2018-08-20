using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassTestMethod1()
        {
            //System.Threading.Thread.Sleep(10 * 1000);
        }

        [TestMethod]
        public void FailTestMethod1()
        {
            Assert.Fail("Fail test");
        }
    }
}
