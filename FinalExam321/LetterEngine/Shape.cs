namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        /// <summary>
        /// Texture property of a shape.
        /// </summary>
        protected string texture;

        /// <summary>
        /// Color property of a shape.
        /// </summary>
        protected string color;

        /// <summary>
        /// Name of the shape.
        /// </summary>
        protected string name;

        /// <summary>
        /// ID of shape to differentiate.
        /// </summary>
        protected int shapeID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="cName">Shape name.</param>
        public Shape(string cName)
        {
            this.texture = string.Empty;
            this.color = string.Empty;
            this.name = cName;
            this.shapeID = LetterManager.ID++;
        }

        /// <summary>
        /// Event handler for Shape.
        /// </summary>
        public event PropertyChangedEventHandler ShapePropertyChanged = (sender, e) => { };

        /// <summary>
        /// Gets or sets texture property.
        /// </summary>
        public string Texture
        {
            get
            {
                return this.texture;
            }

            set
            {
                if (value == this.texture)
                {
                    return;
                }

                this.texture = value;

                // Triggers the event when texture is changed.
                this.ShapePropertyChanged(this, new PropertyChangedEventArgs("Texture"));
            }
        }

        /// <summary>
        /// Gets or sets Color property.
        /// </summary>
        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                if (value == this.color)
                {
                    return;
                }

                this.color = value;

                // Triggers the event when color is changed.
                this.ShapePropertyChanged(this, new PropertyChangedEventArgs("Color"));
            }
        }

        /// <summary>
        /// Returns the name of the shape.
        /// </summary>
        /// <returns>Returns name of shape.</returns>
        public string ReturnName()
        {
            return this.name;
        }

        /// <summary>
        /// Changes color of shape.
        /// </summary>
        /// <param name="shapeToChange">The shape that will be changed.</param>
        /// <param name="color">New color.</param>
        public void ChangeColor(Shape shapeToChange, string color)
        {
            shapeToChange.Color = color;
            this.ShapePropertyChanged(this, new PropertyChangedEventArgs("Color"));
        }

        /// <summary>
        /// Fires the event to update GUI.
        /// </summary>
        public void FireEvent()
        {
            this.ShapePropertyChanged(this, new PropertyChangedEventArgs("Color"));
        }

        /// <summary>
        /// Changes texture of shape.
        /// </summary>
        /// <param name="shapeToChange">The shape that will be changed.</param>
        /// <param name="texture">New texture.</param>
        public void ChangeTexture(Shape shapeToChange, string texture)
        {
            shapeToChange.Texture = texture;
            this.ShapePropertyChanged(this, new PropertyChangedEventArgs("Texture"));
        }

        /// <summary>
        /// Returns the shape's elements.
        /// </summary>
        /// <param name="shapeToReturn">Shape to be expanded.</param>
        /// <returns>Type and color/texture.</returns>
        public string ReturnShapesElements(Shape shapeToReturn)
        {
            return $"{shapeToReturn.ReturnName()}(Color: {shapeToReturn.Color}; Texture: {shapeToReturn.Texture})";
        }

        /// <summary>
        /// Returns shape ID.
        /// </summary>
        /// <returns>Returns ID for comparisons.</returns>
        public int ReturnShapeID()
        {
            return this.shapeID;
        }
    }
}
