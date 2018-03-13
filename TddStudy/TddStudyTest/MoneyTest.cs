using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddStudy.Money;

namespace TddStudyTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.AreEqual(10, five.amount);
            five.times(3);
            Assert.AreEqual(15, five.amount);
        }
    }
}
