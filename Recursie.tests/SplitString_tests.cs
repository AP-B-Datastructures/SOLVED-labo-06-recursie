using System;
using Recursie.library;

namespace Recursie.tests
{
    [TestClass]
    public class SplitString_tests
    {
        private QueueString queue;

        [TestInitialize]
        public void TestInitialize()
        {
            queue = new QueueString();
        }

        [TestMethod]
        public void ReverseTextToQueue_ReversesTextToNewQueue()
        {
            // Arrange
            string text = "abc";

            // Act
            var result = SplitString.ReverseTextToQueue(text);

            // Assert
            queue.Enqueue("c");
            queue.Enqueue("b");
            queue.Enqueue("a");

            Assert.AreEqual(result.Dequeue(), queue.Dequeue());
            Assert.AreEqual(result.Dequeue(), queue.Dequeue());
            Assert.AreEqual(result.Dequeue(), queue.Dequeue());
        }
    }
}
