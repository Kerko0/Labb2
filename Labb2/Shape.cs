using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Xml;
using static ShapeGenerator.Shape;
using System.Runtime.Intrinsics;

namespace ShapeGenerator
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }


        static Random rand = new Random();
        private enum Shapes
        {
            Circle,
            Rectangle,
            Square,
            Triangle,
            Sphere,
            Cuboid,
            Cube
        }
        public static Shape GenerateShape()
        {
            return GenerateShape(RandomVector.RandomVector3Value(1,10));
        }
        
        public static Shape GenerateShape(Vector3 center)
        {
            Shapes randomShape = (Shapes)rand.Next(Enum.GetNames(typeof(Shapes)).Length);

            switch (randomShape)
            {
                case Shapes.Circle:
                    return GenerateCircle(center);

                case Shapes.Rectangle:
                    return GenerateRectangle(center);

                case Shapes.Square:
                    return GenerateSquare(center);

                case Shapes.Triangle:
                    return GenerateTriangle(center);

                case Shapes.Sphere:
                    return GenerateSphere(center);

                case Shapes.Cuboid:
                    return GenerateCuboid(center);

                case Shapes.Cube:
                    return GenerateCube(center);

                default:
                    return null!;
            }
        }     
        
        public static Shape GenerateCircle(Vector3 center)
        {
            return new Circle(Vector3Extensions.ConvertToVector2(center), rand.Next(1, 10));
        }

        public static Shape GenerateRectangle(Vector3 center)
        {
            return new Rectangle(Vector3Extensions.ConvertToVector2(center), RandomVector.RandomVector2Value(1,10));
        }

        public static Shape GenerateSquare(Vector3 center)
        {
            return new Rectangle(Vector3Extensions.ConvertToVector2(center), rand.Next(1, 10));
        }

        public static Shape GenerateTriangle(Vector3 center)
        {
            return new Triangle(Vector3Extensions.ConvertToVector2(center));
        }

        public static Shape GenerateSphere(Vector3 center)
        {
            return new Sphere(center, rand.Next(1, 10));
        }

        public static Shape GenerateCuboid(Vector3 center)
        {
            return new Cuboid(center, RandomVector.RandomVector3Value(1,10));
        }

        public static Shape GenerateCube(Vector3 center)
        {
            return new Cuboid(center, rand.Next(1,10));
        }
    }   
}
