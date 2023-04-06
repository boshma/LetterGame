namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter C class.
    /// </summary>
    public class LetterC : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterC"/> class.
        /// </summary>
        public LetterC()
            : base('C')
        {
            this.symbolProfile = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 0 },
                { "Big Curve", 1 },
                { "Little Curve", 0 },
            };
        }
    }
}