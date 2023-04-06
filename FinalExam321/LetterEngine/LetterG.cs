namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter G class.
    /// </summary>
    public class LetterG : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterG"/> class.
        /// </summary>
        public LetterG()
            : base('G')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 2 },
                { "Big Curve", 1 },
                { "Little Curve", 0 },
            };
        }
    }
}