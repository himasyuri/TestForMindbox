using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricSquare;

namespace GeometricSquareUnitTests
{
    [TestClass]
    public class RightTriangle
    {
        [TestMethod]
        public void IsRightTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);
            var isRight = triangle.IsRight;

            double d = 7;
            double e = 8;
            double f = 3;

            Triangle notRightTriangle = new Triangle(d, e, f);
            var notRight = notRightTriangle.IsRight;

            Assert.AreEqual(true, isRight);
            Assert.AreEqual(false, notRight);
        }
    }
}
