namespace TDD_inl_1.Geometry
{
    using Geothings.Extensions;
    using TDD_inl_1.Interfaces;

    public class Rectangle : IGeometric
    {
        // set the sides
        public float Height { get; set; }
        public float Width { get; set; }

        public Rectangle(float h, float w)
        {
            Height = h;
            Width = w;
        }

        /// <summary>
        /// Find the area
        /// </summary>
        /// <returns>Area: <see cref="float"/></returns>
        public float GetArea()
        {
            return MathExtensions.Round(Height * Width);
        }

        /// <summary>
        /// Find the perimeter
        /// </summary>
        /// <returns>Perimeter: <see cref="float"/></returns>
        public float GetPerimeter()
        {
            return MathExtensions.Round(2 * Height + 2 * Width);
        }
    }
}
