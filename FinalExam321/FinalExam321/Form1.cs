// <copyright file="Form1.cs" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace FinalExam321
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using LetterEngine;

    /// <summary>
    /// Partial class.
    /// </summary>
    public partial class Form1 : Form
    {
        private LetterEngine.LetterManager letterManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.letterManager = new LetterEngine.LetterManager();

            this.letterManager.GUIChangedEvent += this.GUIChanged;

            // Initializes the color selection list.
            this.SelectColorListBox.Items.Add("Yellow");
            this.SelectColorListBox.Items.Add("Red");
            this.SelectColorListBox.Items.Add("Green");

            // Initializes the filter color selection list.
            this.SelectFilterColorListBox.Items.Add("Yellow");
            this.SelectFilterColorListBox.Items.Add("Red");
            this.SelectFilterColorListBox.Items.Add("Green");

            // Initializes numbers to filter letters by.
            this.SelectNumberListBox.Items.Add(1);
            this.SelectNumberListBox.Items.Add(2);
            this.SelectNumberListBox.Items.Add(3);
            this.SelectNumberListBox.Items.Add(4);

            // Initializes the texture selection list.
            this.SelectTextureListBox.Items.Add("Wood");
            this.SelectTextureListBox.Items.Add("Sand");
            this.SelectTextureListBox.Items.Add("Leather");

            // Initializes the shape selection list.
            this.SelectShapeListBox.Items.Add("Big Curve");
            this.SelectShapeListBox.Items.Add("Little Curve");
            this.SelectShapeListBox.Items.Add("Big Line");
            this.SelectShapeListBox.Items.Add("Little Line");

            // Initializes the letter selection list.
            this.SelectedLetterListBox.Items.Add('A');
            this.SelectedLetterListBox.Items.Add('B');
            this.SelectedLetterListBox.Items.Add('C');
            this.SelectedLetterListBox.Items.Add('D');
            this.SelectedLetterListBox.Items.Add('E');
            this.SelectedLetterListBox.Items.Add('F');
            this.SelectedLetterListBox.Items.Add('G');
            this.SelectedLetterListBox.Items.Add('H');
            this.SelectedLetterListBox.Items.Add('I');
            this.SelectedLetterListBox.Items.Add('J');
            this.SelectedLetterListBox.Items.Add('K');
            this.SelectedLetterListBox.Items.Add('L');
            this.SelectedLetterListBox.Items.Add('M');
            this.SelectedLetterListBox.Items.Add('N');
            this.SelectedLetterListBox.Items.Add('O');
            this.SelectedLetterListBox.Items.Add('P');
            this.SelectedLetterListBox.Items.Add('Q');
            this.SelectedLetterListBox.Items.Add('R');
            this.SelectedLetterListBox.Items.Add('S');
            this.SelectedLetterListBox.Items.Add('T');
            this.SelectedLetterListBox.Items.Add('U');
            this.SelectedLetterListBox.Items.Add('V');
            this.SelectedLetterListBox.Items.Add('W');
            this.SelectedLetterListBox.Items.Add('X');
            this.SelectedLetterListBox.Items.Add('Y');
            this.SelectedLetterListBox.Items.Add('Z');
        }

        /// <summary>
        /// ShapeList changed event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void GUIChanged(object sender, PropertyChangedEventArgs e)
        {
            this.CreatedShapesListBox.Items.Clear();
            this.CompletedLettersListBox.Items.Clear();
            this.FilteredLettersListBox.Items.Clear();

            foreach (Shape shape in this.letterManager.ShapeBox)
            {
                this.CreatedShapesListBox.Items.Add(shape.ReturnShapesElements(shape));
            }

            foreach (Letter letter in this.letterManager.LetterBox)
            {
                this.CompletedLettersListBox.Items.Add(letter.ReturnLettersElements(letter));
            }

            foreach (Letter letter in this.letterManager.FilteredLetters)
            {
                this.FilteredLettersListBox.Items.Add(letter.ReturnLettersElements(letter));
            }
        }

        /// <summary>
        /// Creates a shape.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void CreateShapeBtn_Click(object sender, EventArgs e)
        {
             if (this.SelectColorListBox.SelectedItems.Count == 0 || this.SelectTextureListBox.SelectedItems.Count == 0 || this.SelectShapeListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a shape, color and texture before hitting Create Shape button!");
            }
            else
            {
                this.letterManager.CreateShape(this.SelectShapeListBox.SelectedItems[0].ToString(), this.SelectTextureListBox.SelectedItems[0].ToString(), this.SelectColorListBox.SelectedItems[0].ToString());
            }
        }

        /// <summary>
        /// Edits a shape.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void EditShapeBtn_Click(object sender, EventArgs e)
        {
            if (this.SelectColorListBox.SelectedItems.Count == 0 || this.SelectTextureListBox.SelectedItems.Count == 0 || this.SelectShapeListBox.SelectedItems.Count == 0 || this.CreatedShapesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a shape, color and texture before hitting Edit Shape button! Please select same option for characteristics you don't want changed. Don't forget to select" +
                    "the shape that you want changed in your created shapes.");
            }
            else
            {
                Shape shape = this.letterManager.ShapeBox[this.CreatedShapesListBox.SelectedIndex];

                this.letterManager.ChangeShape(shape, this.SelectShapeListBox.SelectedItems[0].ToString(), this.SelectTextureListBox.SelectedItems[0].ToString(), this.SelectColorListBox.SelectedItems[0].ToString());
            }
        }

        /// <summary>
        /// Deletes a shape.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void DeleteShapeBtn_Click(object sender, EventArgs e)
        {
            if (this.CreatedShapesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a shape to delete.");
            }
            else
            {
                Shape shape = this.letterManager.ShapeBox[this.CreatedShapesListBox.SelectedIndex];

                this.letterManager.DeleteShape(shape);
            }
        }

        /// <summary>
        /// Creates a letter.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">e.</param>
        private void CreateLetterBtn_Click(object sender, EventArgs e)
        {
            if (this.CreatedShapesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select atleast one shape to form a letter.");
            }
            else if (this.SelectedLetterListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a letter before hitting Create letter!");
            }
            else
            {
                List<int> indices = new List<int>();

                List<Shape> listToReturn = new List<Shape>();
                foreach (int index in this.CreatedShapesListBox.SelectedIndices)
                {
                    indices.Add(index);
                }

                foreach (int index in indices)
                {
                    listToReturn.Add(this.letterManager.ShapeBox[index]);
                }

                char temp = ' ';
                foreach (char c in this.SelectedLetterListBox.SelectedItems[0].ToString())
                {
                    temp = c;
                }

                if (!this.letterManager.VerifyShapesForLetter(this.letterManager.ReturnLetter(temp), listToReturn))
                {
                    MessageBox.Show("Those shapes don't make up that letter, try again!");
                }
            }
        }

        private void DeleteLetterBtn_Click(object sender, EventArgs e)
        {
            if (this.CompletedLettersListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a letter to delete");
            }
            else
            {
                this.letterManager.DeleteLetter(this.letterManager.LetterBox[this.CompletedLettersListBox.SelectedIndex]);
            }
        }

        private void FilterColorBtn_Click(object sender, EventArgs e)
        {
            if (this.SelectFilterColorListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a color to filter by");
            }
            else
            {
                this.letterManager.FilterLetters(this.SelectFilterColorListBox.SelectedItem.ToString());
            }
        }

        private void FilterSizeBtn_Click(object sender, EventArgs e)
        {
            if (this.SelectNumberListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a size to filter by");
            }
            else
            {
                this.letterManager.FilterLetters(Int16.Parse(this.SelectNumberListBox.SelectedItem.ToString()));
            }
        }
    }
}
