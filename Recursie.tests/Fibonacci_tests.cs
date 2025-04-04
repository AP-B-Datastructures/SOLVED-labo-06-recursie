using System;
using Recursie.library;

namespace Recursie.tests
{
    [TestClass]
    public class Fibonacci_tests
    {
        [DataTestMethod]
        [DataRow(3, 1)]
        [DataRow(4, 2)]
        [DataRow(5, 3)]
        public void FibonacciNr_Test(int nr, int expected)
        {
            // Act
             int actual = Fibonacci.FibonacciNr(nr);

             // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNr_FirstNumberIs0()
        {
            // Act
             int actual = Fibonacci.FibonacciNr(1);

             // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void FibonacciNr_SecondNumberIs1()
        {
            // Act
             int actual = Fibonacci.FibonacciNr(2);

             // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FibonacciNr_NegativeInputNotAllowed()
        {
            Fibonacci.FibonacciNr(-1);
        }

        // TODO
        public void FibonacciSerie_NegativeInputNotAllowed()
        {
            throw new NotImplementedException();
        }
        
        // TODO
        public void FibonacciNr_TestValidInputReturnsCorrectOutput()
        {
            throw new NotImplementedException();
        }
    }
}
