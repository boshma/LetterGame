// <copyright file="Letter.cs" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Security.Permissions;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Letter
    {
        /// <summary>
        /// The character letter.
        /// </summary>
        protected char symbol;

        /// <summary>
        /// ID of letter to differentiate.
        /// </summary>
        protected int letterID;

        /// <summary>
        /// Each letter has their own profile of shapes that make it up. This will be the identifier between
        /// letters.
        /// </summary>
        protected Dictionary<string, int> symbolProfile = new Dictionary<string, int>();

        /// <summary>
        /// This list will contain the correctly selected shapes to form the letter.
        /// </summary>
        protected List<Shape> completedShapes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Letter"/> class.
        /// </summary>
        /// <param name="letter">Letter to be initialized.</param>
        public Letter(char letter)
        {
            this.symbol = letter;
            this.letterID = LetterManager.ID++;
        }

        /// <summary>
        /// Event for letter changed event to update GUI.
        /// </summary>
        public event PropertyChangedEventHandler LetterPropertyChanged = (sender, e) => { };

        /// <summary>
        /// Gets or sets dictionary property as this element will be changed.
        /// </summary>
        public List<Shape> CompletedShapes
        {
            get => this.completedShapes;

            set
            {
                if (value == this.completedShapes)
                {
                    return;
                }

                this.completedShapes = value;

                // Triggers the event when Dictionary is changed.
                this.LetterPropertyChanged(this, new PropertyChangedEventArgs("CompletedShapes"));
            }
        }

        /// <summary>
        /// Returns symbol for testing.
        /// </summary>
        /// <returns>Symbol.</returns>
        public char RetrieveSymbol()
        {
            return this.symbol;
        }

        /// <summary>
        /// Returns symbol profile.
        /// </summary>
        /// <returns> Returns symbol profile dictionary.</returns>
        public Dictionary<string, int> ReturnProfile()
        {
            return this.symbolProfile;
        }

        /// <summary>
        /// Returns letter ID for differentiation.
        /// </summary>
        /// <returns>ID.</returns>
        public int ReturnLetterID()
        {
            return this.letterID;
        }

        /// <summary>
        /// Returns letters characterestics.
        /// </summary>
        /// <param name="letterToReturn">Letter to return.</param>
        /// <returns>Letters mark and shapes.</returns>
        public string ReturnLettersElements(Letter letterToReturn)
        {
            string shapes = char.ToString(letterToReturn.RetrieveSymbol()) + "[";

            foreach (Shape shape in letterToReturn.CompletedShapes)
            {
                shapes += " " + shape.ReturnShapesElements(shape);
            }

            shapes += "]";

            return shapes;
        }
    }
}
