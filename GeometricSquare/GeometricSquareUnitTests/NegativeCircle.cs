using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricSquare;
using System;


namespace GeometricSquareUnitTests
{
    [TestClass]
    public class NegativeCircle
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCircleTest()
        {
            double r = -5;
            double expected = 78.53981633974483;

            Circle circle = new Circle(r);
            var area = circle.Area;

            Assert.AreEqual(expected, area);
        }
    }
}
