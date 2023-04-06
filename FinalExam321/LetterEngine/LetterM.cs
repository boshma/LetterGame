namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter M class.
    /// </summary>
    public class LetterM : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterM"/> class.
        /// </summary>
        public LetterM()
            : base('M')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 2 },
                { "Little Line", 2 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}