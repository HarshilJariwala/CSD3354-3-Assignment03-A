using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfrange()
        {
            double beginningBalance = 11.99;
            double debitamount = -100.00;
            //double expected = 7.44;

            Class1 account = new Class1("Mr. Bryan Walton", beginningBalance);

            account.Debit(debitamount);

            double actual = account.balance;
          //  Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
       [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanZero_ShouldThrowArgumentOutOfrange()
        {
            double beginningBalance = 11.99;
            double debitAmount = 100.00;

            Class1 account = new Class1("Mr. Bryan Walton", beginningBalance);

            account.Debit(debitAmount);

            double actual = account.balance;
        }
    }
}
