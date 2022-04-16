using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricSquare;

namespace GeometricSquareUnitTests
{
    [TestClass]
    public class CircleArea
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            double r = 5;
            double expected = 78.53981633974483;

            Circle circle = new Circle(r);
            var square = circle.Area;

            Assert.AreEqual(expected, square);
        }
    }
}
