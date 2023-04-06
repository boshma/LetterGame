namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter A class.
    /// </summary>
    public class LetterA : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterA"/> class.
        /// </summary>
        public LetterA()
            : base('A')
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
