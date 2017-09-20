using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bandnamegenerator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("",Kata.BandNameGenerator(null));
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("", Kata.BandNameGenerator("a"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Tart", Kata.BandNameGenerator("tart"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("Tartart", Kata.BandNameGenerator("tart"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("Knife", Kata.BandNameGenerator("knife"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("The Knife", Kata.BandNameGenerator("knife"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("Sandlesandles", Kata.BandNameGenerator("sandles"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual("The Bed", Kata.BandNameGenerator("bed"));
        }
    }
}
