using System;

namespace ShapesApp
{
    public abstract class Shape
    {
        private double area;
        private string name;

        // Constructor
        protected Shape(string name)
        {
            this.name = name;
        }



        // Abstract method to calculate area
        public abstract double GetArea();

        // Method to get the name of the shape
        public string GetName()
        {
            return name;
        }


    }
}
