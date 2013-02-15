using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    class TestSuite
    {
        StringCalculator stringCalc;

        [SetUp]
        public void Before()
        {
            stringCalc = new StringCalculator();
        }

        [Test]
        public void ReturnsZero()
        {
            Assert.AreEqual(0, stringCalc.add(""));
        }

        [Test]
        public void ReturnsOneNUmber()
        {
            Assert.AreEqual(1, stringCalc.add("1"));
        }

        [Test]
        public void ReturnsSumTwoNumbers()
        {
            Assert.AreEqual(3, stringCalc.add("1,2"));
        }

        [Test]
        public void ReturnsSumSomeNumbers()
        {
            Assert.AreEqual(18, stringCalc.add("1,2,4,5,6"));
        }

        [Test]
        public void ReturnsSumTwoNumbersNewLine()
        {
            Assert.AreEqual(3, stringCalc.add("1\n2"));
        }

        [Test]
        public void ReturnsSumThreeNumbersMixedDelimiters()
        {
            Assert.AreEqual(6, stringCalc.add("1\n2,3"));
        }

        [Test]
        public void ReturnSumDifferentDelimiters()
        {
            Assert.AreEqual(3, stringCalc.add("//;\n1;2"));
        }
    }
}
