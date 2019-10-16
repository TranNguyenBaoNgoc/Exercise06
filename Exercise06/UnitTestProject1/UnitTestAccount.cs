using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }

        [TestMethod]
        public void TestMethodWithDraw()
        {
            Account acc = new Account(200000);
            acc.WithDraw(20000);
            Assert.AreEqual(180000, acc.Balance());
        }

        [TestMethod]
        public void TestMethodDeposit()
        {
            Account acc = new Account(200000);
            acc.Deposit(40000);
            Assert.AreEqual(240000, acc.Balance());
        }

        [TestMethod]
        public void TestMethodBalance()
        {
            Account acc = new Account(200000);
            acc.WithDraw(20000);
            acc.Deposit(40000);
            Assert.AreEqual(220000, acc.Balance());
        }

    }
}
