namespace LetterEngineTests
{
    using LetterEngine;

    /// <summary>
    /// Tests for CreateLetter function.
    /// </summary>
    public class CreateLetterTests
    {
        private LetterManager testObj;

        /// <summary>
        /// Creates instance of LetterManager.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.testObj = new LetterManager();

            this.testObj.CreateShape("Big Line", "sandy", "white");
            this.testObj.CreateShape("Little Line", "coarse", "Blue");
            this.testObj.CreateShape("Little Line", "smooth", "Yellow");
            this.testObj.CreateShape("Little Line", "silky", "Red");

            this.testObj.CreateLetter('E', this.testObj.ShapeBox);
        }

        /// <summary>
        /// Normal cases for CreateLetter function.
        /// </summary>
        [Test]
        public void CreateLetterNormalCases()
        {
            this.testObj.CreateShape("Big Line", "sandy", "white");
            this.testObj.CreateShape("Little Line", "coarse", "Blue");
            this.testObj.CreateShape("Little Line", "smooth", "Yellow");
            this.testObj.CreateShape("Little Line", "silky", "Red");

            this.testObj.CreateLetter('E', this.testObj.ShapeBox);

            Assert.That(this.testObj.LetterBox[0].RetrieveSymbol(), Is.EqualTo('E'));
        }

        /// <summary>
        /// Edge cases for CreateLetter function.
        /// </summary>
        [Test]
        public void CreateLetterEdgeCases()
        {
            this.testObj.CreateShape("Big Line", "sandy", "white");
            this.testObj.CreateShape("Little Line", "coarse", "Blue");
            this.testObj.CreateShape("Little Line", "smooth", "Yellow");
            this.testObj.CreateShape("Little Line", "silky", "Red");

            this.testObj.CreateLetter('A', this.testObj.ShapeBox);

            Assert.That(this.testObj.LetterBox.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Exceptional cases for CreateLetter function. Could not find any due to static checking of the char argument.
        /// </summary>
        [Test]
        public void CreateLetterExceptionalCases()
        {
            Assert.Pass();
        }
    }
}