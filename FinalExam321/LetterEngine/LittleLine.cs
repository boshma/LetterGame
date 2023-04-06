// <copyright file="LittleLine.cs" company="Bogdan Shmat 011738664">
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
    /// Little Line shape.
    /// </summary>
    public class LittleLine : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LittleLine"/> class.
        /// </summary>
        public LittleLine()
            : base("LittleLine")
        {
            this.name = "Little Line";
        }
    }
}
