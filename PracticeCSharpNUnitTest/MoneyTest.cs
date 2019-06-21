using NUnit.Framework;
using PracticeCSharp.StudyClass;

namespace Tests
{
    public class MoneyTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddMoney()
        {
            Money money1 = new Money(100, Currency.RMB);
            Money money2 = new Money(200, Currency.RMB);

            Money sum = money1 + money2;

            Assert.AreEqual(200, sum.FaceValue);
            Assert.AreEqual(Currency.RMB, sum.Currency);
        }
    }
}