using NUnit.Framework;
using PracticeCSharp;
using System;

namespace TestPracticeCSharp
{
    public class NumberListTest
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Should_Yield_Even_List()
        {
            foreach (var i in NumberList.GetEven())
            {
                Console.WriteLine(i);
            }

        }
    }
}