using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGenerator
{
    public class Triangle : Shape2D
    {
        public override float Area 
        { 
            get { 
                
                return 0.5f * Math.Abs(A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y)); 
            }     
        }
        public override float Circumference 
        {   
            get { 
                
                return MathF.Sqrt(MathF.Pow(B.X - A.X, 2) + MathF.Pow(B.Y - A.Y, 2)) + 
                       MathF.Sqrt(MathF.Pow(C.X - B.X, 2) + MathF.Pow(C.Y - B.Y, 2)) +
                       MathF.Sqrt(MathF.Pow(A.X - C.X, 2) + MathF.Pow(A.Y - C.Y, 2));                          
            }       
        }
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

        public Triangle(Vector2 center)
        {
            A = Vector2Ex.RandomVector2Value(1,10);
            B = Vector2Ex.RandomVector2Value(1,10);
            C = new Vector2((center.X * 3) - (A.X + B.X), (center.Y * 3) - (A.Y + B.Y));
        }



        public override string ToString()
        {
            return $"Triangle @({Center.X}, {Center.Y}): p1({A.X}, {A.Y}), p2({B.X}, {B.Y}), p3({C.X}, {C.Y})";
        }

    }
}
