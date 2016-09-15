using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem5;

namespace dateUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        CheckDate date = new CheckDate();
        [TestMethod]
        public void testIsLeap()
        {
           

            Assert.AreEqual(true, date.isLeap(2400)); // pass divisble by 4,100,400
            Assert.AreEqual(false, date.isLeap(2100)); // fail not leap. divisible by 100 but not 400
        }

        [TestMethod]
        public void testValidDay()
        {
            //Assert.AreEqual(true,date.validDay(31)); // valid.
            //Assert.AreEqual(true,date.validDay(0)); // not valid(should be false)
            //Assert.AreEqual(true,date.validDay(-5)); // Test will fail.
            Assert.AreEqual(false,date.validDay(32)); // test will pass cause 32 is NOT valid.
        }

        [TestMethod]
        public void testDayMonthCombo()
        {
            //Assert.AreEqual(true,date.validDayAndMonth(30,8)); // August 30th. True(Test should Pass)
            //Assert.AreEqual(true,date.validDayAndMonth(31,6)); // June 31st. False(Test should fail)
            Assert.AreEqual(false,date.validDayAndMonth(30,2)); // February 30th. False(Test should pass)
        }
    }
}
