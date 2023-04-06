namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter H class.
    /// </summary>
    public class LetterH : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterH"/> class.
        /// </summary>
        public LetterH()
            : base('H')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 2 },
                { "Little Line", 1 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}