namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter B class.
    /// </summary>
    public class LetterB : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterB"/> class.
        /// </summary>
        public LetterB()
            : base('B')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 1 },
                { "Little Line", 0 },
                { "Big Curve", 1 },
                { "Little Curve", 1 },
            };
        }
    }
}