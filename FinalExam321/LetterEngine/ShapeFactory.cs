// <copyright file="ShapeFactory.cs" company="Bogdan Shmat 011738664">
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
    /// Shape factory class.
    /// </summary>
    internal class ShapeFactory
    {
        /// <summary>
        /// 4 different types of shapes.
        /// </summary>
        public static Dictionary<string, Type> ShapesDict = new Dictionary<string, Type>
        {
            { "Big Curve", typeof(BigCurve) },
            { "Little Curve", typeof(LittleCurve) },
            { "Big Line", typeof(BigLine) },
            { "Little Line", typeof(LittleLine) },
        };

        /// <summary>
        /// Creates instance of shape object.
        /// </summary>
        /// <param name="inputString">Inputted shape's name.</param>
        /// <returns>Shape object or null.</returns>
        public static Shape CreateShape(string inputString)
        {
            if (ShapesDict.ContainsKey(inputString))
            {
                object shapeObj = System.Activator.CreateInstance(ShapesDict[inputString]);
                if (shapeObj is Shape)
                {
                    return (Shape)shapeObj;
                }
            }

            return null;
        }
    }
}
