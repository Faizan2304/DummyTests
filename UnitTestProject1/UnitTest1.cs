using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static TestContext tc;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            tc = context;
        }

        [TestMethod]
        public void PassTestMethod1()
        {
        }

        [TestMethod]
        public void PassTestMethod2()
        {
            tc.AddResultFile("faizanPass21.txt");
        }

        [TestMethod]
        public void PassTestMethod3()
        {
            tc.AddResultFile("faizanPass31.txt");
            tc.AddResultFile("faizanPass32.txt");
            tc.AddResultFile("faizanPass33.txt");
        }

        [TestMethod]
        public void FailMethod1()
        {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void FailMethod2()
        {
            tc.AddResultFile("faizan21.txt");
            Console.WriteLine("Need some attachments");
            Assert.Fail("Failing Test method");
        }

        [TestMethod]
        public void FailMethod3()
        {
            Console.WriteLine("For first attachment");
            Console.Error.WriteLine("For second attachment");
            tc.AddResultFile("faizan31.txt");
            tc.AddResultFile("faizan31.txt");
            tc.AddResultFile("faizan33.txt");
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void InConclusiveMethod1()
        {
            Assert.Inconclusive("InConclusive Test method");
        }
    }
}
