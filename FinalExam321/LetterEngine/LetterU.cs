namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter U class.
    /// </summary>
    public class LetterU : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterU"/> class.
        /// </summary>
        public LetterU()
            : base('U')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 2 },
                { "Big Curve", 0 },
                { "Little Curve", 1 },
            };
        }
    }
}