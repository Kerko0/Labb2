using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Xml;
using ExtensionMethods;

namespace ShapeGenerator
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }


        static Random rand = new Random();
        enum Shapes
        {
            Circle,
            Rectangle,
            Triangle,
            Sphere,
            Cuboid
        }
        public static Shape GenerateShape()
        {
            return GenerateShape(new Vector3(rand.Next(1,10), rand.Next(1,10), rand.Next(1,10)));
        }

        public static Shape GenerateShape(Vector3 center)
        {
            Shapes shapes = (Shapes)rand.Next(Enum.GetNames(typeof(Shapes)).Length);

            switch(shapes)
            {
                case Shapes.Circle:
                    return new Circle(Vector2Ex.ConvertToVector2(center), rand.Next(1, 10));       
                    
                case Shapes.Rectangle:
                    return new Rectangle(Vector2Ex.ConvertToVector2(center), Vector2Ex.RandomVector2Value());

                case Shapes.Triangle:
                    return new Triangle(Vector2Ex.ConvertToVector2(center));

                case Shapes.Sphere:
                    return new Sphere(center, rand.Next(1, 10));

                case Shapes.Cuboid:
                    return new Cuboid(center, Vector3Ex.RandomVector3Value());

                default:
                    return new Circle(new Vector2(0,0), 0);
            }

        }        
    }   
}
