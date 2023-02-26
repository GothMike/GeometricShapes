using GeometricShapes.Interfaces;
using GeometricShapes.Models;

namespace GeometricShapes.Services
{
    public class CircleService : Shape
    {
        private readonly Circle _circle;
        public CircleService(Circle circle)
        {
            _circle = circle;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_circle.Radius, 2);
        }
    }
}