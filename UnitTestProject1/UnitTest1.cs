using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void Debit_withvalidAmount_updateBalance()
        {
            double beginningBalance = 11.99;
            double debitamount = -100.00;
            double expected = 7.44;

            Class1 account = new Class1("Mr. Bryan Walton", beginningBalance);

            account.Debit(debitamount);

            double actual = account.balance;
          
           Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
       [TestMethod]
        
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 11.99;
            double debitAmount = 20.00;

            Class1 account = new Class1("Mr. Bryan Walton", beginningBalance);
        try
        {
            account.Debit(debitAmount);
        }
        catch (ArgumentOutOfRangeException e)
        {
            StringAssert.Contains(e.Message, Class1.DebitAmountExceedBalanceMessage);
                
        }

            Assert.Fail("The Expected exception was not thrown.");
         
        }
    }
}
//public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
// public void Debit_WhenAmountIsMoreThanZero_ShouldThrowArgumentOutOfRange()