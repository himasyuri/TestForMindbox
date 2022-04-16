namespace GeometricSquare
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        private readonly bool isRight;

        public bool IsRight { get { return isRight; } }
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

        public override double Area { get { return CalculateArea(A, B, C); } }

        public Triangle(double a, double b, double c)
        {
           if (a + b < c)
           {
               if (a + c < b)
               {
                   if (b + c < a)
                   {
                       throw new ArgumentException("Not exist");
                   }
                   throw new ArgumentException("Not exist");
               }
               throw new ArgumentException("Not exist");
           }
            A = a;
            B = b;
            C = c;

            isRight = IsRightTriangle(a, b, c);
        }

        private double CalculateArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private static bool IsRightTriangle(double a, double b, double c)
        {
            // Pifagor theorem
            if (a * a + b * b == c * c)
            {
                return true;
            }
            if (a * a + c * c == b * b)
            {
                return true;
            }
            if (b * b + c * c == a * a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}