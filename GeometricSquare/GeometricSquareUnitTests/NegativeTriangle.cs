using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricSquare;
using System;

namespace GeometricSquareUnitTests
{
    [TestClass]
    public class NegativeTriangle
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeTriangleTestException()
        {
            double a = -7;
            double b = 8;
            double c = 3;
            double expected = 10.392304845413264;

            Triangle triangle = new Triangle(a, b, c);
            var area = triangle.Area;

            Assert.AreEqual(expected, area);
        }
    }
}
