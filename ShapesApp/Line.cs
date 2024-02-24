using System;

namespace ShapesApp
{
    internal class Line : Shape // Inherit from the Shape abstract class
    {
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        // Constructor
        public Line(int startX, int startY, int endX, int endY, string name) : base(name) // Call the base class constructor
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        // Getters for line coordinates
        public int StartX { get { return startX; } }
        public int StartY { get { return startY; } }
        public int EndX { get { return endX; } }
        public int EndY { get { return endY; } }

        // Override the GetArea method
        public override double GetArea()
        {
            // For a line, the area is not applicable, so return 0
            return 0;
        }
    }
}
