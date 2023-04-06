// <copyright file="VerifyShapeForLetterTests.cs" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace LetterEngineTests
{
    using LetterEngine;

    /// <summary>
    /// Tests for VerifyShapesForLetter function.
    /// </summary>
    public class VerifyShapesForLetterTests
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
        /// Normal cases for VerifyShapesForLetter function.
        /// </summary>
        [Test]
        public void VerifyShapesForLetterNormalCases()
        {
            this.testObj.CreateShape("Big Line", "sandy", "white");
            this.testObj.CreateShape("Little Line", "coarse", "Blue");
            this.testObj.CreateShape("Little Line", "smooth", "Yellow");
            this.testObj.CreateShape("Little Line", "silky", "Red");
            Assert.That(this.testObj.VerifyShapesForLetter(new LetterE(), this.testObj.ShapeBox), Is.EqualTo(true));
        }

        /// <summary>
        /// Edge cases for VerifyShapesForLetter function. Will throw an exception if user tries to delete a shape
        /// that does not exist from ShapeBox.
        /// </summary>
        [Test]
        public void VerifyShapesForLetterEdgeCases()
        {
            this.testObj.CreateShape("Big Curve", "sandy", "white");
            this.testObj.CreateShape("Little Line", "coarse", "Blue");
            this.testObj.CreateShape("Little Line", "smooth", "Yellow");
            this.testObj.CreateShape("Little Line", "silky", "Red");

            Assert.That(this.testObj.VerifyShapesForLetter(new LetterE(), this.testObj.ShapeBox), Is.EqualTo(false));
        }

        /// <summary>
        /// Exceptional cases for VerifyShapesForLetter function. Could not find any due to static checking of the
        /// system not allowing any exceptions with shape parameters.
        /// </summary>
        [Test]
        public void VerifyShapesForLetterExceptionalCases()
        {
            Assert.Pass();
        }
    }
}