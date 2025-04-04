using System;
using Recursie.library;

namespace Recursie.tests
{
    [TestClass]
    public class Faculteit_tests
    {

        [DataTestMethod]
        [DataRow(3, 6)]
        [DataRow(4, 24)]
        [DataRow(10, 3628800)]
        public void Faculteit_test(int number, int expected)
        { 
            // Act
             int actual = Faculteit.BerekenFaculteit(number);

             // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Faculteit_0Returns1AsResult()
        { 
            // Act
             int actual = Faculteit.BerekenFaculteit(0);

             // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Faculteit_NegativeNumberThrowsException()
        {
            Faculteit.BerekenFaculteit(-1);
        }
    }
}
