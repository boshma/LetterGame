namespace ExpressionTreeTests
{
    using ExpressionTreeCodeDemo;
    using System.Globalization;

    [TestFixture]
    public class ExpressionTests
    {
        [Test]
        [TestCase("3+5", ExpectedResult = 8.0)]
        [TestCase("100/10*10", ExpectedResult = 100.0)]
        [TestCase("100/(10*10)", ExpectedResult = 1.0)]
        [TestCase("7-4+2", ExpectedResult = 5.0)]
        [TestCase("10/(7-2)", ExpectedResult = 2.0)]
        [TestCase("(12-2)/2", ExpectedResult = 5.0)]
        [TestCase("((((2+3)-(4+5))))", ExpectedResult = -4.0)]
        [TestCase("2*3+5", ExpectedResult = 11.0)]
        [TestCase("2+3*5", ExpectedResult = 17.0)]
        [TestCase("2 + 3 * 5", ExpectedResult = 17.0)]
        [TestCase("5/0", ExpectedResult = double.PositiveInfinity)]


        public double TestEvaluateNormalCases(string expression)
        {
            Expression exp = new Expression(expression);
            return exp.Evaluate();
        }

        [TestCase("((2+5))-2(2+3))")] //extra parathesis at end
        public void TestConstructInvalidExpression(string expression)
        {
            Assert.That(()=>new Expression(expression), Throws.TypeOf<System.Exception>());
        }
   


        [TestCase("4%2")]
        public void TestEvaluateUnsupportedOperator(string expression)
        {
            Expression exp = new Expression(expression);
            Assert.That(() => exp.Evaluate(), Throws.TypeOf<System.Collections.Generic.KeyNotFoundException>());
        }

        [Test]
        public void TestInfinity()
        {
            string maxValue = (double.MaxValue).ToString("F", CultureInfo.InvariantCulture);
            double result = new Expression($"{maxValue} + {maxValue}").Evaluate();
            Assert.True(double.IsInfinity(result));
        }
    }
}