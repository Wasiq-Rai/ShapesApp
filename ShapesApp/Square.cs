using System;

namespace ShapesApp
{
    internal class Square : Shape // Inherit from the Shape abstract class
    {
        private float sideLength;

        // Constructor
        public Square(float sideLength, string name) : base(name) // Call the base class constructor
        {
            this.sideLength = sideLength;
        }

        // Override the GetArea method
        public override double GetArea()
        {
            // Implement the area calculation for a square
            return Math.Pow(sideLength, 2);
        }

        public float getSideLength()
        {
            return sideLength;
        }
    }
}
