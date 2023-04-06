// <copyright file="LittleCurve.cs" company="Bogdan Shmat 011738664">
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
    /// Little Curve shape.
    /// </summary>
    public class LittleCurve : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LittleCurve"/> class.
        /// </summary>
        public LittleCurve()
            : base("Little Curve")
        {
            this.name = "Little Curve";
        }
    }
}
