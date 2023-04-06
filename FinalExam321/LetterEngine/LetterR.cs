namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter R class.
    /// </summary>
    public class LetterR : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterR"/> class.
        /// </summary>
        public LetterR()
            : base('R')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 1 },
                { "Little Line", 1 },
                { "Big Curve", 0 },
                { "Little Curve", 1 },
            };
        }
    }
}