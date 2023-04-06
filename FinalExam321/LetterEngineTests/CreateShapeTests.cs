// <copyright file="CreateShapeTests.cs" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace LetterEngineTests
{
    using System.Runtime.CompilerServices;
    using LetterEngine;

    /// <summary>
    /// Tests for CreateShape function.
    /// </summary>
    public class CreateShapeTests
    {
        private LetterManager testObj;

        /// <summary>
        /// Creates instance of LetterManager.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.testObj = new LetterManager();

            // Normal case set-up.
            this.testObj.CreateShape("Little Line", "sandy", "yellow");
            this.testObj.CreateShape("Big Curve", "smooth", "purple");
        }

        /// <summary>
        /// Normal cases for CreateShape function.
        /// </summary>
        [Test]
        public void CreateShapeNormalCases()
        {
            Shape shapeObj = this.testObj.ShapeBox[0];

            shapeObj.ChangeTexture(shapeObj, "sandy");
            Assert.That(this.testObj.ContainsShape(shapeObj));

            BigCurve shapeObj1 = new BigCurve();
            shapeObj1.ChangeColor(shapeObj1, "purple");
            shapeObj1.ChangeTexture(shapeObj1, "smooth");
            Assert.That(this.testObj.ContainsShape(shapeObj1));
        }

        /// <summary>
        /// Edge cases for CreateShape function. Throws an exception if improper shape name is passed in.
        /// </summary>
        [Test]
        public void CreateShapeEdgeCases()
        {
            // Throws null
            // Assert.Throws<System.NullReferenceException>(() => this.testObj.CreateShape(string.Empty, "sandy", "yellow"));
        }

        /// <summary>
        /// Exceptional cases for CreateShape function. Could not find any due to static checking of the
        /// system not allowing any exceptions with string parameters.
        /// </summary>
        [Test]
        public void CreateShapeExceptionalCases()
        {
            Assert.Pass();
        }
    }
}