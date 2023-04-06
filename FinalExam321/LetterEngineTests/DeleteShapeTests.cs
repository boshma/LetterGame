namespace LetterEngineTests
{
    using LetterEngine;

    /// <summary>
    /// Tests for DeleteShape function.
    /// </summary>
    public class DeleteShapeTests
    {
        private LetterManager testObj;

        /// <summary>
        /// Creates instance of LetterManager.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.testObj = new LetterManager();
        }

        /// <summary>
        /// Normal cases for DeleteShape function.
        /// </summary>
        [Test]
        public void DeleteShapeNormalCases()
        {
            LittleLine shapeObj = new LittleLine();
            shapeObj.ChangeColor(shapeObj, "yellow");
            shapeObj.ChangeTexture(shapeObj, "sandy");
            this.testObj.ShapeBox.Add(shapeObj);
            this.testObj.DeleteShape(shapeObj);
            Assert.That(this.testObj.ContainsShape(shapeObj), Is.EqualTo(false));

            BigCurve shapeObj1 = new BigCurve();
            shapeObj1.ChangeColor(shapeObj1, "purple");
            shapeObj1.ChangeTexture(shapeObj1, "smooth");
            this.testObj.ShapeBox.Add(shapeObj1);
            this.testObj.DeleteShape(shapeObj1);
            Assert.That(this.testObj.ContainsShape(shapeObj1), Is.EqualTo(false));
        }

        /// <summary>
        /// Edge cases for DeleteShape function. Will throw an exception if user tries to delete a shape
        /// that does not exist from ShapeBox.
        /// </summary>
        [Test]
        public void DeleteShapeEdgeCases()
        {
            LittleLine shapeObj2 = new LittleLine();
            shapeObj2.ChangeColor(shapeObj2, "blue");
            shapeObj2.ChangeTexture(shapeObj2, "rough");
            Assert.Throws<System.ArgumentException>(() => this.testObj.DeleteShape(shapeObj2));
        }

        /// <summary>
        /// Exceptional cases for DeleteShape function. Could not find any due to static checking of the 
        /// system not allowing any exceptions with shape parameters.
        /// </summary>
        [Test]
        public void DeleteShapeExceptionalCases()
        {
            Assert.Pass();
        }
    }
}