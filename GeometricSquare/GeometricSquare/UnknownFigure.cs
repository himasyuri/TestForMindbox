

namespace GeometricSquare
{
    public class UnknownFigure : Figure
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't be negative value");
                }
                a = value;
            }
            get { return a; }
        }

        public double B
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't be negative value");
                }
                b = value;
            }
            get { return b; }
        }

        public double C
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't be negative value");
                }
                c = value;
            }
            get { return c; }
        }

        public override double Area
        {
            get
            {
                if (A != 0 && B == 0 && C == 0)
                {
                    return CalculateArea(A);
                }
                if (A != 0 && B != 0 && C != 0)
                {
                    return CalculateArea(A, B, C);
                }
                throw new NotImplementedException();
            }
        }

        public UnknownFigure(double a)
        {
            A = a;
            B = 0;
            C = 0;
        }

        public UnknownFigure(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        private static double CalculateArea(double a)
        {
            return Math.PI * a * a;
        }

        public static double CalculateArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
