using GeometricSquare;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricSquareUnitTests
{
    [TestClass]
    public class TriangleArea
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            double a = 7;
            double b = 8;
            double c = 3;
            double expected = 10.392304845413264;

            Triangle triangle = new Triangle(a, b, c);
            var area = triangle.Area;

            Assert.AreEqual(expected, area);
        }
    }
}