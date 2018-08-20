using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace zUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassTestMethod1()
        {
           // System.Threading.Thread.Sleep(10 * 1000);
        }

        [TestMethod]
        public void FailTestMethod1()
        {
            Assert.Fail("Faillllllllllllllll");
        }
    }

    [TestClass]
    public class UnitTest12
    {
        [TestMethod]
        public void PassTestMethod1()
        {
            // System.Threading.Thread.Sleep(10 * 1000);
        }

        [TestMethod]
        public void FailTestMethod1()
        {
            Assert.Fail("Faillllllllllllllll");
        }
    }

    [TestClass]
    public class UnitTest13
    {
        [TestMethod]
        public void PassTestMethod1()
        {
            // System.Threading.Thread.Sleep(10 * 1000);
        }

        [TestMethod]
        public void FailTestMethod1()
        {
            Assert.Fail("Faillllllllllllllll");
        }
    }
}

namespace zUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassTestMethod1()
        {
            // System.Threading.Thread.Sleep(10 * 1000);
        }

        [TestMethod]
        public void FailTestMethod1()
        {
            Assert.Fail("Faillllllllllllllll");
        }
	}

    [TestClass]
    public class UnitTest12
    {
        [TestMethod]
        public void PassTestMethod1()
        {
            // System.Threading.Thread.Sleep(10 * 1000);
        }

        [TestMethod]
        public void FailTestMethod111()
        {
            this.func1();
        }
		
		private void func1()
        {
            func2();
        }
        private void func2()
        {
            func3();
        }
        private void func3()
        {
            func4();
        }
        private void func4()
        {
            func5();
        }
        private void func5()
        {
            func6();
        }
        private void func6()
        {
            func7();
        }
        private void func7()
        {
            func8();
        }
        private void func8()
        {
            func9();
        }
        private void func9()
        {
            func10();
        }
        private void func10()
        {
            func11();
        }
        private void func11()
        {
            func12();
        }
        private void func12()
        {
            func13();
        }
        private void func13()
        {
            func14();
        }
        private void func14()
        {
            func15();
        }
        private void func15()
        {
            func16();
        }
        private void func16()
        {
            func17();
        }
        private void func17()
        {
            func18();
        }
        private void func18()
        {
            func19();
        }
        private void func19()
        {
            throw new Exception("bladklasjkldjaskljdkljaskld askldjaskljdklasjd askdjklasjdklasjkldjklasjd asdnklasjdklasjld sdklasjdklasjdkljaskld asldkjaskldjklasjdkljas daskljdklasjdklas daskldjaskljdklasjd aslkdjaskljdl aslkdjaskljdklas askldjaskljdklasd asdjklasjdklasjd askldjaskljdklasjd askldjklasjdkl\n" +
                "sjdhjksahdjkhasjkd sadhjkashdjkashjkd sakjdshajkd");
        }
    }

    [TestClass]
    public class UnitTest13
    {
        [TestMethod]
        public void PassTestMethod1()
        {
            // System.Threading.Thread.Sleep(10 * 1000);
        }

        [TestMethod]
        public void FailTestMethod1()
        {
            Assert.Fail("Faillllllllllllllll");
        }
    }

}
