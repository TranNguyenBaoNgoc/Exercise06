using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem03;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQueue()
        {
            MyQueue q = new MyQueue(5);
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("c");
            q.Enqueue("d");
            q.Enqueue("e");
            Assert.IsNotNull(q);
            Assert.IsInstanceOfType(q, typeof(MyQueue));
            Assert.AreEqual(5, q.Count());
        }

        [TestMethod]
        public void TestMethodDeQueue()
        {
            MyQueue q = new MyQueue(5);
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("c");
            q.Enqueue("d");
            q.Enqueue("e");
            Assert.AreEqual("a", q.Dequeue());
            Assert.AreEqual(4, q.Count());
            Assert.AreEqual("b", q.Dequeue());
            Assert.AreEqual(3, q.Count());
        }

        [TestMethod]
        public void TestMethodPeek()
        {
            MyQueue q = new MyQueue(5);
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("c");
            q.Enqueue("d");
            q.Enqueue("e");
            Assert.AreEqual("a", q.Peek());
            Assert.AreEqual(5, q.Count());
        }

        [TestMethod]
        public void TestMethodClear()
        {
            MyQueue q = new MyQueue(5);
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("c");
            q.Enqueue("d");
            q.Enqueue("e");
            q.Clear();
            Assert.AreEqual(0, q.Count());
        }
    }
}
