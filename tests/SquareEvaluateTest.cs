using SquareEvaluate;

namespace tests
{
    [TestFixture]
    public class SquareEvaluateTests
    {
        [Test]
        public void TestCircle()
        {
            Circle circle = new Circle(5);
            double expected = 78.53975;
            double result = ShapeSquareEvaluator.Evaluate(circle);
            Assert.AreEqual(expected, result, 0.0001);
        }
        
        [Test]
        public void TestTriangle()
        {
            Triangle triangle = new Triangle(3,4,5);
            double expected = 6;
            double result = ShapeSquareEvaluator.Evaluate(triangle);
            Assert.AreEqual(expected, result, 0.0001);
        }
        
        [Test]
        public void TestIsRightTriangle()
        {
            Triangle triangle = new Triangle(3,4,5);
            bool expected = true;
            bool result = triangle.IsShapeRightTriangle();
            Assert.IsTrue(expected == result);
        }
    }
}
