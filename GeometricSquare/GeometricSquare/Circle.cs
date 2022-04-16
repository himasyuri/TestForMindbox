
namespace GeometricSquare
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't be negative value");
                }
                radius = value;
            }
            get { return radius; }
        }

        public override double Area { get { return CalculateArea(Radius); } }

        public Circle(double radius)
        {
            Radius = radius;
        }
        private double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
