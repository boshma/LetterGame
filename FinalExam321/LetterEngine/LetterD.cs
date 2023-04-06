namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter D class.
    /// </summary>
    public class LetterD : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterD"/> class.
        /// </summary>
        public LetterD()
            : base('D')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 1 },
                { "Little Line", 0 },
                { "Big Curve", 1 },
                { "Little Curve", 0 },
            };
        }
    }
}