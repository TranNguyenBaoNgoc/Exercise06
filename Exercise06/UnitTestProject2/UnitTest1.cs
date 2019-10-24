using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem02;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStack()
        {
            Stack s = new Stack(5);
            s.Put(5);
            s.Put(4);
            s.Put(7);
            s.Put(51);
            s.Put(9);
            Assert.IsNotNull(s);
            Assert.IsInstanceOfType(s, typeof(Stack));
            Assert.AreEqual(5, s.Count());
        }

        [TestMethod]
        public void TestMethodPop()
        {
            Stack s = new Stack(5);
            s.Put(5);
            s.Put(4);
            s.Put(7);
            s.Put(51);
            s.Put(9);
            Assert.AreEqual(9, s.Pop());
            Assert.AreEqual(4, s.Count());
        }

        [TestMethod]
        public void TestMethodPeek()
        {
            Stack s = new Stack(5);
            s.Put(5);
            s.Put(4);
            s.Put(7);
            s.Put(51);
            s.Put(9);
            Assert.AreEqual(9, s.Peek());
            Assert.AreEqual(5, s.Count());
        }

        [TestMethod]
        public void TestMethodClear()
        {
            Stack s = new Stack(5);
            s.Put(5);
            s.Put(4);
            s.Put(7);
            s.Put(51);
            s.Put(9);
            s.Clear();
            Assert.AreEqual(0, s.Count());
        }
    }
}
