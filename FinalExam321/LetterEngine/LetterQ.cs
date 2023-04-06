namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter Q class.
    /// </summary>
    public class LetterQ : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterQ"/> class.
        /// </summary>
        public LetterQ()
            : base('Q')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 1 },
                { "Big Curve", 2 },
                { "Little Curve", 0 },
            };
        }
    }
}