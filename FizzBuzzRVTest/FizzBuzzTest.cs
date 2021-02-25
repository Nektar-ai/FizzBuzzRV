using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzRV;

namespace FizzBuzzRVTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowArgumentExceptionFizzBuzzWith0()
        {
            FizzBuzz.Ask(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowArgumentExceptionFizzBuzzWithNeg1()
        {
            FizzBuzz.Ask(-1);
        }

        [TestMethod]
        public void FizzBuzzWith3()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Ask(3));
        }

        [TestMethod]
        public void FizzBuzzWith5()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Ask(5));
        }
    }
}
