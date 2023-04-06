namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Letter J class.
    /// </summary>
    public class LetterJ : Letter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterJ"/> class.
        /// </summary>
        public LetterJ()
            : base('J')
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