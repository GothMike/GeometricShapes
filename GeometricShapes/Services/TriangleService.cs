using GeometricShapes.Interfaces;
using GeometricShapes.Models;

namespace GeometricShapes.Services
{
    public class TriangleService : Shape
    {
        private readonly Triangle _triangle;
        public TriangleService(Triangle triangle)
        {
            _triangle = triangle;
        }
        public override double GetArea()
        {
            if (IsRightTriangle())
                return GetRightTriangleArea();
            else
            {
                _triangle.Perimeter = (_triangle.Side1 + _triangle.Side2 + _triangle.Side3) / 2;
                _triangle.Area = Math.Sqrt(_triangle.Perimeter * (_triangle.Perimeter - _triangle.Side1) * (_triangle.Perimeter - _triangle.Side2) * (_triangle.Perimeter - _triangle.Side3));

                return _triangle.Area;
            }
        }
        public bool IsRightTriangle()
        {
            double[] sides = { _triangle.Side1, _triangle.Side2, _triangle.Side3 };
            Array.Sort(sides);

            return (Math.Pow(sides[2],2) == ((Math.Pow(sides[0], 2) + (Math.Pow(sides[1], 2))))); // Теорема Пифагора
        }
        public double GetRightTriangleArea()
        {
            double[] sides = { _triangle.Side1, _triangle.Side2, _triangle.Side3 };
            Array.Sort(sides);

            _triangle.Area = Math.Sqrt((Math.Pow(sides[0], 2) + (Math.Pow(sides[1], 2))));

            return _triangle.Area;
        }
    }
}