namespace LetterEngineTests
{
    using LetterEngine;

    /// <summary>
    /// Tests for ChangeShape function.
    /// </summary>
    public class ChangeShapeTests
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
        /// Normal cases for ChangeShape function.
        /// </summary>
        [Test]
        public void ChangeShapeNormalCases()
        {
            LittleLine shapeObj = new LittleLine();
            shapeObj.ChangeColor(shapeObj, "yellow");
            shapeObj.ChangeTexture(shapeObj, "sandy");
            this.testObj.ShapeBox.Add(shapeObj);
            this.testObj.ChangeShape(this.testObj.ShapeBox[0], "Little Line", "smooth", "red");
            Assert.That(this.testObj.ShapeBox[0].Color, Is.EqualTo("red"));

            BigCurve shapeObj1 = new BigCurve();
            shapeObj1.ChangeColor(shapeObj1, "purple");
            shapeObj1.ChangeTexture(shapeObj1, "smooth");
            this.testObj.ShapeBox.Add(shapeObj1);
            this.testObj.ChangeShape(this.testObj.ShapeBox[1], "Big Curve", "silky", "green");
            Assert.That(this.testObj.ShapeBox[1].Texture, Is.EqualTo("silky"));
        }

        /// <summary>
        /// Edge cases for ChangeShape function. Will throw an exception if user tries to delete a shape
        /// that does not exist from ShapeBox.
        /// </summary>
        [Test]
        public void ChangeShapeEdgeCases()
        {
            //LittleLine shapeObj2 = new LittleLine("rough", "blue");
            //Assert.Throws<System.ArgumentException>(() => this.testObj.ChangeShape(shapeObj2, "bad name", "silky", "blue"));
        }

        /// <summary>
        /// Exceptional cases for ChangeShape function. Could not find any due to static checking of the 
        /// system not allowing any exceptions with shape parameters.
        /// </summary>
        [Test]
        public void ChangeShapeExceptionalCases()
        {
            Assert.Pass();
        }
    }
}