using System.Numerics;

namespace ShapeGenerator
{
    public static class RandomVector
    {
        static Random rand = new Random();
        public static Vector2 RandomVector2Value(float minValue, float maxValue)
        {
            return new Vector2(rand.Next(1, 10), rand.Next(1, 10));
        }

        public static Vector3 RandomVector3Value(float minValue, float maxValue)
        {
            return new Vector3(rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
        }
    }
  
}
