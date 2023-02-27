using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Date.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLeapNormalCases()
        {
            Assert.AreEqual(
                true,
                Date.IsLeap(800)); //expected value
            Assert.AreEqual(
                true,
                Date.IsLeap(12)); //expected value
            Assert.AreEqual(
                false,
                Date.IsLeap(1)); //expected value


        }


        [Test]
        public void TestLeapEdgeCases()
        {
            Assert.AreEqual(
                false,
                Date.IsLeap(-5)); //expected value

        }

        [Test]
        public void TestLeapExceptionCases()
        {
            Assert.AreEqual(
                false,
                Date.IsLeap(int.MaxValue)); //expected value
            //Assert.Throws<System.OverflowException>(() => Date.IsLeap(int.MaxValue));

        }
    }
}
