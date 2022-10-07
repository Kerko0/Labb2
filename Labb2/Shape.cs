using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Xml;

namespace ShapeGenerator
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }


        static Random rand = new Random();
        public enum Shapes
        {
            Circle,
            Rectangle,
            Triangle,
            Sphere,
            Cuboid
        }
        public static Shape GenerateShape()
        {
            return GenerateShape(Vector3Ex.RandomVector3Value(1,10));
        }
        
        public static Shape GenerateShape(Vector3 center)
        {
            Shapes randomShape = (Shapes)rand.Next(Enum.GetNames(typeof(Shapes)).Length);   
            
            Dictionary<Shapes, Shape> shapes = new Dictionary<Shapes, Shape>();
            shapes[Shapes.Circle] = GenerateCircle(center);
            shapes[Shapes.Rectangle] = GenerateRectangle(center);
            shapes[Shapes.Triangle] = GenerateTriangle(center);
            shapes[Shapes.Sphere] = GenerateSphere(center);
            shapes[Shapes.Cuboid] = GenerateCuboid(center);

            return shapes[randomShape];
        }     
        
        public static Shape GenerateCircle(Vector3 center)
        {
            return new Circle(Vector2Ex.ConvertToVector2(center), rand.Next(1, 10));
        }

        public static Shape GenerateRectangle(Vector3 center)
        {
            return new Rectangle(Vector2Ex.ConvertToVector2(center), Vector2Ex.RandomVector2Value(1,10));
        }

        public static Shape GenerateTriangle(Vector3 center)
        {
            return new Triangle(Vector2Ex.ConvertToVector2(center));
        }

        public static Shape GenerateSphere(Vector3 center)
        {
            return new Sphere(center, rand.Next(1, 10));
        }

        public static Shape GenerateCuboid(Vector3 center)
        {
            return new Cuboid(center, Vector3Ex.RandomVector3Value(1,10));
        }
    }   
}
