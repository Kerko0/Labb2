using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Cuboid : Shape3D
    {
        public override float Area { get { return 0; } }
        public override float Volume { get { return 0; } }
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
        public Cuboid(Vector3 center, float width)
            : this(center)
        {
            _width = width;
            _height = width;
            _length = width;
        }

        public override string ToString()
        {
            if (IsCube)
            {
                return $"cube @({_center.X}, {_center.Y}, {_center.Z}): w = {_width}, h = {_height}, l = {_length}";
            }
            else
            {
                return $"cuboid @({_center.X}, {_center.Y}, {_center.Z}): w = {_width}, h = {_height}, l = {_length}";
            }

        }
    }
}
