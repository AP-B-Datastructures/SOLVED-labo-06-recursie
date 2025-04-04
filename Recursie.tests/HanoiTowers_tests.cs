using System;
using Recursie.library;

namespace Recursie.tests
{
    [TestClass]
    public class HanoiTowers_tests
    {
        [TestMethod]
        public void Hanoi_MinimumIs2nMinus1()
        {
            int discs = 3;

            int result = HanoiTowers.CalculateHanoiNumberOfSteps(discs);

            int solution = (int)Math.Pow(2, discs) - 1;

            Assert.AreEqual(result, solution);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Hanoi_NegativeInputIsInvalid()
        {
            HanoiTowers.CalculateHanoiNumberOfSteps(-1);
        }
    }
}
