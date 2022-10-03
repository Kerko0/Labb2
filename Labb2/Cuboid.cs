using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGenerator
{
    public class Cuboid : Shape3D
    {
        public override float Area { get { return MathF.Round(2 * ((_length * _width) + (_length * _height) + (_width * _height)), 2); } }
        public override float Volume { get { return _length * _width * _height; } }
        public override Vector3 Center { get { return _center; } }

        public bool IsCube => _width == _height && _width == _length && _height == _length ? true : false;

        private float _width;
        private float _height;
        private float _length;
        private Vector3 _center;


        public Cuboid(Vector3 center)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = center.Z;
        }
        public Cuboid(Vector3 center, Vector3 size)
            : this(center)
        {
            _width = size.X;
            _height = size.Y;
            _length = size.Z;
        }
        public Cuboid(Vector3 center, float size)
            : this(center)
        {
            _width = size;
            _height = size;
            _length = size;
        }

        public override string ToString()
        {
            if (IsCube)
            {
                return $"Cube @({_center.X}, {_center.Y}, {_center.Z}): w = {_width}, h = {_height}, l = {_length}";
            }
            else
            {
                return $"Cuboid @({_center.X}, {_center.Y}, {_center.Z}): w = {_width}, h = {_height}, l = {_length}";
            }

        }
    }
}
