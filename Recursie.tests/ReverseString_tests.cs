using System;
using Recursie.library;

namespace Recursie.tests
{
    [TestClass]
    public class ReverseString_tests
    {
        [TestMethod]
        public void ReverseText_ReverseEmptyTextIsEmpty()
        {
            //arrange
            string input = "hallo";
            string expected = "ollah";

            //act
            string result = ReverseString.ReverseText(input);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
