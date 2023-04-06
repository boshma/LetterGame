namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter O class.
    /// </summary>
    public class LetterO : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterO"/> class.
        /// </summary>
        public LetterO()
            : base('O')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 0 },
                { "Big Curve", 2 },
                { "Little Curve", 0 },
            };
        }
    }
}