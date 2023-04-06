namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter S class.
    /// </summary>
    public class LetterS : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterS"/> class.
        /// </summary>
        public LetterS()
            : base('S')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 0 },
                { "Big Curve", 0 },
                { "Little Curve", 2 },
            };
        }
    }
}