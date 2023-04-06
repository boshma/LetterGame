namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter V class.
    /// </summary>
    public class LetterV : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterV"/> class.
        /// </summary>
        public LetterV()
            : base('V')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 2 },
                { "Little Line", 0 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}