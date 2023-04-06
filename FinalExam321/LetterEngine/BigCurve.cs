// <copyright file="BigCurve.cs" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Big Curve shape.
    /// </summary>
    public class BigCurve : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BigCurve"/> class.
        /// </summary>
        public BigCurve()
            : base("Big Curve")
        {
            this.name = "Big Curve";
        }
    }
}
