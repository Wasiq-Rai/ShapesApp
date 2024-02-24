using System;

namespace ShapesApp
{
    internal class Triangle : Shape // Inherit from the Shape abstract class
    {
        private int _base;
        private int height;

        // Constructor
        public Triangle(int _base, int height, string name) : base(name) // Call the base class constructor
        {
            this._base = _base;
            this.height = height;
        }

        // Override the GetArea method
        public override double GetArea()
        {
            // Implement the area calculation for a triangle
            return 0.5 * _base * height;
        }

        public int getBase()
        {
            return _base;
        }

        public int getHeight()
        {
            return height;
        }
    }
}
