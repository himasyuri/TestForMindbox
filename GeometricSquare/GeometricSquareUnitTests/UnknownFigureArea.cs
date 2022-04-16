using GeometricSquare;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricSquareUnitTests
{
    [TestClass]
    public class UnknownFigureArea
    {
        [TestMethod]
        public void UnknownFigureAreaTest()
        {
            double a = 5;
            double expectedCircleArea = 78.53981633974483;

            UnknownFigure figure = new UnknownFigure(a);
            var circleArea = figure.Area;

            double b = 7;
            double c = 8;
            double d = 3;
            double expectedTriangleArea = 10.392304845413264;

            UnknownFigure figure1 = new UnknownFigure(b, c, d);
            var triangleArea = figure1.Area;

            Assert.AreEqual(expectedCircleArea, circleArea);
            Assert.AreEqual(expectedTriangleArea, triangleArea);
        }
    }
}
