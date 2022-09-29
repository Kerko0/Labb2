using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Circle : Shape2D
    {
        public override float Area { get { return (float)Math.PI * (float)Math.Pow(_radius, 2); } }
        public override float Circumference { get { return (float)Math.PI * 2 * _radius; } }
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
