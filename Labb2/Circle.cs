using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGenerator
{
    public class Circle : Shape2D
    {
        public override float Area { get { return MathF.PI * MathF.Pow(_radius, 2); } }
        public override float Circumference { get { return MathF.PI * 2 * _radius; } }
        public override Vector3 Center { get { return _center; } }
        public float Radius { get { return _radius; } }

        private float _radius;
        private Vector3 _center;
        public Circle(Vector2 center, float radius)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _radius = radius;
        }

        public override string ToString()
        {
            return $"Circle @({_center.X}, {_center.Y}): r = {_radius}";
        }


    }
}
