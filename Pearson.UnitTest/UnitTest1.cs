using CorrelationEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pearson.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Corelation_value_Test()
        {
            int[] a1 = { 15, 18, 21, 24, 27 };
            int[] a2 = { 25, 25, 27, 31, 32 };
            PearsonRecomender p = new PearsonRecomender();
            double Actual = 0.953463;
            Assert.AreEqual(Actual, p.GetCorrelation(a1, a2));
        }
        [TestMethod]
        public void When_baseLength_More()
        {
            int[] a1 = { 15, 18, 21, 24, 27,34,35 };
            int[] a2 = { 25, 25, 27, 31, 32 };
            PearsonRecomender p = new PearsonRecomender();
            double Actual = -0.766548;
            Assert.AreEqual(Actual, p.GetCorrelation(a1, a2));
        }
        [TestMethod]
        public void When_Zero_arrayValie()
        {
            int[] a1 = { 15, 18, 21, 0, 27, 34, 35 };
            int[] a2 = { 25, 25, 27, 31, 32 };
            PearsonRecomender p = new PearsonRecomender();
            double Actual = -0.76909;
            Assert.AreEqual(Actual, p.GetCorrelation(a1, a2));
        }
    }
}
