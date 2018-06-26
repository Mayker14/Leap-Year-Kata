using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYearKataUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ILeapYear1()
        {
            Year year = new Year();
            Assert.AreEqual("Is a Leap Year", actual: Year.Proof("2000"));
        }

        [TestMethod]
        public void INotLeapYear1()
        {
            Year year = new Year();
            Assert.AreEqual("Is Not a Leap Year", actual: Year.Proof("2100"));
        }

        [TestMethod]
        public void ILeapYear2()
        {
            Year year = new Year();
            Assert.AreEqual("Is a Leap Year", actual: Year.Proof("2008"));
        }

        [TestMethod]
        public void ILeapYear3()
        {
            Year year = new Year();
            Assert.AreEqual("Is a Leap Year", actual: Year.Proof("2012"));
        }

        [TestMethod]
        public void ILeapYear4()
        {
            Year year = new Year();
            Assert.AreEqual("Is a Leap Year", actual: Year.Proof("2016"));
        }

        [TestMethod]
        public void INotLeapYear2()
        {
            Year year = new Year();
            Assert.AreEqual("Is Not a Leap Year", actual: Year.Proof("2017"));
        }

        [TestMethod]
        public void INotLeapYear3()
        {
            Year year = new Year();
            Assert.AreEqual("Is Not a Leap Year", actual: Year.Proof("2018"));
        }

        [TestMethod]
        public void INotLeapYear4()
        {
            Year year = new Year();
            Assert.AreEqual("Is Not a Leap Year", actual: Year.Proof("2019"));
        }
    }
}
