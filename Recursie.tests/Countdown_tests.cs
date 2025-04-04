using System;
using Recursie.library;

namespace Recursie.tests
{
    [TestClass]
    public class Countdown_tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            Countdown.StartCountdown(-1);
        }
    }
}
