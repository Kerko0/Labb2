using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGenerator
{
    public static class Vector3Extensions
    {     
        public static Vector2 ConvertToVector2(this Vector3 vector3)
        {
            return new Vector2(vector3.X, vector3.Y);
        }

    }
}
