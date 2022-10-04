using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGenerator
{
    public class Rectangle : Shape2D
    {
        public override float Area { get { return _width * _height; } }
        public override float Circumference { get { return (_width * 2) + (_height * 2); } }
        public override Vector3 Center { get { return _center; } }
        public bool IsSquare => _width == _height ? true : false;

        private string _isSquare => _width == _height ? "Square" : "Rectangle";
        private float _width;
        private float _height;
        private Vector3 _center;


        public Rectangle(Vector2 center)
        {
            _center.X = center.X;
            _center.Y = center.Y;
        }
        public Rectangle(Vector2 center, Vector2 size)
            :this(center)
        {            
            _width = size.X;
            _height = size.Y;
        }
        public Rectangle(Vector2 center, float width)
            :this(center)
        {
            _width = width;
            _height = width;
        }

        public override string ToString()
        {                   
           return $"{_isSquare} @({_center.X}, {_center.Y}): w = {_width}, h = {_height}";                    
        }

    }
}
