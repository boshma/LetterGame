namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter E class.
    /// </summary>
    public class LetterE : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterE"/> class.
        /// </summary>
        public LetterE()
            : base('E')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 1 },
                { "Little Line", 3 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}