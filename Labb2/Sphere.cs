using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGenerator
{
    public class Sphere : Shape3D
    {
        public override float Area { get { return MathF.Round(4 * MathF.PI * MathF.Pow(_radius, 2), 2); } }
        public override Vector3 Center { get { return _center; } }
        
        float fourDividedByThree = 4 / 3; //Formeln är egentligen (4/3) * PI * r^3 men paranteserna funkar inte så jag måste göra en separat variabel för den.
        public override float Volume { get { return MathF.Round(fourDividedByThree * MathF.PI * MathF.Pow(_radius, 3), 2); } }

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
