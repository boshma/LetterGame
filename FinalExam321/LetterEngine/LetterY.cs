namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter Y class.
    /// </summary>
    public class LetterY : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterY"/> class.
        /// </summary>
        public LetterY()
            : base('Y')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 3 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}