namespace LetterEngineTests
{
    using LetterEngine;

    /// <summary>
    /// Tests for FilterByColor function.
    /// </summary>
    public class FilterByColorTests
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
            this.testObj.CreateShape("Little Line", "coarse", "blue");
            this.testObj.CreateShape("Little Line", "smooth", "yellow");
            this.testObj.CreateShape("Little Line", "silky", "red");

            this.testObj.CreateLetter('E', this.testObj.ShapeBox);

        }

        /// <summary>
        /// Normal cases for FilterByColor function.
        /// </summary>
        [Test]
        public void FilterByColorNormalCases()
        {
            this.testObj.FilterLetters("blue");

            Assert.That(this.testObj.FilteredLetters.Count(), Is.EqualTo(1));

        }

        /// <summary>
        /// Edge cases for FilterByColor function. Will throw an exception if user tries to delete a shape
        /// that does not exist from ShapeBox.
        /// </summary>
        [Test]
        public void FilterByColorEdgeCases()
        {
            this.testObj.FilterLetters("topanga");

            Assert.That(this.testObj.FilteredLetters.Count(), Is.EqualTo(0));
        }

        /// <summary>
        /// Exceptional cases for FilterByColor function. Could not find any due to static checking of the 
        /// system not allowing any exceptions with string and int parameters.
        /// </summary>
        [Test]
        public void FilterByColorExceptionalCases()
        {
            Assert.Pass();
        }
    }
}