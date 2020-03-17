using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PO_lab1;

namespace PO_lab1Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle();
            Assert.AreEqual(9.0, triangle.GetArea("3 6"));
            Assert.AreEqual(3900.0, triangle.GetArea("100 78"));
            Assert.AreEqual(0, triangle.GetArea("43 aa"));
            Assert.AreEqual(1692.6, triangle.GetArea("43.4 78"));
            Assert.AreEqual(19.71, triangle.GetArea("5.4 7.3"));
            Assert.AreEqual(0, triangle.GetArea(""));
            Assert.AreEqual(0, triangle.GetArea(null));
            Assert.AreEqual(0, triangle.GetArea("aaa"));
        }
        [TestMethod]
        public void RectangleAreaTest()
        {
            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(60.0, rectangle.GetArea("10 6"));
            Assert.AreEqual(907.43, rectangle.GetArea("10.3 88.1"));
            Assert.AreEqual(0, rectangle.GetArea("43 aa"));
            Assert.AreEqual(0, rectangle.GetArea(""));
            Assert.AreEqual(0, rectangle.GetArea(null));
            Assert.AreEqual(0, rectangle.GetArea("aaa"));
        }
        [TestMethod]
        public void SquareAreaTest()
        {
            Square square = new Square();

            Assert.AreEqual(16.0, square.GetArea("4"));
            Assert.AreEqual(625.0, square.GetArea("25"));
            Assert.AreEqual(0, square.GetArea("43 aa"));
            Assert.AreEqual(0, square.GetArea(""));
            Assert.AreEqual(0, square.GetArea(null));
            Assert.AreEqual(0, square.GetArea("aaa"));
        }
        [TestMethod]
        public void CircleAreaTest()
        {
            Circle circle = new Circle();

            Assert.AreEqual(36*Math.PI, circle.GetArea("6"));
            Assert.AreEqual(10000*Math.PI, circle.GetArea("100"));
            Assert.AreEqual(0, circle.GetArea("43 aa"));
            Assert.AreEqual(0, circle.GetArea(""));
            Assert.AreEqual(0, circle.GetArea(null));
            Assert.AreEqual(0, circle.GetArea("aaa"));
        }
    }
}
