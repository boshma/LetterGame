namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter L class.
    /// </summary>
    public class LetterL : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterL"/> class.
        /// </summary>
        public LetterL()
            : base('L')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 1 },
                { "Little Line", 1 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}