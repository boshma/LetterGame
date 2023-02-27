using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Reflection;

namespace HelloWorld.TripleThis.Tests
{
    public class InternalTripleThisTests
    {

        private ClassToDemoTestingNonPublic objectUnderTest = new ClassToDemoTestingNonPublic();

        private MethodInfo GetMethod(string methodName, Type[] types)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                Assert.Fail("methodName cannot be null or whitespace");
            var method = this.objectUnderTest.GetType().GetMethod(methodName,
            BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, types);
            if (method == null)
                Assert.Fail(string.Format("{0} method not found", methodName));
            return method;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TripleThisNormalCases()
        {
            
            Assert.That(
                ClassToDemoTestingNonPublic.tripleThis(1), Is.EqualTo(3)); //expected value
          

        }


        [Test]
        public void TripleThisEdgeCases()
        {
            Assert.That(
                ClassToDemoTestingNonPublic.tripleThis(0), Is.EqualTo(0)); //expected value

        }

        [Test]
        public void TripleThisExceptionCases()
        {
          
            Assert.Throws<System.OverflowException>(() => ClassToDemoTestingNonPublic.tripleThis(int.MaxValue));

        }

        [Test]
        public void TestPrivateInstanceMethodInt()
        {

            Type[] types = { typeof(int) };

            // Retrieve the method that we want to test using reflection
            MethodInfo methodInfo = this.GetMethod("privateInstanceMethod", types);
            // Test the method by calling the MethodBase.Invoke method
            Assert.AreEqual(5,
            methodInfo.Invoke(objectUnderTest, // the object on which
                                               // we are invoking the method
            new object[] { 5 } // the list of parameters (in our case, just one)
            ));
        }

        [Test]
        public void TestPrivateInstanceMethodDouble()
        {

            Type[] types = { typeof(double) };

            // Retrieve the method that we want to test using reflection
            MethodInfo methodInfo = this.GetMethod("privateInstanceMethod", types);
            // Test the method by calling the MethodBase.Invoke method
            Assert.AreEqual(5,
            methodInfo.Invoke(objectUnderTest, // the object on which
                                               // we are invoking the method
            new object[] { 5 } // the list of parameters (in our case, just one)
            ));
        }

    }
}

