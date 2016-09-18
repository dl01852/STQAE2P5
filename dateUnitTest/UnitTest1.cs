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


            //Assert.AreEqual(true, date.isLeap(2400)); // pass divisble by 4,100,400
            //Assert.AreEqual(true, date.isLeap(2100)); // fail not leap. divisible by 100 but not 400
            //Assert.AreEqual(false, date.isLeap(2200)); // Test passes. Not leap year.
            Assert.AreEqual(false, date.isLeap(2000)); // Test fails. It is a leap year.
        }

        [TestMethod]
        public void testValidDay()
        {
            //Assert.AreEqual(true,date.validDay(31)); // valid.
            //Assert.AreEqual(true,date.validDay(0)); // not valid(should be false) Test fails.
            //Assert.AreEqual(true,date.validDay(-5)); // Test will fail.
            Assert.AreEqual(false, date.validDay(32)); // test will pass cause 32 is NOT valid.
        }

        [TestMethod]
        public void testValidMonth()
        {
            //Assert.AreEqual(true, date.validMonth(1)); // pass
            //Assert.AreEqual(true, date.validMonth(12)); // pass
            //Assert.AreEqual(true, date.validMonth(-1)); // fails.
            //Assert.AreEqual(true, date.validMonth(13)); // fails.
        }

        [TestMethod]
        public void testValidYear()
        {
            //Assert.AreEqual(true, date.validYearRange(1800)); // fails. greater than 1800. 
            // Assert.AreEqual(true, date.validYearRange(2020)); //fails.  less than 2020.
            Assert.AreEqual(true, date.validYearRange(1815)); // pass. 
        }

        [TestMethod]
        public void testDayMonthCombo()
        {
            // *** BVA for months ***
            //Assert.AreEqual(true,date.validDayAndMonth(15,13)); // test fails. No Month for 13.
            //Assert.AreEqual(true, date.validDayAndMonth(12, 12)); // test passes. 12 = December.
            //Assert.AreEqual(true, date.validDayAndMonth(14, 1)); // Test passes. 1 = January

            // *** BVA for days. ***
            //Assert.AreEqual(false, date.validDayAndMonth(0, 8)); // test passes. No day for 0.
            //Assert.AreEqual(false, date.validDayAndMonth(1, 5)); // pass.
            //Assert.AreEqual(true, date.validDayAndMonth(32, 5)); // fails.

            // *** Special cases***
            //Assert.AreEqual(true, date.validDayAndMonth(30, 2)); // fails. Feb 30th.
            Assert.AreEqual(false, date.validDayAndMonth(31, 4)); // pass. April 31st.
        }

        [TestMethod]
        public void testDate()
        {
            //Assert.AreEqual(true, date.validDate(2, 29, 2001));// test should fail!(2001 isn't leap)
            Assert.AreEqual(true, date.validDate(2, 29, 2012)); // valid leap year. pass.
            //Assert.AreEqual(true, date.validDate(4, 29, 2100)); // test should fail!(year out of range)
            //Assert.AreEqual(true, date.validDate(9, 18, 2016)); // valid year.
            //Assert.AreEqual(true, date.validDate(6, 31, 1965)); // fail.
            //Assert.AreEqual(true, date.validDate(1, 31, 1980)); // pass.

        }
    }
}
