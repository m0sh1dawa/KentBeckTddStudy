﻿using System;
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
            Dollar product = five.times(2);
            Assert.AreEqual(10, product.Amount);
            product = five.times(3);
            Assert.AreEqual(15, product.Amount);
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
