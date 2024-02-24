using System;

namespace ShapesApp
{
    internal class Rectangle : Shape // Inherit from the Shape abstract class
    {
        private float height;
        private float width;

        // Constructor
        public Rectangle(float height, float width, string name) : base(name) // Call the base class constructor
        {
            this.height = height;
            this.width = width;
        }

        // Override the GetArea method
        public override double GetArea()
        {
            // Implement the area calculation for a rectangle
            return height * width;
        }

        public float GetWidth()
        {
            return width;
        }

        public float getHeight()
        {
            return height;
        }

    }
}
