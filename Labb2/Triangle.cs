using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal class Triangle : Shape2D
    {
        public override float Area { get { return 0; } }
        public override float Circumference { get { return 0; } }
        public override Vector3 Center 
        {
            get { 

                return new Vector3((A.X + B.X + C.X) / 3, (A.Y + B.Y + C.Y) / 3, 0f);
            } 
        
        }

        private Vector2 A;
        private Vector2 B;
        private Vector2 C;
        public Triangle(Vector2 point1, Vector2 point2, Vector2 point3)
        {
            A = point1;
            B = point2;
            C = point3;
        }

        public override string ToString()
        {
            return $"Triangle @({Center.X}, {Center.Y}): p1({A.X}, {A.Y}), p2({B.X}, {B.Y}), p3({C.X}, {C.Y})";
        }

    }
}
