using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal class Sphere : Shape3D
    {
        public override float Area { get { return 0; } }
        public override Vector3 Center { get { return _center; } }
        public override float Volume { get { return 0; } }
        public float Radius { get { return _radius; } }

        private float _radius;
        private Vector3 _center;
        public Sphere(Vector3 center, float radius)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = center.Z;
            _radius = radius;
        }

        public override string ToString()
        {
            return $"Sphere @({_center.X}, {_center.Y}, {_center.Z}): r = {_radius}";
        }
    }
}
