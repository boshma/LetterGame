namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter P class.
    /// </summary>
    public class LetterP : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterP"/> class.
        /// </summary>
        public LetterP()
            : base('P')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 1 },
                { "Little Line", 0 },
                { "Big Curve", 0 },
                { "Little Curve", 1 },
            };
        }
    }
}