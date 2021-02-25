using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzRV;
using System.IO;
using Moq;
using Times = Moq.Times;

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

        [TestMethod]
        public void FizzBuzzWith15()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Ask(15));
        }

        [TestMethod]
        public void FizzBuzzWith4()
        {
            Assert.AreEqual("4", FizzBuzz.Ask(4));
        }

        [TestMethod]
        public void GameConsoleWriteWelcomeInFizzBuzz()
        {
            var writer = new Mock<IOutputWriter>();
            var mock = new Mock<FizzBuzz>(writer.Object, new object[] { "Welcome to Fizzbuzz ! Press any key to launch.", true });
            mock.CallBase = true;
            var Game = mock.Object;

            Game.Jeu();

            mock.Verify(m => m.Jeu(), Times.Exactly(1));
            writer.Verify(w => w.WriteLine(It.Is<string>(s => s == "Welcome to Fizzbuzz ! Press any key to launch.")), Times.Once);
        }
    }
}
