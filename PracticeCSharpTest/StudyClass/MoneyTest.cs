using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PracticeCSharp.StudyClass;


namespace PracticeCSharpTest.StudyClass
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestAddMoney()
        {
            Money money1 = new Money(100, Currency.RMB);
            Money money2 = new Money(200, Currency.RMB);

            Money sum = money1 + money2;

            Assert.AreEqual(300, sum.FaceValue);
            Assert.AreEqual(Currency.RMB, sum.Currency);
        }

        [TestMethod]
        [ExpectedException(typeof(MoneyException))]
        public void TestThrowException()
        {
            Money money1 = new Money(100, Currency.RMB);
            Money money2 = new Money(200, Currency.ERU);

            Money sum = money1 + money2;

        }
    }
}
