using System;
using Recursie.library;

namespace Recursie.tests
{
    [TestClass]
    public class Teller_tests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            Teller.UpCounter(-1);
        }
    }
}
