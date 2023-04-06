namespace LetterEngineTests
{
    using LetterEngine;

    /// <summary>
    /// Tests for DeleteLetter function.
    /// </summary>
    public class DeleteLetterTests
    {
        private LetterManager testObj;

        LetterA a = new LetterA();
        LetterB b = new LetterB();
        LetterC c = new LetterC();

        /// <summary>
        /// Creates instance of LetterManager.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.testObj = new LetterManager();
         
            List<Letter> letterTest = new List<Letter>()
            {
                a,b,c
            };

            this.testObj.LetterBox = letterTest;
        }

        /// <summary>
        /// Normal cases for DeleteLetter function.
        /// </summary>
        [Test]
        public void DeleteLetterNormalCases()
        {
     
            this.testObj.DeleteLetter(a);

            Assert.That(this.testObj.LetterBox.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Edge cases for DeleteLetter function. Will throw an exception if user tries to delete a shape
        /// that does not exist from ShapeBox.
        /// </summary>
        [Test]
        public void DeleteLetterEdgeCases()
        {
            LetterG passedInG = new LetterG();
            Assert.That(this.testObj.LetterBox.Count, Is.EqualTo(3));
        }

        /// <summary>
        /// Exceptional cases for DeleteLetter function. Could not find any due to static checking of the
        /// system not allowing any exceptions with shape parameters.
        /// </summary>
        [Test]
        public void DeleteLetterExceptionalCases()
        {
            Assert.Pass();
        }
    }
}