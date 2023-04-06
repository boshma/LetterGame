namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter T class.
    /// </summary>
    public class LetterT : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterT"/> class.
        /// </summary>
        public LetterT()
            : base('T')
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