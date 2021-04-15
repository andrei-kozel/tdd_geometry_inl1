using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_inl_1.Interfaces;

namespace TDD_inl_1.Geometry.Tests
{
    [TestClass()]
    public class GeometricTests
    {
        [TestMethod()]
        public void GetSquareAreaTest()
        {
            Assert.AreEqual(100, new Square(10).GetArea());
            Assert.AreEqual(4, new Square(2).GetArea());
            Assert.AreEqual(9, new Square(3).GetArea());
        }

        [TestMethod()]
        public void GetSquarePerimeterTest()
        {
            Assert.AreEqual(40, new Square(10).GetPerimeter());
            Assert.AreEqual(8, new Square(2).GetPerimeter());
            Assert.AreEqual(12, new Square(3).GetPerimeter());
        }

        [TestMethod()]
        public void GetTriangleAreaTest()
        {
            Assert.AreEqual(6, new Triangle(3, 4, 5).GetArea());
            Assert.AreEqual(0, new Triangle(1, 2, 19).GetArea());
            Assert.AreEqual(20.3961, new Triangle(5, 9, 12).GetArea(), 0.0001);
        }

        [TestMethod()]
        public void GetTrianglePerimeterTest()
        {
            Assert.AreEqual(12, new Triangle(3, 4, 5).GetPerimeter());
            Assert.AreEqual(0, new Triangle(1, 2, 19).GetPerimeter());
            Assert.AreEqual(26, new Triangle(5, 9, 12).GetPerimeter());
        }

        // https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert.areequal?view=mstest-net-1.3.2
        [TestMethod()]
        public void GetCircleAreaTest()
        {
            Assert.AreEqual(28.27, new Circle(3).GetArea(), 0.01);
            Assert.AreEqual(78.54, new Circle(5).GetArea(), 0.01);
            Assert.AreEqual(907.92, new Circle(17).GetArea(), 0.01);
        }

        [TestMethod()]
        public void GetCirclePerimeterTest()
        {
            Assert.AreEqual(18.85, new Circle(3).GetPerimeter(), 0.01);
            Assert.AreEqual(31.416, new Circle(5).GetPerimeter(), 0.01);
            Assert.AreEqual(106.814, new Circle(17).GetPerimeter(), 0.01);
        }


    }
}