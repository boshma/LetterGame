


namespace HelloWorld.Math.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddNormalCase()
        {   //Normal cases (positive numbers
            Assert.AreEqual(
                2,
                Math.Add(1, 1)); //expected value
            Assert.AreEqual(
                7,
                Math.Add(-5, 12)); //expected value
            Assert.AreEqual(
                1010,
                Math.Add(1000, 10)); //expected value

        }

        [Test]
        public void TestAddEdgeCases()
        {         
            Assert.AreEqual(
                int.MaxValue,
                Math.Add(0, int.MaxValue)); //expected value
            Assert.AreEqual(
                int.MinValue,
                Math.Add(0, int.MinValue)); //expected value



        }

        [Test]
        public void TestAddExceptionCases()
        {
            Assert.Throws<System.OverflowException>(() => Math.Add(int.MaxValue, 3));

        }
    }
}