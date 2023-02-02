using MindBox;

namespace MIndBoxLibrary.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_10_returned_314()
        {
            //arrange
            Circle circle = new Circle("Circle", 10);
            double expected = 314;

            //act
            double actual = circle.CalcSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Square_4and3and5_returned_6()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 3, 4, 5);
            double expected = 6;

            //act
            double actual = triangle.CalcSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRectangle_True()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 3, 4, 5);

            //Act
            var actual = triangle.IsRectangular();

            //Assert
            Assert.IsTrue(actual);
        }
    }
}
