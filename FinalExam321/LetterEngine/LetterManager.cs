// <copyright file="LetterManager.cs" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// LetterManager class that acts as the mediator between UI and LetterEngine classes.
    /// </summary>
    public class LetterManager
    {
        /// <summary>
        /// Sets ID for similar shapes and letters.
        /// </summary>
        public static int ID = 0;

        /// <summary>
        /// Contains the user's created shapes.
        /// </summary>
        public List<Shape> ShapeBox = new List<Shape>();

        /// <summary>
        /// Contains the user's completed letters.
        /// </summary>
        public List<Letter> LetterBox = new List<Letter>();

        /// <summary>
        /// The filtered litters after filter functions.
        /// </summary>
        public List<Letter> FilteredLetters = new List<Letter>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LetterManager"/> class.
        /// </summary>
        public LetterManager()
        {

        }

        /// <summary>
        /// Event handler for GUI change.
        /// </summary>
        public event PropertyChangedEventHandler GUIChangedEvent = (sender, e) => { };


        /// <summary>
        /// Creates a shape and adds it to the ShapeBox.
        /// </summary>
        /// <param name="name">Name of the shape.</param>
        /// <param name="texture">Texture of the shape.</param>
        /// <param name="color">Color of the shape.</param>
        /// <exception cref="ArgumentException">Thrown if invalid shape name is passed in.</exception>
        public void CreateShape(string name, string texture, string color)
        {
            Shape current;

            current = ShapeFactory.CreateShape(name);
            if (current != null)
            {
                this.ShapeBox.Add(current);
                current.ShapePropertyChanged += this.GUIPropertyChanged;
                current.ChangeTexture(current, texture);
                current.ChangeColor(current, color);
            }
        }

        /// <summary>
        /// Creates a letter given the correctly selected shapes.
        /// </summary>
        /// <param name="letterToCreate">Letter to be formed.</param>
        /// <param name="selectedShapes">Shapes passed in to form letter.</param>
        public void CreateLetter(char letterToCreate, List<Shape> selectedShapes)
        {
            Letter current;

            foreach (Shape shape in selectedShapes)
            {
                this.DeleteShape(shape);
            }

            current = LetterFactory.CreateLetter(letterToCreate);
            if (current != null)
            {
                current.LetterPropertyChanged += this.GUIPropertyChanged;
                this.LetterBox.Add(current);
                current.CompletedShapes = selectedShapes;
            }
        }

        /// <summary>
        /// Deletes a shape from the ShapeBox.
        /// </summary>
        /// <param name="shapeToDelete">The shape that will be removed from the ShapeBox.</param>
        public void DeleteShape(Shape shapeToDelete)
        {

            // Throws an exception if shape selected to be deleted is not in ShapeBox.
            if (!this.ContainsShape(shapeToDelete))
            {
                throw new ArgumentException();
            }

            List<Shape> dummyList = new List<Shape>();

            // Copies over all shapes minus shape to be deleted to new list.
            foreach (Shape shape in this.ShapeBox)
            {
                if (shape.ReturnShapeID() == shapeToDelete.ReturnShapeID())
                {
                    continue;
                }
                else
                {
                    dummyList.Add(shape);
                }
            }

            this.ShapeBox = dummyList;
            this.FireGuiEvent();
        }

        /// <summary>
        /// Deletes a letter from the LetterBox.
        /// </summary>
        /// <param name="letterToDelete">Letter to be deleted.</param>
        public void DeleteLetter(Letter letterToDelete)
        {
            // Throws an exception if letter selected to be deleted is not in LetterBox.
            if (!this.ContainsLetter(letterToDelete))
            {
                throw new ArgumentException();
            }
 
            List<Letter> dummyList = new List<Letter>();

            // Copies over all letters minus letter to be deleted to new list.
            foreach (Letter letter in this.LetterBox)
            {
                if (letter.ReturnLetterID() == letterToDelete.ReturnLetterID())
                {
                    continue;
                }
                else
                {
                    dummyList.Add(letter);
                }
            }

            this.LetterBox = dummyList;
            //this.DeleteLetterFromFilterBox(letterToDelete);

            // Fire off event.
            this.FireGuiEvent();
        }

        /// <summary>
        /// Deletes letter from filteredletters before letterbox.
        /// </summary>
        /// <param name="letterToDelete">Letter to delete.</param>
        /// <exception cref="ArgumentException">GUI glitching.</exception>
        public void DeleteLetterFromFilterBox(Letter letterToDelete)
        {
            // Throws an exception if letter selected to be deleted is not in LetterBox.
            if (!this.ContainsLetterInFilter(letterToDelete))
            {
               // throw new ArgumentException();
            }

            List<Letter> dummyList = new List<Letter>();

            // Copies over all letters minus letter to be deleted to new list.
            foreach (Letter letter in this.FilteredLetters)
            {
                if (letter.ReturnLetterID() == letterToDelete.ReturnLetterID())
                {
                    continue;
                }
                else
                {
                    dummyList.Add(letter);
                }
            }

            this.FilteredLetters = dummyList;

            // Fire off event.
            this.FireGuiEvent();
        }

        /// <summary>
        /// Checks to see if passed in shape is in the ShapeBox. Used for testing.
        /// </summary>
        /// <param name="shapeToFind">Passed in shape to search for.</param>
        /// <returns>True if object is in shapebox otherwise false. </returns>
        public bool ContainsShape(Shape shapeToFind)
        {
            foreach (Shape shape in this.ShapeBox)
            {
                if (shape.ReturnShapeID() == shapeToFind.ReturnShapeID())
                {
                    return true;
                }
            }

            return false;
        }



        /// <summary>
        /// Checks to see if passed in letter is in the letter. Used for testing.
        /// </summary>
        /// <param name="letterToFind">Passed in shape to search for.</param>
        /// <returns>True if object is in shapebox otherwise false. </returns>
        public bool ContainsLetter(Letter letterToFind)
        {
            foreach (Letter letter in this.LetterBox)
            {
                if (letter.ReturnLetterID() == letterToFind.ReturnLetterID())
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Checks to see if passed in letter is in the letter. Used for events.
        /// </summary>
        /// <param name="letterToFind">Passed in shape to search for.</param>
        /// <returns>True if object is in shapebox otherwise false. </returns>
        public bool ContainsLetterInFilter(Letter letterToFind)
        {
            foreach (Letter letter in this.FilteredLetters)
            {
                if (letter.ReturnLetterID() == letterToFind.ReturnLetterID())
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Changes the shape's characteristics.
        /// </summary>
        /// <param name="shapeToChange">Shape to be changed.</param>
        /// <param name="newName">New name of shape.</param>
        /// <param name="newTexture">New texture of shape.</param>
        /// <param name="newColor">New color of shape.</param>
        /// <exception cref="ArgumentException">Invalid shape name.</exception>
        public void ChangeShape(Shape shapeToChange, string newName, string newTexture, string newColor)
        {

            List<Shape> dummyList = new List<Shape>();

            if (!this.ContainsShape(shapeToChange))
            {
                throw new ArgumentException();
            }

            this.CreateShape(newName, newTexture, newColor);
            Shape newShape = this.ShapeBox[this.ShapeBox.Count - 1];
            this.ShapeBox.RemoveAt(this.ShapeBox.Count - 1);


            foreach (Shape shape in this.ShapeBox)
            {
                if (shape.ReturnShapeID() == shapeToChange.ReturnShapeID())
                {
                    dummyList.Add(newShape);
                }
                else
                {
                    dummyList.Add(shape);
                }
            }

            this.ShapeBox = dummyList;

            // Firing off event.
            this.FireGuiEvent();
        }

        /// <summary>
        /// Filters by color.
        /// </summary>
        /// <param name="color">Color to filter by.</param>
        public void FilterLetters(string color)
        {
            var query = from letter in this.LetterBox
            from shape in letter.CompletedShapes
            where shape.Color == color
            select letter;

            // Used to get rid of clones. 
            List<Letter> uniqueIDs = query.Distinct().ToList();
            this.FilteredLetters = uniqueIDs;
            this.FireGuiEvent();
        }

        /// <summary>
        /// Filters by number of shapes in a letter.
        /// </summary>
        /// <param name="size">Number of shapes in a letter to filter by.
        /// Shapes of this size or greater will be added to FilteredList.</param>

        public void FilterLetters(int size)
        {

            var query = from letter in this.LetterBox
                        where letter.CompletedShapes.Count >= size
                        select letter;
            List<Letter> newList = new List<Letter>(query);
            this.FilteredLetters = newList;
            this.FireGuiEvent();
        }

        /// <summary>
        /// Fires off the event in form.cs to update form GUI.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">e.</param>
        public void GUIPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.GUIChangedEvent.Invoke(this, e);
        }

        /// <summary>
        /// Verifies the shapes passed in to see if they form a letter or not.
        /// </summary>
        /// <param name="letterToMake">Selected letter to make.</param>
        /// <param name="selectedShapes">Selected shapes from GUI.</param>
        /// <returns>True if shapes can be formed to create a letter.</returns>
        public bool VerifyShapesForLetter(Letter letterToMake, List<Shape> selectedShapes)
        {

            Dictionary<string, int> dummyDict = new Dictionary<string, int>()
            {
                { "Big Line", 0 },
                { "Little Line", 0 },
                { "Big Curve", 0 },
                { "Little Curve", 0 },
            };

            foreach (Shape shape in selectedShapes)
            {
                dummyDict[shape.ReturnName()] += 1;
            }

            if (dummyDict["Big Line"] == letterToMake.ReturnProfile()["Big Line"] && dummyDict["Little Line"] == letterToMake.ReturnProfile()["Little Line"] && dummyDict["Big Curve"] == letterToMake.ReturnProfile()["Big Curve"] &&
                dummyDict["Little Curve"] == letterToMake.ReturnProfile()["Little Curve"])
            {
                this.CreateLetter(letterToMake.RetrieveSymbol(), selectedShapes);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns letter object.
        /// </summary>
        /// <param name="letterToCreate">Char to create letter from.</param>
        /// <returns>Letter object.</returns>
        public Letter ReturnLetter(char letterToCreate)
        {
            Letter current = LetterFactory.CreateLetter(letterToCreate);
            return current;
        }

        /// <summary>
        /// Easy way to fire off GUI event.
        /// </summary>
        public void FireGuiEvent()
        {
            Shape fireEventVariable = new BigCurve();
            fireEventVariable.ShapePropertyChanged += this.GUIPropertyChanged;
            fireEventVariable.FireEvent();
        }
    }
}
