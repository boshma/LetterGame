namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter N class.
    /// </summary>
    public class LetterN : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterN"/> class.
        /// </summary>
        public LetterN()
            : base('N')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 3 },
                { "Little Line", 0 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };
        }
    }
}