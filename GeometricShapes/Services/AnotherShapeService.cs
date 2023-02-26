using GeometricShapes.Interfaces;
using GeometricShapes.Models;

namespace GeometricShapes.Services
{
    public class AnotherShapeService : Shape
    {
        private readonly AnotherShape _anotherShape;
        public AnotherShapeService(AnotherShape anotherShape)
        {
            _anotherShape = anotherShape;
        }
        public override double GetArea()
        {
            _anotherShape.Area = _anotherShape.Length * _anotherShape.Width;
            return _anotherShape.Area;
        }
    }
}