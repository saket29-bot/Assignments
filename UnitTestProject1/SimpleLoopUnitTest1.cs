using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleLoop.UnitTestProject1
{
    [TestClass]
    public class SimpleLoopUnitTest1
    {
        [TestMethod]
        public void LoopNotExecuted()
        {
            SimpleLoopTest c = new SimpleLoopTest();
            Assert.AreEqual(0, c.FindSum(0));
        }
        [TestMethod]
        public void NegativeIteration()
        {
            SimpleLoopTest c = new SimpleLoopTest();
            Assert.AreEqual(0, c.FindSum(-1));   
        }
        [TestMethod]
        public void LoopRunOnce()
        {
            SimpleLoopTest c = new SimpleLoopTest();
            int expected = 5;
            int actual = c.FindSum(1);
            Assert.AreEqual(actual, expected); 
        }
        [TestMethod]
        public void LoopRunTwice()
        {
            SimpleLoopTest c = new SimpleLoopTest();
            Assert.AreEqual(5, c.FindSum(1));

        }
        [TestMethod]
        public void LoopRunsNTimes()
        {
            SimpleLoopTest c = new SimpleLoopTest();
            Assert.AreEqual(17, c.FindSum(5));
        }
        [TestMethod]
        public void LoopRunsOneLessThanMax()
        {
            SimpleLoopTest s=new SimpleLoopTest();
            Assert.AreEqual(26, s.FindSum(9));
        }
        [TestMethod]
        public void LoopRunsTenTime()
        {
            SimpleLoopTest c = new SimpleLoopTest();
            Assert.AreEqual(36,c.FindSum(10));
        }
        [TestMethod]
        public void LoopRunsOneMoreThanMax()
        {
            SimpleLoopTest c = new SimpleLoopTest();
            Assert.AreEqual(0, c.FindSum(11));
        }
    }
}
