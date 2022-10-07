using System.Numerics;

namespace ShapeGenerator
{
    public static class Vector2Ex
    {
        static Random rand = new Random();
        public static Vector2 ConvertToVector2(this Vector3 vector3)
        {
            return new Vector2(vector3.X, vector3.Y);
        }

        public static Vector2 RandomVector2Value(float minValue, float maxValue)
        {
            return new Vector2(rand.Next(1, 10), rand.Next(1, 10));
        }
    }

    public static class Vector3Ex
    {
        static Random rand = new Random();
        public static Vector3 RandomVector3Value(float minValue, float maxValue)
        {
            return new Vector3(rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
        }
    }
}
