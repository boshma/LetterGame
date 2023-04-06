namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter K class.
    /// </summary>
    public class LetterK : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterK"/> class.
        /// </summary>
        public LetterK()
            : base('K')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 1 },
                { "Little Line", 2 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}