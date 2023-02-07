namespace SquareEvaluate
{
    public interface IShape
    {
        double EvaluateSquare();
    }
    
    public class Circle : IShape
    {
        private double radius;
    
        public Circle(double radius)
        {
            this.radius = radius;
        }
    
        public double EvaluateSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    
    public class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;
    
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    
        public double EvaluateSquare()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    
        public bool IsShapeRightTriangle()
        {
            return a * a + b * b == c * c 
                   || a * a + c * c == b * b 
                   || b * b + c * c == a * a;
        }
    }
    
    public class ShapeSquareEvaluator
    {
        public static double Evaluate(IShape shape)
        {
            return shape.EvaluateSquare();
        }
    }
    /*
     Examples of using this library:
        Circle circle = new Circle(5);
        double circleArea = ShapeAreaCalculator.Evaluate(circle);
    
        Triangle triangle = new Triangle(3, 4, 5);
        double triangleArea = ShapeAreaCalculator.Evaluate(triangle);
        
        Triangle triangle = new Triangle(3, 4, 5);
        bool isRightTriangle = triangle.IsRightTriangle();
    
    For new shape, we should create a new class, where then, we implementing
    methods for calculate square of according shape
     */
     
}
