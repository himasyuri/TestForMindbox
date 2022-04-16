using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricSquare;
using System;

namespace GeometricSquareUnitTests
{
    [TestClass]
    public class IsTriangleExist
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsTriangleExistTestException()
        {
            double a = 4;
            double b = 5;
            double c = 10;
            double expected = 10.392304845413264;

            Triangle triangle = new Triangle(a, b, c);
            var area = triangle.Area;

            Assert.AreEqual(expected, area);
        }
    }
}
