using Shapes.Interfaces;

namespace Shapes.Figures
{
    public class Triangle : IShape
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if(IsValidTriangle(side1, side2, side3))
            {
                _side1 = side1;
                _side2 = side2;
                _side3 = side3;
            }
            else
            {
                throw new ArgumentException($"Невозможно создать треугольник со сторонами {side1}, {side2}, {side3}");
            }
        }

        public double CalculateArea()
        {
            double s = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }

        public bool IsRightAngled()
        {
            double a2 = Math.Pow(_side1, 2);
            double b2 = Math.Pow(_side2, 2);
            double c2 = Math.Pow(_side3, 2);

            return (a2 == b2 + c2) || (b2 == a2 + c2) || (c2 == a2 + b2);
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
