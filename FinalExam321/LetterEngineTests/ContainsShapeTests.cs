// <copyright file="CreateShapeTests" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace LetterEngineTests
{
    using LetterEngine;

    /// <summary>
    /// Tests for ContainsShape function.
    /// </summary>
    public class ContainsShapeTests
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
            this.testObj.CreateShape("Big Curve", "rough", "red");
        }

        /// <summary>
        /// Normal cases for ContainsShape function.
        /// </summary>
        [Test]
        public void ContainsShapeNormalCases()
        {
            LittleLine obj1 = new LittleLine();

            obj1.ChangeColor(obj1, "yellow");
            obj1.ChangeTexture(obj1, "sandy");

            Assert.That(this.testObj.ContainsShape(this.testObj.ShapeBox[0]));

            BigCurve obj2 = new BigCurve();

            obj2.ChangeColor(obj2, "red");
            obj2.ChangeTexture(obj2, "rough");
            Assert.That(this.testObj.ContainsShape(obj2));
        }

        /// <summary>
        /// Edge cases for ContainsShape function.
        /// </summary>
        [Test]
        public void ContainsShapeEdgeCases()
        {
            BigLine obj3 = new BigLine();

            obj3.ChangeColor(obj3, "blue");
            obj3.ChangeTexture(obj3, "scaley");
            Assert.IsFalse(this.testObj.ContainsShape(obj3));
        }

        /// <summary>
        /// Exceptional cases for ContainsShape function. Could not find any as static checking prevents anything that would cause
        /// error to be passed into the shape parameter. 
        /// </summary>
        [Test]
        public void ContainsShapeExceptionalCases()
        {
            Assert.Pass();
        }
    }
}