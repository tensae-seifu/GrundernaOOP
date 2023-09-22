using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_OOP
{
    internal class Circle
    {
        // Define a constant for pi (π).
        public static float _pi = 3.141f;

        // Declare a field for the radius.
        public int _Radius;

        // Constructor to initialize the radius when creating an instance of the Circle class.
        public Circle(int radius)
        {
            this._Radius = radius;
        }

        // Method to calculate the area of the circle based on the provided radius.
        public float GetArea(int _Radius)
        {
            // Calculate and return the area of the circle.
            return _Radius * _Radius * _pi;
        }

        // Method to calculate the circumference of the circle based on the provided radius.
        public float GetCircumference(int _Radius)
        {
            // Calculate and return the circumference of the circle.
            return 2 * _pi * _Radius;
        }

        // Method to calculate the volume of a sphere with the provided radius.
        public float GetVolume(int _Radius)
        {
            // Calculate and return the volume of the sphere using the provided radius.
            return (4.0f / 3.0f) * _pi * (_Radius * _Radius * _Radius);
        }

    }
}