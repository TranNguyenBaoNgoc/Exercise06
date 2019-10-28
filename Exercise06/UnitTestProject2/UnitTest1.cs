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
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            Assert.IsNotNull(s);
            Assert.IsInstanceOfType(s, typeof(Stack));
            Assert.AreEqual(5, s.Count());
        }

        [TestMethod]
        public void TestMethodPop()
        {
            Stack s = new Stack(5);
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            Assert.AreEqual("a", s.Pop());
            Assert.AreEqual(4, s.Count());
        }

        [TestMethod]
        public void TestMethodPeek()
        {
            Stack s = new Stack(5);
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            Assert.AreEqual("a", s.Peek());
            Assert.AreEqual(5, s.Count());
        }

        [TestMethod]
        public void TestMethodClear()
        {
            Stack s = new Stack(5);
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Put("a");
            s.Clear();
            Assert.AreEqual(0, s.Count());
        }
    }
}
