using System;

namespace ShapesApp
{
    internal class Circle : Shape // Inherit from the Shape abstract class
    {
        private float radius;

        // Constructor
        public Circle(float radius, string name) : base(name) // Call the base class constructor
        {
            this.radius = radius;
        }

        // Override the GetArea method
        public override double GetArea()
        {
            // Implement the area calculation for a circle
            return Math.PI * Math.Pow(radius, 2);
        }

        public float getRadius()
        {
            return radius;
        }
    }
}
