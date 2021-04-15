﻿namespace TDD_inl_1.Geometry
{
    using Geothings.Extensions;
    using System;
    using TDD_inl_1.Interfaces;

    public class Circle : IGeometric
    {
        // Set radius
        public float Radius { get; set; }
         
        public Circle(float r)
        {
            Radius = r;
        }

        /// <summary>
        /// Find the area
        /// </summary>
        /// <returns>Area: <see cref="float"/></returns>
        public float GetArea()
        {
            return MathExtensions.Round((float)Math.PI * Radius * Radius);
        }

        /// <summary>
        /// Find the perimeter
        /// </summary>
        /// <returns>Perimeter: <see cref="float"/></returns>
        public float GetPerimeter()
        {
            return MathExtensions.Round((float)Math.PI * Radius * 2);
        }
    }
}
